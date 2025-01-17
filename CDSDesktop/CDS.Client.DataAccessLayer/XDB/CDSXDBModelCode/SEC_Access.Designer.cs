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

    public partial class SEC_Access : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        string _Code;
        [Size(50)]
        public string Code
        {
            get { return _Code; }
            set { SetPropertyValue<string>("Code", ref _Code, value); }
        }
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>("Name", ref _Name, value); }
        }
        string _Description;
        [Size(2000)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        SEC_Access _ParentId;
        [Association(@"SEC_AccessReferencesSEC_Access")]
        public SEC_Access ParentId
        {
            get { return _ParentId; }
            set { SetPropertyValue<SEC_Access>("ParentId", ref _ParentId, value); }
        }
        string _CustomValue1;
        [Size(50)]
        public string CustomValue1
        {
            get { return _CustomValue1; }
            set { SetPropertyValue<string>("CustomValue1", ref _CustomValue1, value); }
        }
        string _CustomValue2;
        [Size(50)]
        public string CustomValue2
        {
            get { return _CustomValue2; }
            set { SetPropertyValue<string>("CustomValue2", ref _CustomValue2, value); }
        }
        string _CustomValue3;
        [Size(50)]
        public string CustomValue3
        {
            get { return _CustomValue3; }
            set { SetPropertyValue<string>("CustomValue3", ref _CustomValue3, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"SEC_AccessReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        DateTime _ModifiedOn;
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { SetPropertyValue<DateTime>("ModifiedOn", ref _ModifiedOn, value); }
        }
        string _ModifiedBy;
        [Size(50)]
        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set { SetPropertyValue<string>("ModifiedBy", ref _ModifiedBy, value); }
        }
        [Association(@"SEC_RoleAccessReferencesSEC_Access", typeof(SEC_RoleAccess))]
        public XPCollection<SEC_RoleAccess> SEC_RoleAccesss { get { return GetCollection<SEC_RoleAccess>("SEC_RoleAccesss"); } }
        [Association(@"SEC_AccessReferencesSEC_Access", typeof(SEC_Access))]
        public XPCollection<SEC_Access> SEC_AccessCollection { get { return GetCollection<SEC_Access>("SEC_AccessCollection"); } }
    }

}
