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

    public partial class SYS_Address : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        SYS_Type _TypeId;
        [Association(@"SYS_AddressReferencesSYS_Type")]
        public SYS_Type TypeId
        {
            get { return _TypeId; }
            set { SetPropertyValue<SYS_Type>("TypeId", ref _TypeId, value); }
        }
        string _Line1;
        [Size(50)]
        public string Line1
        {
            get { return _Line1; }
            set { SetPropertyValue<string>("Line1", ref _Line1, value); }
        }
        string _Line2;
        [Size(50)]
        public string Line2
        {
            get { return _Line2; }
            set { SetPropertyValue<string>("Line2", ref _Line2, value); }
        }
        string _Line3;
        [Size(50)]
        public string Line3
        {
            get { return _Line3; }
            set { SetPropertyValue<string>("Line3", ref _Line3, value); }
        }
        string _Line4;
        [Size(50)]
        public string Line4
        {
            get { return _Line4; }
            set { SetPropertyValue<string>("Line4", ref _Line4, value); }
        }
        string _Code;
        [Size(10)]
        public string Code
        {
            get { return _Code; }
            set { SetPropertyValue<string>("Code", ref _Code, value); }
        }
        string _Title;
        [Size(163)]
        public string Title
        {
            get { return _Title; }
            set { SetPropertyValue<string>("Title", ref _Title, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"SYS_AddressReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"ORG_CompanyAddressReferencesSYS_Address", typeof(ORG_CompanyAddress))]
        public XPCollection<ORG_CompanyAddress> ORG_CompanyAddresss { get { return GetCollection<ORG_CompanyAddress>("ORG_CompanyAddresss"); } }
        [Association(@"SYS_SiteReferencesSYS_Address", typeof(SYS_Site))]
        public XPCollection<SYS_Site> SYS_Sites { get { return GetCollection<SYS_Site>("SYS_Sites"); } }
        [Association(@"SYS_SiteReferencesSYS_Address1", typeof(SYS_Site))]
        public XPCollection<SYS_Site> SYS_Sites1 { get { return GetCollection<SYS_Site>("SYS_Sites1"); } }
    }

}