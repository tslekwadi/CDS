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
    
    
    public partial class ORG_TRX_Header : INotifyPropertyChanged, IBaseEntity
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
        private long headerId;
        private byte shippingTypeId;
        private long companyId;
        private Nullable<System.DateTime> datePosted;
        private Nullable<System.DateTime> dateFirstPrinted;
        private Nullable<System.DateTime> dateLastPrinted;
        private Nullable<long> firstPrintedBy;
        private Nullable<long> lastPrintedBy;
        private Nullable<System.DateTime> dateValid;
        private string referenceShort1;
        private string referenceShort2;
        private string referenceShort3;
        private string referenceShort4;
        private string referenceShort5;
        private string referenceLong1;
        private string referenceLong2;
        private string referenceLong3;
        private string referenceLong4;
        private string referenceLong5;
        private Nullable<decimal> rounding;
        private string contactPerson;
        private string contactTelephone;
        private string telephone;
        private string vatNumber;
        private string shippingAddressLine1;
        private string shippingAddressLine2;
        private string shippingAddressLine3;
        private string shippingAddressLine4;
        private string shippingAddressCode;
        private string billingAddressLine1;
        private string billingAddressLine2;
        private string billingAddressLine3;
        private string billingAddressLine4;
        private string billingAddressCode;
        private Nullable<decimal> totalCash;
        private Nullable<decimal> totalCredit;
        private Nullable<decimal> totalAccount;
        private Nullable<System.DateTime> createdOn;
        private Nullable<long> createdBy;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public long HeaderId 
    	{ 
    		get { return headerId; }
    		set { SetProperty(ref headerId, value); }
    	 }
        public byte ShippingTypeId 
    	{ 
    		get { return shippingTypeId; }
    		set { SetProperty(ref shippingTypeId, value); }
    	 }
        public long CompanyId 
    	{ 
    		get { return companyId; }
    		set { SetProperty(ref companyId, value); }
    	 }
        public Nullable<System.DateTime> DatePosted 
    	{ 
    		get { return datePosted; }
    		set { SetProperty(ref datePosted, value); }
    	 }
        public Nullable<System.DateTime> DateFirstPrinted 
    	{ 
    		get { return dateFirstPrinted; }
    		set { SetProperty(ref dateFirstPrinted, value); }
    	 }
        public Nullable<System.DateTime> DateLastPrinted 
    	{ 
    		get { return dateLastPrinted; }
    		set { SetProperty(ref dateLastPrinted, value); }
    	 }
        public Nullable<long> FirstPrintedBy 
    	{ 
    		get { return firstPrintedBy; }
    		set { SetProperty(ref firstPrintedBy, value); }
    	 }
        public Nullable<long> LastPrintedBy 
    	{ 
    		get { return lastPrintedBy; }
    		set { SetProperty(ref lastPrintedBy, value); }
    	 }
        public Nullable<System.DateTime> DateValid 
    	{ 
    		get { return dateValid; }
    		set { SetProperty(ref dateValid, value); }
    	 }
        public string ReferenceShort1 
    	{ 
    		get { return referenceShort1; }
    		set { SetProperty(ref referenceShort1, value); }
    	 }
        public string ReferenceShort2 
    	{ 
    		get { return referenceShort2; }
    		set { SetProperty(ref referenceShort2, value); }
    	 }
        public string ReferenceShort3 
    	{ 
    		get { return referenceShort3; }
    		set { SetProperty(ref referenceShort3, value); }
    	 }
        public string ReferenceShort4 
    	{ 
    		get { return referenceShort4; }
    		set { SetProperty(ref referenceShort4, value); }
    	 }
        public string ReferenceShort5 
    	{ 
    		get { return referenceShort5; }
    		set { SetProperty(ref referenceShort5, value); }
    	 }
        public string ReferenceLong1 
    	{ 
    		get { return referenceLong1; }
    		set { SetProperty(ref referenceLong1, value); }
    	 }
        public string ReferenceLong2 
    	{ 
    		get { return referenceLong2; }
    		set { SetProperty(ref referenceLong2, value); }
    	 }
        public string ReferenceLong3 
    	{ 
    		get { return referenceLong3; }
    		set { SetProperty(ref referenceLong3, value); }
    	 }
        public string ReferenceLong4 
    	{ 
    		get { return referenceLong4; }
    		set { SetProperty(ref referenceLong4, value); }
    	 }
        public string ReferenceLong5 
    	{ 
    		get { return referenceLong5; }
    		set { SetProperty(ref referenceLong5, value); }
    	 }
        public Nullable<decimal> Rounding 
    	{ 
    		get { return rounding; }
    		set { SetProperty(ref rounding, value); }
    	 }
        public string ContactPerson 
    	{ 
    		get { return contactPerson; }
    		set { SetProperty(ref contactPerson, value); }
    	 }
        public string ContactTelephone 
    	{ 
    		get { return contactTelephone; }
    		set { SetProperty(ref contactTelephone, value); }
    	 }
        public string Telephone 
    	{ 
    		get { return telephone; }
    		set { SetProperty(ref telephone, value); }
    	 }
        public string VatNumber 
    	{ 
    		get { return vatNumber; }
    		set { SetProperty(ref vatNumber, value); }
    	 }
        public string ShippingAddressLine1 
    	{ 
    		get { return shippingAddressLine1; }
    		set { SetProperty(ref shippingAddressLine1, value); }
    	 }
        public string ShippingAddressLine2 
    	{ 
    		get { return shippingAddressLine2; }
    		set { SetProperty(ref shippingAddressLine2, value); }
    	 }
        public string ShippingAddressLine3 
    	{ 
    		get { return shippingAddressLine3; }
    		set { SetProperty(ref shippingAddressLine3, value); }
    	 }
        public string ShippingAddressLine4 
    	{ 
    		get { return shippingAddressLine4; }
    		set { SetProperty(ref shippingAddressLine4, value); }
    	 }
        public string ShippingAddressCode 
    	{ 
    		get { return shippingAddressCode; }
    		set { SetProperty(ref shippingAddressCode, value); }
    	 }
        public string BillingAddressLine1 
    	{ 
    		get { return billingAddressLine1; }
    		set { SetProperty(ref billingAddressLine1, value); }
    	 }
        public string BillingAddressLine2 
    	{ 
    		get { return billingAddressLine2; }
    		set { SetProperty(ref billingAddressLine2, value); }
    	 }
        public string BillingAddressLine3 
    	{ 
    		get { return billingAddressLine3; }
    		set { SetProperty(ref billingAddressLine3, value); }
    	 }
        public string BillingAddressLine4 
    	{ 
    		get { return billingAddressLine4; }
    		set { SetProperty(ref billingAddressLine4, value); }
    	 }
        public string BillingAddressCode 
    	{ 
    		get { return billingAddressCode; }
    		set { SetProperty(ref billingAddressCode, value); }
    	 }
        public Nullable<decimal> TotalCash 
    	{ 
    		get { return totalCash; }
    		set { SetProperty(ref totalCash, value); }
    	 }
        public Nullable<decimal> TotalCredit 
    	{ 
    		get { return totalCredit; }
    		set { SetProperty(ref totalCredit, value); }
    	 }
        public Nullable<decimal> TotalAccount 
    	{ 
    		get { return totalAccount; }
    		set { SetProperty(ref totalAccount, value); }
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
    
        
    	public virtual ORG_Company ORG_Company { get; set; }
        
    	public virtual ORG_TRX_ShippingType ORG_TRX_ShippingType { get; set; }
    }
}
