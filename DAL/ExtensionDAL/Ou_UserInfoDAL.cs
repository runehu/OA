using IDAL;
using Model;

namespace DAL
{
    public partial class Ou_UserInfoDAL : IOu_UserInfoDAL
    {
        public Ou_UserInfo GetUserInfoByName(string loginName)
        {
            return base.GetListBy(x => x.uLoginName == loginName).FirstOrDefault();
        }
    }
}