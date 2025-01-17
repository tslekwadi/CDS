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

    [Persistent(@"CDS_SEC.SEC_Role")]
    public partial class SEC_Role : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        string fCode;
        [Size(50)]
        public string Code
        {
            get { return fCode; }
            set { SetPropertyValue<string>("Code", ref fCode, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fDescription;
        [Size(2000)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"SEC_RoleReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
        [Association(@"SEC_RoleAccessReferencesSEC_Role", typeof(SEC_RoleAccess))]
        public XPCollection<SEC_RoleAccess> SEC_RoleAccesss { get { return GetCollection<SEC_RoleAccess>("SEC_RoleAccesss"); } }
        [Association(@"SEC_UserRoleReferencesSEC_Role", typeof(SEC_UserRole))]
        public XPCollection<SEC_UserRole> SEC_UserRoles { get { return GetCollection<SEC_UserRole>("SEC_UserRoles"); } }
    }

}
