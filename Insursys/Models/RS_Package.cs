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
    
    public partial class RS_Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RS_Package()
        {
            this.RS_Request = new HashSet<RS_Request>();
        }
    
        public int Package_Id { get; set; }
        public Nullable<int> Package_ProviderId { get; set; }
        public string Package_Name { get; set; }
        public Nullable<int> Package_ServiceTypeId { get; set; }
        public Nullable<decimal> Package_Coefficient { get; set; }
        public Nullable<int> Package_WebServiceId { get; set; }
        public bool Package_Active { get; set; }
    
        public virtual RS_Provider RS_Provider { get; set; }
        public virtual RS_ServiceType RS_ServiceType { get; set; }
        public virtual RS_WebService RS_WebService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RS_Request> RS_Request { get; set; }
    }
}
