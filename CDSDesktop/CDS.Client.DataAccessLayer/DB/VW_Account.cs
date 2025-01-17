//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDS.Client.DataAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_Account
    {
        public long Id { get; set; }
        public Nullable<long> ControlId { get; set; }
        public long AccountId { get; set; }
        public Nullable<long> CenterId { get; set; }
        public byte AccountTypeId { get; set; }
        public string Control { get; set; }
        public string Title { get; set; }
        public string CodeMain { get; set; }
        public string CodeSub { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Flag1Type { get; set; }
        public string Flag2Type { get; set; }
        public string BalanceGroup { get; set; }
        public string CodeType { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public bool Archived { get; set; }
        public Nullable<bool> SystemDefaultAccount { get; set; }
        public bool AgingAccount { get; set; }
        public Nullable<long> SiteId { get; set; }
    }
}
