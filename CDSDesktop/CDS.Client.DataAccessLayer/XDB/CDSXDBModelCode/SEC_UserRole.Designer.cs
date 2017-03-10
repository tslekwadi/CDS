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

    public partial class SEC_UserRole : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        SEC_User _UserId;
        [Association(@"SEC_UserRoleReferencesSEC_User")]
        public SEC_User UserId
        {
            get { return _UserId; }
            set { SetPropertyValue<SEC_User>("UserId", ref _UserId, value); }
        }
        SEC_Role _RoleId;
        [Association(@"SEC_UserRoleReferencesSEC_Role")]
        public SEC_Role RoleId
        {
            get { return _RoleId; }
            set { SetPropertyValue<SEC_Role>("RoleId", ref _RoleId, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"SEC_UserRoleReferencesSYS_Person")]
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
    }

}