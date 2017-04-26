using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class drug_entryType
    {
        #region Static Calls

        public static drug_entryType Get(string typeName)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.drug_entryType.AsNoTracking().Where(p => p.entryName == typeName).FirstOrDefault();
                return ret;
            }
        }

        #endregion
    }
}
