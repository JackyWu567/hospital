using longhu.his.IDAL;
using longhu.his.Model;
using System;
using System.Linq;

namespace longhu.his.SQLServerDAL
{
    public class User : IUser
    {
        public int Create(sys_users user)
        {
            throw new NotImplementedException();
        }

        public sys_users Get(string userName, string password)
        {
            return sys_users.Get(userName, password);
        }

        public int Update(sys_users user)
        {
            throw new NotImplementedException();
        }
    }
}
