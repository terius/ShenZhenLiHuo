using DAL;
using Helpers;
using System;
using System.Collections;
using System.Data;

namespace BLL
{
    public class ScanHeadBLL
    {
        private readonly COMMON comm = new COMMON();
        int maxScanNo = 0;
     

        public void GetMaxSCANNO()
        {
            maxScanNo = comm.GetIntData("select max(scan_no) from EHS_SCAN_TMP1");

        }

        public int InsertNewDataToTmp(string billno)
        {
            int insertId = 0;
            GetMaxSCANNO();
            if (CheckBillNOInTmp(billno))//tmp表已存在此billno
            {
                insertId = CopyTmp(billno);
            }
            else
            {
                insertId = CopyFromHead(billno);
            }
            return insertId;
        }

        private int CopyFromHead(string billno)
        {
            int insertId = 0;
            string sql = "select top 1 SHIP_ID,VOYAGE_NO,BILL_NO,I_E_FLAG,PACK_NO,I_E_DATE,DEC_TYPE from EHS_SCAN_HEAD where BILL_NO=@BILL_NO";
            Hashtable ht = new Hashtable();
            ht["BILL_NO"] = billno;
            DataRow dr = comm.GetOneRow(sql, ht);
            if (dr != null)
            {
                Hashtable htparm = DataRowToHashtable(dr);
                htparm["Multi_Pack_No"] = 1;
                htparm["SCAN_NO"] = maxScanNo + 1;
                htparm["SEND_TYPE"] = dr["DEC_TYPE"];
                insertId = comm.InsertByHashtable("EHS_SCAN_TMP1", htparm, true);
                WriteLog(insertId, htparm);
                UpdateList2(dr["VOYAGE_NO"].ToString(), true);
                UpdateHead(billno);
            }
            else
            {
                DataRow drLast = GetLastScanDataInTmp();
                if (drLast != null)
                {
                    ht["SHIP_ID"] = drLast["SHIP_ID"].ToString();
                    ht["VOYAGE_NO"] = drLast["VOYAGE_NO"].ToString();
                    ht["I_E_FLAG"] = drLast["I_E_FLAG"].ToString();
                    ht["I_E_DATE"] = drLast["I_E_DATE"];
                    ht["PACK_NO"] = 1;
                    ht["DEC_TYPE"] = 0;
                    ht["SCAN_NO"] = maxScanNo + 1;
                    ht["Multi_Pack_No"] = 1;
                    ht["SEND_TYPE"] = 2;
                    insertId = comm.InsertByHashtable("EHS_SCAN_TMP1", ht, true);
                    WriteLog(insertId, ht);
                    UpdateList2(drLast["VOYAGE_NO"].ToString(), true);
                }

            }
            return insertId;
        }

        private DataRow GetLastScanDataInTmp()
        {
            string sql = "select * from EHS_SCAN_TMP1 where scan_no=@scan_no";
            Hashtable ht = new Hashtable();
            ht["scan_no"] = maxScanNo;
            return comm.GetOneRow(sql, ht);
        }

        private int CopyTmp(string billno)
        {
            int insertId = 0;
            Hashtable ht = new Hashtable();
            ht["bill_no"] = billno;
            DataRow dr = comm.GetOneRow("select top 1 * from EHS_SCAN_TMP1 where bill_no = @bill_no "
                + " and scan_no = (select max(scan_no) from EHS_SCAN_TMP1 where bill_no = @bill_no)", ht);
            if (dr != null)
            {
                dr["SCAN_NO"] = maxScanNo + 1;
                dr["Multi_Pack_No"] = Convert.ToInt32(dr["Multi_Pack_No"]) + 1;
                Hashtable htparm = DataRowToHashtable(dr, new string[] { "id", "scan_time" });
                insertId = comm.InsertByHashtable("EHS_SCAN_TMP1", htparm, true);
                WriteLog(insertId, htparm);
                UpdateList2(dr["VOYAGE_NO"].ToString(), false);
                UpdateHead(billno);
            }
            else
            {
                throw new Exception("分运单号：" + billno + "错误");
            }
            return insertId;
        }

        private void WriteLog(int insertId, Hashtable htparm)
        {
            StringHelper.WriteLog(string.Format("#1,{0},{1},{2}", 
                htparm["SCAN_NO"].ToString(), htparm["SEND_TYPE"].ToString(), htparm["BILL_NO"].ToString()));
            string sql = "update EHS_SCAN_TMP1 set send_time =getdate() where id=@id";
            Hashtable ht = new Hashtable();
            ht["id"] = insertId;
            comm.UID(sql, ht);
        }

        private void UpdateHead(string billno)
        {
            string sql = "update EHS_SCAN_HEAD set SCAN_FLAG=1,SCAN_TIME=getdate() where BILL_NO=@BILL_NO";
            Hashtable ht = new Hashtable();
            ht["BILL_NO"] = billno;
            comm.UID(sql, ht);
        }

        private void UpdateList2(string voyageno, bool updateBillSum)
        {
            string sql = "";
            if (CheckVoyageExistInList2(voyageno))
            {
                if (updateBillSum)
                {
                    sql = "update EHS_SCAN_LIST2 set SCAN_PACK_SUM = SCAN_PACK_SUM+ 1,SCAN_BILL_SUM = SCAN_BILL_SUM+1 where VOYAGE_NO= @VOYAGE_NO";
                }
                else
                {
                    sql = "update EHS_SCAN_LIST2 set SCAN_PACK_SUM = SCAN_PACK_SUM+ 1 where VOYAGE_NO= @VOYAGE_NO";
                }
                Hashtable ht = new Hashtable();
                ht["VOYAGE_NO"] = voyageno;
                comm.UID(sql, ht);
            }
            else
            {
                Hashtable ht = new Hashtable();
                ht["VOYAGE_NO"] = voyageno;
                sql = "select count(bill_no) as billnocount,isnull(sum(pack_no),0) as packsum from EHS_SCAN_HEAD where VOYAGE_NO=@VOYAGE_NO";
                DataRow dr = comm.GetOneRow(sql, ht);
                if (dr != null)
                {
                    sql = "insert into EHS_SCAN_LIST2 values(newid(),@VOYAGE_NO,@BILL_SUM,@PACK_SUM,1,1)";
                    ht["BILL_SUM"] = Convert.ToInt32(dr["billnocount"]);
                    ht["PACK_SUM"] = Convert.ToInt32(dr["packsum"]);
                    comm.UID(sql, ht);
                }
            }
        }

        private bool CheckVoyageExistInList2(string voyageno)
        {
            string sql = "select count(1) from EHS_SCAN_LIST2 where VOYAGE_NO = @VOYAGE_NO";
            Hashtable ht = new Hashtable();
            ht["VOYAGE_NO"] = voyageno;
            return comm.Exists(sql, ht);
        }


        private Hashtable DataRowToHashtable(DataRow dr, string[] ingoreColums = null)
        {
            Hashtable ht = new Hashtable();
            foreach (DataColumn dc in dr.Table.Columns)
            {
                if (!StringHelper.CheckValueInList(dc.ColumnName, ingoreColums))
                {
                    ht[dc.ColumnName] = dr[dc];
                }
            }
            return ht;
        }



        private bool CheckBillNOInTmp(string billno)
        {
            string sql = "select count(1) from EHS_SCAN_TMP1 where bill_no = @bill_no";
            Hashtable ht = new Hashtable();
            ht["bill_no"] = billno;
            return comm.Exists(sql, ht);
        }
    }

    public class ScanHeadInfo
    {
        public Guid ID { get; set; }
        public string SHIP_ID { get; set; }
        public string VOYAGE_NO { get; set; }
        public string BILL_NO { get; set; }
        public string I_E_FLAG { get; set; }
        public double? PACK_NO { get; set; }
        public DateTime? I_E_DATE { get; set; }
        public string DEC_TYPE { get; set; }
        public string DEC_TYPE2 { get; set; }
        public string SCAN_FLAG { get; set; }
        public DateTime? SCAN_TIME { get; set; }
        public double? SCAN_PACK { get; set; }
    }
}
