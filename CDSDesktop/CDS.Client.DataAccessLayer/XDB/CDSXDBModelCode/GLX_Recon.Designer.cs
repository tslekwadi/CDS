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

    public partial class GLX_Recon : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        string _Reference;
        [Size(50)]
        public string Reference
        {
            get { return _Reference; }
            set { SetPropertyValue<string>("Reference", ref _Reference, value); }
        }
        string _Description;
        [Size(50)]
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
        decimal _StartAmount;
        public decimal StartAmount
        {
            get { return _StartAmount; }
            set { SetPropertyValue<decimal>("StartAmount", ref _StartAmount, value); }
        }
        decimal _EndAmount;
        public decimal EndAmount
        {
            get { return _EndAmount; }
            set { SetPropertyValue<decimal>("EndAmount", ref _EndAmount, value); }
        }
        SYS_Status _StatusId;
        [Association(@"GLX_ReconReferencesSYS_Status")]
        public SYS_Status StatusId
        {
            get { return _StatusId; }
            set { SetPropertyValue<SYS_Status>("StatusId", ref _StatusId, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"GLX_ReconReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        string _Title;
        [Size(61)]
        public string Title
        {
            get { return _Title; }
            set { SetPropertyValue<string>("Title", ref _Title, value); }
        }
        [Association(@"GLX_LineReferencesGLX_Recon", typeof(GLX_Line))]
        public XPCollection<GLX_Line> GLX_Lines { get { return GetCollection<GLX_Line>("GLX_Lines"); } }
    }

}