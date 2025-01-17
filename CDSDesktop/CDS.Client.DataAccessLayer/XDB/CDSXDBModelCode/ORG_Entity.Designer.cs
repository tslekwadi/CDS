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

    public partial class ORG_Entity : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        SYS_Entity _EntityId;
        [Association(@"ORG_EntityReferencesSYS_Entity")]
        public SYS_Entity EntityId
        {
            get { return _EntityId; }
            set { SetPropertyValue<SYS_Entity>("EntityId", ref _EntityId, value); }
        }
        string _RegistrationNumber;
        [Size(50)]
        public string RegistrationNumber
        {
            get { return _RegistrationNumber; }
            set { SetPropertyValue<string>("RegistrationNumber", ref _RegistrationNumber, value); }
        }
        string _VatNumber;
        [Size(50)]
        public string VatNumber
        {
            get { return _VatNumber; }
            set { SetPropertyValue<string>("VatNumber", ref _VatNumber, value); }
        }
        string _Note;
        [Size(4000)]
        public string Note
        {
            get { return _Note; }
            set { SetPropertyValue<string>("Note", ref _Note, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"ORG_EntityReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"ORG_CompanyReferencesORG_Entity", typeof(ORG_Company))]
        public XPCollection<ORG_Company> ORG_Companys { get { return GetCollection<ORG_Company>("ORG_Companys"); } }
    }

}
