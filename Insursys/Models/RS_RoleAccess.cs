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
    
    public partial class RS_RoleAccess
    {
        public int RoleAccess_Id { get; set; }
        public int RoleAccess_MenuId { get; set; }
        public int RoleAccess_Role_id { get; set; }
    
        public virtual RS_Menu RS_Menu { get; set; }
        public virtual RS_Roles RS_Roles { get; set; }
    }
}
