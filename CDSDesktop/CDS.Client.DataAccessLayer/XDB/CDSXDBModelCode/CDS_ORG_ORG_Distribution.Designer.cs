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

    [Persistent(@"CDS_ORG.ORG_Distribution")]
    public partial class CDS_ORG_ORG_Distribution : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_ORG_ORG_Company _EntityId;
        [Association(@"CDS_ORG_ORG_DistributionReferencesCDS_ORG_ORG_Company")]
        public CDS_ORG_ORG_Company EntityId
        {
            get { return _EntityId; }
            set { SetPropertyValue<CDS_ORG_ORG_Company>("EntityId", ref _EntityId, value); }
        }
        CDS_ORG_ORG_DistributionType _DistributionTypeId;
        [Association(@"CDS_ORG_ORG_DistributionReferencesCDS_ORG_ORG_DistributionType")]
        public CDS_ORG_ORG_DistributionType DistributionTypeId
        {
            get { return _DistributionTypeId; }
            set { SetPropertyValue<CDS_ORG_ORG_DistributionType>("DistributionTypeId", ref _DistributionTypeId, value); }
        }
        string _DistributionNumber;
        [Size(50)]
        public string DistributionNumber
        {
            get { return _DistributionNumber; }
            set { SetPropertyValue<string>("DistributionNumber", ref _DistributionNumber, value); }
        }
        string _Path;
        [Size(50)]
        public string Path
        {
            get { return _Path; }
            set { SetPropertyValue<string>("Path", ref _Path, value); }
        }
        int _InventoryViewLevel;
        public int InventoryViewLevel
        {
            get { return _InventoryViewLevel; }
            set { SetPropertyValue<int>("InventoryViewLevel", ref _InventoryViewLevel, value); }
        }
        string _TeccomHeader;
        [Size(200)]
        public string TeccomHeader
        {
            get { return _TeccomHeader; }
            set { SetPropertyValue<string>("TeccomHeader", ref _TeccomHeader, value); }
        }
        string _CustomerCode;
        [Size(200)]
        public string CustomerCode
        {
            get { return _CustomerCode; }
            set { SetPropertyValue<string>("CustomerCode", ref _CustomerCode, value); }
        }
        string _SupplierCode;
        [Size(200)]
        public string SupplierCode
        {
            get { return _SupplierCode; }
            set { SetPropertyValue<string>("SupplierCode", ref _SupplierCode, value); }
        }
        bool _ViewCost;
        public bool ViewCost
        {
            get { return _ViewCost; }
            set { SetPropertyValue<bool>("ViewCost", ref _ViewCost, value); }
        }
        string _Url;
        [Size(250)]
        public string Url
        {
            get { return _Url; }
            set { SetPropertyValue<string>("Url", ref _Url, value); }
        }
        string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { SetPropertyValue<string>("UserName", ref _UserName, value); }
        }
        string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValue<string>("Password", ref _Password, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_ORG_ORG_DistributionReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
    }

}
