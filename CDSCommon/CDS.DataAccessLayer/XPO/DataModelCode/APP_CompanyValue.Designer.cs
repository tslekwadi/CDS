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

    [Persistent(@"CDS_APP.APP_CompanyValue")]
    public partial class APP_CompanyValue : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        SYS_Entity fApplicationId;
        [Association(@"APP_CompanyValueReferencesSYS_Entity_ApplicationId")]
        public SYS_Entity ApplicationId
        {
            get { return fApplicationId; }
            set { SetPropertyValue<SYS_Entity>("ApplicationId", ref fApplicationId, value); }
        }
        SYS_Entity fEntityId;
        [Association(@"APP_CompanyValueReferencesSYS_Entity_EntityId")]
        public SYS_Entity EntityId
        {
            get { return fEntityId; }
            set { SetPropertyValue<SYS_Entity>("EntityId", ref fEntityId, value); }
        }
        APP_Attribute fAttributeId;
        [Association(@"APP_CompanyValueReferencesAPP_Attribute")]
        public APP_Attribute AttributeId
        {
            get { return fAttributeId; }
            set { SetPropertyValue<APP_Attribute>("AttributeId", ref fAttributeId, value); }
        }
        string fValue;
        [Size(500)]
        public string Value
        {
            get { return fValue; }
            set { SetPropertyValue<string>("Value", ref fValue, value); }
        }
    }

}
