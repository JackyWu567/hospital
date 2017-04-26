using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class department
    {
        public static department Get(int deparId)
        {
            using (DBConnection db = new DBConnection())
            {
                var depart = db.departments.AsNoTracking().Where(d => d.Id == deparId).FirstOrDefault();
                return depart;
            }
        }
    }
}
