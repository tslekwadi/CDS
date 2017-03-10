//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace CDS.Client.DataAccessLayer.XDB
{

    [Persistent(@"CDS_SYS.SYS_DOC_Line")]
    public partial class CDS_SYS_SYS_DOC_Line : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_DOC_Header _HeaderId;
        [Association(@"CDS_SYS_SYS_DOC_LineReferencesCDS_SYS_SYS_DOC_Header")]
        public CDS_SYS_SYS_DOC_Header HeaderId
        {
            get { return _HeaderId; }
            set { SetPropertyValue<CDS_SYS_SYS_DOC_Header>("HeaderId", ref _HeaderId, value); }
        }
        CDS_SYS_SYS_Entity _ItemId;
        [Association(@"CDS_SYS_SYS_DOC_LineReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity ItemId
        {
            get { return _ItemId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("ItemId", ref _ItemId, value); }
        }
        int _LineOrder;
        public int LineOrder
        {
            get { return _LineOrder; }
            set { SetPropertyValue<int>("LineOrder", ref _LineOrder, value); }
        }
        decimal _DiscountPercentage;
        public decimal DiscountPercentage
        {
            get { return _DiscountPercentage; }
            set { SetPropertyValue<decimal>("DiscountPercentage", ref _DiscountPercentage, value); }
        }
        decimal _DiscountAmount;
        public decimal DiscountAmount
        {
            get { return _DiscountAmount; }
            set { SetPropertyValue<decimal>("DiscountAmount", ref _DiscountAmount, value); }
        }
        string _Description;
        [Size(50)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue<decimal>("Quantity", ref _Quantity, value); }
        }
        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { SetPropertyValue<decimal>("Amount", ref _Amount, value); }
        }
        decimal _Total;
        public decimal Total
        {
            get { return _Total; }
            set { SetPropertyValue<decimal>("Total", ref _Total, value); }
        }
        decimal _TotalTax;
        public decimal TotalTax
        {
            get { return _TotalTax; }
            set { SetPropertyValue<decimal>("TotalTax", ref _TotalTax, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_SYS_SYS_DOC_LineReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"CDS_ITM_ITM_MovementReferencesCDS_SYS_SYS_DOC_Line", typeof(CDS_ITM_ITM_Movement))]
        public XPCollection<CDS_ITM_ITM_Movement> CDS_ITM_ITM_Movements { get { return GetCollection<CDS_ITM_ITM_Movement>("CDS_ITM_ITM_Movements"); } }
    }

}