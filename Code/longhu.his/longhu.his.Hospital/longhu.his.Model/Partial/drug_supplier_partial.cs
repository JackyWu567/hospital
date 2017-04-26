using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
   public partial class drug_supplier
    {
        #region Static Calls

        public static drug_supplier Get(string supplier)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.drug_supplier.AsNoTracking().Where(p => p.supplier_name.Contains(supplier)|| p.supplier_name==supplier).FirstOrDefault();
                return ret;
            }
        }

        #endregion
    }
}
