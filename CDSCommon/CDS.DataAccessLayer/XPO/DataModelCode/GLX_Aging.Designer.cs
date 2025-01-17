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

    [Persistent(@"CDS_GLX.GLX_Aging")]
    public partial class GLX_Aging : XPLiteObject
    {
        byte fId;
        [Key]
        public byte Id
        {
            get { return fId; }
            set { SetPropertyValue<byte>("Id", ref fId, value); }
        }
        string fCode;
        [Size(50)]
        public string Code
        {
            get { return fCode; }
            set { SetPropertyValue<string>("Code", ref fCode, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fDescription;
        [Size(2000)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fTitle;
        [Size(151)]
        public string Title
        {
            get { return fTitle; }
            set { SetPropertyValue<string>("Title", ref fTitle, value); }
        }
        [Association(@"GLX_HistoryReferencesGLX_Aging", typeof(GLX_History))]
        public XPCollection<GLX_History> GLX_Historys { get { return GetCollection<GLX_History>("GLX_Historys"); } }
        [Association(@"GLX_LineReferencesGLX_Aging", typeof(GLX_Line))]
        public XPCollection<GLX_Line> GLX_Lines { get { return GetCollection<GLX_Line>("GLX_Lines"); } }
    }

}
