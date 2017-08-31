using System;
using System.Windows.Forms;

namespace ShenZhenLiHuo
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            labALLText.Text = "";
            labStatusTEXT.Text = "";
            InitGridView();
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

        private void QueryData()
        {

        }
    }
}
