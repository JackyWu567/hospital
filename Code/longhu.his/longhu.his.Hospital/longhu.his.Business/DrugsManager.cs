using longhu.his.IDAL;
using longhu.his.Model;
using System;
using System.Collections.Generic;

namespace longhu.his.Business
{
    public class DrugsManager
    {
        // Get an instance of the Category DAL using the DALFactory
        // Making this static will cache the DAL instance after the initial load

        #region 查询操作
        private static readonly IDrugsManager dal = longhu.his.DALFactory.DataAccess.CreateDrugsManager();

        public List<DrugsNotNotedEntryModel> GetNotNotedEntries()
        {
            var results = new List<DrugsNotNotedEntryModel>();
            var vResults = dal.GetNotNotedEntries();

            foreach (var v in vResults)
            {
                results.Add(new DrugsNotNotedEntryModel
                {
                    DrugEntryType = v.entryName,
                    InvoiceCode = v.billNumer,
                    InvoiceDate = (v.bill_date ?? DateTime.MinValue).ToShortDateString(),
                    PurchaseAuditor = v.purchase_auditor_Name,
                    PurchaseNoteId = v.purchase_note_id,
                    Purchaser = v.purchase_Name,
                    Status = (v.Status ?? 0).ToString(),
                    Supplier = v.supplier_name,
                    SupplierAddress = v.supplier_Address
                });
            }

            return results;
        }

        public List<DrugsNotNotedEntryModel> GetNotNotedEntriesByInvoiceAndSupplier(string invoiceCode,string supplierAddress)
        {
            var results = new List<DrugsNotNotedEntryModel>();
            var vResults = dal.GetNotNotedEntriesByInvoiceAndSupplier(invoiceCode, supplierAddress);
            foreach (var v in vResults)
            {
                results.Add(new DrugsNotNotedEntryModel
                {
                    DrugEntryType = v.entryName,
                    InvoiceCode = v.billNumer,
                    InvoiceDate = (v.bill_date ?? DateTime.MinValue).ToShortDateString(),
                    PurchaseAuditor = v.purchase_auditor_Name,
                    PurchaseNoteId = v.purchase_note_id,
                    Purchaser = v.purchase_Name,
                    Status = (v.Status ?? 0).ToString(),
                    Supplier = v.supplier_name,
                    SupplierAddress = v.supplier_Address
                });
            }

            return results;
        }

        public List<DrugEntryDvItem> GetDrugEntryByPurNotedNo(string purNotedNo)
        {
            var reuslts = new List<DrugEntryDvItem>();
            var ret = dal.GetDrugEntryByPurNotedNo(purNotedNo);
            return ret;
        }

        #endregion

        #region 入库单操作

        public DrugEntryModel AddDrugEntry()
        {

            return null;
        }

        #endregion
    }
}
