using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public partial class godown_entry
    {
        public godown_entry_details GodownEntryDetails { get; set; }

        #region Constructors

        public godown_entry() { }

        #endregion

        #region Static Calls

        public static godown_entry GetByPurchaseNoteNo(string purchaserNoteNo)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = db.godown_entry.AsNoTracking().Where(p => p.purchase_note_id == purchaserNoteNo).FirstOrDefault();
                return ret;
            }
        }

        public static List<View_GetNotNotedDrugEntries> GetNotNotedEntries()
        {
            using (DBConnection db = new DBConnection())
            {
                return db.View_GetNotNotedDrugEntries.ToList();
            }
        }

        public static List<View_GetNotNotedDrugEntries> GetNotNotedEntriesByInvoiceAndSupplier(string invoiceCode, string supplierAddress)
        {
            using (DBConnection db = new DBConnection())
            {
                var result = db.View_GetNotNotedDrugEntries.Where(e => (string.IsNullOrEmpty(invoiceCode) || (e.billNumer.Contains(invoiceCode)))
                                                                    && ((string.IsNullOrEmpty(supplierAddress) || (e.supplier_Address.Contains(supplierAddress))))).ToList();
                return result;
            }
        }

        /// <summary>
        /// Get Entry
        /// </summary>
        /// <param name="purNotedNo"></param>
        /// <returns></returns>
        public static List<DrugEntryDvItem> GetDrugEntryByPurNotedNo(string purNotedNo)
        {
            using (DBConnection db = new DBConnection())
            {
                var ret = from gdwn in db.godown_entry
                          join gdwn_details in db.godown_entry_details on gdwn.Id equals gdwn_details.godown_entry_Id
                          join entryType in db.drug_entryType on gdwn.drug_entryType_id equals entryType.Id
                          where gdwn.purchase_note_id == purNotedNo
                          select new DrugEntryDvItem
                          {
                              /// </summary>
                              Amount = gdwn_details.Amount,
                              /// <summary>
                              /// 进价
                              /// </summary>
                              PurchasePrice = gdwn_details.dg_price,
                              /// <summary>
                              /// 供应商
                              /// </summary>
                              Supplier = gdwn_details.drug_supplier.supplier_name,
                              /// <summary>
                              /// 入库日期
                              /// </summary>
                              EntryDate = gdwn.Created_date ?? DateTime.MinValue,
                              /// <summary>
                              /// 有效期
                              /// </summary>
                              ExpiredDate = gdwn_details.dg_expiration_date ?? DateTime.MinValue,
                              /// <summary>
                              /// 入库方式
                              /// </summary>
                              EntryType = entryType.entryName,
                              /// <summary>
                              /// 入库单号
                              /// </summary>
                              EntryNoteNo = gdwn.purchase_note_id,
                              /// <summary>
                              /// 发票日期
                              /// </summary>
                              InvoiceDate = gdwn.bill_date ?? DateTime.MinValue,
                              /// <summary>
                              /// 发票号
                              /// </summary>
                              InvoiceCode = gdwn.billNumer,
                              /// <summary>
                              /// 药品编码
                              /// </summary>
                              DrugCodes = gdwn_details.dg_codes,
                              /// <summary>
                              /// 药品扣率
                              /// </summary>
                              PurchaserDiscount = gdwn_details.Dicount_rate ?? 0,
                              /// <summary>
                              /// 药品批号
                              /// </summary>
                              DurgBatchNumber = gdwn_details.Drug_batch_number,
                              /// <summary>
                              /// 默认扣率
                              /// </summary>
                              DefaultDiscount = gdwn_details.Default_discount_rate ?? 0,
                              /// <summary>
                              /// 上次进价
                              /// </summary>
                              LastPurchasePrice = gdwn_details.dg_last_price ?? 0,
                              /// <summary>
                              /// 进价金额
                              /// </summary>
                              PurchasePriceTotal = gdwn_details.dg_price * gdwn_details.Amount
                          };

                return ret.ToList();
            }
        }

        #endregion

        #region Create/Update/Delete

        public int Create()
        {
            using (DBConnection db = new DBConnection())
            {
                db.godown_entry.Add(this);
               var rowCount= db.SaveChanges();

                return rowCount;
            }
        }

        public int UpdateInvoiceCode()
        {
            using (DBConnection db = new DBConnection())
            {
                db.godown_entry.Attach(this);

                db.Entry(this).Property(p => p.billNumer).IsModified = true;
                db.Entry(this).Property(p => p.bill_date).IsModified = true;
                db.Entry(this).Property(p => p.Updatedby).IsModified = true;
                db.Entry(this).Property(p => p.Updated_date).IsModified = true;

               var rowCount= db.SaveChanges();
                return rowCount;
            }
        }

        public int UpdateEntryStatus()
        {
            using (DBConnection db = new DBConnection())
            {
                db.godown_entry.Attach(this);

                db.Entry(this).Property(p => p.Status).IsModified = true;
                db.Entry(this).Property(p => p.Updatedby).IsModified = true;
                db.Entry(this).Property(p => p.Updated_date).IsModified = true;

                var rowCount = db.SaveChanges();
                return rowCount;
            }
        }

        public int Delete()
        {
            using (DBConnection db = new DBConnection())
            {
                db.godown_entry.Attach(this);

                db.Entry(this).Property(p => p.Delete_flag).IsModified = true;

                db.Entry(this).Property(p => p.Updatedby).IsModified = true;
                db.Entry(this).Property(p => p.Updated_date).IsModified = true;

                var rowCount = db.SaveChanges();
                return rowCount;
            }
        }

        #endregion

    }
}
