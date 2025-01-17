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

    public partial class ITM_BOM_Recipe : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        SYS_Entity _ItemResultId;
        [Association(@"ITM_BOM_RecipeReferencesSYS_Entity")]
        public SYS_Entity ItemResultId
        {
            get { return _ItemResultId; }
            set { SetPropertyValue<SYS_Entity>("ItemResultId", ref _ItemResultId, value); }
        }
        string _Description;
        [Size(1000)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        decimal _QuantityResult;
        public decimal QuantityResult
        {
            get { return _QuantityResult; }
            set { SetPropertyValue<decimal>("QuantityResult", ref _QuantityResult, value); }
        }
        decimal _Building;
        public decimal Building
        {
            get { return _Building; }
            set { SetPropertyValue<decimal>("Building", ref _Building, value); }
        }
        decimal _UnBuilding;
        public decimal UnBuilding
        {
            get { return _UnBuilding; }
            set { SetPropertyValue<decimal>("UnBuilding", ref _UnBuilding, value); }
        }
        bool _Archived;
        public bool Archived
        {
            get { return _Archived; }
            set { SetPropertyValue<bool>("Archived", ref _Archived, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"ITM_BOM_RecipeReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"ITM_BOM_DocumentReferencesITM_BOM_Recipe", typeof(ITM_BOM_Document))]
        public XPCollection<ITM_BOM_Document> ITM_BOM_Documents { get { return GetCollection<ITM_BOM_Document>("ITM_BOM_Documents"); } }
        [Association(@"ITM_BOM_RecipeLineReferencesITM_BOM_Recipe", typeof(ITM_BOM_RecipeLine))]
        public XPCollection<ITM_BOM_RecipeLine> ITM_BOM_RecipeLines { get { return GetCollection<ITM_BOM_RecipeLine>("ITM_BOM_RecipeLines"); } }
    }

}
