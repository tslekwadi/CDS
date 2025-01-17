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

    [Persistent(@"CDS_ORG.ORG_Contact")]
    public partial class ORG_Contact : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        SYS_Entity fCompanyId;
        [Association(@"ORG_ContactReferencesSYS_Entity")]
        public SYS_Entity CompanyId
        {
            get { return fCompanyId; }
            set { SetPropertyValue<SYS_Entity>("CompanyId", ref fCompanyId, value); }
        }
        SYS_Person fPersonId;
        [Association(@"ORG_ContactReferencesSYS_Person")]
        public SYS_Person PersonId
        {
            get { return fPersonId; }
            set { SetPropertyValue<SYS_Person>("PersonId", ref fPersonId, value); }
        }
        CDS.DataAccessLayer.XPO.Enums.ORG_Department fDepartmentId;
        public CDS.DataAccessLayer.XPO.Enums.ORG_Department DepartmentId
        {
            get { return fDepartmentId; }
            set { SetPropertyValue<CDS.DataAccessLayer.XPO.Enums.ORG_Department>("DepartmentId", ref fDepartmentId, value); }
        }
        string fTelephone1;
        [Size(50)]
        public string Telephone1
        {
            get { return fTelephone1; }
            set { SetPropertyValue<string>("Telephone1", ref fTelephone1, value); }
        }
        string fTelephone2;
        [Size(50)]
        public string Telephone2
        {
            get { return fTelephone2; }
            set { SetPropertyValue<string>("Telephone2", ref fTelephone2, value); }
        }
        string fFax;
        [Size(50)]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fEmail;
        [Size(50)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fNote;
        [Size(1000)]
        public string Note
        {
            get { return fNote; }
            set { SetPropertyValue<string>("Note", ref fNote, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"ORG_ContactReferencesSYS_Person1")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
        bool fDefault;
        public bool Default
        {
            get { return fDefault; }
            set { SetPropertyValue<bool>("Default", ref fDefault, value); }
        }
    }

}
