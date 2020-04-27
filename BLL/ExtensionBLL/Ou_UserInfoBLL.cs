using Model;
using IBLL;

namespace BLL
{
    public partial class Ou_UserInfoBLL : IOu_UserInfoBLL
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        public Ou_UserInfo Login(string strName, string strPwd)
        {
            //1.调用业务层方法 根据登陆名查询
            Ou_UserInfo usr = base.GetListBy(u => u.uLoginName == strName).FirstOrDefault();
            //2.判断是否登陆成功

            return null;
        }
    }
}