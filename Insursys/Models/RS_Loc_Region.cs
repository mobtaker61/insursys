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
    
    public partial class RS_Loc_Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RS_Loc_Region()
        {
            this.RS_AccountAddress = new HashSet<RS_AccountAddress>();
        }
    
        public int Region_Id { get; set; }
        public int Region_CityId { get; set; }
        public string Region_Name { get; set; }
        public Nullable<int> Region_WsCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_AccountAddress> RS_AccountAddress { get; set; }
        public virtual RS_Loc_City RS_Loc_City { get; set; }
    }
}