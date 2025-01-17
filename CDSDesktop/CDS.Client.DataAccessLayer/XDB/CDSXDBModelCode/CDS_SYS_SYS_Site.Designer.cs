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

    [Persistent(@"CDS_SYS.SYS_Site")]
    public partial class CDS_SYS_SYS_Site : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Entity _EntityId;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity EntityId
        {
            get { return _EntityId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("EntityId", ref _EntityId, value); }
        }
        CDS_SYS_SYS_Address _BillingAddress;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Address")]
        public CDS_SYS_SYS_Address BillingAddress
        {
            get { return _BillingAddress; }
            set { SetPropertyValue<CDS_SYS_SYS_Address>("BillingAddress", ref _BillingAddress, value); }
        }
        CDS_SYS_SYS_Address _ShippingAddress;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Address1")]
        public CDS_SYS_SYS_Address ShippingAddress
        {
            get { return _ShippingAddress; }
            set { SetPropertyValue<CDS_SYS_SYS_Address>("ShippingAddress", ref _ShippingAddress, value); }
        }
        string _Telephone;
        [Size(50)]
        public string Telephone
        {
            get { return _Telephone; }
            set { SetPropertyValue<string>("Telephone", ref _Telephone, value); }
        }
        string _EmailAddress;
        [Size(50)]
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { SetPropertyValue<string>("EmailAddress", ref _EmailAddress, value); }
        }
        string _RegistrationNumber;
        [Size(50)]
        public string RegistrationNumber
        {
            get { return _RegistrationNumber; }
            set { SetPropertyValue<string>("RegistrationNumber", ref _RegistrationNumber, value); }
        }
        decimal _VatPercentage;
        public decimal VatPercentage
        {
            get { return _VatPercentage; }
            set { SetPropertyValue<decimal>("VatPercentage", ref _VatPercentage, value); }
        }
        string _VatNumber;
        [Size(50)]
        public string VatNumber
        {
            get { return _VatNumber; }
            set { SetPropertyValue<string>("VatNumber", ref _VatNumber, value); }
        }
        string _Currency;
        [Size(50)]
        public string Currency
        {
            get { return _Currency; }
            set { SetPropertyValue<string>("Currency", ref _Currency, value); }
        }
        short _CashierRefreshIntervals;
        public short CashierRefreshIntervals
        {
            get { return _CashierRefreshIntervals; }
            set { SetPropertyValue<short>("CashierRefreshIntervals", ref _CashierRefreshIntervals, value); }
        }
        string _SMTPServerLocation;
        [Size(50)]
        public string SMTPServerLocation
        {
            get { return _SMTPServerLocation; }
            set { SetPropertyValue<string>("SMTPServerLocation", ref _SMTPServerLocation, value); }
        }
        string _AccountEmailAddress;
        [Size(50)]
        public string AccountEmailAddress
        {
            get { return _AccountEmailAddress; }
            set { SetPropertyValue<string>("AccountEmailAddress", ref _AccountEmailAddress, value); }
        }
        string _AccountEmailUsername;
        [Size(50)]
        public string AccountEmailUsername
        {
            get { return _AccountEmailUsername; }
            set { SetPropertyValue<string>("AccountEmailUsername", ref _AccountEmailUsername, value); }
        }
        string _AccountEmailPassword;
        [Size(50)]
        public string AccountEmailPassword
        {
            get { return _AccountEmailPassword; }
            set { SetPropertyValue<string>("AccountEmailPassword", ref _AccountEmailPassword, value); }
        }
        string _AccountEmailDomain;
        [Size(50)]
        public string AccountEmailDomain
        {
            get { return _AccountEmailDomain; }
            set { SetPropertyValue<string>("AccountEmailDomain", ref _AccountEmailDomain, value); }
        }
        string _AccountEmailBCCAddress;
        [Size(50)]
        public string AccountEmailBCCAddress
        {
            get { return _AccountEmailBCCAddress; }
            set { SetPropertyValue<string>("AccountEmailBCCAddress", ref _AccountEmailBCCAddress, value); }
        }
        string _DocumentEmailAddress;
        [Size(50)]
        public string DocumentEmailAddress
        {
            get { return _DocumentEmailAddress; }
            set { SetPropertyValue<string>("DocumentEmailAddress", ref _DocumentEmailAddress, value); }
        }
        string _DocumentEmailUsername;
        [Size(50)]
        public string DocumentEmailUsername
        {
            get { return _DocumentEmailUsername; }
            set { SetPropertyValue<string>("DocumentEmailUsername", ref _DocumentEmailUsername, value); }
        }
        string _DocumentEmailPassword;
        [Size(50)]
        public string DocumentEmailPassword
        {
            get { return _DocumentEmailPassword; }
            set { SetPropertyValue<string>("DocumentEmailPassword", ref _DocumentEmailPassword, value); }
        }
        string _DocumentEmailDomain;
        [Size(50)]
        public string DocumentEmailDomain
        {
            get { return _DocumentEmailDomain; }
            set { SetPropertyValue<string>("DocumentEmailDomain", ref _DocumentEmailDomain, value); }
        }
        string _DocumentEmailBCCAddress;
        [Size(50)]
        public string DocumentEmailBCCAddress
        {
            get { return _DocumentEmailBCCAddress; }
            set { SetPropertyValue<string>("DocumentEmailBCCAddress", ref _DocumentEmailBCCAddress, value); }
        }
        string _ProxyServerLocation;
        [Size(50)]
        public string ProxyServerLocation
        {
            get { return _ProxyServerLocation; }
            set { SetPropertyValue<string>("ProxyServerLocation", ref _ProxyServerLocation, value); }
        }
        string _ProxyServerUsername;
        [Size(50)]
        public string ProxyServerUsername
        {
            get { return _ProxyServerUsername; }
            set { SetPropertyValue<string>("ProxyServerUsername", ref _ProxyServerUsername, value); }
        }
        string _ProxyServerPassword;
        [Size(50)]
        public string ProxyServerPassword
        {
            get { return _ProxyServerPassword; }
            set { SetPropertyValue<string>("ProxyServerPassword", ref _ProxyServerPassword, value); }
        }
        string _PrintServerLocation;
        [Size(200)]
        public string PrintServerLocation
        {
            get { return _PrintServerLocation; }
            set { SetPropertyValue<string>("PrintServerLocation", ref _PrintServerLocation, value); }
        }
        string _BankName;
        [Size(50)]
        public string BankName
        {
            get { return _BankName; }
            set { SetPropertyValue<string>("BankName", ref _BankName, value); }
        }
        string _BankBranch;
        [Size(50)]
        public string BankBranch
        {
            get { return _BankBranch; }
            set { SetPropertyValue<string>("BankBranch", ref _BankBranch, value); }
        }
        string _BankCode;
        [Size(50)]
        public string BankCode
        {
            get { return _BankCode; }
            set { SetPropertyValue<string>("BankCode", ref _BankCode, value); }
        }
        string _BankAccountNumber;
        [Size(50)]
        public string BankAccountNumber
        {
            get { return _BankAccountNumber; }
            set { SetPropertyValue<string>("BankAccountNumber", ref _BankAccountNumber, value); }
        }
        string _DefaultMessageDocument;
        [Size(1000)]
        public string DefaultMessageDocument
        {
            get { return _DefaultMessageDocument; }
            set { SetPropertyValue<string>("DefaultMessageDocument", ref _DefaultMessageDocument, value); }
        }
        string _DefaultMessageStatement;
        [Size(1000)]
        public string DefaultMessageStatement
        {
            get { return _DefaultMessageStatement; }
            set { SetPropertyValue<string>("DefaultMessageStatement", ref _DefaultMessageStatement, value); }
        }
        CDS_SYS_SYS_Printer _PrinterBarcode;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Printer")]
        public CDS_SYS_SYS_Printer PrinterBarcode
        {
            get { return _PrinterBarcode; }
            set { SetPropertyValue<CDS_SYS_SYS_Printer>("PrinterBarcode", ref _PrinterBarcode, value); }
        }
        CDS_SYS_SYS_Printer _PrinterPicker;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Printer1")]
        public CDS_SYS_SYS_Printer PrinterPicker
        {
            get { return _PrinterPicker; }
            set { SetPropertyValue<CDS_SYS_SYS_Printer>("PrinterPicker", ref _PrinterPicker, value); }
        }
        CDS_SYS_SYS_Printer _PrinterReceipt;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_SYS_SYS_Printer2")]
        public CDS_SYS_SYS_Printer PrinterReceipt
        {
            get { return _PrinterReceipt; }
            set { SetPropertyValue<CDS_SYS_SYS_Printer>("PrinterReceipt", ref _PrinterReceipt, value); }
        }
        string _UpdateURL;
        [Size(50)]
        public string UpdateURL
        {
            get { return _UpdateURL; }
            set { SetPropertyValue<string>("UpdateURL", ref _UpdateURL, value); }
        }
        bool _MinimizeNavigation;
        public bool MinimizeNavigation
        {
            get { return _MinimizeNavigation; }
            set { SetPropertyValue<bool>("MinimizeNavigation", ref _MinimizeNavigation, value); }
        }
        string _UpdateCheckTime;
        [Size(50)]
        public string UpdateCheckTime
        {
            get { return _UpdateCheckTime; }
            set { SetPropertyValue<string>("UpdateCheckTime", ref _UpdateCheckTime, value); }
        }
        string _PaymentAccounts;
        [Size(1000)]
        public string PaymentAccounts
        {
            get { return _PaymentAccounts; }
            set { SetPropertyValue<string>("PaymentAccounts", ref _PaymentAccounts, value); }
        }
        bool _UseBarcodes;
        public bool UseBarcodes
        {
            get { return _UseBarcodes; }
            set { SetPropertyValue<bool>("UseBarcodes", ref _UseBarcodes, value); }
        }
        bool _UseLabels;
        public bool UseLabels
        {
            get { return _UseLabels; }
            set { SetPropertyValue<bool>("UseLabels", ref _UseLabels, value); }
        }
        bool _CopyInvoiceOrderNumbertoCreditNote;
        public bool CopyInvoiceOrderNumbertoCreditNote
        {
            get { return _CopyInvoiceOrderNumbertoCreditNote; }
            set { SetPropertyValue<bool>("CopyInvoiceOrderNumbertoCreditNote", ref _CopyInvoiceOrderNumbertoCreditNote, value); }
        }
        bool _AutoWriteoffOpenItemCredits;
        public bool AutoWriteoffOpenItemCredits
        {
            get { return _AutoWriteoffOpenItemCredits; }
            set { SetPropertyValue<bool>("AutoWriteoffOpenItemCredits", ref _AutoWriteoffOpenItemCredits, value); }
        }
        byte _NegativeDiscountEffects;
        public byte NegativeDiscountEffects
        {
            get { return _NegativeDiscountEffects; }
            set { SetPropertyValue<byte>("NegativeDiscountEffects", ref _NegativeDiscountEffects, value); }
        }
        bool _NotifyonZeroMarkupSale;
        public bool NotifyonZeroMarkupSale
        {
            get { return _NotifyonZeroMarkupSale; }
            set { SetPropertyValue<bool>("NotifyonZeroMarkupSale", ref _NotifyonZeroMarkupSale, value); }
        }
        bool _NotifyonZeroProfitSale;
        public bool NotifyonZeroProfitSale
        {
            get { return _NotifyonZeroProfitSale; }
            set { SetPropertyValue<bool>("NotifyonZeroProfitSale", ref _NotifyonZeroProfitSale, value); }
        }
        byte _QuoteValidDays;
        public byte QuoteValidDays
        {
            get { return _QuoteValidDays; }
            set { SetPropertyValue<byte>("QuoteValidDays", ref _QuoteValidDays, value); }
        }
        byte _QuoteValidMax;
        public byte QuoteValidMax
        {
            get { return _QuoteValidMax; }
            set { SetPropertyValue<byte>("QuoteValidMax", ref _QuoteValidMax, value); }
        }
        bool _NotifyonBackOrder;
        public bool NotifyonBackOrder
        {
            get { return _NotifyonBackOrder; }
            set { SetPropertyValue<bool>("NotifyonBackOrder", ref _NotifyonBackOrder, value); }
        }
        decimal _RoundingAmount;
        public decimal RoundingAmount
        {
            get { return _RoundingAmount; }
            set { SetPropertyValue<decimal>("RoundingAmount", ref _RoundingAmount, value); }
        }
        bool _CashierPaymentsFullAmount;
        public bool CashierPaymentsFullAmount
        {
            get { return _CashierPaymentsFullAmount; }
            set { SetPropertyValue<bool>("CashierPaymentsFullAmount", ref _CashierPaymentsFullAmount, value); }
        }
        byte _CODAccountLimit;
        public byte CODAccountLimit
        {
            get { return _CODAccountLimit; }
            set { SetPropertyValue<byte>("CODAccountLimit", ref _CODAccountLimit, value); }
        }
        byte _DebtorGracePeriod;
        public byte DebtorGracePeriod
        {
            get { return _DebtorGracePeriod; }
            set { SetPropertyValue<byte>("DebtorGracePeriod", ref _DebtorGracePeriod, value); }
        }
        decimal _DefaultInterestCharged;
        public decimal DefaultInterestCharged
        {
            get { return _DefaultInterestCharged; }
            set { SetPropertyValue<decimal>("DefaultInterestCharged", ref _DefaultInterestCharged, value); }
        }
        byte _MonthWeight3;
        public byte MonthWeight3
        {
            get { return _MonthWeight3; }
            set { SetPropertyValue<byte>("MonthWeight3", ref _MonthWeight3, value); }
        }
        byte _MonthWeight6;
        public byte MonthWeight6
        {
            get { return _MonthWeight6; }
            set { SetPropertyValue<byte>("MonthWeight6", ref _MonthWeight6, value); }
        }
        byte _MonthWeight12;
        public byte MonthWeight12
        {
            get { return _MonthWeight12; }
            set { SetPropertyValue<byte>("MonthWeight12", ref _MonthWeight12, value); }
        }
        byte _MonthWeight24;
        public byte MonthWeight24
        {
            get { return _MonthWeight24; }
            set { SetPropertyValue<byte>("MonthWeight24", ref _MonthWeight24, value); }
        }
        byte _MonthWeight36;
        public byte MonthWeight36
        {
            get { return _MonthWeight36; }
            set { SetPropertyValue<byte>("MonthWeight36", ref _MonthWeight36, value); }
        }
        decimal _FixedOrderCost;
        public decimal FixedOrderCost
        {
            get { return _FixedOrderCost; }
            set { SetPropertyValue<decimal>("FixedOrderCost", ref _FixedOrderCost, value); }
        }
        byte _MaxOrderLines;
        public byte MaxOrderLines
        {
            get { return _MaxOrderLines; }
            set { SetPropertyValue<byte>("MaxOrderLines", ref _MaxOrderLines, value); }
        }
        byte _SafetyStockPeriod;
        public byte SafetyStockPeriod
        {
            get { return _SafetyStockPeriod; }
            set { SetPropertyValue<byte>("SafetyStockPeriod", ref _SafetyStockPeriod, value); }
        }
        string _DistributionNumber;
        [Size(50)]
        public string DistributionNumber
        {
            get { return _DistributionNumber; }
            set { SetPropertyValue<string>("DistributionNumber", ref _DistributionNumber, value); }
        }
        string _BackupLocation;
        [Size(200)]
        public string BackupLocation
        {
            get { return _BackupLocation; }
            set { SetPropertyValue<string>("BackupLocation", ref _BackupLocation, value); }
        }
        string _LineTypeFilter;
        [Size(200)]
        public string LineTypeFilter
        {
            get { return _LineTypeFilter; }
            set { SetPropertyValue<string>("LineTypeFilter", ref _LineTypeFilter, value); }
        }
        CDS_ORG_ORG_Company _BuyoutSupplierAccount;
        [Association(@"CDS_SYS_SYS_SiteReferencesCDS_ORG_ORG_Company")]
        public CDS_ORG_ORG_Company BuyoutSupplierAccount
        {
            get { return _BuyoutSupplierAccount; }
            set { SetPropertyValue<CDS_ORG_ORG_Company>("BuyoutSupplierAccount", ref _BuyoutSupplierAccount, value); }
        }
        string _ClientZipLocation;
        [Size(200)]
        public string ClientZipLocation
        {
            get { return _ClientZipLocation; }
            set { SetPropertyValue<string>("ClientZipLocation", ref _ClientZipLocation, value); }
        }
        [Association(@"CDS_ORG_ORG_CompanyReferencesCDS_SYS_SYS_Site", typeof(CDS_ORG_ORG_Company))]
        public XPCollection<CDS_ORG_ORG_Company> CDS_ORG_ORG_Companys { get { return GetCollection<CDS_ORG_ORG_Company>("CDS_ORG_ORG_Companys"); } }
    }

}
