using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using longhu.his.IDAL;
using longhu.his.Model;

namespace longhu.his.SQLServerDAL
{
    public class DrugsManager:IDrugsManager
    {
        public List<View_GetNotNotedDrugEntries> GetNotNotedEntries()
        {
            return godown_entry.GetNotNotedEntries();
        }

        public List<View_GetNotNotedDrugEntries> GetNotNotedEntriesByInvoiceAndSupplier(string invoiceCode, string supplierAddress)
        {

            return godown_entry.GetNotNotedEntriesByInvoiceAndSupplier(invoiceCode,supplierAddress);
        }

        public List<DrugEntryDvItem> GetDrugEntryByPurNotedNo(string purNotedNo)
        {
            return godown_entry.GetDrugEntryByPurNotedNo(purNotedNo);
        }
    }
}
