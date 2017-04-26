using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public class DrugEntryModel : IDisposable
    {
        public godown_entry GodownEntry { get; set; }

        public List<DrugEntryDvItem> DrugEntryDvItems { get; set; }

        #region Constructors

        public DrugEntryModel() { }

        public DrugEntryModel(string purchaserNoteNo)
        {

        }

        #endregion

        #region IDisposable Interface Implements

        public void Dispose()
        {
            //
            this.GodownEntry = null;
        }

        #endregion
    }
}
