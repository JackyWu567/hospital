//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace longhu.his.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class drug_deliveries_details
    {
        public int drug_deliveries_Id { get; set; }
        public int supplier_id { get; set; }
        public int dg_Category_id { get; set; }
        public int dg_specification_id { get; set; }
        public int dg_units_id { get; set; }
        public string dg_name { get; set; }
        public string dg_name_ab { get; set; }
        public string Description { get; set; }
        public string dg_brand { get; set; }
        public string dg_plant { get; set; }
        public decimal dg_price { get; set; }
        public decimal dg_sale_price { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
        public string Updatedby { get; set; }
        public Nullable<int> Delete_flag { get; set; }
    
        public virtual drug_specification drug_specification { get; set; }
        public virtual drug_supplier drug_supplier { get; set; }
        public virtual drug_units drug_units { get; set; }
    }
}