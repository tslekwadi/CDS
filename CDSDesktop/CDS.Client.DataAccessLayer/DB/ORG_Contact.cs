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
    
    
    public partial class ORG_Contact : INotifyPropertyChanged, IBaseEntity
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
     
        private long id;
        private Nullable<long> companyId;
        private long personId;
        private Nullable<byte> departmentId;
        private string telephone1;
        private string telephone2;
        private string fax;
        private string email;
        private string note;
        private Nullable<System.DateTime> createdOn;
        private Nullable<long> createdBy;
        private Nullable<bool> isDefault;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public Nullable<long> CompanyId 
    	{ 
    		get { return companyId; }
    		set { SetProperty(ref companyId, value); }
    	 }
        public long PersonId 
    	{ 
    		get { return personId; }
    		set { SetProperty(ref personId, value); }
    	 }
        public Nullable<byte> DepartmentId 
    	{ 
    		get { return departmentId; }
    		set { SetProperty(ref departmentId, value); }
    	 }
        public string Telephone1 
    	{ 
    		get { return telephone1; }
    		set { SetProperty(ref telephone1, value); }
    	 }
        public string Telephone2 
    	{ 
    		get { return telephone2; }
    		set { SetProperty(ref telephone2, value); }
    	 }
        public string Fax 
    	{ 
    		get { return fax; }
    		set { SetProperty(ref fax, value); }
    	 }
        public string Email 
    	{ 
    		get { return email; }
    		set { SetProperty(ref email, value); }
    	 }
        public string Note 
    	{ 
    		get { return note; }
    		set { SetProperty(ref note, value); }
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
        public Nullable<bool> IsDefault 
    	{ 
    		get { return isDefault; }
    		set { SetProperty(ref isDefault, value); }
    	 }
    
        
    	public virtual ORG_Department ORG_Department { get; set; }
    }
}
