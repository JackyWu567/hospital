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
    
    public partial class drug_categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drug_categories()
        {
            this.drugs = new HashSet<drug>();
            this.godown_entry_details = new HashSet<godown_entry_details>();
        }
    
        public int Id { get; set; }
        public string Category_name { get; set; }
        public string Category_name_ab { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
        public string Updatedby { get; set; }
        public Nullable<int> Delete_flag { get; set; }
        public Nullable<int> parentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drug> drugs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<godown_entry_details> godown_entry_details { get; set; }
    }
}
