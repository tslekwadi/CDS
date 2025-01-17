//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDS.Client.DataAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    
    public partial class AOR_Order : INotifyPropertyChanged, IBaseEntity
    { 
    	bool hasChanges = false;
        public bool HasChanges
        {
        	get
        	{
                return hasChanges;
        	}
        	set
        	{
                if (hasChanges != value)
                    hasChanges = value;
        	}
        } 
    	
    	bool ignoreChanges = false;
        public bool IgnoreChanges
        {
            get
            {
                
                
                return ignoreChanges;
            }
            set
            {
                if (ignoreChanges != value)
                {
                    ignoreChanges = value;
                }
            }
        }
    
    	List<string> changeList = new List<string>();
    	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public List<string> ChangeList
        {
            get
            { 
                return changeList;
            }
            set
            {
                if (changeList != value)
                {
                    changeList = value;
                }
            }
        } 
    
    	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged; 
    	private void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string name = "")
    	{
    		if (!EqualityComparer<T>.Default.Equals(field, value))
    		{
    			field = value;
    			//ChangeSet.Add(LogEntry.New<T>(field.ToString(),this.ToString(), this.Id,  field,  value ));
    			var handler = PropertyChanged;
    			if (handler != null)
    			{
    				if(!name.StartsWith("Id") && name != "Title" && name != "CreatedOn" && !IgnoreChanges)  
    				{
    					HasChanges = true;
    					ChangeList.Add(name);
    				}
    
    				handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
    			}
    		}
    	} 
     
        public AOR_Order()
        {
            this.AOR_OrderLine = new List<AOR_OrderLine>();
        }
    
        private long id;
        private Nullable<long> supplierId;
        private byte statusId;
        private Nullable<System.DateTime> startDate;
        private Nullable<System.DateTime> orderDate;
        private string filter;
        private Nullable<byte> monthWeight3;
        private Nullable<byte> monthWeight6;
        private Nullable<byte> monthWeight12;
        private Nullable<byte> monthWeight24;
        private Nullable<byte> monthWeight36;
        private int lastChangedLine;
        private long createdBy;
        private Nullable<System.DateTime> createdOn;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public Nullable<long> SupplierId 
    	{ 
    		get { return supplierId; }
    		set { SetProperty(ref supplierId, value); }
    	 }
        public byte StatusId 
    	{ 
    		get { return statusId; }
    		set { SetProperty(ref statusId, value); }
    	 }
        public Nullable<System.DateTime> StartDate 
    	{ 
    		get { return startDate; }
    		set { SetProperty(ref startDate, value); }
    	 }
        public Nullable<System.DateTime> OrderDate 
    	{ 
    		get { return orderDate; }
    		set { SetProperty(ref orderDate, value); }
    	 }
        public string Filter 
    	{ 
    		get { return filter; }
    		set { SetProperty(ref filter, value); }
    	 }
        public Nullable<byte> MonthWeight3 
    	{ 
    		get { return monthWeight3; }
    		set { SetProperty(ref monthWeight3, value); }
    	 }
        public Nullable<byte> MonthWeight6 
    	{ 
    		get { return monthWeight6; }
    		set { SetProperty(ref monthWeight6, value); }
    	 }
        public Nullable<byte> MonthWeight12 
    	{ 
    		get { return monthWeight12; }
    		set { SetProperty(ref monthWeight12, value); }
    	 }
        public Nullable<byte> MonthWeight24 
    	{ 
    		get { return monthWeight24; }
    		set { SetProperty(ref monthWeight24, value); }
    	 }
        public Nullable<byte> MonthWeight36 
    	{ 
    		get { return monthWeight36; }
    		set { SetProperty(ref monthWeight36, value); }
    	 }
        public int LastChangedLine 
    	{ 
    		get { return lastChangedLine; }
    		set { SetProperty(ref lastChangedLine, value); }
    	 }
        public long CreatedBy 
    	{ 
    		get { return createdBy; }
    		set { SetProperty(ref createdBy, value); }
    	 }
        public Nullable<System.DateTime> CreatedOn 
    	{ 
    		get { return createdOn; }
    		set { SetProperty(ref createdOn, value); }
    	 }
    
        [System.Xml.Serialization.XmlIgnore]
    	public virtual ICollection<AOR_OrderLine> AOR_OrderLine { get; set; }
    }
}
