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

    [Persistent(@"CDS_ORG.ORG_Distribution")]
    public partial class ORG_Distribution : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        ORG_Company fEntityId;
        [Association(@"ORG_DistributionReferencesORG_Company")]
        public ORG_Company EntityId
        {
            get { return fEntityId; }
            set { SetPropertyValue<ORG_Company>("EntityId", ref fEntityId, value); }
        }
        CDS.DataAccessLayer.XPO.Enums.ORG_DistributionType fDistributionTypeId;
        public CDS.DataAccessLayer.XPO.Enums.ORG_DistributionType DistributionTypeId
        {
            get { return fDistributionTypeId; }
            set { SetPropertyValue<CDS.DataAccessLayer.XPO.Enums.ORG_DistributionType>("DistributionTypeId", ref fDistributionTypeId, value); }
        }
        string fDistributionNumber;
        [Size(50)]
        public string DistributionNumber
        {
            get { return fDistributionNumber; }
            set { SetPropertyValue<string>("DistributionNumber", ref fDistributionNumber, value); }
        }
        string fPath;
        [Size(50)]
        public string Path
        {
            get { return fPath; }
            set { SetPropertyValue<string>("Path", ref fPath, value); }
        }
        int fInventoryViewLevel;
        public int InventoryViewLevel
        {
            get { return fInventoryViewLevel; }
            set { SetPropertyValue<int>("InventoryViewLevel", ref fInventoryViewLevel, value); }
        }
        string fTeccomHeader;
        [Size(200)]
        public string TeccomHeader
        {
            get { return fTeccomHeader; }
            set { SetPropertyValue<string>("TeccomHeader", ref fTeccomHeader, value); }
        }
        string fCustomerCode;
        [Size(200)]
        public string CustomerCode
        {
            get { return fCustomerCode; }
            set { SetPropertyValue<string>("CustomerCode", ref fCustomerCode, value); }
        }
        string fSupplierCode;
        [Size(200)]
        public string SupplierCode
        {
            get { return fSupplierCode; }
            set { SetPropertyValue<string>("SupplierCode", ref fSupplierCode, value); }
        }
        bool fViewCost;
        public bool ViewCost
        {
            get { return fViewCost; }
            set { SetPropertyValue<bool>("ViewCost", ref fViewCost, value); }
        }
        string fUrl;
        [Size(250)]
        public string Url
        {
            get { return fUrl; }
            set { SetPropertyValue<string>("Url", ref fUrl, value); }
        }
        string fUserName;
        public string UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<string>("UserName", ref fUserName, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>("Password", ref fPassword, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"ORG_DistributionReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
    }

}
