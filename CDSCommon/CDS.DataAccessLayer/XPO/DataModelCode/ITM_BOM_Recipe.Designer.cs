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

    [Persistent(@"CDS_ITM.ITM_BOM_Recipe")]
    public partial class ITM_BOM_Recipe : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        SYS_Entity fItemResultId;
        [Association(@"ITM_BOM_RecipeReferencesSYS_Entity")]
        public SYS_Entity ItemResultId
        {
            get { return fItemResultId; }
            set { SetPropertyValue<SYS_Entity>("ItemResultId", ref fItemResultId, value); }
        }
        string fDescription;
        [Size(1000)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        decimal fQuantityResult;
        public decimal QuantityResult
        {
            get { return fQuantityResult; }
            set { SetPropertyValue<decimal>("QuantityResult", ref fQuantityResult, value); }
        }
        decimal fBuilding;
        public decimal Building
        {
            get { return fBuilding; }
            set { SetPropertyValue<decimal>("Building", ref fBuilding, value); }
        }
        decimal fUnBuilding;
        public decimal UnBuilding
        {
            get { return fUnBuilding; }
            set { SetPropertyValue<decimal>("UnBuilding", ref fUnBuilding, value); }
        }
        bool fArchived;
        public bool Archived
        {
            get { return fArchived; }
            set { SetPropertyValue<bool>("Archived", ref fArchived, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"ITM_BOM_RecipeReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
        [Association(@"ITM_BOM_DocumentReferencesITM_BOM_Recipe", typeof(ITM_BOM_Document))]
        public XPCollection<ITM_BOM_Document> ITM_BOM_Documents { get { return GetCollection<ITM_BOM_Document>("ITM_BOM_Documents"); } }
        [Association(@"ITM_BOM_RecipeLineReferencesITM_BOM_Recipe", typeof(ITM_BOM_RecipeLine))]
        public XPCollection<ITM_BOM_RecipeLine> ITM_BOM_RecipeLines { get { return GetCollection<ITM_BOM_RecipeLine>("ITM_BOM_RecipeLines"); } }
    }

}
