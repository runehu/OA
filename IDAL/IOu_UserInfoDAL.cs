using Model;
namespace IDAL
{
    public partial interface IOu_UserInfoDAL
    {
        Ou_UserInfo GetUserInfoByName(string loginName);
    }
}