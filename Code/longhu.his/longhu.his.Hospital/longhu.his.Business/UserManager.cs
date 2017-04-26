using longhu.his.IDAL;
using longhu.his.Model;
using longhu.his.Common;

namespace longhu.his.Business
{
    public class UserManager
    {
        // Get an instance of the Category DAL using the DALFactory
        // Making this static will cache the DAL instance after the initial load
        private static readonly IUser dal = longhu.his.DALFactory.DataAccess.CreateUser();

        protected sys_users Get(string userName, string password)
        {
            return dal.Get(userName, password);
        }

        public bool VerfyUserLogin(string userName,string password,out sys_users usr)
        {
            var encryptPwd = Utilities.MD5Encrypt(password);

            sys_users user = Get(userName, encryptPwd);
            usr = user;

            return user != null;
        }

    }
}
