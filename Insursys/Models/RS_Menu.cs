//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insursys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RS_Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RS_Menu()
        {
            this.RS_Menu1 = new HashSet<RS_Menu>();
            this.RS_RoleAccess = new HashSet<RS_RoleAccess>();
        }
    
        public int Menu_Id { get; set; }
        public Nullable<int> Menu_ParentId { get; set; }
        public string Menu_FormName { get; set; }
        public string Menu_Url { get; set; }
        public string Menu_Icon { get; set; }
        public string Menu_Class { get; set; }
        public bool Menu_Active { get; set; }
        public string Menu_Type { get; set; }
        public int Menu_Order { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_Menu> RS_Menu1 { get; set; }
        public virtual RS_Menu RS_Menu2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_RoleAccess> RS_RoleAccess { get; set; }
    }
}
