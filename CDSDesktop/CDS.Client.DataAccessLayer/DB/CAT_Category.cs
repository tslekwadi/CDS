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
    
    
    public partial class CAT_Category : INotifyPropertyChanged, IBaseEntity
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
     
        public CAT_Category()
        {
            this.CAT_Category1 = new List<CAT_Category>();
            this.CAT_ItemData = new List<CAT_ItemData>();
            this.CAT_Meta = new List<CAT_Meta>();
            this.CAT_MetaData = new List<CAT_MetaData>();
        }
    
        private long id;
        private Nullable<long> categoryId;
        private long catalogueId;
        private string name;
        private Nullable<System.DateTime> createdOn;
        private Nullable<long> createdBy;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public Nullable<long> CategoryId 
    	{ 
    		get { return categoryId; }
    		set { SetProperty(ref categoryId, value); }
    	 }
        public long CatalogueId 
    	{ 
    		get { return catalogueId; }
    		set { SetProperty(ref catalogueId, value); }
    	 }
        public string Name 
    	{ 
    		get { return name; }
    		set { SetProperty(ref name, value); }
    	 }
        public Nullable<System.DateTime> CreatedOn 
    	{ 
    		get { return createdOn; }
    		set { SetProperty(ref createdOn, value); }
    	 }
        public Nullable<long> CreatedBy 
    	{ 
    		get { return createdBy; }
    		set { SetProperty(ref createdBy, value); }
    	 }
    
        
    	public virtual CAT_Catalogue CAT_Catalogue { get; set; }
        [System.Xml.Serialization.XmlIgnore]
    	public virtual ICollection<CAT_Category> CAT_Category1 { get; set; }
        
    	public virtual CAT_Category CAT_Category2 { get; set; }
        [System.Xml.Serialization.XmlIgnore]
    	public virtual ICollection<CAT_ItemData> CAT_ItemData { get; set; }
        [System.Xml.Serialization.XmlIgnore]
    	public virtual ICollection<CAT_Meta> CAT_Meta { get; set; }
        [System.Xml.Serialization.XmlIgnore]
    	public virtual ICollection<CAT_MetaData> CAT_MetaData { get; set; }
    }
}