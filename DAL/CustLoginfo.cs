//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustLoginfo
    {
        public int Logid { get; set; }
        public string CustEmail { get; set; }
        public string CustName { get; set; }
        public string LogStatus { get; set; }
        public Nullable<int> Userid { get; set; }
        public string Description { get; set; }
    
        public virtual Userinfo Userinfo { get; set; }
    }
}
