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

    [Persistent(@"CDS_ITM.ITM_StockTakeItem")]
    public partial class CDS_ITM_ITM_StockTakeItem : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_ITM_ITM_StockTake _StockTakeId;
        [Association(@"CDS_ITM_ITM_StockTakeItemReferencesCDS_ITM_ITM_StockTake")]
        public CDS_ITM_ITM_StockTake StockTakeId
        {
            get { return _StockTakeId; }
            set { SetPropertyValue<CDS_ITM_ITM_StockTake>("StockTakeId", ref _StockTakeId, value); }
        }
        CDS_SYS_SYS_Entity _InventoryId;
        [Association(@"CDS_ITM_ITM_StockTakeItemReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity InventoryId
        {
            get { return _InventoryId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("InventoryId", ref _InventoryId, value); }
        }
        long _LineNumber;
        public long LineNumber
        {
            get { return _LineNumber; }
            set { SetPropertyValue<long>("LineNumber", ref _LineNumber, value); }
        }
        int _PageNumber;
        public int PageNumber
        {
            get { return _PageNumber; }
            set { SetPropertyValue<int>("PageNumber", ref _PageNumber, value); }
        }
        decimal _OnHand;
        public decimal OnHand
        {
            get { return _OnHand; }
            set { SetPropertyValue<decimal>("OnHand", ref _OnHand, value); }
        }
        decimal _QuantityCount1;
        public decimal QuantityCount1
        {
            get { return _QuantityCount1; }
            set { SetPropertyValue<decimal>("QuantityCount1", ref _QuantityCount1, value); }
        }
        decimal _QuantityCount2;
        public decimal QuantityCount2
        {
            get { return _QuantityCount2; }
            set { SetPropertyValue<decimal>("QuantityCount2", ref _QuantityCount2, value); }
        }
        decimal _UnitPrice;
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref _UnitPrice, value); }
        }
        decimal _UnitCost;
        public decimal UnitCost
        {
            get { return _UnitCost; }
            set { SetPropertyValue<decimal>("UnitCost", ref _UnitCost, value); }
        }
        decimal _UnitAverage;
        public decimal UnitAverage
        {
            get { return _UnitAverage; }
            set { SetPropertyValue<decimal>("UnitAverage", ref _UnitAverage, value); }
        }
        bool _SuccessfullyChanged;
        public bool SuccessfullyChanged
        {
            get { return _SuccessfullyChanged; }
            set { SetPropertyValue<bool>("SuccessfullyChanged", ref _SuccessfullyChanged, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_ITM_ITM_StockTakeItemReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
    }

}
