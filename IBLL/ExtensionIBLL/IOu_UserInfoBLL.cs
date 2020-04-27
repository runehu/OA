using Model;

namespace IBLL
{
    public partial interface IOu_UserInfoBLL
    {
        Ou_UserInfo Login(string strName, string strPwd);
    }
}