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
    
    public partial class RS_Issued
    {
        public int Issued_Id { get; set; }
        public int Issued_RequestId { get; set; }
        public string Issued_No { get; set; }
        public Nullable<decimal> Issued_Price { get; set; }
        public Nullable<System.DateTime> Issued_StartDate { get; set; }
        public string Issued_OriginalPolicyUrl { get; set; }
        public Nullable<System.DateTime> Issued_Date { get; set; }
    
        public virtual RS_Request RS_Request { get; set; }
    }
}
