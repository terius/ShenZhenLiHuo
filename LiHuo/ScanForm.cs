using BLL;
using DAL;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShenZhenLiHuo
{
    public partial class ScanForm : Form
    {
        readonly COMMON comm = new COMMON();
        readonly ScanHeadBLL bll = new ScanHeadBLL();
        int setMaxNo = 0;
        public ScanForm()
        {
            GlobalVariable.CreateTestLoginInfo();
            InitializeComponent();
            InitGridView();
            BindData();

        }

        private void BindData()
        {
            string sql = "select top 100 a.SCAN_NO,a.BILL_NO,a.PACK_NO,a.VOYAGE_NO,b.BILL_SUM,b.PACK_SUM,"
             + " 0 as ALLSCANBILL,0 as ALLSCANPACK,"
             + " (case a.DEC_TYPE when 0 then 1 else 0 end) as FANGXING,"
             + " (case a.DEC_TYPE when 1 then 1 else 0 end) as CHAYAN,"
             + " (case a.SEND_TYPE when 2 then 1 else 0 end) as NODATA"
             + " from EHS_SCAN_TMP1 a left"
             + " join EHS_SCAN_LIST2 b on a.VOYAGE_NO = b.VOYAGE_NO order by a.SCAN_NO desc";
            DataTable dt = comm.Query(sql);
            foreach (DataRow dr in dt.Rows)
            {
                this.superGrid1.Rows.Add(dr.ItemArray);
            }
        }

        private void InitGridView()
        {
            superGrid1.EnableHeadersVisualStyles = false;
            CommonHelper.AddColumn(this.superGrid1, "扫描计数", "SCAN_NO");
            CommonHelper.AddColumn(this.superGrid1, "分运单号", "BILL_NO");
            CommonHelper.AddColumn(this.superGrid1, "申报件数", "PACK_NO");
            CommonHelper.AddColumn(this.superGrid1, "总运单号", "VOYAGE_NO");
            CommonHelper.AddColumn(this.superGrid1, "总票数", "BILL_SUM");
            CommonHelper.AddColumn(this.superGrid1, "总件数", "PACK_SUM");
            CommonHelper.AddColumn(this.superGrid1, "已扫票数", "ALLSCANBILL");
            CommonHelper.AddColumn(this.superGrid1, "已扫件数", "ALLSCANPACK");
            CommonHelper.AddColumn(this.superGrid1, "放行标识", "FANGXING");
            CommonHelper.AddColumn(this.superGrid1, "查验标识", "CHAYAN");
            CommonHelper.AddColumn(this.superGrid1, "无数据标识", "NODATA");
        }

        private void tbNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClearStatus();
                string billno = tbNo.Text.Trim();
                if (billno.Length == 34)
                {
                    billno = billno.Substring(22);
                    labNowScan.Text = billno;
                    int insertId = bll.InsertNewDataToTmp(billno,setMaxNo);
                    AddNewGridRow(insertId);
                    setMaxNo = 0;
                }
                else
                {
                    labMessage.Text = "条码长度错误！必须为34位条码";
                }
            }
        }

        private void AddNewGridRow(int insertId)
        {
            if (insertId == 0)
            {
                MessageBox.Show("扫描条码错误，请检查！");
                return;
            }
            string sql = "select top 1 a.SCAN_NO,a.BILL_NO,a.PACK_NO,a.VOYAGE_NO,b.BILL_SUM,b.PACK_SUM,"
             + " b.SCAN_BILL_SUM as ALLSCANBILL,b.SCAN_PACK_SUM as ALLSCANPACK,"
             + " (case a.DEC_TYPE when 0 then 1 else 0 end) as FANGXING,"
             + " (case a.DEC_TYPE when 1 then 1 else 0 end) as CHAYAN,"
             + " (case a.SEND_TYPE when 2 then 1 else 0 end) as NODATA"
             + " from EHS_SCAN_TMP1 a left"
             + " join EHS_SCAN_LIST2 b on a.VOYAGE_NO = b.VOYAGE_NO where a.id=@id ";
            Hashtable ht = new Hashtable();
            ht["id"] = insertId;
            DataRow dr = comm.GetOneRow(sql, ht);
            if (dr != null)
            {
                superGrid1.Rows.Insert(0, dr.ItemArray);
                superGrid1.Rows[0].Selected = true;
                superGrid1.FirstDisplayedScrollingRowIndex = 0;

                if (dr["FANGXING"].ToString() == "1")
                {
                    labFangXing.BackColor = Color.Red;
                }

                if (dr["CHAYAN"].ToString() == "1")
                {
                    labChaYan.BackColor = Color.Red;
                }

                if (dr["NODATA"].ToString() == "1")
                {
                    labWuShuJu.BackColor = Color.Red;
                }

                if (tbNo.Focused)
                {
                    tbNo.Text = "";
                }
                else if (txtBillNo.Focused)
                {
                    txtBillNo.Text = "";
                    tbNo.Text = "";
                    tbNo.Focus();
                }
            }
        }

        private void ClearStatus()
        {
            labFangXing.BackColor = labChaYan.BackColor = labWuShuJu.BackColor = Color.Silver;
            labMessage.Text = "";

        }

        private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ClearStatus();
                string billno = txtBillNo.Text.Trim();
                if (billno.Length == 12)
                {
                    labNowScan.Text = billno;
                    int insertId = bll.InsertNewDataToTmp(billno,setMaxNo);
                 
                    AddNewGridRow(insertId);
                    setMaxNo = 0;
                }
                else
                {
                    labMessage.Text = "条码长度错误！必须为12位条码";
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string str = Interaction.InputBox("设置扫描序列号", "设置扫描序列号", "", 100, 100);
            int nowMaxScanNo = comm.GetIntData("select max(scan_no) from EHS_SCAN_TMP1");
            int itemp = 0;
            if (int.TryParse(str, out itemp))
            {
                if (itemp <= nowMaxScanNo)
                {
                    MessageBox.Show("设置扫描序列号错误，必须大于当前扫描序列号，当前扫描序列号为" + nowMaxScanNo);
                    return;
                }

                setMaxNo = itemp;
            }
            else
            {
                MessageBox.Show("扫描序列号必须为数字，请重新输入");
            }


        }



        //private object[] CreateNewRow(string sn)
        //{
        //    string billNo = sn;
        //    object[] obs = new object[] { };
        //    obs[0] = bll.GetMaxSCANNO(billNo);

        //}
    }
}
