using Model;

namespace ShenZhenLiHuo
{
    public static class GlobalVariable
    {
        public static UserInfo LoginUserInfo { get; set; }

        public static void CreateTestLoginInfo()
        {
            GlobalVariable.LoginUserInfo = new Model.UserInfo();
            GlobalVariable.LoginUserInfo.HY_NAME = "xxx公司";
            GlobalVariable.LoginUserInfo.id = 1;
            GlobalVariable.LoginUserInfo.Lever = "3";
            GlobalVariable.LoginUserInfo.UserName = "user001";
            GlobalVariable.LoginUserInfo.UserPassword = "99999";
        }
    }
}
