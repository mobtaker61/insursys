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
    
    public partial class RS_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RS_Roles()
        {
            this.RS_Account = new HashSet<RS_Account>();
            this.RS_RoleAccess = new HashSet<RS_RoleAccess>();
        }
    
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }
        public string Role_Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_Account> RS_Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_RoleAccess> RS_RoleAccess { get; set; }
    }
}