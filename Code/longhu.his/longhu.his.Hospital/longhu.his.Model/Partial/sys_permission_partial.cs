using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class sys_permission
    {
        public sys_permission() { }

        public static List<sys_permission> Get(string content)
        {
            var permissions = content.Split(new string[] { "," }, StringSplitOptions.None);
            var PermissionDetails = new List<sys_permission>();
            using (DBConnection db = new DBConnection())
            {
                foreach (var str in permissions)
                {
                    var result = db.sys_permission.AsNoTracking().Where(p => p.Id == int.Parse(str)).FirstOrDefault();
                    PermissionDetails.Add(result);
                }

                return PermissionDetails;
            }
        }
    }
}
