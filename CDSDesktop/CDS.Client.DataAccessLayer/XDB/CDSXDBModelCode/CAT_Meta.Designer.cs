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

    public partial class CAT_Meta : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>("Name", ref _Name, value); }
        }
        string _Grouping;
        public string Grouping
        {
            get { return _Grouping; }
            set { SetPropertyValue<string>("Grouping", ref _Grouping, value); }
        }
        CAT_Category _CategoryId;
        [Association(@"CAT_MetaReferencesCAT_Category")]
        public CAT_Category CategoryId
        {
            get { return _CategoryId; }
            set { SetPropertyValue<CAT_Category>("CategoryId", ref _CategoryId, value); }
        }
        string _Type;
        public string Type
        {
            get { return _Type; }
            set { SetPropertyValue<string>("Type", ref _Type, value); }
        }
        bool _Grouped;
        public bool Grouped
        {
            get { return _Grouped; }
            set { SetPropertyValue<bool>("Grouped", ref _Grouped, value); }
        }
        int _SortOrder;
        public int SortOrder
        {
            get { return _SortOrder; }
            set { SetPropertyValue<int>("SortOrder", ref _SortOrder, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"CAT_MetaReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        [Association(@"CAT_MetaDataReferencesCAT_Meta", typeof(CAT_MetaData))]
        public XPCollection<CAT_MetaData> CAT_MetaDatas { get { return GetCollection<CAT_MetaData>("CAT_MetaDatas"); } }
    }

}