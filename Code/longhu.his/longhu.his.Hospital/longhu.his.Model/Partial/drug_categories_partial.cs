using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
   public partial class drug_categories
    {
        #region Static Calls

        public static drug_categories Get(int id)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.drug_categories.AsNoTracking().Where(p => p.Id == id).FirstOrDefault();
                return ret;
            }
        }

        #endregion
    }
}
