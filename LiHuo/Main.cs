using Model;
using System;
using System.Windows.Forms;
using BLL;
namespace ShenZhenLiHuo
{
    public partial class Main : Form
    {

        private readonly UserBLL userBLL = new UserBLL();
        public Main()
        {
            InitializeComponent();
            GlobalVariable.CreateTestLoginInfo();
            //  userInfo = userBLL.GetUserInfoById(userId);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labTitle.Text = "欢迎 " + (GlobalVariable.LoginUserInfo.HY_NAME) + " 用户登录";
            //if (GlobalVariable.LoginUserInfo.UserName.Equals("admin", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    btnGJInput.Visible = true;
            //    btnImport.Visible = false;
            //    //   btnReport.Visible = false;
            //    btnScan.Visible = false;
            //    btnScanFast.Visible = false;

            //}
            //else
            //{
            //    btnGJInput.Visible = false;
            //    btnImport.Visible = true;
            //    //    btnReport.Visible = true;
            //    btnScan.Visible = true;
            //    btnScanFast.Visible = true;
            //}
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
            // Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanForm frm = new ScanForm();
            frm.ShowDialog();
        }

        private void btnGJInput_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
