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
    
    public partial class RS_TransactionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RS_TransactionType()
        {
            this.RS_Transaction = new HashSet<RS_Transaction>();
        }
    
        public int TransactionType_Id { get; set; }
        public string TransactionType_Name { get; set; }
        public string TransactionType_Class { get; set; }
        public string TransactionType_Icon { get; set; }
        public Nullable<int> TransactionType_SortOrder { get; set; }
        public Nullable<int> TransactionType_GroupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_Transaction> RS_Transaction { get; set; }
    }
}
