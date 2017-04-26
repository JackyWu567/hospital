using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
   public partial class sys_user_roles
    {
        public List<sys_roles> Roles { get; set; }
        
        public sys_user_roles() { }

        public sys_user_roles(int userId)
        {
            using (DBConnection db = new DBConnection())
            {
                var role_permissions = from rp in db.View_Permission_Roles
                                      join ur in db.sys_user_roles on rp.roleId equals ur.Role_id
                                      where ur.user_id == userId
                                      select new {
                                          rp.permisionId,
                                          rp.Permissionname,
                                          rp.Permissionname_ab,
                                          rp.permissions,
                                          rp.roleId,
                                          rp.Rolename,
                                          rp.Rolename_ab,
                                          ur.user_id 
                                      };
                this.Roles = new List<sys_roles> ();
                foreach(var item in role_permissions)
                {
                    this.Roles.Add(new sys_roles
                    {
                        Id=item.roleId,
                        Rolename = item.Rolename,
                        Rolename_ab = item.Rolename_ab,
                        PermissionContent = new sys_permission_roles
                        {
                             roleId =item.roleId,
                             //PermissionDetails=
                             permissions=item.permissions,
                        }
                    });
                }
            }
        }
    }
}
