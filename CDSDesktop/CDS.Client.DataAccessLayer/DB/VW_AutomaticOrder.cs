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
    
    public partial class VW_AutomaticOrder
    {
        public long Id { get; set; }
        public Nullable<long> SupplierId { get; set; }
        public byte StatusId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string Status { get; set; }
        public string Filter { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> TotalTax { get; set; }
        public Nullable<decimal> TotalIncl { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}