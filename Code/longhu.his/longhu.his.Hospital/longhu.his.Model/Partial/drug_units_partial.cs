using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
   public partial class drug_units
    {
        #region Static Calls

        public static drug_units Get(int id)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.drug_units.AsNoTracking().Where(p => p.Id == id).FirstOrDefault();
                return ret;
            }
        }

        #endregion
    }
}
