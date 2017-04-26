using longhu.his.Model;
using System.Collections.Generic;

namespace longhu.his.IDAL
{
    public interface IDrugsManager
    {
        List<View_GetNotNotedDrugEntries> GetNotNotedEntries();
        List<View_GetNotNotedDrugEntries> GetNotNotedEntriesByInvoiceAndSupplier(string invoiceCode, string supplierAddress);
        List<DrugEntryDvItem> GetDrugEntryByPurNotedNo(string purNotedNo);
    }
}
