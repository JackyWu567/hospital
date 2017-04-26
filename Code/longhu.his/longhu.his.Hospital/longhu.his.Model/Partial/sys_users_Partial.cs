using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class sys_users
    {
      //  public sys_usr_type UserType { get; set; }

        public sys_user_roles UserRoles { get; set; }

        public department Department { get; set; }

        #region Constructors

        public sys_users() { }

        #endregion

        #region Static Calls

        public static sys_users Get(string account,string password)
        {
            using (DBConnection db = new DBConnection())
            {
                var v = db.View_GetUserInfo.AsNoTracking().Where(u => u.Account == account && u.password == password).FirstOrDefault();

                var sysUser = new sys_users();
                if (v != null)
                {
                    sysUser.Id = v.Id;
                    sysUser.userTypeId = v.userTypeId;
                    sysUser.departmentId = v.departmentId;
                    sysUser.Account = v.Account;
                    sysUser.password = v.password;
                    sysUser.userName = v.userName;
                    sysUser.Gender = v.Gender;
                    sysUser.Age = v.Age;
                    sysUser.Adress = v.Adress;
                    sysUser.Address1 = v.Address1;
                    sysUser.Mobile = v.Mobile;
                    sysUser.Telphone = v.Telphone;
                    sysUser.QQ = v.QQ;
                    sysUser.Email = v.Email;
                    sysUser.residentID = v.residentID;
                    sysUser.Created_date = v.Created_date;
                    sysUser.Createdby = v.Createdby;
                    sysUser.Delete_flag = v.Delete_flag;

                    // handle Customer properties
                    sysUser.UserRoles = new sys_user_roles(v.Id);
                    sysUser.Department = department.Get(v.departmentId);
                }else
                {
                    sysUser = null;
                }

                return sysUser;
            }
        }

        #endregion

    }
}
