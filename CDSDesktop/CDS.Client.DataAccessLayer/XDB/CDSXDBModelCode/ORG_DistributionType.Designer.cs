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

    public partial class ORG_DistributionType : XPLiteObject
    {
        short _Id;
        [Key]
        public short Id
        {
            get { return _Id; }
            set { SetPropertyValue<short>("Id", ref _Id, value); }
        }
        string _Name;
        [Size(50)]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>("Name", ref _Name, value); }
        }
        [Association(@"ORG_DistributionReferencesORG_DistributionType", typeof(ORG_Distribution))]
        public XPCollection<ORG_Distribution> ORG_Distributions { get { return GetCollection<ORG_Distribution>("ORG_Distributions"); } }
    }

}
