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

    [Persistent(@"CDS_SYS.SYS_MSG_Message")]
    public partial class CDS_SYS_SYS_MSG_Message : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Person _FromId;
        [Association(@"CDS_SYS_SYS_MSG_MessageReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person FromId
        {
            get { return _FromId; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("FromId", ref _FromId, value); }
        }
        CDS_SYS_SYS_Person _ToId;
        [Association(@"CDS_SYS_SYS_MSG_MessageReferencesCDS_SYS_SYS_Person1")]
        public CDS_SYS_SYS_Person ToId
        {
            get { return _ToId; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("ToId", ref _ToId, value); }
        }
        bool _Sent;
        public bool Sent
        {
            get { return _Sent; }
            set { SetPropertyValue<bool>("Sent", ref _Sent, value); }
        }
        bool _Received;
        public bool Received
        {
            get { return _Received; }
            set { SetPropertyValue<bool>("Received", ref _Received, value); }
        }
        DateTime _SentOn;
        public DateTime SentOn
        {
            get { return _SentOn; }
            set { SetPropertyValue<DateTime>("SentOn", ref _SentOn, value); }
        }
        DateTime _ReceivedOn;
        public DateTime ReceivedOn
        {
            get { return _ReceivedOn; }
            set { SetPropertyValue<DateTime>("ReceivedOn", ref _ReceivedOn, value); }
        }
        string _Message;
        [Size(1000)]
        public string Message
        {
            get { return _Message; }
            set { SetPropertyValue<string>("Message", ref _Message, value); }
        }
    }

}
