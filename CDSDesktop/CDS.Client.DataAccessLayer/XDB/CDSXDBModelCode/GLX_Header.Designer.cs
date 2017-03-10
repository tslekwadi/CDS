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

    public partial class GLX_Header : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        SYS_Period _PeriodId;
        [Association(@"GLX_HeaderReferencesSYS_Period")]
        public SYS_Period PeriodId
        {
            get { return _PeriodId; }
            set { SetPropertyValue<SYS_Period>("PeriodId", ref _PeriodId, value); }
        }
        SYS_Status _StatusId;
        [Association(@"GLX_HeaderReferencesSYS_Status")]
        public SYS_Status StatusId
        {
            get { return _StatusId; }
            set { SetPropertyValue<SYS_Status>("StatusId", ref _StatusId, value); }
        }
        SYS_Tracking _TrackId;
        [Association(@"GLX_HeaderReferencesSYS_Tracking")]
        public SYS_Tracking TrackId
        {
            get { return _TrackId; }
            set { SetPropertyValue<SYS_Tracking>("TrackId", ref _TrackId, value); }
        }
        GLX_JournalType _JournalTypeId;
        [Association(@"GLX_HeaderReferencesGLX_JournalType")]
        public GLX_JournalType JournalTypeId
        {
            get { return _JournalTypeId; }
            set { SetPropertyValue<GLX_JournalType>("JournalTypeId", ref _JournalTypeId, value); }
        }
        string _Reference;
        [Size(50)]
        public string Reference
        {
            get { return _Reference; }
            set { SetPropertyValue<string>("Reference", ref _Reference, value); }
        }
        string _Description;
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValue<DateTime>("Date", ref _Date, value); }
        }
        DateTime _PostedDate;
        public DateTime PostedDate
        {
            get { return _PostedDate; }
            set { SetPropertyValue<DateTime>("PostedDate", ref _PostedDate, value); }
        }
        string _Title;
        [Size(151)]
        public string Title
        {
            get { return _Title; }
            set { SetPropertyValue<string>("Title", ref _Title, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"GLX_HeaderReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        long _ReferenceId;
        public long ReferenceId
        {
            get { return _ReferenceId; }
            set { SetPropertyValue<long>("ReferenceId", ref _ReferenceId, value); }
        }
        [Association(@"GLX_LineReferencesGLX_Header", typeof(GLX_Line))]
        public XPCollection<GLX_Line> GLX_Lines { get { return GetCollection<GLX_Line>("GLX_Lines"); } }
    }

}