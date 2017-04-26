using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class godown_entry_details
    {
        #region Properties

        public int MyProperty { get; set; }

        #endregion

        #region Constructors

        public godown_entry_details() { }

        #endregion

        #region Static Calls

        public static godown_entry_details Get(int id)
        {
            using (DBConnection db = new DBConnection())
            {
                var result = (from details in db.godown_entry_details
                             where details.godown_entry_Id == id
                             select details).FirstOrDefault();

                return result;
            }
        }

        public static List<godown_entry_details> GetGodownDetails(int entryId)
        {
            using (DBConnection db = new DBConnection())
            {
                var result = (from details in db.godown_entry_details
                              where details.godown_entry_Id == entryId
                              select details).ToList();
                return result;
            }
        }

        #endregion

        #region Create/Update/Delete

        public int Create()
        {
            using (DBConnection db = new DBConnection())
            {
                db.godown_entry_details.Add(this);
                var rowCount = db.SaveChanges();
                return rowCount;
            }
        }

        //public int Update

        #endregion
    }
}
