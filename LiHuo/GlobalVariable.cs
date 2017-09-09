using Model;

namespace ShenZhenLiHuo
{
    public static class GlobalVariable
    {
        public static UserInfo LoginUserInfo { get; set; }

        public static void CreateTestLoginInfo()
        {
            LoginUserInfo = new Model.UserInfo();
            LoginUserInfo.HY_NAME = "联邦快递公司";
            LoginUserInfo.id = 1;
            LoginUserInfo.Lever = "3";
            LoginUserInfo.UserName = "user001";
            LoginUserInfo.UserPassword = "99999";
        }
    }
}
