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

    [Persistent(@"CDS_CAL.CAL_Calendar")]
    public partial class CDS_CAL_CAL_Calendar : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        short _LabelId;
        public short LabelId
        {
            get { return _LabelId; }
            set { SetPropertyValue<short>("LabelId", ref _LabelId, value); }
        }
        string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set { SetPropertyValue<string>("Subject", ref _Subject, value); }
        }
        string _Description;
        [Size(200)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        DateTime _StartDate;
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { SetPropertyValue<DateTime>("StartDate", ref _StartDate, value); }
        }
        DateTime _EndDate;
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { SetPropertyValue<DateTime>("EndDate", ref _EndDate, value); }
        }
        bool _AllDay;
        public bool AllDay
        {
            get { return _AllDay; }
            set { SetPropertyValue<bool>("AllDay", ref _AllDay, value); }
        }
        string _Location;
        public string Location
        {
            get { return _Location; }
            set { SetPropertyValue<string>("Location", ref _Location, value); }
        }
        decimal _PercentComplete;
        public decimal PercentComplete
        {
            get { return _PercentComplete; }
            set { SetPropertyValue<decimal>("PercentComplete", ref _PercentComplete, value); }
        }
        string _RecurrenceInfo;
        [Size(SizeAttribute.Unlimited)]
        public string RecurrenceInfo
        {
            get { return _RecurrenceInfo; }
            set { SetPropertyValue<string>("RecurrenceInfo", ref _RecurrenceInfo, value); }
        }
        string _ReminderInfo;
        [Size(SizeAttribute.Unlimited)]
        public string ReminderInfo
        {
            get { return _ReminderInfo; }
            set { SetPropertyValue<string>("ReminderInfo", ref _ReminderInfo, value); }
        }
        long _ResourceId;
        public long ResourceId
        {
            get { return _ResourceId; }
            set { SetPropertyValue<long>("ResourceId", ref _ResourceId, value); }
        }
        short _StatusId;
        public short StatusId
        {
            get { return _StatusId; }
            set { SetPropertyValue<short>("StatusId", ref _StatusId, value); }
        }
        short _TypeId;
        public short TypeId
        {
            get { return _TypeId; }
            set { SetPropertyValue<short>("TypeId", ref _TypeId, value); }
        }
        CDS_SYS_SYS_DOC_Header _DocumentId;
        [Association(@"CDS_CAL_CAL_CalendarReferencesCDS_SYS_SYS_DOC_Header")]
        public CDS_SYS_SYS_DOC_Header DocumentId
        {
            get { return _DocumentId; }
            set { SetPropertyValue<CDS_SYS_SYS_DOC_Header>("DocumentId", ref _DocumentId, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_CAL_CAL_CalendarReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        string _Vehicle;
        [Size(50)]
        public string Vehicle
        {
            get { return _Vehicle; }
            set { SetPropertyValue<string>("Vehicle", ref _Vehicle, value); }
        }
        string _Registration;
        [Size(50)]
        public string Registration
        {
            get { return _Registration; }
            set { SetPropertyValue<string>("Registration", ref _Registration, value); }
        }
        string _Mileage;
        [Size(50)]
        public string Mileage
        {
            get { return _Mileage; }
            set { SetPropertyValue<string>("Mileage", ref _Mileage, value); }
        }
        string _Contact;
        [Size(50)]
        public string Contact
        {
            get { return _Contact; }
            set { SetPropertyValue<string>("Contact", ref _Contact, value); }
        }
        string _Telephone;
        [Size(50)]
        public string Telephone
        {
            get { return _Telephone; }
            set { SetPropertyValue<string>("Telephone", ref _Telephone, value); }
        }
        CDS_SYS_SYS_Entity _EntityId;
        [Association(@"CDS_CAL_CAL_CalendarReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity EntityId
        {
            get { return _EntityId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("EntityId", ref _EntityId, value); }
        }
        [Association(@"CDS_CAL_CAL_AttachmentReferencesCDS_CAL_CAL_Calendar", typeof(CDS_CAL_CAL_Attachment))]
        public XPCollection<CDS_CAL_CAL_Attachment> CDS_CAL_CAL_Attachments { get { return GetCollection<CDS_CAL_CAL_Attachment>("CDS_CAL_CAL_Attachments"); } }
    }

}
