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
    
    public partial class godown_entry
    {
        public int Id { get; set; }
        public int Entry_user_id { get; set; }
        public string purchase_note_id { get; set; }
        public int drug_entryType_id { get; set; }
        public int purchase_auditor_id { get; set; }
        public string billNumer { get; set; }
        public Nullable<System.DateTime> bill_date { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
        public string Updatedby { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Delete_flag { get; set; }
    }
}
