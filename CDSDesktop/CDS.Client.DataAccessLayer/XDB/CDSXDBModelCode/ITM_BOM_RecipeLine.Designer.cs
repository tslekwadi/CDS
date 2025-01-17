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

    public partial class ITM_BOM_RecipeLine : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        ITM_BOM_Recipe _RecipeId;
        [Association(@"ITM_BOM_RecipeLineReferencesITM_BOM_Recipe")]
        public ITM_BOM_Recipe RecipeId
        {
            get { return _RecipeId; }
            set { SetPropertyValue<ITM_BOM_Recipe>("RecipeId", ref _RecipeId, value); }
        }
        SYS_Entity _ItemId;
        [Association(@"ITM_BOM_RecipeLineReferencesSYS_Entity")]
        public SYS_Entity ItemId
        {
            get { return _ItemId; }
            set { SetPropertyValue<SYS_Entity>("ItemId", ref _ItemId, value); }
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
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"ITM_BOM_RecipeLineReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
    }

}
