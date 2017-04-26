using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public class DrugsNotNotedEntryModel
    {
        public string PurchaseNoteId { get; set; }
        public string DrugEntryType { get; set; }
        public string Supplier { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceDate { get; set; }
        public string Purchaser { get; set; }
        public string PurchaseAuditor { get; set; }
        public string Status { get; set; }
        public string SupplierAddress { get; set; }
    }
}
