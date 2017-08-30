using System.Windows.Forms;

namespace ShenZhenLiHuo
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
            InitGridView();
        }

        private void InitGridView()
        {
            superGrid1.EnableHeadersVisualStyles = false;
            CommonHelper.AddColumn(this.superGrid1, "扫描计数", "SCAN_NO");
            CommonHelper.AddColumn(this.superGrid1, "分运单号", "BILL_NO");
            CommonHelper.AddColumn(this.superGrid1, "申报件数", "PACK_NO");
            CommonHelper.AddColumn(this.superGrid1, "总运单号", "VOYAGE_NO");
            CommonHelper.AddColumn(this.superGrid1, "总票数", "MAIN_G_NAME");
            CommonHelper.AddColumn(this.superGrid1, "总件数", "I_E_FLAG");
            CommonHelper.AddColumn(this.superGrid1, "已扫票数", "I_E_PORT");
            CommonHelper.AddColumn(this.superGrid1, "已扫件数", "D_DATE");
            CommonHelper.AddColumn(this.superGrid1, "放行标识", "RSK_FLAG");
            CommonHelper.AddColumn(this.superGrid1, "查验标识", "OP_TYPE");
            CommonHelper.AddColumn(this.superGrid1, "无数据标识", "OP_TYPE");
        }

        private void tbNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
