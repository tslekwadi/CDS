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

    [Persistent(@"CDS_GLX.GLX_SystemAccountType")]
    public partial class CDS_GLX_GLX_SystemAccountType : XPLiteObject
    {
        int _Id;
        [Key(true)]
        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue<int>("Id", ref _Id, value); }
        }
        string _Name;
        [Size(50)]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>("Name", ref _Name, value); }
        }
        CDS_GLX_GLX_Type _TypeId;
        [Association(@"CDS_GLX_GLX_SystemAccountTypeReferencesCDS_GLX_GLX_Type")]
        public CDS_GLX_GLX_Type TypeId
        {
            get { return _TypeId; }
            set { SetPropertyValue<CDS_GLX_GLX_Type>("TypeId", ref _TypeId, value); }
        }
        [Association(@"CDS_GLX_GLX_SiteAccountReferencesCDS_GLX_GLX_SystemAccountType", typeof(CDS_GLX_GLX_SiteAccount))]
        public XPCollection<CDS_GLX_GLX_SiteAccount> CDS_GLX_GLX_SiteAccounts { get { return GetCollection<CDS_GLX_GLX_SiteAccount>("CDS_GLX_GLX_SiteAccounts"); } }
    }

}