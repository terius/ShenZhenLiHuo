using DAL;
using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ShenZhenLiHuo
{
    public partial class QueryForm : Form
    {
        readonly COMMON comm = new COMMON();
        public QueryForm()
        {
            InitializeComponent();
            labALLText.Text = "";
            labStatusTEXT.Text = "";
            InitGridView();
            BindType();
            CheckDate();
        }

        private void InitGridView()
        {
            superGrid1.EnableHeadersVisualStyles = false;
            CommonHelper.AddColumn(this.superGrid1, "扫描序列号", "SCAN_NO");
            CommonHelper.AddColumn(this.superGrid1, "分运单号", "BILL_NO");
            CommonHelper.AddColumn(this.superGrid1, "总运单号", "VOYAGE_NO");
            CommonHelper.AddColumn(this.superGrid1, "进出口标识", "I_E_FLAG");
            CommonHelper.AddColumn(this.superGrid1, "扫描时间", "SCAN_TIME");
            CommonHelper.AddColumn(this.superGrid1, "放行标识", "FANGXING");
            CommonHelper.AddColumn(this.superGrid1, "查验标识", "CHAYAN");
            CommonHelper.AddColumn(this.superGrid1, "无数据标识", "NODATA");
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            QueryData();
        }

        private void BindType()
        {

            cboxType.Items.Add("所有货物");
            cboxType.Items.Add("放行货物");
            cboxType.Items.Add("查验货物");
            cboxType.Items.Add("无数据货物");
            cboxType.SelectedIndex = 0;
        }

        private void QueryData()
        {
            StringBuilder sb = new StringBuilder();
            Hashtable ht = new Hashtable();
            string billno = tbBillNo.Text.Trim();
            if (!string.IsNullOrEmpty(billno))
            {
                sb.Append(" and bill_no like @bill_no");
                ht["bill_no"] = "%" + billno + "%";
            }

            string voyageno = txtVoyageNo.Text.Trim();
            if (!string.IsNullOrEmpty(voyageno))
            {
                sb.Append(" and voyage_no like @voyage_no");
                ht["voyage_no"] = "%" + voyageno + "%";
            }
            else if (rdHistory.Checked)
            {
                MessageBox.Show("查询历史数据必须输入总运单号！");
                return;
            }
            DateTime dtsix = DateTime.Now.Date.AddHours(6);
            ht["nowsix"] = dtsix;
            if (rdHistory.Checked)
            {

                sb.Append(" and scan_time >= @stime and scan_time <= @etime and scan_time <= @nowsix");
                ht["stime"] = stime.Value;
                ht["etime"] = etime.Value;
            }
            else
            {
            
                sb.Append(" and scan_time >= @nowsix");
             
            }
            switch (cboxType.SelectedIndex)
            {
                case 1:
                    sb.Append(" and dec_type =0");
                    break;
                case 2:
                    sb.Append(" and dec_type =1");
                    break;
                case 3:
                    sb.Append(" and send_type =2");
                    break;
                default:
                    break;
            }
            string table = rbToday.Checked ? "EHS_SCAN_TMP1" : "EHS_SCAN_TMP2";
            string sql = " select SCAN_NO,BILL_NO,VOYAGE_NO,I_E_FLAG,SCAN_TIME,"
                  + " (case DEC_TYPE when 0 then 1 else 0 end) as FANGXING,"
             + " (case DEC_TYPE when 1 then 1 else 0 end) as CHAYAN,"
             + " (case SEND_TYPE when 2 then 1 else 0 end) as NODATA from " + table + " where 1=1 " + sb.ToString();
            DataTable dt = comm.Query(sql, ht);
            this.superGrid1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            CheckDate();
        }

        private void CheckDate()
        {
            if (rbToday.Checked)
            {
                panel4.Hide();

            }
            else
            {
                panel4.Show();
            }
        }

        private void rdHistory_CheckedChanged(object sender, EventArgs e)
        {
            CheckDate();
        }
    }
}
