using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
   public partial class drug_specification
    {
        #region Static Calls

        public static drug_specification Get(int id)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.drug_specification.AsNoTracking().Where(p => p.id == id).FirstOrDefault();
                return ret;
            }
        }

        #endregion
    }
}
