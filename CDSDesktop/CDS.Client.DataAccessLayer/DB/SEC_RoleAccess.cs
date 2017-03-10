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
    
    
    public partial class SEC_RoleAccess : INotifyPropertyChanged, IBaseEntity
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
        private long roleId;
        private long accessId;
        private Nullable<System.DateTime> createdOn;
        private Nullable<long> createdBy;
        private Nullable<System.DateTime> modifiedOn;
        private string modifiedBy;
        private Nullable<System.DateTime> securityModifiedOn;
        private string securityModifiedBy;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public long RoleId 
    	{ 
    		get { return roleId; }
    		set { SetProperty(ref roleId, value); }
    	 }
        public long AccessId 
    	{ 
    		get { return accessId; }
    		set { SetProperty(ref accessId, value); }
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
        public Nullable<System.DateTime> ModifiedOn 
    	{ 
    		get { return modifiedOn; }
    		set { SetProperty(ref modifiedOn, value); }
    	 }
        public string ModifiedBy 
    	{ 
    		get { return modifiedBy; }
    		set { SetProperty(ref modifiedBy, value); }
    	 }
        public Nullable<System.DateTime> SecurityModifiedOn 
    	{ 
    		get { return securityModifiedOn; }
    		set { SetProperty(ref securityModifiedOn, value); }
    	 }
        public string SecurityModifiedBy 
    	{ 
    		get { return securityModifiedBy; }
    		set { SetProperty(ref securityModifiedBy, value); }
    	 }
    
        
    	public virtual SEC_Access SEC_Access { get; set; }
        
    	public virtual SEC_Role SEC_Role { get; set; }
    }
}