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

    [Persistent(@"CDS_SEC.SEC_User")]
    public partial class CDS_SEC_SEC_User : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Person _PersonId;
        [Association(@"CDS_SEC_SEC_UserReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person PersonId
        {
            get { return _PersonId; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("PersonId", ref _PersonId, value); }
        }
        string _Username;
        [Size(20)]
        public string Username
        {
            get { return _Username; }
            set { SetPropertyValue<string>("Username", ref _Username, value); }
        }
        string _Password;
        [Size(50)]
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValue<string>("Password", ref _Password, value); }
        }
        string _DisplayName;
        [Size(50)]
        public string DisplayName
        {
            get { return _DisplayName; }
            set { SetPropertyValue<string>("DisplayName", ref _DisplayName, value); }
        }
        CDS_SYS_SYS_Printer _DefaultPrinterId;
        [Association(@"CDS_SEC_SEC_UserReferencesCDS_SYS_SYS_Printer")]
        public CDS_SYS_SYS_Printer DefaultPrinterId
        {
            get { return _DefaultPrinterId; }
            set { SetPropertyValue<CDS_SYS_SYS_Printer>("DefaultPrinterId", ref _DefaultPrinterId, value); }
        }
        CDS_SYS_SYS_Entity _DefaultSiteId;
        [Association(@"CDS_SEC_SEC_UserReferencesCDS_SYS_SYS_Entity1")]
        public CDS_SYS_SYS_Entity DefaultSiteId
        {
            get { return _DefaultSiteId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("DefaultSiteId", ref _DefaultSiteId, value); }
        }
        CDS_SYS_SYS_Entity _DefaultCashAccountId;
        [Association(@"CDS_SEC_SEC_UserReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity DefaultCashAccountId
        {
            get { return _DefaultCashAccountId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("DefaultCashAccountId", ref _DefaultCashAccountId, value); }
        }
        DateTime _LastDate;
        public DateTime LastDate
        {
            get { return _LastDate; }
            set { SetPropertyValue<DateTime>("LastDate", ref _LastDate, value); }
        }
        string _LastVersion;
        [Size(50)]
        public string LastVersion
        {
            get { return _LastVersion; }
            set { SetPropertyValue<string>("LastVersion", ref _LastVersion, value); }
        }
        string _LastLocation;
        [Size(200)]
        public string LastLocation
        {
            get { return _LastLocation; }
            set { SetPropertyValue<string>("LastLocation", ref _LastLocation, value); }
        }
        decimal _DiscountLimit;
        public decimal DiscountLimit
        {
            get { return _DiscountLimit; }
            set { SetPropertyValue<decimal>("DiscountLimit", ref _DiscountLimit, value); }
        }
        bool _UseServerPrinting;
        public bool UseServerPrinting
        {
            get { return _UseServerPrinting; }
            set { SetPropertyValue<bool>("UseServerPrinting", ref _UseServerPrinting, value); }
        }
        string _RoleModifiedBy;
        [Size(200)]
        public string RoleModifiedBy
        {
            get { return _RoleModifiedBy; }
            set { SetPropertyValue<string>("RoleModifiedBy", ref _RoleModifiedBy, value); }
        }
        DateTime _RoleModifiedOn;
        public DateTime RoleModifiedOn
        {
            get { return _RoleModifiedOn; }
            set { SetPropertyValue<DateTime>("RoleModifiedOn", ref _RoleModifiedOn, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_SEC_SEC_UserReferencesCDS_SYS_SYS_Person1")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"CDS_SEC_SEC_UserRoleReferencesCDS_SEC_SEC_User", typeof(CDS_SEC_SEC_UserRole))]
        public XPCollection<CDS_SEC_SEC_UserRole> CDS_SEC_SEC_UserRoles { get { return GetCollection<CDS_SEC_SEC_UserRole>("CDS_SEC_SEC_UserRoles"); } }
    }

}