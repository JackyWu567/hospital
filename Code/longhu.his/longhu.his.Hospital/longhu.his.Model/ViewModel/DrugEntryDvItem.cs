using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model
{
    public class DrugEntryDvItem
    {
        /// <summary>
        /// 药品名称
        /// </summary>
        public string DrugName { get; set; }
        /// <summary>
        /// 药品规格
        /// </summary>
        public string DrugSpecification { get; set; }
        /// <summary>
        /// 药品剂量
        /// </summary>
        public string DrugUnits { get; set; }
        /// <summary>
        /// 药品剂量
        /// </summary>
        public string DrugCategory { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        public string ProduceArea { get; set; }
        /// <summary>
        /// 批发价
        /// </summary>
        public decimal WholeSalePrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }
        /// <summary>
        /// 包装单位
        /// </summary>
        public string DrugPacker { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 进价
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string Supplier { get; set; }
        /// <summary>
        /// 入库日期
        /// </summary>
        public DateTime EntryDate { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime ExpiredDate { get; set; }
        /// <summary>
        /// 入库方式
        /// </summary>
        public string EntryType { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        public string EntryNoteNo { get; set; }
        /// <summary>
        /// 发票日期
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoiceCode { get; set; }
        /// <summary>
        /// 药品编码
        /// </summary>
        public string DrugCodes { get; set; }
        /// <summary>
        /// 药品扣率
        /// </summary>
        public decimal PurchaserDiscount { get; set; }
        /// <summary>
        /// 药品批号
        /// </summary>
        public string DurgBatchNumber { get; set; }
        /// <summary>
        /// 默认扣率
        /// </summary>
        public decimal DefaultDiscount { get; set; }
        /// <summary>
        /// 上次进价
        /// </summary>
        public decimal LastPurchasePrice { get; set; }
        /// <summary>
        /// 进价金额
        /// </summary>
        public decimal PurchasePriceTotal { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
