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
    
    public partial class drug_shelves_maping
    {
        public int Id { get; set; }
        public int Dg_category_id { get; set; }
        public int drug_id { get; set; }
        public string Shelf_no { get; set; }
        public string Shelg_row_no { get; set; }
        public string Shelg_column_no { get; set; }
        public Nullable<decimal> current_sotred_amount { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
        public string Updatedby { get; set; }
        public Nullable<int> Delete_flag { get; set; }
    }
}
