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

    [Persistent(@"CDS_ITM.ITM_Surcharge")]
    public partial class CDS_ITM_ITM_Surcharge : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Entity _EntityId;
        [Association(@"CDS_ITM_ITM_SurchargeReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity EntityId
        {
            get { return _EntityId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("EntityId", ref _EntityId, value); }
        }
        CDS_SYS_SYS_Entity _SurchargeId;
        [Association(@"CDS_ITM_ITM_SurchargeReferencesCDS_SYS_SYS_Entity1")]
        public CDS_SYS_SYS_Entity SurchargeId
        {
            get { return _SurchargeId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("SurchargeId", ref _SurchargeId, value); }
        }
    }

}
