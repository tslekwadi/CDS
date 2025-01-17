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
namespace CDS.DataAccessLayer.XPO.Datamodel
{

    [Persistent(@"CDS_ITM.ITM_BOM_RecipeLine")]
    public partial class ITM_BOM_RecipeLine : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        ITM_BOM_Recipe fRecipeId;
        [Association(@"ITM_BOM_RecipeLineReferencesITM_BOM_Recipe")]
        public ITM_BOM_Recipe RecipeId
        {
            get { return fRecipeId; }
            set { SetPropertyValue<ITM_BOM_Recipe>("RecipeId", ref fRecipeId, value); }
        }
        SYS_Entity fItemId;
        [Association(@"ITM_BOM_RecipeLineReferencesSYS_Entity")]
        public SYS_Entity ItemId
        {
            get { return fItemId; }
            set { SetPropertyValue<SYS_Entity>("ItemId", ref fItemId, value); }
        }
        decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<decimal>("Quantity", ref fQuantity, value); }
        }
        decimal fAmount;
        public decimal Amount
        {
            get { return fAmount; }
            set { SetPropertyValue<decimal>("Amount", ref fAmount, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"ITM_BOM_RecipeLineReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
    }

}
