namespace cufxstandards.com {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public partial class AccountList {
        
        private Account[] accountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("account")]
        public Account[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public partial class Account {
        
        private string accountIdField;
        
        private IdType idTypeField;
        
        private bool idTypeFieldSpecified;
        
        private string descriptionField;
        
        private AccountType typeField;
        
        private bool typeFieldSpecified;
        
        private string subTypeField;
        
        private System.DateTime openDateField;
        
        private bool openDateFieldSpecified;
        
        private string accountNickNameField;
        
        private string micrAccountNumberField;
        
        private string branchField;
        
        private Money actualBalanceField;
        
        private Money availableBalanceField;
        
        private Money minimumBalanceField;
        
        private string routingNumberField;
        
        private bool externalAccountFlagField;
        
        private bool externalAccountFlagFieldSpecified;
        
        private bool externalTransferFromField;
        
        private bool externalTransferFromFieldSpecified;
        
        private bool externalTransferToField;
        
        private bool externalTransferToFieldSpecified;
        
        private bool transferFromField;
        
        private bool transferFromFieldSpecified;
        
        private bool transferToField;
        
        private bool transferToFieldSpecified;
        
        private RateType rateTypeField;
        
        private bool rateTypeFieldSpecified;
        
        private string sourceCodeField;
        
        private string[] partyIdListField;
        
        private string relationshipIdField;
        
        private ValuePair[] customDataField;
        
        private Meta metaField;
        
        private TransactionListTransaction[] transactionListField;
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        public IdType idType {
            get {
                return this.idTypeField;
            }
            set {
                this.idTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idTypeSpecified {
            get {
                return this.idTypeFieldSpecified;
            }
            set {
                this.idTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public AccountType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string subType {
            get {
                return this.subTypeField;
            }
            set {
                this.subTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime openDate {
            get {
                return this.openDateField;
            }
            set {
                this.openDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openDateSpecified {
            get {
                return this.openDateFieldSpecified;
            }
            set {
                this.openDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string accountNickName {
            get {
                return this.accountNickNameField;
            }
            set {
                this.accountNickNameField = value;
            }
        }
        
        /// <remarks/>
        public string micrAccountNumber {
            get {
                return this.micrAccountNumberField;
            }
            set {
                this.micrAccountNumberField = value;
            }
        }
        
        /// <remarks/>
        public string branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        public Money actualBalance {
            get {
                return this.actualBalanceField;
            }
            set {
                this.actualBalanceField = value;
            }
        }
        
        /// <remarks/>
        public Money availableBalance {
            get {
                return this.availableBalanceField;
            }
            set {
                this.availableBalanceField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumBalance {
            get {
                return this.minimumBalanceField;
            }
            set {
                this.minimumBalanceField = value;
            }
        }
        
        /// <remarks/>
        public string routingNumber {
            get {
                return this.routingNumberField;
            }
            set {
                this.routingNumberField = value;
            }
        }
        
        /// <remarks/>
        public bool externalAccountFlag {
            get {
                return this.externalAccountFlagField;
            }
            set {
                this.externalAccountFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool externalAccountFlagSpecified {
            get {
                return this.externalAccountFlagFieldSpecified;
            }
            set {
                this.externalAccountFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool externalTransferFrom {
            get {
                return this.externalTransferFromField;
            }
            set {
                this.externalTransferFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool externalTransferFromSpecified {
            get {
                return this.externalTransferFromFieldSpecified;
            }
            set {
                this.externalTransferFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool externalTransferTo {
            get {
                return this.externalTransferToField;
            }
            set {
                this.externalTransferToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool externalTransferToSpecified {
            get {
                return this.externalTransferToFieldSpecified;
            }
            set {
                this.externalTransferToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool transferFrom {
            get {
                return this.transferFromField;
            }
            set {
                this.transferFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transferFromSpecified {
            get {
                return this.transferFromFieldSpecified;
            }
            set {
                this.transferFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool transferTo {
            get {
                return this.transferToField;
            }
            set {
                this.transferToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transferToSpecified {
            get {
                return this.transferToFieldSpecified;
            }
            set {
                this.transferToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RateType rateType {
            get {
                return this.rateTypeField;
            }
            set {
                this.rateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateTypeSpecified {
            get {
                return this.rateTypeFieldSpecified;
            }
            set {
                this.rateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string sourceCode {
            get {
                return this.sourceCodeField;
            }
            set {
                this.sourceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        public string relationshipId {
            get {
                return this.relationshipIdField;
            }
            set {
                this.relationshipIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Meta meta {
            get {
                return this.metaField;
            }
            set {
                this.metaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("transaction")]
        public TransactionListTransaction[] transactionList {
            get {
                return this.transactionListField;
            }
            set {
                this.transactionListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum IdType {
        
        /// <remarks/>
        Reserved,
        
        /// <remarks/>
        Actual,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum AccountType {
        
        /// <remarks/>
        Checking,
        
        /// <remarks/>
        Savings,
        
        /// <remarks/>
        Loan,
        
        /// <remarks/>
        CreditCard,
        
        /// <remarks/>
        LineOfCredit,
        
        /// <remarks/>
        Mortgage,
        
        /// <remarks/>
        Investment,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class Money {
        
        private decimal valueField;
        
        private ISOCurrencyCodeType currencyCodeField;
        
        public Money() {
            this.currencyCodeField = ISOCurrencyCodeType.USD;
        }
        
        /// <remarks/>
        public decimal value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public ISOCurrencyCodeType currencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ISOCurrencyCodeType.xsd")]
    public enum ISOCurrencyCodeType {
        
        /// <remarks/>
        AED,
        
        /// <remarks/>
        AFN,
        
        /// <remarks/>
        ALL,
        
        /// <remarks/>
        AMD,
        
        /// <remarks/>
        ANG,
        
        /// <remarks/>
        AOA,
        
        /// <remarks/>
        ARS,
        
        /// <remarks/>
        AUD,
        
        /// <remarks/>
        AWG,
        
        /// <remarks/>
        AZN,
        
        /// <remarks/>
        BAM,
        
        /// <remarks/>
        BBD,
        
        /// <remarks/>
        BDT,
        
        /// <remarks/>
        BGN,
        
        /// <remarks/>
        BHD,
        
        /// <remarks/>
        BIF,
        
        /// <remarks/>
        BMD,
        
        /// <remarks/>
        BND,
        
        /// <remarks/>
        BOB,
        
        /// <remarks/>
        BRL,
        
        /// <remarks/>
        BSD,
        
        /// <remarks/>
        BTN,
        
        /// <remarks/>
        BWP,
        
        /// <remarks/>
        BYR,
        
        /// <remarks/>
        BZD,
        
        /// <remarks/>
        CAD,
        
        /// <remarks/>
        CDF,
        
        /// <remarks/>
        CHF,
        
        /// <remarks/>
        CLP,
        
        /// <remarks/>
        CNY,
        
        /// <remarks/>
        COP,
        
        /// <remarks/>
        CRC,
        
        /// <remarks/>
        CUP,
        
        /// <remarks/>
        CVE,
        
        /// <remarks/>
        CZK,
        
        /// <remarks/>
        DJF,
        
        /// <remarks/>
        DKK,
        
        /// <remarks/>
        DOP,
        
        /// <remarks/>
        DZD,
        
        /// <remarks/>
        EEK,
        
        /// <remarks/>
        EGP,
        
        /// <remarks/>
        ERN,
        
        /// <remarks/>
        ETB,
        
        /// <remarks/>
        EUR,
        
        /// <remarks/>
        FJD,
        
        /// <remarks/>
        FKP,
        
        /// <remarks/>
        GBP,
        
        /// <remarks/>
        GEL,
        
        /// <remarks/>
        GHS,
        
        /// <remarks/>
        GIP,
        
        /// <remarks/>
        GMD,
        
        /// <remarks/>
        GNF,
        
        /// <remarks/>
        GTQ,
        
        /// <remarks/>
        GYD,
        
        /// <remarks/>
        GWP,
        
        /// <remarks/>
        HKD,
        
        /// <remarks/>
        HNL,
        
        /// <remarks/>
        HRK,
        
        /// <remarks/>
        HTG,
        
        /// <remarks/>
        HUF,
        
        /// <remarks/>
        IDR,
        
        /// <remarks/>
        ILS,
        
        /// <remarks/>
        INR,
        
        /// <remarks/>
        IQD,
        
        /// <remarks/>
        IRR,
        
        /// <remarks/>
        ISK,
        
        /// <remarks/>
        JMD,
        
        /// <remarks/>
        JOD,
        
        /// <remarks/>
        JPY,
        
        /// <remarks/>
        KES,
        
        /// <remarks/>
        KGS,
        
        /// <remarks/>
        KHR,
        
        /// <remarks/>
        KMF,
        
        /// <remarks/>
        KPW,
        
        /// <remarks/>
        KRW,
        
        /// <remarks/>
        KWD,
        
        /// <remarks/>
        KYD,
        
        /// <remarks/>
        KZT,
        
        /// <remarks/>
        LAK,
        
        /// <remarks/>
        LBP,
        
        /// <remarks/>
        LKR,
        
        /// <remarks/>
        LRD,
        
        /// <remarks/>
        LSL,
        
        /// <remarks/>
        LTL,
        
        /// <remarks/>
        LVL,
        
        /// <remarks/>
        LYD,
        
        /// <remarks/>
        MAD,
        
        /// <remarks/>
        MDL,
        
        /// <remarks/>
        MGA,
        
        /// <remarks/>
        MKD,
        
        /// <remarks/>
        MMK,
        
        /// <remarks/>
        MNT,
        
        /// <remarks/>
        MOP,
        
        /// <remarks/>
        MRO,
        
        /// <remarks/>
        MUR,
        
        /// <remarks/>
        MVR,
        
        /// <remarks/>
        MWK,
        
        /// <remarks/>
        MXN,
        
        /// <remarks/>
        MYR,
        
        /// <remarks/>
        MZN,
        
        /// <remarks/>
        NAD,
        
        /// <remarks/>
        NGN,
        
        /// <remarks/>
        NIO,
        
        /// <remarks/>
        NOK,
        
        /// <remarks/>
        NPR,
        
        /// <remarks/>
        NZD,
        
        /// <remarks/>
        OMR,
        
        /// <remarks/>
        PAB,
        
        /// <remarks/>
        PEN,
        
        /// <remarks/>
        PGK,
        
        /// <remarks/>
        PHP,
        
        /// <remarks/>
        PKR,
        
        /// <remarks/>
        PLN,
        
        /// <remarks/>
        PYG,
        
        /// <remarks/>
        QAR,
        
        /// <remarks/>
        RON,
        
        /// <remarks/>
        RSD,
        
        /// <remarks/>
        RUB,
        
        /// <remarks/>
        RWF,
        
        /// <remarks/>
        SAR,
        
        /// <remarks/>
        SBD,
        
        /// <remarks/>
        SCR,
        
        /// <remarks/>
        SDG,
        
        /// <remarks/>
        SEK,
        
        /// <remarks/>
        SGD,
        
        /// <remarks/>
        SHP,
        
        /// <remarks/>
        SKK,
        
        /// <remarks/>
        SLL,
        
        /// <remarks/>
        SOS,
        
        /// <remarks/>
        SRD,
        
        /// <remarks/>
        STD,
        
        /// <remarks/>
        SVC,
        
        /// <remarks/>
        SYP,
        
        /// <remarks/>
        SZL,
        
        /// <remarks/>
        THB,
        
        /// <remarks/>
        TJS,
        
        /// <remarks/>
        TMM,
        
        /// <remarks/>
        TND,
        
        /// <remarks/>
        TOP,
        
        /// <remarks/>
        TRY,
        
        /// <remarks/>
        TTD,
        
        /// <remarks/>
        TWD,
        
        /// <remarks/>
        TZS,
        
        /// <remarks/>
        UAH,
        
        /// <remarks/>
        UGX,
        
        /// <remarks/>
        USD,
        
        /// <remarks/>
        UYU,
        
        /// <remarks/>
        UZS,
        
        /// <remarks/>
        VEF,
        
        /// <remarks/>
        VND,
        
        /// <remarks/>
        VUV,
        
        /// <remarks/>
        WST,
        
        /// <remarks/>
        XAF,
        
        /// <remarks/>
        XAG,
        
        /// <remarks/>
        XAU,
        
        /// <remarks/>
        XCD,
        
        /// <remarks/>
        XDR,
        
        /// <remarks/>
        XOF,
        
        /// <remarks/>
        XPD,
        
        /// <remarks/>
        XPF,
        
        /// <remarks/>
        XPT,
        
        /// <remarks/>
        YER,
        
        /// <remarks/>
        ZAR,
        
        /// <remarks/>
        ZMK,
        
        /// <remarks/>
        ZWR,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class Note {
        
        private CoreRecordType recordTypeField;
        
        private bool recordTypeFieldSpecified;
        
        private string noteCodeField;
        
        private string[] noteTextField;
        
        private System.DateTime noteCreatedDateTimeField;
        
        private bool noteCreatedDateTimeFieldSpecified;
        
        private System.DateTime noteExpirationDateField;
        
        private bool noteExpirationDateFieldSpecified;
        
        private string noteCreatorField;
        
        /// <remarks/>
        public CoreRecordType recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recordTypeSpecified {
            get {
                return this.recordTypeFieldSpecified;
            }
            set {
                this.recordTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string noteCode {
            get {
                return this.noteCodeField;
            }
            set {
                this.noteCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("noteText")]
        public string[] noteText {
            get {
                return this.noteTextField;
            }
            set {
                this.noteTextField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime noteCreatedDateTime {
            get {
                return this.noteCreatedDateTimeField;
            }
            set {
                this.noteCreatedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noteCreatedDateTimeSpecified {
            get {
                return this.noteCreatedDateTimeFieldSpecified;
            }
            set {
                this.noteCreatedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime noteExpirationDate {
            get {
                return this.noteExpirationDateField;
            }
            set {
                this.noteExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noteExpirationDateSpecified {
            get {
                return this.noteExpirationDateFieldSpecified;
            }
            set {
                this.noteExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string noteCreator {
            get {
                return this.noteCreatorField;
            }
            set {
                this.noteCreatorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public enum CoreRecordType {
        
        /// <remarks/>
        Account,
        
        /// <remarks/>
        Application,
        
        /// <remarks/>
        Loan,
        
        /// <remarks/>
        Portfolio,
        
        /// <remarks/>
        Deposit,
        
        /// <remarks/>
        ProductServiceRequest,
        
        /// <remarks/>
        Request,
        
        /// <remarks/>
        Activity,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class SkipPayment {
        
        private string numberOfSkipPaymentsAllowedField;
        
        private System.DateTime skipPaymentBeginDateField;
        
        private bool skipPaymentBeginDateFieldSpecified;
        
        private MonthType monthToStartSkipPaymentsField;
        
        private bool monthToStartSkipPaymentsFieldSpecified;
        
        private string yearToSkipPaymentField;
        
        private bool isSkipRecurringField;
        
        private bool isSkipRecurringFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string numberOfSkipPaymentsAllowed {
            get {
                return this.numberOfSkipPaymentsAllowedField;
            }
            set {
                this.numberOfSkipPaymentsAllowedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime skipPaymentBeginDate {
            get {
                return this.skipPaymentBeginDateField;
            }
            set {
                this.skipPaymentBeginDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool skipPaymentBeginDateSpecified {
            get {
                return this.skipPaymentBeginDateFieldSpecified;
            }
            set {
                this.skipPaymentBeginDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MonthType monthToStartSkipPayments {
            get {
                return this.monthToStartSkipPaymentsField;
            }
            set {
                this.monthToStartSkipPaymentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthToStartSkipPaymentsSpecified {
            get {
                return this.monthToStartSkipPaymentsFieldSpecified;
            }
            set {
                this.monthToStartSkipPaymentsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string yearToSkipPayment {
            get {
                return this.yearToSkipPaymentField;
            }
            set {
                this.yearToSkipPaymentField = value;
            }
        }
        
        /// <remarks/>
        public bool isSkipRecurring {
            get {
                return this.isSkipRecurringField;
            }
            set {
                this.isSkipRecurringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSkipRecurringSpecified {
            get {
                return this.isSkipRecurringFieldSpecified;
            }
            set {
                this.isSkipRecurringFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum MonthType {
        
        /// <remarks/>
        January,
        
        /// <remarks/>
        February,
        
        /// <remarks/>
        March,
        
        /// <remarks/>
        April,
        
        /// <remarks/>
        May,
        
        /// <remarks/>
        June,
        
        /// <remarks/>
        July,
        
        /// <remarks/>
        August,
        
        /// <remarks/>
        September,
        
        /// <remarks/>
        October,
        
        /// <remarks/>
        November,
        
        /// <remarks/>
        December,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class DelinquencyNotice {
        
        private string delinquencyNoticeIdField;
        
        private string codeField;
        
        private string delinquencyNoticeDaysField;
        
        private string delinquencyLockDaysField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string delinquencyNoticeId {
            get {
                return this.delinquencyNoticeIdField;
            }
            set {
                this.delinquencyNoticeIdField = value;
            }
        }
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string delinquencyNoticeDays {
            get {
                return this.delinquencyNoticeDaysField;
            }
            set {
                this.delinquencyNoticeDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string delinquencyLockDays {
            get {
                return this.delinquencyLockDaysField;
            }
            set {
                this.delinquencyLockDaysField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class AutoPaymentOption {
        
        private AutoPaymentOptionType autoPaymentOptionField;
        
        private bool autoPaymentOptionFieldSpecified;
        
        private string otherAutoPaymentOptionField;
        
        private AutoPaymentFrequencyType autoPaymentFrequencyField;
        
        private bool autoPaymentFrequencyFieldSpecified;
        
        private DayOfTheWeek autoPaymentDayOfTheWeekField;
        
        private bool autoPaymentDayOfTheWeekFieldSpecified;
        
        private string autoPaymentDayOfTheMonthField;
        
        private Money autoPaymentAmountField;
        
        private string fromAccountIdField;
        
        /// <remarks/>
        public AutoPaymentOptionType autoPaymentOption {
            get {
                return this.autoPaymentOptionField;
            }
            set {
                this.autoPaymentOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoPaymentOptionSpecified {
            get {
                return this.autoPaymentOptionFieldSpecified;
            }
            set {
                this.autoPaymentOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string otherAutoPaymentOption {
            get {
                return this.otherAutoPaymentOptionField;
            }
            set {
                this.otherAutoPaymentOptionField = value;
            }
        }
        
        /// <remarks/>
        public AutoPaymentFrequencyType autoPaymentFrequency {
            get {
                return this.autoPaymentFrequencyField;
            }
            set {
                this.autoPaymentFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoPaymentFrequencySpecified {
            get {
                return this.autoPaymentFrequencyFieldSpecified;
            }
            set {
                this.autoPaymentFrequencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DayOfTheWeek autoPaymentDayOfTheWeek {
            get {
                return this.autoPaymentDayOfTheWeekField;
            }
            set {
                this.autoPaymentDayOfTheWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoPaymentDayOfTheWeekSpecified {
            get {
                return this.autoPaymentDayOfTheWeekFieldSpecified;
            }
            set {
                this.autoPaymentDayOfTheWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string autoPaymentDayOfTheMonth {
            get {
                return this.autoPaymentDayOfTheMonthField;
            }
            set {
                this.autoPaymentDayOfTheMonthField = value;
            }
        }
        
        /// <remarks/>
        public Money autoPaymentAmount {
            get {
                return this.autoPaymentAmountField;
            }
            set {
                this.autoPaymentAmountField = value;
            }
        }
        
        /// <remarks/>
        public string fromAccountId {
            get {
                return this.fromAccountIdField;
            }
            set {
                this.fromAccountIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum AutoPaymentOptionType {
        
        /// <remarks/>
        Balance,
        
        /// <remarks/>
        MinimumDue,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Principal,
        
        /// <remarks/>
        SetPayment,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum AutoPaymentFrequencyType {
        
        /// <remarks/>
        Bimonthly,
        
        /// <remarks/>
        Biweekly,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        OneTime,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Weekly,
        
        /// <remarks/>
        Yearly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public enum DayOfTheWeek {
        
        /// <remarks/>
        Monday,
        
        /// <remarks/>
        Tuesday,
        
        /// <remarks/>
        Wednesday,
        
        /// <remarks/>
        Thursday,
        
        /// <remarks/>
        Friday,
        
        /// <remarks/>
        Saturday,
        
        /// <remarks/>
        Sunday,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class CollateralBase {
        
        private string collateralIdField;
        
        private string collateralCodeField;
        
        private System.DateTime collateralPledgedDateField;
        
        private bool collateralPledgedDateFieldSpecified;
        
        private string descriptionField;
        
        private string securedCodeField;
        
        private Money totalSecuredAmountField;
        
        private Money valuationOfCollateralField;
        
        private string ownerOfCollateralField;
        
        private decimal loanToValuePercentageField;
        
        private bool loanToValuePercentageFieldSpecified;
        
        private System.DateTime collateralValueSourceDateField;
        
        private bool collateralValueSourceDateFieldSpecified;
        
        private string collateralValueSourceField;
        
        /// <remarks/>
        public string collateralId {
            get {
                return this.collateralIdField;
            }
            set {
                this.collateralIdField = value;
            }
        }
        
        /// <remarks/>
        public string collateralCode {
            get {
                return this.collateralCodeField;
            }
            set {
                this.collateralCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime collateralPledgedDate {
            get {
                return this.collateralPledgedDateField;
            }
            set {
                this.collateralPledgedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool collateralPledgedDateSpecified {
            get {
                return this.collateralPledgedDateFieldSpecified;
            }
            set {
                this.collateralPledgedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string securedCode {
            get {
                return this.securedCodeField;
            }
            set {
                this.securedCodeField = value;
            }
        }
        
        /// <remarks/>
        public Money totalSecuredAmount {
            get {
                return this.totalSecuredAmountField;
            }
            set {
                this.totalSecuredAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money valuationOfCollateral {
            get {
                return this.valuationOfCollateralField;
            }
            set {
                this.valuationOfCollateralField = value;
            }
        }
        
        /// <remarks/>
        public string ownerOfCollateral {
            get {
                return this.ownerOfCollateralField;
            }
            set {
                this.ownerOfCollateralField = value;
            }
        }
        
        /// <remarks/>
        public decimal loanToValuePercentage {
            get {
                return this.loanToValuePercentageField;
            }
            set {
                this.loanToValuePercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool loanToValuePercentageSpecified {
            get {
                return this.loanToValuePercentageFieldSpecified;
            }
            set {
                this.loanToValuePercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime collateralValueSourceDate {
            get {
                return this.collateralValueSourceDateField;
            }
            set {
                this.collateralValueSourceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool collateralValueSourceDateSpecified {
            get {
                return this.collateralValueSourceDateFieldSpecified;
            }
            set {
                this.collateralValueSourceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string collateralValueSource {
            get {
                return this.collateralValueSourceField;
            }
            set {
                this.collateralValueSourceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public abstract partial class PossessoryCollateralBase : CollateralBase {
        
        private Money securityCollateralValueLimitField;
        
        private System.Nullable<decimal> securityMarketValueLimitField;
        
        private bool securityMarketValueLimitFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Money securityCollateralValueLimit {
            get {
                return this.securityCollateralValueLimitField;
            }
            set {
                this.securityCollateralValueLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> securityMarketValueLimit {
            get {
                return this.securityMarketValueLimitField;
            }
            set {
                this.securityMarketValueLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool securityMarketValueLimitSpecified {
            get {
                return this.securityMarketValueLimitFieldSpecified;
            }
            set {
                this.securityMarketValueLimitFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class LetterOfCreditCollateral : PossessoryCollateralBase {
        
        private string possessoryNumberField;
        
        private System.Nullable<System.DateTime> issueDateField;
        
        private bool issueDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string possessoryNumber {
            get {
                return this.possessoryNumberField;
            }
            set {
                this.possessoryNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> issueDate {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool issueDateSpecified {
            get {
                return this.issueDateFieldSpecified;
            }
            set {
                this.issueDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class SecuritiesCollateral : PossessoryCollateralBase {
        
        private string possessoryNumberField;
        
        private string faceValueField;
        
        private string issuerField;
        
        private System.Nullable<decimal> numberOfSharesField;
        
        private bool numberOfSharesFieldSpecified;
        
        private string cusipNumberField;
        
        private string heldByField;
        
        private System.Nullable<bool> bookEntryField;
        
        private bool bookEntryFieldSpecified;
        
        private System.Nullable<ValuationFrequency> valuationFrequencyField;
        
        private bool valuationFrequencyFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string possessoryNumber {
            get {
                return this.possessoryNumberField;
            }
            set {
                this.possessoryNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string faceValue {
            get {
                return this.faceValueField;
            }
            set {
                this.faceValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string issuer {
            get {
                return this.issuerField;
            }
            set {
                this.issuerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> numberOfShares {
            get {
                return this.numberOfSharesField;
            }
            set {
                this.numberOfSharesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfSharesSpecified {
            get {
                return this.numberOfSharesFieldSpecified;
            }
            set {
                this.numberOfSharesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cusipNumber {
            get {
                return this.cusipNumberField;
            }
            set {
                this.cusipNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string heldBy {
            get {
                return this.heldByField;
            }
            set {
                this.heldByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> bookEntry {
            get {
                return this.bookEntryField;
            }
            set {
                this.bookEntryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bookEntrySpecified {
            get {
                return this.bookEntryFieldSpecified;
            }
            set {
                this.bookEntryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<ValuationFrequency> valuationFrequency {
            get {
                return this.valuationFrequencyField;
            }
            set {
                this.valuationFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valuationFrequencySpecified {
            get {
                return this.valuationFrequencyFieldSpecified;
            }
            set {
                this.valuationFrequencyFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public enum ValuationFrequency {
        
        /// <remarks/>
        Weekly,
        
        /// <remarks/>
        BiWeekly,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        BiMonthly,
        
        /// <remarks/>
        Quarterly,
        
        /// <remarks/>
        SemiAnnually,
        
        /// <remarks/>
        Annually,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class SavingsCDCollateral : PossessoryCollateralBase {
        
        private string accountNumberField;
        
        private string faceValueField;
        
        private string issuerTypeField;
        
        private System.Nullable<bool> certifiedField;
        
        private bool certifiedFieldSpecified;
        
        private Money possessoryInterestRateField;
        
        private Money amountField;
        
        private decimal percentageField;
        
        private bool percentageFieldSpecified;
        
        /// <remarks/>
        public string accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string faceValue {
            get {
                return this.faceValueField;
            }
            set {
                this.faceValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string issuerType {
            get {
                return this.issuerTypeField;
            }
            set {
                this.issuerTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> certified {
            get {
                return this.certifiedField;
            }
            set {
                this.certifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool certifiedSpecified {
            get {
                return this.certifiedFieldSpecified;
            }
            set {
                this.certifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Money possessoryInterestRate {
            get {
                return this.possessoryInterestRateField;
            }
            set {
                this.possessoryInterestRateField = value;
            }
        }
        
        /// <remarks/>
        public Money amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public decimal percentage {
            get {
                return this.percentageField;
            }
            set {
                this.percentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentageSpecified {
            get {
                return this.percentageFieldSpecified;
            }
            set {
                this.percentageFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class UccCollateral : CollateralBase {
        
        private System.Nullable<bool> financingStatementField;
        
        private bool financingStatementFieldSpecified;
        
        private string generalDescriptionField;
        
        private string tortClaimDescriptionField;
        
        private string immovableDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> financingStatement {
            get {
                return this.financingStatementField;
            }
            set {
                this.financingStatementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool financingStatementSpecified {
            get {
                return this.financingStatementFieldSpecified;
            }
            set {
                this.financingStatementFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string generalDescription {
            get {
                return this.generalDescriptionField;
            }
            set {
                this.generalDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string tortClaimDescription {
            get {
                return this.tortClaimDescriptionField;
            }
            set {
                this.tortClaimDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string immovableDescription {
            get {
                return this.immovableDescriptionField;
            }
            set {
                this.immovableDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class RealEstateCollateral : CollateralBase {
        
        private string taxIDField;
        
        private string parcelIDNNumberField;
        
        private string sectionField;
        
        private string blockField;
        
        private string lotField;
        
        private System.Nullable<bool> firstLienField;
        
        private bool firstLienFieldSpecified;
        
        private System.Nullable<bool> existingLiensField;
        
        private bool existingLiensFieldSpecified;
        
        private System.Nullable<bool> dwellingField;
        
        private bool dwellingFieldSpecified;
        
        private System.Nullable<float> numberOfUnitsField;
        
        private bool numberOfUnitsFieldSpecified;
        
        private System.Nullable<bool> ownerOccupiedField;
        
        private bool ownerOccupiedFieldSpecified;
        
        private System.Nullable<bool> principalDwellingField;
        
        private bool principalDwellingFieldSpecified;
        
        private System.Nullable<bool> assumableField;
        
        private bool assumableFieldSpecified;
        
        private System.Nullable<bool> manufacturedHousingField;
        
        private bool manufacturedHousingFieldSpecified;
        
        private System.Nullable<bool> constructionField;
        
        private bool constructionFieldSpecified;
        
        private System.Nullable<float> yearBuiltField;
        
        private bool yearBuiltFieldSpecified;
        
        private System.Nullable<bool> condoPUDField;
        
        private bool condoPUDFieldSpecified;
        
        private string legalDescriptionField;
        
        private System.Nullable<bool> rentalPropertyField;
        
        private bool rentalPropertyFieldSpecified;
        
        private string yearAcquiredField;
        
        private Money originalCostField;
        
        private Money presentValueField;
        
        private Money improvementsField;
        
        private System.Nullable<bool> timeshareField;
        
        private bool timeshareFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string taxID {
            get {
                return this.taxIDField;
            }
            set {
                this.taxIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string parcelIDNNumber {
            get {
                return this.parcelIDNNumberField;
            }
            set {
                this.parcelIDNNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string section {
            get {
                return this.sectionField;
            }
            set {
                this.sectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> firstLien {
            get {
                return this.firstLienField;
            }
            set {
                this.firstLienField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstLienSpecified {
            get {
                return this.firstLienFieldSpecified;
            }
            set {
                this.firstLienFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> existingLiens {
            get {
                return this.existingLiensField;
            }
            set {
                this.existingLiensField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existingLiensSpecified {
            get {
                return this.existingLiensFieldSpecified;
            }
            set {
                this.existingLiensFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> dwelling {
            get {
                return this.dwellingField;
            }
            set {
                this.dwellingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dwellingSpecified {
            get {
                return this.dwellingFieldSpecified;
            }
            set {
                this.dwellingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<float> numberOfUnits {
            get {
                return this.numberOfUnitsField;
            }
            set {
                this.numberOfUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfUnitsSpecified {
            get {
                return this.numberOfUnitsFieldSpecified;
            }
            set {
                this.numberOfUnitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> ownerOccupied {
            get {
                return this.ownerOccupiedField;
            }
            set {
                this.ownerOccupiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ownerOccupiedSpecified {
            get {
                return this.ownerOccupiedFieldSpecified;
            }
            set {
                this.ownerOccupiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> principalDwelling {
            get {
                return this.principalDwellingField;
            }
            set {
                this.principalDwellingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool principalDwellingSpecified {
            get {
                return this.principalDwellingFieldSpecified;
            }
            set {
                this.principalDwellingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> assumable {
            get {
                return this.assumableField;
            }
            set {
                this.assumableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool assumableSpecified {
            get {
                return this.assumableFieldSpecified;
            }
            set {
                this.assumableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> manufacturedHousing {
            get {
                return this.manufacturedHousingField;
            }
            set {
                this.manufacturedHousingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manufacturedHousingSpecified {
            get {
                return this.manufacturedHousingFieldSpecified;
            }
            set {
                this.manufacturedHousingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> construction {
            get {
                return this.constructionField;
            }
            set {
                this.constructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool constructionSpecified {
            get {
                return this.constructionFieldSpecified;
            }
            set {
                this.constructionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<float> yearBuilt {
            get {
                return this.yearBuiltField;
            }
            set {
                this.yearBuiltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearBuiltSpecified {
            get {
                return this.yearBuiltFieldSpecified;
            }
            set {
                this.yearBuiltFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> condoPUD {
            get {
                return this.condoPUDField;
            }
            set {
                this.condoPUDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool condoPUDSpecified {
            get {
                return this.condoPUDFieldSpecified;
            }
            set {
                this.condoPUDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string legalDescription {
            get {
                return this.legalDescriptionField;
            }
            set {
                this.legalDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> rentalProperty {
            get {
                return this.rentalPropertyField;
            }
            set {
                this.rentalPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rentalPropertySpecified {
            get {
                return this.rentalPropertyFieldSpecified;
            }
            set {
                this.rentalPropertyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string yearAcquired {
            get {
                return this.yearAcquiredField;
            }
            set {
                this.yearAcquiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Money originalCost {
            get {
                return this.originalCostField;
            }
            set {
                this.originalCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Money presentValue {
            get {
                return this.presentValueField;
            }
            set {
                this.presentValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Money improvements {
            get {
                return this.improvementsField;
            }
            set {
                this.improvementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> timeshare {
            get {
                return this.timeshareField;
            }
            set {
                this.timeshareField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeshareSpecified {
            get {
                return this.timeshareFieldSpecified;
            }
            set {
                this.timeshareFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class TitledCollateralBase : CollateralBase {
        
        private string yearField;
        
        private string manufacturerField;
        
        private string makeField;
        
        private string modelField;
        
        private string colorField;
        
        private Money purchasePriceField;
        
        private bool isVehicleUsedField;
        
        private bool isVehicleUsedFieldSpecified;
        
        private string uccCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public string manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        public string make {
            get {
                return this.makeField;
            }
            set {
                this.makeField = value;
            }
        }
        
        /// <remarks/>
        public string model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        public Money purchasePrice {
            get {
                return this.purchasePriceField;
            }
            set {
                this.purchasePriceField = value;
            }
        }
        
        /// <remarks/>
        public bool isVehicleUsed {
            get {
                return this.isVehicleUsedField;
            }
            set {
                this.isVehicleUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVehicleUsedSpecified {
            get {
                return this.isVehicleUsedFieldSpecified;
            }
            set {
                this.isVehicleUsedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string uccCode {
            get {
                return this.uccCodeField;
            }
            set {
                this.uccCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class MobileHomeCollateral : TitledCollateralBase {
        
        private string serialNumberField;
        
        private string bodyStyleField;
        
        private string descOfEquipmentField;
        
        /// <remarks/>
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string bodyStyle {
            get {
                return this.bodyStyleField;
            }
            set {
                this.bodyStyleField = value;
            }
        }
        
        /// <remarks/>
        public string descOfEquipment {
            get {
                return this.descOfEquipmentField;
            }
            set {
                this.descOfEquipmentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class OtherTitledCollateral : TitledCollateralBase {
        
        private string bodyStyleField;
        
        private string serialNumberField;
        
        /// <remarks/>
        public string bodyStyle {
            get {
                return this.bodyStyleField;
            }
            set {
                this.bodyStyleField = value;
            }
        }
        
        /// <remarks/>
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class BoatCollateral : TitledCollateralBase {
        
        private string bodyStyleField;
        
        private string serialNumberField;
        
        private string marinaPortField;
        
        private string descOfEnginesEquipField;
        
        private string descOfLogBooksField;
        
        /// <remarks/>
        public string bodyStyle {
            get {
                return this.bodyStyleField;
            }
            set {
                this.bodyStyleField = value;
            }
        }
        
        /// <remarks/>
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string marinaPort {
            get {
                return this.marinaPortField;
            }
            set {
                this.marinaPortField = value;
            }
        }
        
        /// <remarks/>
        public string descOfEnginesEquip {
            get {
                return this.descOfEnginesEquipField;
            }
            set {
                this.descOfEnginesEquipField = value;
            }
        }
        
        /// <remarks/>
        public string descOfLogBooks {
            get {
                return this.descOfLogBooksField;
            }
            set {
                this.descOfLogBooksField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class TrailerCollateral : TitledCollateralBase {
        
        private string serialNumberField;
        
        /// <remarks/>
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class ShipCollateral : TitledCollateralBase {
        
        private string nameOfVesselField;
        
        private string officialNumberField;
        
        private string marinaPortField;
        
        private string grossTonnageField;
        
        private string netTonnageField;
        
        /// <remarks/>
        public string nameOfVessel {
            get {
                return this.nameOfVesselField;
            }
            set {
                this.nameOfVesselField = value;
            }
        }
        
        /// <remarks/>
        public string officialNumber {
            get {
                return this.officialNumberField;
            }
            set {
                this.officialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string marinaPort {
            get {
                return this.marinaPortField;
            }
            set {
                this.marinaPortField = value;
            }
        }
        
        /// <remarks/>
        public string grossTonnage {
            get {
                return this.grossTonnageField;
            }
            set {
                this.grossTonnageField = value;
            }
        }
        
        /// <remarks/>
        public string netTonnage {
            get {
                return this.netTonnageField;
            }
            set {
                this.netTonnageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class AircraftCollateral : TitledCollateralBase {
        
        private string serialNumberField;
        
        private string faaRegistrationNumberField;
        
        private bool inspectionReportYNField;
        
        private bool inspectionReportYNFieldSpecified;
        
        private bool faaCoverLetterYNField;
        
        private bool faaCoverLetterYNFieldSpecified;
        
        private bool aircraftForCommercialUseField;
        
        private bool aircraftForCommercialUseFieldSpecified;
        
        private string descAvionicsEnginesField;
        
        private string descOfLogBooksField;
        
        private string airportHomeBaseField;
        
        private string hoursField;
        
        /// <remarks/>
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string faaRegistrationNumber {
            get {
                return this.faaRegistrationNumberField;
            }
            set {
                this.faaRegistrationNumberField = value;
            }
        }
        
        /// <remarks/>
        public bool inspectionReportYN {
            get {
                return this.inspectionReportYNField;
            }
            set {
                this.inspectionReportYNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inspectionReportYNSpecified {
            get {
                return this.inspectionReportYNFieldSpecified;
            }
            set {
                this.inspectionReportYNFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool faaCoverLetterYN {
            get {
                return this.faaCoverLetterYNField;
            }
            set {
                this.faaCoverLetterYNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool faaCoverLetterYNSpecified {
            get {
                return this.faaCoverLetterYNFieldSpecified;
            }
            set {
                this.faaCoverLetterYNFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool aircraftForCommercialUse {
            get {
                return this.aircraftForCommercialUseField;
            }
            set {
                this.aircraftForCommercialUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aircraftForCommercialUseSpecified {
            get {
                return this.aircraftForCommercialUseFieldSpecified;
            }
            set {
                this.aircraftForCommercialUseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string descAvionicsEngines {
            get {
                return this.descAvionicsEnginesField;
            }
            set {
                this.descAvionicsEnginesField = value;
            }
        }
        
        /// <remarks/>
        public string descOfLogBooks {
            get {
                return this.descOfLogBooksField;
            }
            set {
                this.descOfLogBooksField = value;
            }
        }
        
        /// <remarks/>
        public string airportHomeBase {
            get {
                return this.airportHomeBaseField;
            }
            set {
                this.airportHomeBaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class MotorVehicleCollateral : TitledCollateralBase {
        
        private string vehicleIdentificationNumberField;
        
        private string mileageField;
        
        private string licensePlateNumberField;
        
        private string licensePlateStateField;
        
        private System.DateTime licensePlateExpirationField;
        
        private bool licensePlateExpirationFieldSpecified;
        
        private string titleNumberField;
        
        private string titleStateField;
        
        /// <remarks/>
        public string vehicleIdentificationNumber {
            get {
                return this.vehicleIdentificationNumberField;
            }
            set {
                this.vehicleIdentificationNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
        
        /// <remarks/>
        public string licensePlateNumber {
            get {
                return this.licensePlateNumberField;
            }
            set {
                this.licensePlateNumberField = value;
            }
        }
        
        /// <remarks/>
        public string licensePlateState {
            get {
                return this.licensePlateStateField;
            }
            set {
                this.licensePlateStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime licensePlateExpiration {
            get {
                return this.licensePlateExpirationField;
            }
            set {
                this.licensePlateExpirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool licensePlateExpirationSpecified {
            get {
                return this.licensePlateExpirationFieldSpecified;
            }
            set {
                this.licensePlateExpirationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string titleNumber {
            get {
                return this.titleNumberField;
            }
            set {
                this.titleNumberField = value;
            }
        }
        
        /// <remarks/>
        public string titleState {
            get {
                return this.titleStateField;
            }
            set {
                this.titleStateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class Collateral {
        
        private CollateralBase itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("aircraftCollateral", typeof(AircraftCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("boatCollateral", typeof(BoatCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("letterOfCreditCollateral", typeof(LetterOfCreditCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("mobileHomeCollateral", typeof(MobileHomeCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("motorVehicleCollateral", typeof(MotorVehicleCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("otherTitledCollateral", typeof(OtherTitledCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("realEstateCollateral", typeof(RealEstateCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("savingsCDCollateral", typeof(SavingsCDCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("securitiesCollateral", typeof(SecuritiesCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("shipCollateral", typeof(ShipCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("trailerCollateral", typeof(TrailerCollateral))]
        [System.Xml.Serialization.XmlElementAttribute("uccCollateral", typeof(UccCollateral))]
        public CollateralBase Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class InsuranceAddOn {
        
        private string insuranceAddOnIdField;
        
        private LoanInsuranceType insuranceTypeField;
        
        private bool insuranceTypeFieldSpecified;
        
        private string otherInsuranceTypeField;
        
        private Money insuranceMaximumField;
        
        private Money insuranceAmountField;
        
        private Money insuranceFeeAmountField;
        
        private string insuranceSubTypeField;
        
        private string insuranceShortDescriptionField;
        
        private string insuranceDescriptionField;
        
        private bool insurancePostingConsolidationFlagField;
        
        private bool insurancePostingConsolidationFlagFieldSpecified;
        
        private System.DateTime primaryInsuredDateOfBirthField;
        
        private bool primaryInsuredDateOfBirthFieldSpecified;
        
        private System.DateTime secondInsuredDateOfBirthField;
        
        private bool secondInsuredDateOfBirthFieldSpecified;
        
        /// <remarks/>
        public string insuranceAddOnId {
            get {
                return this.insuranceAddOnIdField;
            }
            set {
                this.insuranceAddOnIdField = value;
            }
        }
        
        /// <remarks/>
        public LoanInsuranceType insuranceType {
            get {
                return this.insuranceTypeField;
            }
            set {
                this.insuranceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insuranceTypeSpecified {
            get {
                return this.insuranceTypeFieldSpecified;
            }
            set {
                this.insuranceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string otherInsuranceType {
            get {
                return this.otherInsuranceTypeField;
            }
            set {
                this.otherInsuranceTypeField = value;
            }
        }
        
        /// <remarks/>
        public Money insuranceMaximum {
            get {
                return this.insuranceMaximumField;
            }
            set {
                this.insuranceMaximumField = value;
            }
        }
        
        /// <remarks/>
        public Money insuranceAmount {
            get {
                return this.insuranceAmountField;
            }
            set {
                this.insuranceAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money insuranceFeeAmount {
            get {
                return this.insuranceFeeAmountField;
            }
            set {
                this.insuranceFeeAmountField = value;
            }
        }
        
        /// <remarks/>
        public string insuranceSubType {
            get {
                return this.insuranceSubTypeField;
            }
            set {
                this.insuranceSubTypeField = value;
            }
        }
        
        /// <remarks/>
        public string insuranceShortDescription {
            get {
                return this.insuranceShortDescriptionField;
            }
            set {
                this.insuranceShortDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string insuranceDescription {
            get {
                return this.insuranceDescriptionField;
            }
            set {
                this.insuranceDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public bool insurancePostingConsolidationFlag {
            get {
                return this.insurancePostingConsolidationFlagField;
            }
            set {
                this.insurancePostingConsolidationFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insurancePostingConsolidationFlagSpecified {
            get {
                return this.insurancePostingConsolidationFlagFieldSpecified;
            }
            set {
                this.insurancePostingConsolidationFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime primaryInsuredDateOfBirth {
            get {
                return this.primaryInsuredDateOfBirthField;
            }
            set {
                this.primaryInsuredDateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool primaryInsuredDateOfBirthSpecified {
            get {
                return this.primaryInsuredDateOfBirthFieldSpecified;
            }
            set {
                this.primaryInsuredDateOfBirthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime secondInsuredDateOfBirth {
            get {
                return this.secondInsuredDateOfBirthField;
            }
            set {
                this.secondInsuredDateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondInsuredDateOfBirthSpecified {
            get {
                return this.secondInsuredDateOfBirthFieldSpecified;
            }
            set {
                this.secondInsuredDateOfBirthFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanInsuranceType {
        
        /// <remarks/>
        AccidentalDeathAndDismemberment,
        
        /// <remarks/>
        DebtCancellation,
        
        /// <remarks/>
        Disability,
        
        /// <remarks/>
        Gap,
        
        /// <remarks/>
        Life,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        PaymentProtection,
        
        /// <remarks/>
        Mbi,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LateChargeFee {
        
        private string lateChargeFormulaCodeField;
        
        private string numberOfLateChargeGraceDaysField;
        
        private bool addLateChargeToStandardPaymentField;
        
        private bool addLateChargeToStandardPaymentFieldSpecified;
        
        private decimal lateChargePercentageRateField;
        
        private bool lateChargePercentageRateFieldSpecified;
        
        /// <remarks/>
        public string lateChargeFormulaCode {
            get {
                return this.lateChargeFormulaCodeField;
            }
            set {
                this.lateChargeFormulaCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string numberOfLateChargeGraceDays {
            get {
                return this.numberOfLateChargeGraceDaysField;
            }
            set {
                this.numberOfLateChargeGraceDaysField = value;
            }
        }
        
        /// <remarks/>
        public bool addLateChargeToStandardPayment {
            get {
                return this.addLateChargeToStandardPaymentField;
            }
            set {
                this.addLateChargeToStandardPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool addLateChargeToStandardPaymentSpecified {
            get {
                return this.addLateChargeToStandardPaymentFieldSpecified;
            }
            set {
                this.addLateChargeToStandardPaymentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal lateChargePercentageRate {
            get {
                return this.lateChargePercentageRateField;
            }
            set {
                this.lateChargePercentageRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lateChargePercentageRateSpecified {
            get {
                return this.lateChargePercentageRateFieldSpecified;
            }
            set {
                this.lateChargePercentageRateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LoanFee {
        
        private string loanFeeIdField;
        
        private LateChargeFee lateChargeFeeField;
        
        private Money feeAmountField;
        
        private bool includeEscrowInLateChargeField;
        
        private bool includeEscrowInLateChargeFieldSpecified;
        
        private string feeCodeField;
        
        private Money feeMinField;
        
        private Money feeMaxField;
        
        private Money prePaidAmountField;
        
        private Money financedFeeAmountField;
        
        private Money unamortizedFeesField;
        
        private string feeDescriptionField;
        
        /// <remarks/>
        public string loanFeeId {
            get {
                return this.loanFeeIdField;
            }
            set {
                this.loanFeeIdField = value;
            }
        }
        
        /// <remarks/>
        public LateChargeFee lateChargeFee {
            get {
                return this.lateChargeFeeField;
            }
            set {
                this.lateChargeFeeField = value;
            }
        }
        
        /// <remarks/>
        public Money feeAmount {
            get {
                return this.feeAmountField;
            }
            set {
                this.feeAmountField = value;
            }
        }
        
        /// <remarks/>
        public bool includeEscrowInLateCharge {
            get {
                return this.includeEscrowInLateChargeField;
            }
            set {
                this.includeEscrowInLateChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeEscrowInLateChargeSpecified {
            get {
                return this.includeEscrowInLateChargeFieldSpecified;
            }
            set {
                this.includeEscrowInLateChargeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string feeCode {
            get {
                return this.feeCodeField;
            }
            set {
                this.feeCodeField = value;
            }
        }
        
        /// <remarks/>
        public Money feeMin {
            get {
                return this.feeMinField;
            }
            set {
                this.feeMinField = value;
            }
        }
        
        /// <remarks/>
        public Money feeMax {
            get {
                return this.feeMaxField;
            }
            set {
                this.feeMaxField = value;
            }
        }
        
        /// <remarks/>
        public Money prePaidAmount {
            get {
                return this.prePaidAmountField;
            }
            set {
                this.prePaidAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money financedFeeAmount {
            get {
                return this.financedFeeAmountField;
            }
            set {
                this.financedFeeAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money unamortizedFees {
            get {
                return this.unamortizedFeesField;
            }
            set {
                this.unamortizedFeesField = value;
            }
        }
        
        /// <remarks/>
        public string feeDescription {
            get {
                return this.feeDescriptionField;
            }
            set {
                this.feeDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class PaymentOption {
        
        private string calculationCodeField;
        
        private PaymentOptionType typeField;
        
        private bool typeFieldSpecified;
        
        private string calculationMethodField;
        
        private decimal calculationPercentageField;
        
        private bool calculationPercentageFieldSpecified;
        
        private string paymentApplicationOrderCodeField;
        
        private LoanPaymentFrequencyType frequencyField;
        
        private bool frequencyFieldSpecified;
        
        private string numberOfAnnualPaymentsField;
        
        private string adjustmentMethodField;
        
        private bool isRoundPaymentField;
        
        private bool isRoundPaymentFieldSpecified;
        
        private Money paymentAmountField;
        
        private System.DateTime dueDateField;
        
        private bool dueDateFieldSpecified;
        
        private System.DateTime firstPaymentDueDateField;
        
        private bool firstPaymentDueDateFieldSpecified;
        
        private Money minimumPaymentAmountField;
        
        private Money latePaymentAmountField;
        
        private Money finalPaymentAmountField;
        
        private System.DateTime maturityDateField;
        
        private bool maturityDateFieldSpecified;
        
        private string paymentDayField;
        
        private LoanPaymentMethodType paymentMethodField;
        
        private bool paymentMethodFieldSpecified;
        
        private string otherPaymentMethodField;
        
        private string couponCodeField;
        
        private Money amountIncludingPrincipalAndInterestField;
        
        /// <remarks/>
        public string calculationCode {
            get {
                return this.calculationCodeField;
            }
            set {
                this.calculationCodeField = value;
            }
        }
        
        /// <remarks/>
        public PaymentOptionType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string calculationMethod {
            get {
                return this.calculationMethodField;
            }
            set {
                this.calculationMethodField = value;
            }
        }
        
        /// <remarks/>
        public decimal calculationPercentage {
            get {
                return this.calculationPercentageField;
            }
            set {
                this.calculationPercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculationPercentageSpecified {
            get {
                return this.calculationPercentageFieldSpecified;
            }
            set {
                this.calculationPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string paymentApplicationOrderCode {
            get {
                return this.paymentApplicationOrderCodeField;
            }
            set {
                this.paymentApplicationOrderCodeField = value;
            }
        }
        
        /// <remarks/>
        public LoanPaymentFrequencyType frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool frequencySpecified {
            get {
                return this.frequencyFieldSpecified;
            }
            set {
                this.frequencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string numberOfAnnualPayments {
            get {
                return this.numberOfAnnualPaymentsField;
            }
            set {
                this.numberOfAnnualPaymentsField = value;
            }
        }
        
        /// <remarks/>
        public string adjustmentMethod {
            get {
                return this.adjustmentMethodField;
            }
            set {
                this.adjustmentMethodField = value;
            }
        }
        
        /// <remarks/>
        public bool isRoundPayment {
            get {
                return this.isRoundPaymentField;
            }
            set {
                this.isRoundPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRoundPaymentSpecified {
            get {
                return this.isRoundPaymentFieldSpecified;
            }
            set {
                this.isRoundPaymentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money paymentAmount {
            get {
                return this.paymentAmountField;
            }
            set {
                this.paymentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime firstPaymentDueDate {
            get {
                return this.firstPaymentDueDateField;
            }
            set {
                this.firstPaymentDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstPaymentDueDateSpecified {
            get {
                return this.firstPaymentDueDateFieldSpecified;
            }
            set {
                this.firstPaymentDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money minimumPaymentAmount {
            get {
                return this.minimumPaymentAmountField;
            }
            set {
                this.minimumPaymentAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money latePaymentAmount {
            get {
                return this.latePaymentAmountField;
            }
            set {
                this.latePaymentAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money finalPaymentAmount {
            get {
                return this.finalPaymentAmountField;
            }
            set {
                this.finalPaymentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityDate {
            get {
                return this.maturityDateField;
            }
            set {
                this.maturityDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityDateSpecified {
            get {
                return this.maturityDateFieldSpecified;
            }
            set {
                this.maturityDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string paymentDay {
            get {
                return this.paymentDayField;
            }
            set {
                this.paymentDayField = value;
            }
        }
        
        /// <remarks/>
        public LoanPaymentMethodType paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentMethodSpecified {
            get {
                return this.paymentMethodFieldSpecified;
            }
            set {
                this.paymentMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string otherPaymentMethod {
            get {
                return this.otherPaymentMethodField;
            }
            set {
                this.otherPaymentMethodField = value;
            }
        }
        
        /// <remarks/>
        public string couponCode {
            get {
                return this.couponCodeField;
            }
            set {
                this.couponCodeField = value;
            }
        }
        
        /// <remarks/>
        public Money amountIncludingPrincipalAndInterest {
            get {
                return this.amountIncludingPrincipalAndInterestField;
            }
            set {
                this.amountIncludingPrincipalAndInterestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum PaymentOptionType {
        
        /// <remarks/>
        Fixed,
        
        /// <remarks/>
        LevelPayment,
        
        /// <remarks/>
        LevelPrincipal,
        
        /// <remarks/>
        Variable,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanPaymentFrequencyType {
        
        /// <remarks/>
        AmortizedSchedule,
        
        /// <remarks/>
        Annual,
        
        /// <remarks/>
        Bimonthly,
        
        /// <remarks/>
        Biweekly,
        
        /// <remarks/>
        BiweeklySkipFirst,
        
        /// <remarks/>
        BiweeklySkipLast,
        
        /// <remarks/>
        Immediate,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        Quarterly,
        
        /// <remarks/>
        SemiAnnual,
        
        /// <remarks/>
        SemiMonthly,
        
        /// <remarks/>
        SinglePayment,
        
        /// <remarks/>
        Weekly,
        
        /// <remarks/>
        WeeklySkipFirst,
        
        /// <remarks/>
        WeeklySkipLast,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanPaymentMethodType {
        
        /// <remarks/>
        AutomaticDebit,
        
        /// <remarks/>
        AutomaticTransfer,
        
        /// <remarks/>
        BillPay,
        
        /// <remarks/>
        Cash,
        
        /// <remarks/>
        Check,
        
        /// <remarks/>
        Counter,
        
        /// <remarks/>
        Coupon,
        
        /// <remarks/>
        DebitCard,
        
        /// <remarks/>
        Distribution,
        
        /// <remarks/>
        DistributionAfterDue,
        
        /// <remarks/>
        Electronic,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Payroll,
        
        /// <remarks/>
        PayrollAfterDue,
        
        /// <remarks/>
        Phone,
        
        /// <remarks/>
        ScheduledAutomaticTransfer,
        
        /// <remarks/>
        ScheduledAutomaticTransferAfterDue,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LoanInterestRateDetail {
        
        private decimal originalEffectiveRateField;
        
        private bool originalEffectiveRateFieldSpecified;
        
        private decimal rateDiscountPercentageField;
        
        private bool rateDiscountPercentageFieldSpecified;
        
        private string rateDiscountReasonCodeField;
        
        private decimal relationshipRateDiscountPercentageField;
        
        private bool relationshipRateDiscountPercentageFieldSpecified;
        
        private string relationshipRateDiscountReasonCodeField;
        
        private decimal annualPercentageRateField;
        
        private bool annualPercentageRateFieldSpecified;
        
        private decimal rateField;
        
        private bool rateFieldSpecified;
        
        private bool isSplitRateField;
        
        private bool isSplitRateFieldSpecified;
        
        private string splitRateCodeField;
        
        private decimal rateMaximumField;
        
        private bool rateMaximumFieldSpecified;
        
        private decimal rateMinimumField;
        
        private bool rateMinimumFieldSpecified;
        
        private decimal ratePercentageChangeField;
        
        private bool ratePercentageChangeFieldSpecified;
        
        private InterestRateMarginType marginField;
        
        private bool marginFieldSpecified;
        
        private decimal baseRateIndexField;
        
        private bool baseRateIndexFieldSpecified;
        
        private decimal rateMarginPercentageField;
        
        private bool rateMarginPercentageFieldSpecified;
        
        private decimal maximumFirstRateChangeIncreaseField;
        
        private bool maximumFirstRateChangeIncreaseFieldSpecified;
        
        private decimal maximumFirstRateChangeDecreaseField;
        
        private bool maximumFirstRateChangeDecreaseFieldSpecified;
        
        private decimal maximumPercentageAdjustableRateChangeIncreaseField;
        
        private bool maximumPercentageAdjustableRateChangeIncreaseFieldSpecified;
        
        private decimal maxPercentageAdjustableRateChangeDecreaseField;
        
        private bool maxPercentageAdjustableRateChangeDecreaseFieldSpecified;
        
        private decimal maxAnnualRateChangeIncreaseField;
        
        private bool maxAnnualRateChangeIncreaseFieldSpecified;
        
        private decimal maxAnnualRateChangeDecreaseField;
        
        private bool maxAnnualRateChangeDecreaseFieldSpecified;
        
        private bool isRateMarginAboveIndexField;
        
        private bool isRateMarginAboveIndexFieldSpecified;
        
        private decimal marginRiskRateField;
        
        private bool marginRiskRateFieldSpecified;
        
        private System.DateTime scheduledRateChangeDateField;
        
        private bool scheduledRateChangeDateFieldSpecified;
        
        private Money periodicCapAmountField;
        
        private decimal periodicCapStartRateField;
        
        private bool periodicCapStartRateFieldSpecified;
        
        private System.DateTime periodicCapStartDateField;
        
        private bool periodicCapStartDateFieldSpecified;
        
        private PeriodicCapFrequencyType periodicCapFrequencyField;
        
        private bool periodicCapFrequencyFieldSpecified;
        
        private string periodicCapFrequencyValueField;
        
        private Money splitRateBalanceField;
        
        /// <remarks/>
        public decimal originalEffectiveRate {
            get {
                return this.originalEffectiveRateField;
            }
            set {
                this.originalEffectiveRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originalEffectiveRateSpecified {
            get {
                return this.originalEffectiveRateFieldSpecified;
            }
            set {
                this.originalEffectiveRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal rateDiscountPercentage {
            get {
                return this.rateDiscountPercentageField;
            }
            set {
                this.rateDiscountPercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateDiscountPercentageSpecified {
            get {
                return this.rateDiscountPercentageFieldSpecified;
            }
            set {
                this.rateDiscountPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string rateDiscountReasonCode {
            get {
                return this.rateDiscountReasonCodeField;
            }
            set {
                this.rateDiscountReasonCodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal relationshipRateDiscountPercentage {
            get {
                return this.relationshipRateDiscountPercentageField;
            }
            set {
                this.relationshipRateDiscountPercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relationshipRateDiscountPercentageSpecified {
            get {
                return this.relationshipRateDiscountPercentageFieldSpecified;
            }
            set {
                this.relationshipRateDiscountPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string relationshipRateDiscountReasonCode {
            get {
                return this.relationshipRateDiscountReasonCodeField;
            }
            set {
                this.relationshipRateDiscountReasonCodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal annualPercentageRate {
            get {
                return this.annualPercentageRateField;
            }
            set {
                this.annualPercentageRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool annualPercentageRateSpecified {
            get {
                return this.annualPercentageRateFieldSpecified;
            }
            set {
                this.annualPercentageRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isSplitRate {
            get {
                return this.isSplitRateField;
            }
            set {
                this.isSplitRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSplitRateSpecified {
            get {
                return this.isSplitRateFieldSpecified;
            }
            set {
                this.isSplitRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string splitRateCode {
            get {
                return this.splitRateCodeField;
            }
            set {
                this.splitRateCodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal rateMaximum {
            get {
                return this.rateMaximumField;
            }
            set {
                this.rateMaximumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateMaximumSpecified {
            get {
                return this.rateMaximumFieldSpecified;
            }
            set {
                this.rateMaximumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal rateMinimum {
            get {
                return this.rateMinimumField;
            }
            set {
                this.rateMinimumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateMinimumSpecified {
            get {
                return this.rateMinimumFieldSpecified;
            }
            set {
                this.rateMinimumFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal ratePercentageChange {
            get {
                return this.ratePercentageChangeField;
            }
            set {
                this.ratePercentageChangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ratePercentageChangeSpecified {
            get {
                return this.ratePercentageChangeFieldSpecified;
            }
            set {
                this.ratePercentageChangeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public InterestRateMarginType margin {
            get {
                return this.marginField;
            }
            set {
                this.marginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool marginSpecified {
            get {
                return this.marginFieldSpecified;
            }
            set {
                this.marginFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal baseRateIndex {
            get {
                return this.baseRateIndexField;
            }
            set {
                this.baseRateIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseRateIndexSpecified {
            get {
                return this.baseRateIndexFieldSpecified;
            }
            set {
                this.baseRateIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal rateMarginPercentage {
            get {
                return this.rateMarginPercentageField;
            }
            set {
                this.rateMarginPercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateMarginPercentageSpecified {
            get {
                return this.rateMarginPercentageFieldSpecified;
            }
            set {
                this.rateMarginPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maximumFirstRateChangeIncrease {
            get {
                return this.maximumFirstRateChangeIncreaseField;
            }
            set {
                this.maximumFirstRateChangeIncreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumFirstRateChangeIncreaseSpecified {
            get {
                return this.maximumFirstRateChangeIncreaseFieldSpecified;
            }
            set {
                this.maximumFirstRateChangeIncreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maximumFirstRateChangeDecrease {
            get {
                return this.maximumFirstRateChangeDecreaseField;
            }
            set {
                this.maximumFirstRateChangeDecreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumFirstRateChangeDecreaseSpecified {
            get {
                return this.maximumFirstRateChangeDecreaseFieldSpecified;
            }
            set {
                this.maximumFirstRateChangeDecreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maximumPercentageAdjustableRateChangeIncrease {
            get {
                return this.maximumPercentageAdjustableRateChangeIncreaseField;
            }
            set {
                this.maximumPercentageAdjustableRateChangeIncreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumPercentageAdjustableRateChangeIncreaseSpecified {
            get {
                return this.maximumPercentageAdjustableRateChangeIncreaseFieldSpecified;
            }
            set {
                this.maximumPercentageAdjustableRateChangeIncreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maxPercentageAdjustableRateChangeDecrease {
            get {
                return this.maxPercentageAdjustableRateChangeDecreaseField;
            }
            set {
                this.maxPercentageAdjustableRateChangeDecreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxPercentageAdjustableRateChangeDecreaseSpecified {
            get {
                return this.maxPercentageAdjustableRateChangeDecreaseFieldSpecified;
            }
            set {
                this.maxPercentageAdjustableRateChangeDecreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maxAnnualRateChangeIncrease {
            get {
                return this.maxAnnualRateChangeIncreaseField;
            }
            set {
                this.maxAnnualRateChangeIncreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxAnnualRateChangeIncreaseSpecified {
            get {
                return this.maxAnnualRateChangeIncreaseFieldSpecified;
            }
            set {
                this.maxAnnualRateChangeIncreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal maxAnnualRateChangeDecrease {
            get {
                return this.maxAnnualRateChangeDecreaseField;
            }
            set {
                this.maxAnnualRateChangeDecreaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxAnnualRateChangeDecreaseSpecified {
            get {
                return this.maxAnnualRateChangeDecreaseFieldSpecified;
            }
            set {
                this.maxAnnualRateChangeDecreaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isRateMarginAboveIndex {
            get {
                return this.isRateMarginAboveIndexField;
            }
            set {
                this.isRateMarginAboveIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRateMarginAboveIndexSpecified {
            get {
                return this.isRateMarginAboveIndexFieldSpecified;
            }
            set {
                this.isRateMarginAboveIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal marginRiskRate {
            get {
                return this.marginRiskRateField;
            }
            set {
                this.marginRiskRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool marginRiskRateSpecified {
            get {
                return this.marginRiskRateFieldSpecified;
            }
            set {
                this.marginRiskRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime scheduledRateChangeDate {
            get {
                return this.scheduledRateChangeDateField;
            }
            set {
                this.scheduledRateChangeDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduledRateChangeDateSpecified {
            get {
                return this.scheduledRateChangeDateFieldSpecified;
            }
            set {
                this.scheduledRateChangeDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money periodicCapAmount {
            get {
                return this.periodicCapAmountField;
            }
            set {
                this.periodicCapAmountField = value;
            }
        }
        
        /// <remarks/>
        public decimal periodicCapStartRate {
            get {
                return this.periodicCapStartRateField;
            }
            set {
                this.periodicCapStartRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodicCapStartRateSpecified {
            get {
                return this.periodicCapStartRateFieldSpecified;
            }
            set {
                this.periodicCapStartRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime periodicCapStartDate {
            get {
                return this.periodicCapStartDateField;
            }
            set {
                this.periodicCapStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodicCapStartDateSpecified {
            get {
                return this.periodicCapStartDateFieldSpecified;
            }
            set {
                this.periodicCapStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PeriodicCapFrequencyType periodicCapFrequency {
            get {
                return this.periodicCapFrequencyField;
            }
            set {
                this.periodicCapFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodicCapFrequencySpecified {
            get {
                return this.periodicCapFrequencyFieldSpecified;
            }
            set {
                this.periodicCapFrequencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string periodicCapFrequencyValue {
            get {
                return this.periodicCapFrequencyValueField;
            }
            set {
                this.periodicCapFrequencyValueField = value;
            }
        }
        
        /// <remarks/>
        public Money splitRateBalance {
            get {
                return this.splitRateBalanceField;
            }
            set {
                this.splitRateBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum InterestRateMarginType {
        
        /// <remarks/>
        Percentage,
        
        /// <remarks/>
        Points,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum PeriodicCapFrequencyType {
        
        /// <remarks/>
        Annual,
        
        /// <remarks/>
        Quarterly,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Semi-Annual")]
        SemiAnnual,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CreditReport.xsd")]
    public partial class CreditReport {
        
        private string creditReportIdField;
        
        private System.DateTime creditReportDateField;
        
        private bool creditReportDateFieldSpecified;
        
        private string creditSourceField;
        
        private string reportTypeField;
        
        private string scoreTypeField;
        
        private string partyIdField;
        
        private string taxIdField;
        
        private string creditScoreField;
        
        private string creditTierField;
        
        private string reportDataField;
        
        /// <remarks/>
        public string creditReportId {
            get {
                return this.creditReportIdField;
            }
            set {
                this.creditReportIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime creditReportDate {
            get {
                return this.creditReportDateField;
            }
            set {
                this.creditReportDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditReportDateSpecified {
            get {
                return this.creditReportDateFieldSpecified;
            }
            set {
                this.creditReportDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string creditSource {
            get {
                return this.creditSourceField;
            }
            set {
                this.creditSourceField = value;
            }
        }
        
        /// <remarks/>
        public string reportType {
            get {
                return this.reportTypeField;
            }
            set {
                this.reportTypeField = value;
            }
        }
        
        /// <remarks/>
        public string scoreType {
            get {
                return this.scoreTypeField;
            }
            set {
                this.scoreTypeField = value;
            }
        }
        
        /// <remarks/>
        public string partyId {
            get {
                return this.partyIdField;
            }
            set {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string taxId {
            get {
                return this.taxIdField;
            }
            set {
                this.taxIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string creditScore {
            get {
                return this.creditScoreField;
            }
            set {
                this.creditScoreField = value;
            }
        }
        
        /// <remarks/>
        public string creditTier {
            get {
                return this.creditTierField;
            }
            set {
                this.creditTierField = value;
            }
        }
        
        /// <remarks/>
        public string reportData {
            get {
                return this.reportDataField;
            }
            set {
                this.reportDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class CollateralGrantor {
        
        private Authority authorityField;
        
        public CollateralGrantor() {
            this.authorityField = Authority.Unauthorized;
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum Authority {
        
        /// <remarks/>
        Authorized,
        
        /// <remarks/>
        Unauthorized,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Payee {
        
        private PayeeQualifier qualifierField;
        
        private string authorityField;
        
        public Payee() {
            this.authorityField = "DIVIDEND_ONLY";
        }
        
        /// <remarks/>
        public PayeeQualifier qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public string authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum PayeeQualifier {
        
        /// <remarks/>
        Dividend,
        
        /// <remarks/>
        Maturity,
        
        /// <remarks/>
        DividendAndMaturity,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class Borrower {
        
        private PrimaryJoint qualifierField;
        
        private Authority authorityField;
        
        /// <remarks/>
        public PrimaryJoint qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum PrimaryJoint {
        
        /// <remarks/>
        Primary,
        
        /// <remarks/>
        Joint,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LoanPartyRelationshipType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("agent", typeof(Agent))]
        [System.Xml.Serialization.XmlElementAttribute("borrower", typeof(Borrower))]
        [System.Xml.Serialization.XmlElementAttribute("collateralGrantor", typeof(CollateralGrantor))]
        [System.Xml.Serialization.XmlElementAttribute("guarantor", typeof(Guarantor))]
        [System.Xml.Serialization.XmlElementAttribute("payee", typeof(Payee))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Agent {
        
        private AgentQualifier qualifierField;
        
        private Authority authorityField;
        
        public Agent() {
            this.authorityField = Authority.Authorized;
        }
        
        /// <remarks/>
        public AgentQualifier qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum AgentQualifier {
        
        /// <remarks/>
        Custodian,
        
        /// <remarks/>
        Trustee,
        
        /// <remarks/>
        PowerOfAttorney,
        
        /// <remarks/>
        Representative,
        
        /// <remarks/>
        CtrTransactor,
        
        /// <remarks/>
        AttorneyTrust,
        
        /// <remarks/>
        ResponsibleIndividual,
        
        /// <remarks/>
        Signer,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Guarantor {
        
        private Authority authorityField;
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LoanParty {
        
        private string loanPartyIdField;
        
        private LoanPartyRelationshipType loanPartyRelationshipTypeField;
        
        private string[] contactIdListField;
        
        /// <remarks/>
        public string loanPartyId {
            get {
                return this.loanPartyIdField;
            }
            set {
                this.loanPartyIdField = value;
            }
        }
        
        /// <remarks/>
        public LoanPartyRelationshipType loanPartyRelationshipType {
            get {
                return this.loanPartyRelationshipTypeField;
            }
            set {
                this.loanPartyRelationshipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class SafeDepositBoxUser {
        
        private SafeDepositBoxUserQualifier qualifierField;
        
        private Authority authorityField;
        
        public SafeDepositBoxUser() {
            this.authorityField = Authority.Unauthorized;
        }
        
        /// <remarks/>
        public SafeDepositBoxUserQualifier qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum SafeDepositBoxUserQualifier {
        
        /// <remarks/>
        Colessee,
        
        /// <remarks/>
        Deputy,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Beneficiary {
        
        private BeneficiaryQualifier qualifierField;
        
        private Authority authorityField;
        
        private decimal beneficiaryPercentField;
        
        private BeneficiaryTypes beneficiaryTypesField;
        
        public Beneficiary() {
            this.authorityField = Authority.Unauthorized;
            this.beneficiaryPercentField = ((decimal)(1.00m));
        }
        
        /// <remarks/>
        public BeneficiaryQualifier qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
        
        /// <remarks/>
        public decimal beneficiaryPercent {
            get {
                return this.beneficiaryPercentField;
            }
            set {
                this.beneficiaryPercentField = value;
            }
        }
        
        /// <remarks/>
        public BeneficiaryTypes beneficiaryTypes {
            get {
                return this.beneficiaryTypesField;
            }
            set {
                this.beneficiaryTypesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum BeneficiaryQualifier {
        
        /// <remarks/>
        Standard,
        
        /// <remarks/>
        Education,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public enum BeneficiaryTypes {
        
        /// <remarks/>
        Primary,
        
        /// <remarks/>
        Contingent,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Holder {
        
        private PrimaryJoint qualifierField;
        
        private Authority authorityField;
        
        /// <remarks/>
        public PrimaryJoint qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
        
        /// <remarks/>
        public Authority authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public partial class DepositPartyRelationshipType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("agent", typeof(Agent))]
        [System.Xml.Serialization.XmlElementAttribute("beneficiary", typeof(Beneficiary))]
        [System.Xml.Serialization.XmlElementAttribute("guarantor", typeof(Guarantor))]
        [System.Xml.Serialization.XmlElementAttribute("holder", typeof(Holder))]
        [System.Xml.Serialization.XmlElementAttribute("safeDepositBoxUser", typeof(SafeDepositBoxUser))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public partial class DepositParty {
        
        private string depositPartyIdField;
        
        private DepositPartyRelationshipType depositPartyRelationshipTypeField;
        
        private bool ssnOverrideField;
        
        private string[] contactIdListField;
        
        public DepositParty() {
            this.ssnOverrideField = false;
        }
        
        /// <remarks/>
        public string depositPartyId {
            get {
                return this.depositPartyIdField;
            }
            set {
                this.depositPartyIdField = value;
            }
        }
        
        /// <remarks/>
        public DepositPartyRelationshipType depositPartyRelationshipType {
            get {
                return this.depositPartyRelationshipTypeField;
            }
            set {
                this.depositPartyRelationshipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ssnOverride {
            get {
                return this.ssnOverrideField;
            }
            set {
                this.ssnOverrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class MortgageMeta {
        
        private decimal interestRateField;
        
        private bool interestRateFieldSpecified;
        
        private Money originalBalanceField;
        
        private System.DateTime maturityDateField;
        
        private bool maturityDateFieldSpecified;
        
        private Money escrowBalanceField;
        
        private Money minimumPaymentField;
        
        private System.DateTime currentDueDateField;
        
        private bool currentDueDateFieldSpecified;
        
        private Money currentPayoffBalanceField;
        
        /// <remarks/>
        public decimal interestRate {
            get {
                return this.interestRateField;
            }
            set {
                this.interestRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestRateSpecified {
            get {
                return this.interestRateFieldSpecified;
            }
            set {
                this.interestRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money originalBalance {
            get {
                return this.originalBalanceField;
            }
            set {
                this.originalBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityDate {
            get {
                return this.maturityDateField;
            }
            set {
                this.maturityDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityDateSpecified {
            get {
                return this.maturityDateFieldSpecified;
            }
            set {
                this.maturityDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money escrowBalance {
            get {
                return this.escrowBalanceField;
            }
            set {
                this.escrowBalanceField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumPayment {
            get {
                return this.minimumPaymentField;
            }
            set {
                this.minimumPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime currentDueDate {
            get {
                return this.currentDueDateField;
            }
            set {
                this.currentDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentDueDateSpecified {
            get {
                return this.currentDueDateFieldSpecified;
            }
            set {
                this.currentDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money currentPayoffBalance {
            get {
                return this.currentPayoffBalanceField;
            }
            set {
                this.currentPayoffBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class LineOfCreditMeta {
        
        private decimal interestRateField;
        
        private bool interestRateFieldSpecified;
        
        private Money originalBalanceField;
        
        private Money creditLimitField;
        
        private Money minimumPaymentField;
        
        private System.DateTime currentDueDateField;
        
        private bool currentDueDateFieldSpecified;
        
        private Money currentPayoffBalanceField;
        
        /// <remarks/>
        public decimal interestRate {
            get {
                return this.interestRateField;
            }
            set {
                this.interestRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestRateSpecified {
            get {
                return this.interestRateFieldSpecified;
            }
            set {
                this.interestRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money originalBalance {
            get {
                return this.originalBalanceField;
            }
            set {
                this.originalBalanceField = value;
            }
        }
        
        /// <remarks/>
        public Money creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumPayment {
            get {
                return this.minimumPaymentField;
            }
            set {
                this.minimumPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime currentDueDate {
            get {
                return this.currentDueDateField;
            }
            set {
                this.currentDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentDueDateSpecified {
            get {
                return this.currentDueDateFieldSpecified;
            }
            set {
                this.currentDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money currentPayoffBalance {
            get {
                return this.currentPayoffBalanceField;
            }
            set {
                this.currentPayoffBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class InvestmentMeta {
        
        private Money startingBalanceField;
        
        private System.DateTime maturityDateField;
        
        private bool maturityDateFieldSpecified;
        
        private decimal interestRateField;
        
        private bool interestRateFieldSpecified;
        
        private string compoundingFrequencyField;
        
        /// <remarks/>
        public Money startingBalance {
            get {
                return this.startingBalanceField;
            }
            set {
                this.startingBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityDate {
            get {
                return this.maturityDateField;
            }
            set {
                this.maturityDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityDateSpecified {
            get {
                return this.maturityDateFieldSpecified;
            }
            set {
                this.maturityDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal interestRate {
            get {
                return this.interestRateField;
            }
            set {
                this.interestRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestRateSpecified {
            get {
                return this.interestRateFieldSpecified;
            }
            set {
                this.interestRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string compoundingFrequency {
            get {
                return this.compoundingFrequencyField;
            }
            set {
                this.compoundingFrequencyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class CreditCardMeta {
        
        private string brandField;
        
        /// <remarks/>
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class CheckingSavingsMeta {
        
        private decimal apyField;
        
        private bool apyFieldSpecified;
        
        private Money minimumBalanceField;
        
        /// <remarks/>
        public decimal apy {
            get {
                return this.apyField;
            }
            set {
                this.apyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apySpecified {
            get {
                return this.apyFieldSpecified;
            }
            set {
                this.apyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money minimumBalance {
            get {
                return this.minimumBalanceField;
            }
            set {
                this.minimumBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class LoanMeta {
        
        private decimal interestRateField;
        
        private bool interestRateFieldSpecified;
        
        private Money creditLimitField;
        
        private decimal annualPercentageRateField;
        
        private bool annualPercentageRateFieldSpecified;
        
        private decimal rateField;
        
        private bool rateFieldSpecified;
        
        private Money minimumPaymentField;
        
        private System.DateTime maturityDateField;
        
        private bool maturityDateFieldSpecified;
        
        private Money originalBalanceField;
        
        private System.DateTime currentDueDateField;
        
        private bool currentDueDateFieldSpecified;
        
        private Money currentPayoffBalanceField;
        
        /// <remarks/>
        public decimal interestRate {
            get {
                return this.interestRateField;
            }
            set {
                this.interestRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestRateSpecified {
            get {
                return this.interestRateFieldSpecified;
            }
            set {
                this.interestRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }
        
        /// <remarks/>
        public decimal annualPercentageRate {
            get {
                return this.annualPercentageRateField;
            }
            set {
                this.annualPercentageRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool annualPercentageRateSpecified {
            get {
                return this.annualPercentageRateFieldSpecified;
            }
            set {
                this.annualPercentageRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money minimumPayment {
            get {
                return this.minimumPaymentField;
            }
            set {
                this.minimumPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityDate {
            get {
                return this.maturityDateField;
            }
            set {
                this.maturityDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityDateSpecified {
            get {
                return this.maturityDateFieldSpecified;
            }
            set {
                this.maturityDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money originalBalance {
            get {
                return this.originalBalanceField;
            }
            set {
                this.originalBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime currentDueDate {
            get {
                return this.currentDueDateField;
            }
            set {
                this.currentDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentDueDateSpecified {
            get {
                return this.currentDueDateFieldSpecified;
            }
            set {
                this.currentDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money currentPayoffBalance {
            get {
                return this.currentPayoffBalanceField;
            }
            set {
                this.currentPayoffBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Meta.xsd")]
    public partial class Meta {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("checkingSavingsMeta", typeof(CheckingSavingsMeta))]
        [System.Xml.Serialization.XmlElementAttribute("creditCardMeta", typeof(CreditCardMeta))]
        [System.Xml.Serialization.XmlElementAttribute("investmentMeta", typeof(InvestmentMeta))]
        [System.Xml.Serialization.XmlElementAttribute("lineOfCreditMeta", typeof(LineOfCreditMeta))]
        [System.Xml.Serialization.XmlElementAttribute("loanMeta", typeof(LoanMeta))]
        [System.Xml.Serialization.XmlElementAttribute("mortgageMeta", typeof(MortgageMeta))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class ValuePair {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum RateType {
        
        /// <remarks/>
        Fixed,
        
        /// <remarks/>
        Variable,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public partial class TransactionListTransaction {
        
        private string idField;
        
        private TransactionListTransactionType typeField;
        
        private bool typeFieldSpecified;
        
        private Money amountField;
        
        private string descriptionField;
        
        private System.DateTime dateTimePostedField;
        
        private bool dateTimePostedFieldSpecified;
        
        private System.DateTime dateTimeEffectiveField;
        
        private bool dateTimeEffectiveFieldSpecified;
        
        private TransactionListTransactionStatus statusField;
        
        private Money principalAmountField;
        
        private Money interestAmountField;
        
        private string merchantCategoryCodeField;
        
        private TransactionSource sourceField;
        
        private bool sourceFieldSpecified;
        
        private ValuePair[] customDataField;
        
        public TransactionListTransaction() {
            this.statusField = TransactionListTransactionStatus.Posted;
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public TransactionListTransactionType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dateTimePosted {
            get {
                return this.dateTimePostedField;
            }
            set {
                this.dateTimePostedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateTimePostedSpecified {
            get {
                return this.dateTimePostedFieldSpecified;
            }
            set {
                this.dateTimePostedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dateTimeEffective {
            get {
                return this.dateTimeEffectiveField;
            }
            set {
                this.dateTimeEffectiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateTimeEffectiveSpecified {
            get {
                return this.dateTimeEffectiveFieldSpecified;
            }
            set {
                this.dateTimeEffectiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(TransactionListTransactionStatus.Posted)]
        public TransactionListTransactionStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public Money principalAmount {
            get {
                return this.principalAmountField;
            }
            set {
                this.principalAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money interestAmount {
            get {
                return this.interestAmountField;
            }
            set {
                this.interestAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string merchantCategoryCode {
            get {
                return this.merchantCategoryCodeField;
            }
            set {
                this.merchantCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        public TransactionSource source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sourceSpecified {
            get {
                return this.sourceFieldSpecified;
            }
            set {
                this.sourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum TransactionListTransactionType {
        
        /// <remarks/>
        Debit,
        
        /// <remarks/>
        Credit,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum TransactionListTransactionStatus {
        
        /// <remarks/>
        Posted,
        
        /// <remarks/>
        Pending,
        
        /// <remarks/>
        Denied,
        
        /// <remarks/>
        Void,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Account.xsd")]
    public enum TransactionSource {
        
        /// <remarks/>
        Ach,
        
        /// <remarks/>
        Atm,
        
        /// <remarks/>
        BillPay,
        
        /// <remarks/>
        BulkDeposit,
        
        /// <remarks/>
        Cash,
        
        /// <remarks/>
        Check,
        
        /// <remarks/>
        Fee,
        
        /// <remarks/>
        HomeBanking,
        
        /// <remarks/>
        Insurance,
        
        /// <remarks/>
        InterestEarned,
        
        /// <remarks/>
        InterestPaid,
        
        /// <remarks/>
        Ivr,
        
        /// <remarks/>
        MobileBanking,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Payroll,
        
        /// <remarks/>
        PinPurchase,
        
        /// <remarks/>
        SharedBranch,
        
        /// <remarks/>
        Signature,
        
        /// <remarks/>
        Wire,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class Loan : Account {
        
        private LoanParty[] loanPartyListField;
        
        private string officerIdField;
        
        private string processorIdField;
        
        private System.DateTime loanDecisionDateField;
        
        private bool loanDecisionDateFieldSpecified;
        
        private System.DateTime applicationOriginationDateField;
        
        private bool applicationOriginationDateFieldSpecified;
        
        private LoanDecisionType applicationDecisionStatusField;
        
        private bool applicationDecisionStatusFieldSpecified;
        
        private string noteNumberField;
        
        private LoanAccountCategory categoryField;
        
        private bool categoryFieldSpecified;
        
        private string purposeCodeField;
        
        private Money requestedAmountField;
        
        private Money noteAmountField;
        
        private Money creditLimitField;
        
        private System.DateTime creditLimitExpirationField;
        
        private bool creditLimitExpirationFieldSpecified;
        
        private string creditLimitGroupCodeField;
        
        private EcoaGroupType ecoaGroupField;
        
        private bool ecoaGroupFieldSpecified;
        
        private string creditReportingCodeField;
        
        private Money minimumBalance1Field;
        
        private bool isRevolvingLineOfCreditField;
        
        private bool isRevolvingLineOfCreditFieldSpecified;
        
        private Money minimumAdvanceAmountField;
        
        private Money maximumAdvanceAmountField;
        
        private System.DateTime originationDateField;
        
        private bool originationDateFieldSpecified;
        
        private System.DateTime disbursalDateField;
        
        private bool disbursalDateFieldSpecified;
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private string termField;
        
        private LoanTermType termTypeField;
        
        private bool termTypeFieldSpecified;
        
        private CreditReport[] creditReportListField;
        
        private LoanInterestRateDetail loanInterestRateDetailField;
        
        private PaymentOption paymentOptionField;
        
        private LoanInterestCalculationType interestCalculationTypeField;
        
        private bool interestCalculationTypeFieldSpecified;
        
        private decimal dailyPeriodicRateField;
        
        private bool dailyPeriodicRateFieldSpecified;
        
        private string totalNumberOfPaymentsField;
        
        private Money prePaidFinanceChargesField;
        
        private Money prepaidInterestField;
        
        private System.DateTime interestPaidThruDateField;
        
        private bool interestPaidThruDateFieldSpecified;
        
        private string numberOfGraceDaysField;
        
        private Money balloonAmountField;
        
        private System.DateTime balloonDueDateField;
        
        private bool balloonDueDateFieldSpecified;
        
        private BalloonDueDateTermType balloonDueDateTermField;
        
        private bool balloonDueDateTermFieldSpecified;
        
        private string balloonDueDateTermValueField;
        
        private PrepaymentPenaltyBasisType prepaymentPenaltyBasisField;
        
        private bool prepaymentPenaltyBasisFieldSpecified;
        
        private Money prepaymentPenaltyBasisAmountField;
        
        private decimal prepaymentPenaltyPercentageField;
        
        private bool prepaymentPenaltyPercentageFieldSpecified;
        
        private System.DateTime prepaymentPenaltyExpirationDateField;
        
        private bool prepaymentPenaltyExpirationDateFieldSpecified;
        
        private string statementCodeField;
        
        private string statementGroupField;
        
        private System.DateTime statementDateField;
        
        private bool statementDateFieldSpecified;
        
        private decimal debtIncomeRatioField;
        
        private bool debtIncomeRatioFieldSpecified;
        
        private LoanFee[] loanFeeListField;
        
        private InsuranceAddOn[] insuranceAddOnListField;
        
        private Collateral[] collateralListField;
        
        private AutoPaymentOption autoPaymentOptionField;
        
        private DelinquencyNotice[] delinquencyNoticeListField;
        
        private SkipPayment skipPaymentField;
        
        private string promotionCodeField;
        
        private Note[] noteListField;
        
        private ValuePair[] customData1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("loanParty", IsNullable=false)]
        public LoanParty[] loanPartyList {
            get {
                return this.loanPartyListField;
            }
            set {
                this.loanPartyListField = value;
            }
        }
        
        /// <remarks/>
        public string officerId {
            get {
                return this.officerIdField;
            }
            set {
                this.officerIdField = value;
            }
        }
        
        /// <remarks/>
        public string processorId {
            get {
                return this.processorIdField;
            }
            set {
                this.processorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime loanDecisionDate {
            get {
                return this.loanDecisionDateField;
            }
            set {
                this.loanDecisionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool loanDecisionDateSpecified {
            get {
                return this.loanDecisionDateFieldSpecified;
            }
            set {
                this.loanDecisionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime applicationOriginationDate {
            get {
                return this.applicationOriginationDateField;
            }
            set {
                this.applicationOriginationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicationOriginationDateSpecified {
            get {
                return this.applicationOriginationDateFieldSpecified;
            }
            set {
                this.applicationOriginationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public LoanDecisionType applicationDecisionStatus {
            get {
                return this.applicationDecisionStatusField;
            }
            set {
                this.applicationDecisionStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicationDecisionStatusSpecified {
            get {
                return this.applicationDecisionStatusFieldSpecified;
            }
            set {
                this.applicationDecisionStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string noteNumber {
            get {
                return this.noteNumberField;
            }
            set {
                this.noteNumberField = value;
            }
        }
        
        /// <remarks/>
        public LoanAccountCategory category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool categorySpecified {
            get {
                return this.categoryFieldSpecified;
            }
            set {
                this.categoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string purposeCode {
            get {
                return this.purposeCodeField;
            }
            set {
                this.purposeCodeField = value;
            }
        }
        
        /// <remarks/>
        public Money requestedAmount {
            get {
                return this.requestedAmountField;
            }
            set {
                this.requestedAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money noteAmount {
            get {
                return this.noteAmountField;
            }
            set {
                this.noteAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime creditLimitExpiration {
            get {
                return this.creditLimitExpirationField;
            }
            set {
                this.creditLimitExpirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditLimitExpirationSpecified {
            get {
                return this.creditLimitExpirationFieldSpecified;
            }
            set {
                this.creditLimitExpirationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string creditLimitGroupCode {
            get {
                return this.creditLimitGroupCodeField;
            }
            set {
                this.creditLimitGroupCodeField = value;
            }
        }
        
        /// <remarks/>
        public EcoaGroupType ecoaGroup {
            get {
                return this.ecoaGroupField;
            }
            set {
                this.ecoaGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ecoaGroupSpecified {
            get {
                return this.ecoaGroupFieldSpecified;
            }
            set {
                this.ecoaGroupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string creditReportingCode {
            get {
                return this.creditReportingCodeField;
            }
            set {
                this.creditReportingCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("minimumBalance")]
        public Money minimumBalance1 {
            get {
                return this.minimumBalance1Field;
            }
            set {
                this.minimumBalance1Field = value;
            }
        }
        
        /// <remarks/>
        public bool isRevolvingLineOfCredit {
            get {
                return this.isRevolvingLineOfCreditField;
            }
            set {
                this.isRevolvingLineOfCreditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRevolvingLineOfCreditSpecified {
            get {
                return this.isRevolvingLineOfCreditFieldSpecified;
            }
            set {
                this.isRevolvingLineOfCreditFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money minimumAdvanceAmount {
            get {
                return this.minimumAdvanceAmountField;
            }
            set {
                this.minimumAdvanceAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money maximumAdvanceAmount {
            get {
                return this.maximumAdvanceAmountField;
            }
            set {
                this.maximumAdvanceAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime originationDate {
            get {
                return this.originationDateField;
            }
            set {
                this.originationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originationDateSpecified {
            get {
                return this.originationDateFieldSpecified;
            }
            set {
                this.originationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime disbursalDate {
            get {
                return this.disbursalDateField;
            }
            set {
                this.disbursalDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool disbursalDateSpecified {
            get {
                return this.disbursalDateFieldSpecified;
            }
            set {
                this.disbursalDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime creationDate {
            get {
                return this.creationDateField;
            }
            set {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creationDateSpecified {
            get {
                return this.creationDateFieldSpecified;
            }
            set {
                this.creationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string term {
            get {
                return this.termField;
            }
            set {
                this.termField = value;
            }
        }
        
        /// <remarks/>
        public LoanTermType termType {
            get {
                return this.termTypeField;
            }
            set {
                this.termTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool termTypeSpecified {
            get {
                return this.termTypeFieldSpecified;
            }
            set {
                this.termTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("creditReport", Namespace="http://cufxstandards.com/v2/CreditReport.xsd", IsNullable=false)]
        public CreditReport[] creditReportList {
            get {
                return this.creditReportListField;
            }
            set {
                this.creditReportListField = value;
            }
        }
        
        /// <remarks/>
        public LoanInterestRateDetail loanInterestRateDetail {
            get {
                return this.loanInterestRateDetailField;
            }
            set {
                this.loanInterestRateDetailField = value;
            }
        }
        
        /// <remarks/>
        public PaymentOption paymentOption {
            get {
                return this.paymentOptionField;
            }
            set {
                this.paymentOptionField = value;
            }
        }
        
        /// <remarks/>
        public LoanInterestCalculationType interestCalculationType {
            get {
                return this.interestCalculationTypeField;
            }
            set {
                this.interestCalculationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestCalculationTypeSpecified {
            get {
                return this.interestCalculationTypeFieldSpecified;
            }
            set {
                this.interestCalculationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal dailyPeriodicRate {
            get {
                return this.dailyPeriodicRateField;
            }
            set {
                this.dailyPeriodicRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyPeriodicRateSpecified {
            get {
                return this.dailyPeriodicRateFieldSpecified;
            }
            set {
                this.dailyPeriodicRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string totalNumberOfPayments {
            get {
                return this.totalNumberOfPaymentsField;
            }
            set {
                this.totalNumberOfPaymentsField = value;
            }
        }
        
        /// <remarks/>
        public Money prePaidFinanceCharges {
            get {
                return this.prePaidFinanceChargesField;
            }
            set {
                this.prePaidFinanceChargesField = value;
            }
        }
        
        /// <remarks/>
        public Money prepaidInterest {
            get {
                return this.prepaidInterestField;
            }
            set {
                this.prepaidInterestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime interestPaidThruDate {
            get {
                return this.interestPaidThruDateField;
            }
            set {
                this.interestPaidThruDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestPaidThruDateSpecified {
            get {
                return this.interestPaidThruDateFieldSpecified;
            }
            set {
                this.interestPaidThruDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string numberOfGraceDays {
            get {
                return this.numberOfGraceDaysField;
            }
            set {
                this.numberOfGraceDaysField = value;
            }
        }
        
        /// <remarks/>
        public Money balloonAmount {
            get {
                return this.balloonAmountField;
            }
            set {
                this.balloonAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime balloonDueDate {
            get {
                return this.balloonDueDateField;
            }
            set {
                this.balloonDueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balloonDueDateSpecified {
            get {
                return this.balloonDueDateFieldSpecified;
            }
            set {
                this.balloonDueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public BalloonDueDateTermType balloonDueDateTerm {
            get {
                return this.balloonDueDateTermField;
            }
            set {
                this.balloonDueDateTermField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balloonDueDateTermSpecified {
            get {
                return this.balloonDueDateTermFieldSpecified;
            }
            set {
                this.balloonDueDateTermFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string balloonDueDateTermValue {
            get {
                return this.balloonDueDateTermValueField;
            }
            set {
                this.balloonDueDateTermValueField = value;
            }
        }
        
        /// <remarks/>
        public PrepaymentPenaltyBasisType prepaymentPenaltyBasis {
            get {
                return this.prepaymentPenaltyBasisField;
            }
            set {
                this.prepaymentPenaltyBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prepaymentPenaltyBasisSpecified {
            get {
                return this.prepaymentPenaltyBasisFieldSpecified;
            }
            set {
                this.prepaymentPenaltyBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money prepaymentPenaltyBasisAmount {
            get {
                return this.prepaymentPenaltyBasisAmountField;
            }
            set {
                this.prepaymentPenaltyBasisAmountField = value;
            }
        }
        
        /// <remarks/>
        public decimal prepaymentPenaltyPercentage {
            get {
                return this.prepaymentPenaltyPercentageField;
            }
            set {
                this.prepaymentPenaltyPercentageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prepaymentPenaltyPercentageSpecified {
            get {
                return this.prepaymentPenaltyPercentageFieldSpecified;
            }
            set {
                this.prepaymentPenaltyPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime prepaymentPenaltyExpirationDate {
            get {
                return this.prepaymentPenaltyExpirationDateField;
            }
            set {
                this.prepaymentPenaltyExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prepaymentPenaltyExpirationDateSpecified {
            get {
                return this.prepaymentPenaltyExpirationDateFieldSpecified;
            }
            set {
                this.prepaymentPenaltyExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string statementCode {
            get {
                return this.statementCodeField;
            }
            set {
                this.statementCodeField = value;
            }
        }
        
        /// <remarks/>
        public string statementGroup {
            get {
                return this.statementGroupField;
            }
            set {
                this.statementGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime StatementDate {
            get {
                return this.statementDateField;
            }
            set {
                this.statementDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatementDateSpecified {
            get {
                return this.statementDateFieldSpecified;
            }
            set {
                this.statementDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal debtIncomeRatio {
            get {
                return this.debtIncomeRatioField;
            }
            set {
                this.debtIncomeRatioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debtIncomeRatioSpecified {
            get {
                return this.debtIncomeRatioFieldSpecified;
            }
            set {
                this.debtIncomeRatioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("loanFee", IsNullable=false)]
        public LoanFee[] loanFeeList {
            get {
                return this.loanFeeListField;
            }
            set {
                this.loanFeeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("insuranceAddOn", IsNullable=false)]
        public InsuranceAddOn[] insuranceAddOnList {
            get {
                return this.insuranceAddOnListField;
            }
            set {
                this.insuranceAddOnListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("collateral", Namespace="http://cufxstandards.com/v2/Collateral.xsd", IsNullable=false)]
        public Collateral[] collateralList {
            get {
                return this.collateralListField;
            }
            set {
                this.collateralListField = value;
            }
        }
        
        /// <remarks/>
        public AutoPaymentOption autoPaymentOption {
            get {
                return this.autoPaymentOptionField;
            }
            set {
                this.autoPaymentOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("delinquencyNotice", IsNullable=false)]
        public DelinquencyNotice[] delinquencyNoticeList {
            get {
                return this.delinquencyNoticeListField;
            }
            set {
                this.delinquencyNoticeListField = value;
            }
        }
        
        /// <remarks/>
        public SkipPayment skipPayment {
            get {
                return this.skipPaymentField;
            }
            set {
                this.skipPaymentField = value;
            }
        }
        
        /// <remarks/>
        public string promotionCode {
            get {
                return this.promotionCodeField;
            }
            set {
                this.promotionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("note", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public Note[] noteList {
            get {
                return this.noteListField;
            }
            set {
                this.noteListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("customData")]
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData1 {
            get {
                return this.customData1Field;
            }
            set {
                this.customData1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanDecisionType {
        
        /// <remarks/>
        Approve,
        
        /// <remarks/>
        CounterOffer,
        
        /// <remarks/>
        Denied,
        
        /// <remarks/>
        Review,
        
        /// <remarks/>
        Withdrawn,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanAccountCategory {
        
        /// <remarks/>
        AverageDailyBalanceLineOfCredit,
        
        /// <remarks/>
        ClosedEnd,
        
        /// <remarks/>
        CreditCard,
        
        /// <remarks/>
        Lease,
        
        /// <remarks/>
        LineOfCredit,
        
        /// <remarks/>
        LineOfCreditCombination,
        
        /// <remarks/>
        OpenEnd,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum EcoaGroupType {
        
        /// <remarks/>
        Individual,
        
        /// <remarks/>
        Joint,
        
        /// <remarks/>
        AuthorizedUser,
        
        /// <remarks/>
        CoSigner,
        
        /// <remarks/>
        Maker,
        
        /// <remarks/>
        CoMaker,
        
        /// <remarks/>
        Terminated,
        
        /// <remarks/>
        Undesignated,
        
        /// <remarks/>
        BusinessOrCommercial,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanTermType {
        
        /// <remarks/>
        Days,
        
        /// <remarks/>
        Months,
        
        /// <remarks/>
        Years,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum LoanInterestCalculationType {
        
        /// <remarks/>
        Actual360,
        
        /// <remarks/>
        Actual364,
        
        /// <remarks/>
        Daily365,
        
        /// <remarks/>
        Daily365Leap,
        
        /// <remarks/>
        DailyBilled360,
        
        /// <remarks/>
        Monthly360,
        
        /// <remarks/>
        Scheduled364,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum BalloonDueDateTermType {
        
        /// <remarks/>
        Months,
        
        /// <remarks/>
        Years,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public enum PrepaymentPenaltyBasisType {
        
        /// <remarks/>
        Amount,
        
        /// <remarks/>
        PercentOfBalance,
        
        /// <remarks/>
        PercentOfOriginalAmount,
        
        /// <remarks/>
        PercentOfPrincipal,
        
        /// <remarks/>
        PercentOfUndisbursed,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public partial class Deposit : Account {
        
        private DepositParty[] depositPartyListField;
        
        private System.DateTime bumpEffectiveDateField;
        
        private bool bumpEffectiveDateFieldSpecified;
        
        private System.DateTime bumpExpirationDateField;
        
        private bool bumpExpirationDateFieldSpecified;
        
        private decimal bumpRateField;
        
        private bool bumpRateFieldSpecified;
        
        private DividendPostCodeType dividendPostCodeField;
        
        private bool dividendPostCodeFieldSpecified;
        
        private decimal dividendRateField;
        
        private bool dividendRateFieldSpecified;
        
        private string dividendTransferAccountIdField;
        
        private string dividendTypeField;
        
        private string irsCodeField;
        
        private MaturityPostCodeType maturityPostCodeField;
        
        private bool maturityPostCodeFieldSpecified;
        
        private string maturityTransferAccountIdField;
        
        private Money minimumDepositField;
        
        private Money minimumWithdrawalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("depositParty", IsNullable=false)]
        public DepositParty[] depositPartyList {
            get {
                return this.depositPartyListField;
            }
            set {
                this.depositPartyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime bumpEffectiveDate {
            get {
                return this.bumpEffectiveDateField;
            }
            set {
                this.bumpEffectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bumpEffectiveDateSpecified {
            get {
                return this.bumpEffectiveDateFieldSpecified;
            }
            set {
                this.bumpEffectiveDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime bumpExpirationDate {
            get {
                return this.bumpExpirationDateField;
            }
            set {
                this.bumpExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bumpExpirationDateSpecified {
            get {
                return this.bumpExpirationDateFieldSpecified;
            }
            set {
                this.bumpExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal bumpRate {
            get {
                return this.bumpRateField;
            }
            set {
                this.bumpRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bumpRateSpecified {
            get {
                return this.bumpRateFieldSpecified;
            }
            set {
                this.bumpRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DividendPostCodeType dividendPostCode {
            get {
                return this.dividendPostCodeField;
            }
            set {
                this.dividendPostCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dividendPostCodeSpecified {
            get {
                return this.dividendPostCodeFieldSpecified;
            }
            set {
                this.dividendPostCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal dividendRate {
            get {
                return this.dividendRateField;
            }
            set {
                this.dividendRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dividendRateSpecified {
            get {
                return this.dividendRateFieldSpecified;
            }
            set {
                this.dividendRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dividendTransferAccountId {
            get {
                return this.dividendTransferAccountIdField;
            }
            set {
                this.dividendTransferAccountIdField = value;
            }
        }
        
        /// <remarks/>
        public string dividendType {
            get {
                return this.dividendTypeField;
            }
            set {
                this.dividendTypeField = value;
            }
        }
        
        /// <remarks/>
        public string irsCode {
            get {
                return this.irsCodeField;
            }
            set {
                this.irsCodeField = value;
            }
        }
        
        /// <remarks/>
        public MaturityPostCodeType maturityPostCode {
            get {
                return this.maturityPostCodeField;
            }
            set {
                this.maturityPostCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityPostCodeSpecified {
            get {
                return this.maturityPostCodeFieldSpecified;
            }
            set {
                this.maturityPostCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string maturityTransferAccountId {
            get {
                return this.maturityTransferAccountIdField;
            }
            set {
                this.maturityTransferAccountIdField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumDeposit {
            get {
                return this.minimumDepositField;
            }
            set {
                this.minimumDepositField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumWithdrawal {
            get {
                return this.minimumWithdrawalField;
            }
            set {
                this.minimumWithdrawalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public enum DividendPostCodeType {
        
        /// <remarks/>
        ToAccount,
        
        /// <remarks/>
        ByCheck,
        
        /// <remarks/>
        Transfer,
        
        /// <remarks/>
        Forfeit,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public enum MaturityPostCodeType {
        
        /// <remarks/>
        Renew,
        
        /// <remarks/>
        ByCheck,
        
        /// <remarks/>
        Transfer,
        
        /// <remarks/>
        Suspend,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/AccountFilter.xsd")]
    public partial class AccountFilter {
        
        private string[] accountIdListField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private AccountType[] accountTypeListField;
        
        private System.DateTime transactionStartDateTimeField;
        
        private bool transactionStartDateTimeFieldSpecified;
        
        private System.DateTime transactionEndDateTimeField;
        
        private bool transactionEndDateTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountType", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public AccountType[] accountTypeList {
            get {
                return this.accountTypeListField;
            }
            set {
                this.accountTypeListField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime transactionStartDateTime {
            get {
                return this.transactionStartDateTimeField;
            }
            set {
                this.transactionStartDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionStartDateTimeSpecified {
            get {
                return this.transactionStartDateTimeFieldSpecified;
            }
            set {
                this.transactionStartDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime transactionEndDateTime {
            get {
                return this.transactionEndDateTimeField;
            }
            set {
                this.transactionEndDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionEndDateTimeSpecified {
            get {
                return this.transactionEndDateTimeFieldSpecified;
            }
            set {
                this.transactionEndDateTimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/DepositFilter.xsd")]
    public partial class DepositFilter : AccountFilter {
        
        private System.DateTime maturityStartDateField;
        
        private bool maturityStartDateFieldSpecified;
        
        private System.DateTime maturityEndDateField;
        
        private bool maturityEndDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityStartDate {
            get {
                return this.maturityStartDateField;
            }
            set {
                this.maturityStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityStartDateSpecified {
            get {
                return this.maturityStartDateFieldSpecified;
            }
            set {
                this.maturityStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime maturityEndDate {
            get {
                return this.maturityEndDateField;
            }
            set {
                this.maturityEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maturityEndDateSpecified {
            get {
                return this.maturityEndDateFieldSpecified;
            }
            set {
                this.maturityEndDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class ApplicationList {
        
        private Application[] applicationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("application")]
        public Application[] application {
            get {
                return this.applicationField;
            }
            set {
                this.applicationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class Application {
        
        private string applicationIdField;
        
        private ApplicationStatus applicationStatusField;
        
        private bool applicationStatusFieldSpecified;
        
        private ProductAppliedForList productAppliedForListField;
        
        private Applicant[] applicantListField;
        
        private string finalCreditBureauScoreField;
        
        /// <remarks/>
        public string applicationId {
            get {
                return this.applicationIdField;
            }
            set {
                this.applicationIdField = value;
            }
        }
        
        /// <remarks/>
        public ApplicationStatus applicationStatus {
            get {
                return this.applicationStatusField;
            }
            set {
                this.applicationStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicationStatusSpecified {
            get {
                return this.applicationStatusFieldSpecified;
            }
            set {
                this.applicationStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ProductAppliedForList productAppliedForList {
            get {
                return this.productAppliedForListField;
            }
            set {
                this.productAppliedForListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("applicant", IsNullable=false)]
        public Applicant[] applicantList {
            get {
                return this.applicantListField;
            }
            set {
                this.applicantListField = value;
            }
        }
        
        /// <remarks/>
        public string finalCreditBureauScore {
            get {
                return this.finalCreditBureauScoreField;
            }
            set {
                this.finalCreditBureauScoreField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public enum ApplicationStatus {
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        PreApproved,
        
        /// <remarks/>
        Assigned,
        
        /// <remarks/>
        InDiscussion,
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        Declined,
        
        /// <remarks/>
        Converting,
        
        /// <remarks/>
        Booked,
        
        /// <remarks/>
        Lost,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class ProductAppliedForList {
        
        private ProductAppliedFor productAppliedForField;
        
        /// <remarks/>
        public ProductAppliedFor productAppliedFor {
            get {
                return this.productAppliedForField;
            }
            set {
                this.productAppliedForField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class ProductAppliedFor {
        
        private string productAppliedForIdField;
        
        private AccountType productTypeField;
        
        private bool productTypeFieldSpecified;
        
        private string productSubTypeField;
        
        private ApplicationStatus productApplicationStatusField;
        
        private ProductDetail productDetailField;
        
        /// <remarks/>
        public string productAppliedForId {
            get {
                return this.productAppliedForIdField;
            }
            set {
                this.productAppliedForIdField = value;
            }
        }
        
        /// <remarks/>
        public AccountType productType {
            get {
                return this.productTypeField;
            }
            set {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool productTypeSpecified {
            get {
                return this.productTypeFieldSpecified;
            }
            set {
                this.productTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string productSubType {
            get {
                return this.productSubTypeField;
            }
            set {
                this.productSubTypeField = value;
            }
        }
        
        /// <remarks/>
        public ApplicationStatus productApplicationStatus {
            get {
                return this.productApplicationStatusField;
            }
            set {
                this.productApplicationStatusField = value;
            }
        }
        
        /// <remarks/>
        public ProductDetail productDetail {
            get {
                return this.productDetailField;
            }
            set {
                this.productDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class ProductDetail {
        
        private Account itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deposit", typeof(Deposit))]
        [System.Xml.Serialization.XmlElementAttribute("loan", typeof(Loan))]
        public Account Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public partial class Applicant {
        
        private string applicantIdField;
        
        private ApplicantRole roleField;
        
        private CreditReport[] creditReportListField;
        
        private string relationshipIdField;
        
        private string partyIdField;
        
        private Party partyField;
        
        /// <remarks/>
        public string applicantId {
            get {
                return this.applicantIdField;
            }
            set {
                this.applicantIdField = value;
            }
        }
        
        /// <remarks/>
        public ApplicantRole role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("creditReport", Namespace="http://cufxstandards.com/v2/CreditReport.xsd", IsNullable=false)]
        public CreditReport[] creditReportList {
            get {
                return this.creditReportListField;
            }
            set {
                this.creditReportListField = value;
            }
        }
        
        /// <remarks/>
        public string relationshipId {
            get {
                return this.relationshipIdField;
            }
            set {
                this.relationshipIdField = value;
            }
        }
        
        /// <remarks/>
        public string partyId {
            get {
                return this.partyIdField;
            }
            set {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        public Party party {
            get {
                return this.partyField;
            }
            set {
                this.partyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Application.xsd")]
    public enum ApplicantRole {
        
        /// <remarks/>
        Primary,
        
        /// <remarks/>
        Secondary,
        
        /// <remarks/>
        AuthorizedUser,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Party {
        
        private string idField;
        
        private Irs irsField;
        
        private PartyType typeField;
        
        private bool typeFieldSpecified;
        
        private Characteristics characteristicsField;
        
        private IdentificationDocument[] identificationDocumentListField;
        
        private EligibilityRequirementMet[] eligibilityRequirementMetListField;
        
        private string[] contactIdListField;
        
        private Contact[] contactListField;
        
        private string[] fiUserIdListField;
        
        private string householdIdField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public Irs irs {
            get {
                return this.irsField;
            }
            set {
                this.irsField = value;
            }
        }
        
        /// <remarks/>
        public PartyType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Characteristics characteristics {
            get {
                return this.characteristicsField;
            }
            set {
                this.characteristicsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("identificationDocument")]
        public IdentificationDocument[] identificationDocumentList {
            get {
                return this.identificationDocumentListField;
            }
            set {
                this.identificationDocumentListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("eligibilityRequirementMet")]
        public EligibilityRequirementMet[] eligibilityRequirementMetList {
            get {
                return this.eligibilityRequirementMetListField;
            }
            set {
                this.eligibilityRequirementMetListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contact", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public Contact[] contactList {
            get {
                return this.contactListField;
            }
            set {
                this.contactListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fiUserId", Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd", IsNullable=false)]
        public string[] fiUserIdList {
            get {
                return this.fiUserIdListField;
            }
            set {
                this.fiUserIdListField = value;
            }
        }
        
        /// <remarks/>
        public string householdId {
            get {
                return this.householdIdField;
            }
            set {
                this.householdIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Irs {
        
        private string taxIdField;
        
        private bool taxIdEncryptedField;
        
        private bool taxIdEncryptedFieldSpecified;
        
        private TaxIdType taxIdTypeField;
        
        private bool taxIdTypeFieldSpecified;
        
        private bool reportingFlagField;
        
        private bool verifiedTaxIdFlagField;
        
        private bool verifiedTaxIdFlagFieldSpecified;
        
        private string taxIdWarningCountField;
        
        private bool backupWithholdingFlagField;
        
        private bool backupWithholdingFlagFieldSpecified;
        
        private string backupWithholdingReasonField;
        
        private IrsBackupWithholdingExemptionReason backupWithholdingExemptionReasonField;
        
        private bool backupWithholdingExemptionReasonFieldSpecified;
        
        private System.DateTime backupWithholdingEffectiveDateField;
        
        private bool backupWithholdingEffectiveDateFieldSpecified;
        
        public Irs() {
            this.reportingFlagField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string taxId {
            get {
                return this.taxIdField;
            }
            set {
                this.taxIdField = value;
            }
        }
        
        /// <remarks/>
        public bool taxIdEncrypted {
            get {
                return this.taxIdEncryptedField;
            }
            set {
                this.taxIdEncryptedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxIdEncryptedSpecified {
            get {
                return this.taxIdEncryptedFieldSpecified;
            }
            set {
                this.taxIdEncryptedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TaxIdType taxIdType {
            get {
                return this.taxIdTypeField;
            }
            set {
                this.taxIdTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxIdTypeSpecified {
            get {
                return this.taxIdTypeFieldSpecified;
            }
            set {
                this.taxIdTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool reportingFlag {
            get {
                return this.reportingFlagField;
            }
            set {
                this.reportingFlagField = value;
            }
        }
        
        /// <remarks/>
        public bool verifiedTaxIdFlag {
            get {
                return this.verifiedTaxIdFlagField;
            }
            set {
                this.verifiedTaxIdFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verifiedTaxIdFlagSpecified {
            get {
                return this.verifiedTaxIdFlagFieldSpecified;
            }
            set {
                this.verifiedTaxIdFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string taxIdWarningCount {
            get {
                return this.taxIdWarningCountField;
            }
            set {
                this.taxIdWarningCountField = value;
            }
        }
        
        /// <remarks/>
        public bool backupWithholdingFlag {
            get {
                return this.backupWithholdingFlagField;
            }
            set {
                this.backupWithholdingFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool backupWithholdingFlagSpecified {
            get {
                return this.backupWithholdingFlagFieldSpecified;
            }
            set {
                this.backupWithholdingFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string backupWithholdingReason {
            get {
                return this.backupWithholdingReasonField;
            }
            set {
                this.backupWithholdingReasonField = value;
            }
        }
        
        /// <remarks/>
        public IrsBackupWithholdingExemptionReason backupWithholdingExemptionReason {
            get {
                return this.backupWithholdingExemptionReasonField;
            }
            set {
                this.backupWithholdingExemptionReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool backupWithholdingExemptionReasonSpecified {
            get {
                return this.backupWithholdingExemptionReasonFieldSpecified;
            }
            set {
                this.backupWithholdingExemptionReasonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime backupWithholdingEffectiveDate {
            get {
                return this.backupWithholdingEffectiveDateField;
            }
            set {
                this.backupWithholdingEffectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool backupWithholdingEffectiveDateSpecified {
            get {
                return this.backupWithholdingEffectiveDateFieldSpecified;
            }
            set {
                this.backupWithholdingEffectiveDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum TaxIdType {
        
        /// <remarks/>
        SocialSecurityNumber,
        
        /// <remarks/>
        EmployerIdentificationNumber,
        
        /// <remarks/>
        IndividualTaxpayerIdentificationNumber,
        
        /// <remarks/>
        TaxpayerIdentificationNumberForPendingUSAdoptions,
        
        /// <remarks/>
        PreparerTaxpayerIdentificationNumber,
        
        /// <remarks/>
        ForeignNational,
        
        /// <remarks/>
        ForeignNumberNoTIN,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IrsBackupWithholdingExemptionReason {
        
        /// <remarks/>
        ExceptFromWithholding,
        
        /// <remarks/>
        NotNotifiedByIrs,
        
        /// <remarks/>
        IrsNotifiedNoLongSubject,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum PartyType {
        
        /// <remarks/>
        Individual,
        
        /// <remarks/>
        Organization,
        
        /// <remarks/>
        Trust,
        
        /// <remarks/>
        Estate,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Characteristics {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estate", typeof(Estate))]
        [System.Xml.Serialization.XmlElementAttribute("individual", typeof(Individual))]
        [System.Xml.Serialization.XmlElementAttribute("organization", typeof(Organization))]
        [System.Xml.Serialization.XmlElementAttribute("trust", typeof(Trust))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Estate {
        
        private string estateNameField;
        
        /// <remarks/>
        public string estateName {
            get {
                return this.estateNameField;
            }
            set {
                this.estateNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Individual {
        
        private string firstNameField;
        
        private string middleNameField;
        
        private string lastNameField;
        
        private string prefixField;
        
        private string suffixField;
        
        private string formattedNameField;
        
        private string mothersMaidenNameField;
        
        private string nicknameField;
        
        private System.DateTime birthdateField;
        
        private bool birthdateFieldSpecified;
        
        private IndividualGender genderField;
        
        private bool genderFieldSpecified;
        
        private string cityOfBirthField;
        
        private Citizenship[] citizenshipListField;
        
        private EmploymentStatusType employmentStatusField;
        
        private bool employmentStatusFieldSpecified;
        
        private Employment[] employmentListField;
        
        private AdditionalIncome[] additionalIncomeListField;
        
        private Liability[] liabilityListField;
        
        private Residence residenceField;
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string prefix {
            get {
                return this.prefixField;
            }
            set {
                this.prefixField = value;
            }
        }
        
        /// <remarks/>
        public string suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        public string formattedName {
            get {
                return this.formattedNameField;
            }
            set {
                this.formattedNameField = value;
            }
        }
        
        /// <remarks/>
        public string mothersMaidenName {
            get {
                return this.mothersMaidenNameField;
            }
            set {
                this.mothersMaidenNameField = value;
            }
        }
        
        /// <remarks/>
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                this.nicknameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime birthdate {
            get {
                return this.birthdateField;
            }
            set {
                this.birthdateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool birthdateSpecified {
            get {
                return this.birthdateFieldSpecified;
            }
            set {
                this.birthdateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IndividualGender gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified {
            get {
                return this.genderFieldSpecified;
            }
            set {
                this.genderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string cityOfBirth {
            get {
                return this.cityOfBirthField;
            }
            set {
                this.cityOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("citizenship")]
        public Citizenship[] citizenshipList {
            get {
                return this.citizenshipListField;
            }
            set {
                this.citizenshipListField = value;
            }
        }
        
        /// <remarks/>
        public EmploymentStatusType employmentStatus {
            get {
                return this.employmentStatusField;
            }
            set {
                this.employmentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool employmentStatusSpecified {
            get {
                return this.employmentStatusFieldSpecified;
            }
            set {
                this.employmentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("employment", IsNullable=false)]
        public Employment[] employmentList {
            get {
                return this.employmentListField;
            }
            set {
                this.employmentListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("additionalIncome", IsNullable=false)]
        public AdditionalIncome[] additionalIncomeList {
            get {
                return this.additionalIncomeListField;
            }
            set {
                this.additionalIncomeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("liability", IsNullable=false)]
        public Liability[] liabilityList {
            get {
                return this.liabilityListField;
            }
            set {
                this.liabilityListField = value;
            }
        }
        
        /// <remarks/>
        public Residence residence {
            get {
                return this.residenceField;
            }
            set {
                this.residenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IndividualGender {
        
        /// <remarks/>
        Male,
        
        /// <remarks/>
        Female,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Citizenship {
        
        private System.Nullable<ISOCountryCodeType> citizenshipField;
        
        private bool citizenshipFieldSpecified;
        
        private bool wasCitizenshipCertifiedField;
        
        private bool wasCitizenshipCertifiedFieldSpecified;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<ISOCountryCodeType> citizenship {
            get {
                return this.citizenshipField;
            }
            set {
                this.citizenshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool citizenshipSpecified {
            get {
                return this.citizenshipFieldSpecified;
            }
            set {
                this.citizenshipFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool wasCitizenshipCertified {
            get {
                return this.wasCitizenshipCertifiedField;
            }
            set {
                this.wasCitizenshipCertifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wasCitizenshipCertifiedSpecified {
            get {
                return this.wasCitizenshipCertifiedFieldSpecified;
            }
            set {
                this.wasCitizenshipCertifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ISOCountryCodeType-V2006.xsd")]
    public enum ISOCountryCodeType {
        
        /// <remarks/>
        AD,
        
        /// <remarks/>
        AE,
        
        /// <remarks/>
        AF,
        
        /// <remarks/>
        AG,
        
        /// <remarks/>
        AI,
        
        /// <remarks/>
        AL,
        
        /// <remarks/>
        AM,
        
        /// <remarks/>
        AN,
        
        /// <remarks/>
        AO,
        
        /// <remarks/>
        AQ,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        AS,
        
        /// <remarks/>
        AT,
        
        /// <remarks/>
        AU,
        
        /// <remarks/>
        AW,
        
        /// <remarks/>
        AX,
        
        /// <remarks/>
        AZ,
        
        /// <remarks/>
        BA,
        
        /// <remarks/>
        BB,
        
        /// <remarks/>
        BD,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        BF,
        
        /// <remarks/>
        BG,
        
        /// <remarks/>
        BH,
        
        /// <remarks/>
        BI,
        
        /// <remarks/>
        BJ,
        
        /// <remarks/>
        BL,
        
        /// <remarks/>
        BM,
        
        /// <remarks/>
        BN,
        
        /// <remarks/>
        BO,
        
        /// <remarks/>
        BR,
        
        /// <remarks/>
        BS,
        
        /// <remarks/>
        BT,
        
        /// <remarks/>
        BV,
        
        /// <remarks/>
        BW,
        
        /// <remarks/>
        BY,
        
        /// <remarks/>
        BZ,
        
        /// <remarks/>
        CA,
        
        /// <remarks/>
        CC,
        
        /// <remarks/>
        CD,
        
        /// <remarks/>
        CF,
        
        /// <remarks/>
        CG,
        
        /// <remarks/>
        CH,
        
        /// <remarks/>
        CI,
        
        /// <remarks/>
        CK,
        
        /// <remarks/>
        CL,
        
        /// <remarks/>
        CM,
        
        /// <remarks/>
        CN,
        
        /// <remarks/>
        CO,
        
        /// <remarks/>
        CR,
        
        /// <remarks/>
        CU,
        
        /// <remarks/>
        CV,
        
        /// <remarks/>
        CX,
        
        /// <remarks/>
        CY,
        
        /// <remarks/>
        CZ,
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        DJ,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        DM,
        
        /// <remarks/>
        DO,
        
        /// <remarks/>
        DZ,
        
        /// <remarks/>
        EC,
        
        /// <remarks/>
        EE,
        
        /// <remarks/>
        EG,
        
        /// <remarks/>
        EH,
        
        /// <remarks/>
        ER,
        
        /// <remarks/>
        ES,
        
        /// <remarks/>
        ET,
        
        /// <remarks/>
        FI,
        
        /// <remarks/>
        FJ,
        
        /// <remarks/>
        FK,
        
        /// <remarks/>
        FM,
        
        /// <remarks/>
        FO,
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        GA,
        
        /// <remarks/>
        GB,
        
        /// <remarks/>
        GD,
        
        /// <remarks/>
        GE,
        
        /// <remarks/>
        GF,
        
        /// <remarks/>
        GG,
        
        /// <remarks/>
        GH,
        
        /// <remarks/>
        GI,
        
        /// <remarks/>
        GL,
        
        /// <remarks/>
        GM,
        
        /// <remarks/>
        GN,
        
        /// <remarks/>
        GP,
        
        /// <remarks/>
        GQ,
        
        /// <remarks/>
        GR,
        
        /// <remarks/>
        GS,
        
        /// <remarks/>
        GT,
        
        /// <remarks/>
        GU,
        
        /// <remarks/>
        GW,
        
        /// <remarks/>
        GY,
        
        /// <remarks/>
        HK,
        
        /// <remarks/>
        HM,
        
        /// <remarks/>
        HN,
        
        /// <remarks/>
        HR,
        
        /// <remarks/>
        HT,
        
        /// <remarks/>
        HU,
        
        /// <remarks/>
        ID,
        
        /// <remarks/>
        IE,
        
        /// <remarks/>
        IL,
        
        /// <remarks/>
        IM,
        
        /// <remarks/>
        IN,
        
        /// <remarks/>
        IO,
        
        /// <remarks/>
        IQ,
        
        /// <remarks/>
        IR,
        
        /// <remarks/>
        IS,
        
        /// <remarks/>
        IT,
        
        /// <remarks/>
        JE,
        
        /// <remarks/>
        JM,
        
        /// <remarks/>
        JO,
        
        /// <remarks/>
        JP,
        
        /// <remarks/>
        KE,
        
        /// <remarks/>
        KG,
        
        /// <remarks/>
        KH,
        
        /// <remarks/>
        KI,
        
        /// <remarks/>
        KM,
        
        /// <remarks/>
        KN,
        
        /// <remarks/>
        KP,
        
        /// <remarks/>
        KR,
        
        /// <remarks/>
        KW,
        
        /// <remarks/>
        KY,
        
        /// <remarks/>
        KZ,
        
        /// <remarks/>
        LA,
        
        /// <remarks/>
        LB,
        
        /// <remarks/>
        LC,
        
        /// <remarks/>
        LI,
        
        /// <remarks/>
        LK,
        
        /// <remarks/>
        LR,
        
        /// <remarks/>
        LS,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        LU,
        
        /// <remarks/>
        LV,
        
        /// <remarks/>
        LY,
        
        /// <remarks/>
        MA,
        
        /// <remarks/>
        MC,
        
        /// <remarks/>
        MD,
        
        /// <remarks/>
        ME,
        
        /// <remarks/>
        MF,
        
        /// <remarks/>
        MG,
        
        /// <remarks/>
        MH,
        
        /// <remarks/>
        MK,
        
        /// <remarks/>
        ML,
        
        /// <remarks/>
        MM,
        
        /// <remarks/>
        MN,
        
        /// <remarks/>
        MO,
        
        /// <remarks/>
        MP,
        
        /// <remarks/>
        MQ,
        
        /// <remarks/>
        MR,
        
        /// <remarks/>
        MS,
        
        /// <remarks/>
        MT,
        
        /// <remarks/>
        MU,
        
        /// <remarks/>
        MV,
        
        /// <remarks/>
        MW,
        
        /// <remarks/>
        MX,
        
        /// <remarks/>
        MY,
        
        /// <remarks/>
        MZ,
        
        /// <remarks/>
        NA,
        
        /// <remarks/>
        NC,
        
        /// <remarks/>
        NE,
        
        /// <remarks/>
        NF,
        
        /// <remarks/>
        NG,
        
        /// <remarks/>
        NI,
        
        /// <remarks/>
        NL,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        NP,
        
        /// <remarks/>
        NR,
        
        /// <remarks/>
        NU,
        
        /// <remarks/>
        NZ,
        
        /// <remarks/>
        OM,
        
        /// <remarks/>
        PA,
        
        /// <remarks/>
        PE,
        
        /// <remarks/>
        PF,
        
        /// <remarks/>
        PG,
        
        /// <remarks/>
        PH,
        
        /// <remarks/>
        PK,
        
        /// <remarks/>
        PL,
        
        /// <remarks/>
        PM,
        
        /// <remarks/>
        PN,
        
        /// <remarks/>
        PR,
        
        /// <remarks/>
        PS,
        
        /// <remarks/>
        PT,
        
        /// <remarks/>
        PW,
        
        /// <remarks/>
        PY,
        
        /// <remarks/>
        QA,
        
        /// <remarks/>
        RE,
        
        /// <remarks/>
        RO,
        
        /// <remarks/>
        RS,
        
        /// <remarks/>
        RU,
        
        /// <remarks/>
        RW,
        
        /// <remarks/>
        SA,
        
        /// <remarks/>
        SB,
        
        /// <remarks/>
        SC,
        
        /// <remarks/>
        SD,
        
        /// <remarks/>
        SE,
        
        /// <remarks/>
        SG,
        
        /// <remarks/>
        SH,
        
        /// <remarks/>
        SI,
        
        /// <remarks/>
        SJ,
        
        /// <remarks/>
        SK,
        
        /// <remarks/>
        SL,
        
        /// <remarks/>
        SM,
        
        /// <remarks/>
        SN,
        
        /// <remarks/>
        SO,
        
        /// <remarks/>
        SR,
        
        /// <remarks/>
        ST,
        
        /// <remarks/>
        SV,
        
        /// <remarks/>
        SY,
        
        /// <remarks/>
        SZ,
        
        /// <remarks/>
        TC,
        
        /// <remarks/>
        TD,
        
        /// <remarks/>
        TF,
        
        /// <remarks/>
        TG,
        
        /// <remarks/>
        TH,
        
        /// <remarks/>
        TJ,
        
        /// <remarks/>
        TK,
        
        /// <remarks/>
        TL,
        
        /// <remarks/>
        TM,
        
        /// <remarks/>
        TN,
        
        /// <remarks/>
        TO,
        
        /// <remarks/>
        TR,
        
        /// <remarks/>
        TT,
        
        /// <remarks/>
        TV,
        
        /// <remarks/>
        TW,
        
        /// <remarks/>
        TZ,
        
        /// <remarks/>
        UA,
        
        /// <remarks/>
        UG,
        
        /// <remarks/>
        UM,
        
        /// <remarks/>
        US,
        
        /// <remarks/>
        UY,
        
        /// <remarks/>
        UZ,
        
        /// <remarks/>
        VA,
        
        /// <remarks/>
        VC,
        
        /// <remarks/>
        VE,
        
        /// <remarks/>
        VG,
        
        /// <remarks/>
        VI,
        
        /// <remarks/>
        VN,
        
        /// <remarks/>
        VU,
        
        /// <remarks/>
        WF,
        
        /// <remarks/>
        WS,
        
        /// <remarks/>
        YE,
        
        /// <remarks/>
        YT,
        
        /// <remarks/>
        ZA,
        
        /// <remarks/>
        ZM,
        
        /// <remarks/>
        ZW,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum EmploymentStatusType {
        
        /// <remarks/>
        Contract,
        
        /// <remarks/>
        Employed,
        
        /// <remarks/>
        Homemaker,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Retired,
        
        /// <remarks/>
        SelfEmployed,
        
        /// <remarks/>
        Student,
        
        /// <remarks/>
        Temporary,
        
        /// <remarks/>
        Unemployed,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Employment {
        
        private string employmentIdField;
        
        private string employerPartyIdField;
        
        private string employerNameField;
        
        private System.DateTime employmentStartDateField;
        
        private bool employmentStartDateFieldSpecified;
        
        private System.DateTime employmentEndDateField;
        
        private bool employmentEndDateFieldSpecified;
        
        private string timeAtEmployerField;
        
        private string employeeOccupationField;
        
        private Address[] employerAddressField;
        
        private Phone[] employerPhoneField;
        
        private EmployerStatusType employerStatusField;
        
        private bool employerStatusFieldSpecified;
        
        private EmploymentType typeField;
        
        private bool typeFieldSpecified;
        
        private IncomeDetail employmentIncomeField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string employmentId {
            get {
                return this.employmentIdField;
            }
            set {
                this.employmentIdField = value;
            }
        }
        
        /// <remarks/>
        public string employerPartyId {
            get {
                return this.employerPartyIdField;
            }
            set {
                this.employerPartyIdField = value;
            }
        }
        
        /// <remarks/>
        public string employerName {
            get {
                return this.employerNameField;
            }
            set {
                this.employerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime employmentStartDate {
            get {
                return this.employmentStartDateField;
            }
            set {
                this.employmentStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool employmentStartDateSpecified {
            get {
                return this.employmentStartDateFieldSpecified;
            }
            set {
                this.employmentStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime employmentEndDate {
            get {
                return this.employmentEndDateField;
            }
            set {
                this.employmentEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool employmentEndDateSpecified {
            get {
                return this.employmentEndDateFieldSpecified;
            }
            set {
                this.employmentEndDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string timeAtEmployer {
            get {
                return this.timeAtEmployerField;
            }
            set {
                this.timeAtEmployerField = value;
            }
        }
        
        /// <remarks/>
        public string employeeOccupation {
            get {
                return this.employeeOccupationField;
            }
            set {
                this.employeeOccupationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employerAddress")]
        public Address[] employerAddress {
            get {
                return this.employerAddressField;
            }
            set {
                this.employerAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employerPhone")]
        public Phone[] employerPhone {
            get {
                return this.employerPhoneField;
            }
            set {
                this.employerPhoneField = value;
            }
        }
        
        /// <remarks/>
        public EmployerStatusType employerStatus {
            get {
                return this.employerStatusField;
            }
            set {
                this.employerStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool employerStatusSpecified {
            get {
                return this.employerStatusFieldSpecified;
            }
            set {
                this.employerStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmploymentType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncomeDetail employmentIncome {
            get {
                return this.employmentIncomeField;
            }
            set {
                this.employmentIncomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class Address {
        
        private string line1Field;
        
        private string line2Field;
        
        private string line3Field;
        
        private string cityField;
        
        private string stateProvinceField;
        
        private string postalCodeField;
        
        private ISOCountryCodeType countryCodeField;
        
        private bool countryCodeFieldSpecified;
        
        private string countryField;
        
        private Coordinate coordinateField;
        
        /// <remarks/>
        public string line1 {
            get {
                return this.line1Field;
            }
            set {
                this.line1Field = value;
            }
        }
        
        /// <remarks/>
        public string line2 {
            get {
                return this.line2Field;
            }
            set {
                this.line2Field = value;
            }
        }
        
        /// <remarks/>
        public string line3 {
            get {
                return this.line3Field;
            }
            set {
                this.line3Field = value;
            }
        }
        
        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string stateProvince {
            get {
                return this.stateProvinceField;
            }
            set {
                this.stateProvinceField = value;
            }
        }
        
        /// <remarks/>
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public ISOCountryCodeType countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryCodeSpecified {
            get {
                return this.countryCodeFieldSpecified;
            }
            set {
                this.countryCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public Coordinate coordinate {
            get {
                return this.coordinateField;
            }
            set {
                this.coordinateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class Coordinate {
        
        private decimal latitudeField;
        
        private decimal longitudeField;
        
        /// <remarks/>
        public decimal latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        public decimal longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class ContactAddress : Address {
        
        private ContactAddressType typeField;
        
        private bool typeFieldSpecified;
        
        private System.DateTime effectiveDateTimeField;
        
        private bool effectiveDateTimeFieldSpecified;
        
        private System.DateTime expirationDateTimeField;
        
        private bool expirationDateTimeFieldSpecified;
        
        private string timeAtAddressField;
        
        private System.DateTime addressVerifyDateTimeField;
        
        private bool addressVerifyDateTimeFieldSpecified;
        
        /// <remarks/>
        public ContactAddressType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime effectiveDateTime {
            get {
                return this.effectiveDateTimeField;
            }
            set {
                this.effectiveDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateTimeSpecified {
            get {
                return this.effectiveDateTimeFieldSpecified;
            }
            set {
                this.effectiveDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime expirationDateTime {
            get {
                return this.expirationDateTimeField;
            }
            set {
                this.expirationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateTimeSpecified {
            get {
                return this.expirationDateTimeFieldSpecified;
            }
            set {
                this.expirationDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string timeAtAddress {
            get {
                return this.timeAtAddressField;
            }
            set {
                this.timeAtAddressField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime addressVerifyDateTime {
            get {
                return this.addressVerifyDateTimeField;
            }
            set {
                this.addressVerifyDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool addressVerifyDateTimeSpecified {
            get {
                return this.addressVerifyDateTimeFieldSpecified;
            }
            set {
                this.addressVerifyDateTimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum ContactAddressType {
        
        /// <remarks/>
        Home,
        
        /// <remarks/>
        Work,
        
        /// <remarks/>
        Mailing,
        
        /// <remarks/>
        Previous,
        
        /// <remarks/>
        Temporary,
        
        /// <remarks/>
        CTR,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class Phone {
        
        private PhoneType typeField;
        
        private bool typeFieldSpecified;
        
        private string numberField;
        
        private string extensionField;
        
        private PhonePlanFormat planFormatField;
        
        private bool planFormatFieldSpecified;
        
        private string descriptionField;
        
        private bool smsRegisteredField;
        
        private bool smsRegisteredFieldSpecified;
        
        /// <remarks/>
        public PhoneType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public string extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        public PhonePlanFormat planFormat {
            get {
                return this.planFormatField;
            }
            set {
                this.planFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool planFormatSpecified {
            get {
                return this.planFormatFieldSpecified;
            }
            set {
                this.planFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public bool smsRegistered {
            get {
                return this.smsRegisteredField;
            }
            set {
                this.smsRegisteredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool smsRegisteredSpecified {
            get {
                return this.smsRegisteredFieldSpecified;
            }
            set {
                this.smsRegisteredFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum PhoneType {
        
        /// <remarks/>
        Home,
        
        /// <remarks/>
        Work,
        
        /// <remarks/>
        Mobile,
        
        /// <remarks/>
        Pager,
        
        /// <remarks/>
        Fax,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum PhonePlanFormat {
        
        /// <remarks/>
        Nanp,
        
        /// <remarks/>
        NanpLessCountryCode,
        
        /// <remarks/>
        OtherInternational,
        
        /// <remarks/>
        NationalNumber,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum EmployerStatusType {
        
        /// <remarks/>
        Current,
        
        /// <remarks/>
        Previous,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum EmploymentType {
        
        /// <remarks/>
        FullTime,
        
        /// <remarks/>
        PartTime,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class IncomeDetail {
        
        private Income grossIncomeDataField;
        
        private Income netIncomeDataField;
        
        /// <remarks/>
        public Income grossIncomeData {
            get {
                return this.grossIncomeDataField;
            }
            set {
                this.grossIncomeDataField = value;
            }
        }
        
        /// <remarks/>
        public Income netIncomeData {
            get {
                return this.netIncomeDataField;
            }
            set {
                this.netIncomeDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Income {
        
        private Money amountField;
        
        private FrequencyType frequencyField;
        
        private bool frequencyFieldSpecified;
        
        private string otherFrequencyTypeField;
        
        private bool excludeIncomeFromCalculationsField;
        
        private ValuePair[] customDataField;
        
        public Income() {
            this.excludeIncomeFromCalculationsField = false;
        }
        
        /// <remarks/>
        public Money amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public FrequencyType frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool frequencySpecified {
            get {
                return this.frequencyFieldSpecified;
            }
            set {
                this.frequencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string otherFrequencyType {
            get {
                return this.otherFrequencyTypeField;
            }
            set {
                this.otherFrequencyTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool excludeIncomeFromCalculations {
            get {
                return this.excludeIncomeFromCalculationsField;
            }
            set {
                this.excludeIncomeFromCalculationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum FrequencyType {
        
        /// <remarks/>
        Biweekly,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        SemiMonthly,
        
        /// <remarks/>
        Other,
        
        /// <remarks/>
        Weekly,
        
        /// <remarks/>
        Yearly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class AdditionalIncome : Income {
        
        private string sourceField;
        
        /// <remarks/>
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Liability {
        
        private string descriptionField;
        
        private Money paymentField;
        
        private FrequencyType paymentFrequencyField;
        
        private bool paymentFrequencyFieldSpecified;
        
        private Money balanceField;
        
        private bool excludeLiabilityFromCalculationsField;
        
        private bool excludeLiabilityFromCalculationsFieldSpecified;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Money payment {
            get {
                return this.paymentField;
            }
            set {
                this.paymentField = value;
            }
        }
        
        /// <remarks/>
        public FrequencyType paymentFrequency {
            get {
                return this.paymentFrequencyField;
            }
            set {
                this.paymentFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentFrequencySpecified {
            get {
                return this.paymentFrequencyFieldSpecified;
            }
            set {
                this.paymentFrequencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }
        
        /// <remarks/>
        public bool excludeLiabilityFromCalculations {
            get {
                return this.excludeLiabilityFromCalculationsField;
            }
            set {
                this.excludeLiabilityFromCalculationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeLiabilityFromCalculationsSpecified {
            get {
                return this.excludeLiabilityFromCalculationsFieldSpecified;
            }
            set {
                this.excludeLiabilityFromCalculationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Residence {
        
        private HousingStatusType currentHousingStatusField;
        
        private bool currentHousingStatusFieldSpecified;
        
        private HousingOwnershipType currentHousingOwnershipTypeField;
        
        private bool currentHousingOwnershipTypeFieldSpecified;
        
        private HousingDebtType currentHousingDebtTypeField;
        
        private bool currentHousingDebtTypeFieldSpecified;
        
        private HousingType currentHousingTypeField;
        
        private bool currentHousingTypeFieldSpecified;
        
        /// <remarks/>
        public HousingStatusType currentHousingStatus {
            get {
                return this.currentHousingStatusField;
            }
            set {
                this.currentHousingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentHousingStatusSpecified {
            get {
                return this.currentHousingStatusFieldSpecified;
            }
            set {
                this.currentHousingStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HousingOwnershipType currentHousingOwnershipType {
            get {
                return this.currentHousingOwnershipTypeField;
            }
            set {
                this.currentHousingOwnershipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentHousingOwnershipTypeSpecified {
            get {
                return this.currentHousingOwnershipTypeFieldSpecified;
            }
            set {
                this.currentHousingOwnershipTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HousingDebtType currentHousingDebtType {
            get {
                return this.currentHousingDebtTypeField;
            }
            set {
                this.currentHousingDebtTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentHousingDebtTypeSpecified {
            get {
                return this.currentHousingDebtTypeFieldSpecified;
            }
            set {
                this.currentHousingDebtTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HousingType currentHousingType {
            get {
                return this.currentHousingTypeField;
            }
            set {
                this.currentHousingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentHousingTypeSpecified {
            get {
                return this.currentHousingTypeFieldSpecified;
            }
            set {
                this.currentHousingTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum HousingStatusType {
        
        /// <remarks/>
        Rent,
        
        /// <remarks/>
        Own,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum HousingOwnershipType {
        
        /// <remarks/>
        Self,
        
        /// <remarks/>
        Government,
        
        /// <remarks/>
        Military,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum HousingDebtType {
        
        /// <remarks/>
        OwnWithMortgage,
        
        /// <remarks/>
        OwnWithoutMortgage,
        
        /// <remarks/>
        Rent,
        
        /// <remarks/>
        NoHousingExpense,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum HousingType {
        
        /// <remarks/>
        PrimaryResidence,
        
        /// <remarks/>
        NonPrimaryResidence,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Organization {
        
        private OrganizationType organizationTypeField;
        
        private bool organizationTypeFieldSpecified;
        
        private string organizationNameField;
        
        private DoingBusinessAs[] doingBusinessAsListField;
        
        /// <remarks/>
        public OrganizationType organizationType {
            get {
                return this.organizationTypeField;
            }
            set {
                this.organizationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool organizationTypeSpecified {
            get {
                return this.organizationTypeFieldSpecified;
            }
            set {
                this.organizationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string organizationName {
            get {
                return this.organizationNameField;
            }
            set {
                this.organizationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("doingBusinessAs")]
        public DoingBusinessAs[] doingBusinessAsList {
            get {
                return this.doingBusinessAsListField;
            }
            set {
                this.doingBusinessAsListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum OrganizationType {
        
        /// <remarks/>
        SoleProprietorship,
        
        /// <remarks/>
        Llc,
        
        /// <remarks/>
        Partnership,
        
        /// <remarks/>
        Corporation,
        
        /// <remarks/>
        NotForProfit,
        
        /// <remarks/>
        Club,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class DoingBusinessAs {
        
        private string doingBusinessAsIdField;
        
        private string doingBusinessAsNameField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string doingBusinessAsId {
            get {
                return this.doingBusinessAsIdField;
            }
            set {
                this.doingBusinessAsIdField = value;
            }
        }
        
        /// <remarks/>
        public string doingBusinessAsName {
            get {
                return this.doingBusinessAsNameField;
            }
            set {
                this.doingBusinessAsNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class Trust {
        
        private string trustNameField;
        
        /// <remarks/>
        public string trustName {
            get {
                return this.trustNameField;
            }
            set {
                this.trustNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class IdentificationDocument {
        
        private string idDocumentIdentiferField;
        
        private IdDocumentType idDocumentTypeField;
        
        private string idIssuedByField;
        
        private System.DateTime idIssueDateField;
        
        private bool idIssueDateFieldSpecified;
        
        private System.DateTime idExpirationDateField;
        
        private bool idExpirationDateFieldSpecified;
        
        private string idDisplayOrderField;
        
        private System.DateTime idVerifyDateTimeField;
        
        private bool idVerifyDateTimeFieldSpecified;
        
        private string documentIdField;
        
        /// <remarks/>
        public string IdDocumentIdentifer {
            get {
                return this.idDocumentIdentiferField;
            }
            set {
                this.idDocumentIdentiferField = value;
            }
        }
        
        /// <remarks/>
        public IdDocumentType idDocumentType {
            get {
                return this.idDocumentTypeField;
            }
            set {
                this.idDocumentTypeField = value;
            }
        }
        
        /// <remarks/>
        public string idIssuedBy {
            get {
                return this.idIssuedByField;
            }
            set {
                this.idIssuedByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime idIssueDate {
            get {
                return this.idIssueDateField;
            }
            set {
                this.idIssueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idIssueDateSpecified {
            get {
                return this.idIssueDateFieldSpecified;
            }
            set {
                this.idIssueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime idExpirationDate {
            get {
                return this.idExpirationDateField;
            }
            set {
                this.idExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idExpirationDateSpecified {
            get {
                return this.idExpirationDateFieldSpecified;
            }
            set {
                this.idExpirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string idDisplayOrder {
            get {
                return this.idDisplayOrderField;
            }
            set {
                this.idDisplayOrderField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime idVerifyDateTime {
            get {
                return this.idVerifyDateTimeField;
            }
            set {
                this.idVerifyDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idVerifyDateTimeSpecified {
            get {
                return this.idVerifyDateTimeFieldSpecified;
            }
            set {
                this.idVerifyDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string documentId {
            get {
                return this.documentIdField;
            }
            set {
                this.documentIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class IdDocumentType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estateDocument", typeof(IdDocumentTypeEstateDocument))]
        [System.Xml.Serialization.XmlElementAttribute("individualDocument", typeof(IdDocumentTypeIndividualDocument))]
        [System.Xml.Serialization.XmlElementAttribute("organizationDocument", typeof(IdDocumentTypeOrganizationDocument))]
        [System.Xml.Serialization.XmlElementAttribute("trustDocument", typeof(IdDocumentTypeTrustDocument))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IdDocumentTypeEstateDocument {
        
        /// <remarks/>
        Will,
        
        /// <remarks/>
        EstateInstrument,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IdDocumentTypeIndividualDocument {
        
        /// <remarks/>
        DriversLicense,
        
        /// <remarks/>
        USPassport,
        
        /// <remarks/>
        MilitaryId,
        
        /// <remarks/>
        StateIssuedId,
        
        /// <remarks/>
        BirthCertficate,
        
        /// <remarks/>
        ForeignPassport,
        
        /// <remarks/>
        KnownExistingParty,
        
        /// <remarks/>
        ForeignGovernmentId,
        
        /// <remarks/>
        ResidentAlienCard,
        
        /// <remarks/>
        NonResidentAlienCard,
        
        /// <remarks/>
        DisabledElderlyWithNoId,
        
        /// <remarks/>
        ForeignEntityWithNoId,
        
        /// <remarks/>
        LawEnforcementId,
        
        /// <remarks/>
        AmishPartyWithNoId,
        
        /// <remarks/>
        ForeignDriversLicense,
        
        /// <remarks/>
        InsuranceCard,
        
        /// <remarks/>
        OrganizationalMembershipCard,
        
        /// <remarks/>
        PropertyTaxBill,
        
        /// <remarks/>
        SocialSecurityCard,
        
        /// <remarks/>
        StudentId,
        
        /// <remarks/>
        UtilityBill,
        
        /// <remarks/>
        Visa,
        
        /// <remarks/>
        DepartmentHomelandSecurityEmploymentAuthorization,
        
        /// <remarks/>
        VoterRegistrationCard,
        
        /// <remarks/>
        Photo,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IdDocumentTypeOrganizationDocument {
        
        /// <remarks/>
        StateCorporateId,
        
        /// <remarks/>
        StateDba,
        
        /// <remarks/>
        ArticlesOfIncorporation,
        
        /// <remarks/>
        BusinessLicense,
        
        /// <remarks/>
        CorporateResolution,
        
        /// <remarks/>
        SecretaryOfStateFilingReceipt,
        
        /// <remarks/>
        AssociationMinutes,
        
        /// <remarks/>
        PartnershipAgreement,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public enum IdDocumentTypeTrustDocument {
        
        /// <remarks/>
        TrustDocument,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class EligibilityRequirementMet {
        
        private string requirementIDField;
        
        private string referenceDescriptionField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string requirementID {
            get {
                return this.requirementIDField;
            }
            set {
                this.requirementIDField = value;
            }
        }
        
        /// <remarks/>
        public string referenceDescription {
            get {
                return this.referenceDescriptionField;
            }
            set {
                this.referenceDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class Contact {
        
        private string contactIdField;
        
        private ContactType contactTypeField;
        
        private ContactAddress addressField;
        
        private Phone phoneField;
        
        private Email emailField;
        
        private ContactInstantMessage instantMessageField;
        
        private ContactSocial socialField;
        
        private ContactWebsite websiteField;
        
        private TimeOfDayType timeOfDayField;
        
        private bool timeOfDayFieldSpecified;
        
        private DemonstratedAccess demonstratedAccessField;
        
        private bool badContactPointField;
        
        private bool badContactPointFieldSpecified;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string contactId {
            get {
                return this.contactIdField;
            }
            set {
                this.contactIdField = value;
            }
        }
        
        /// <remarks/>
        public ContactType contactType {
            get {
                return this.contactTypeField;
            }
            set {
                this.contactTypeField = value;
            }
        }
        
        /// <remarks/>
        public ContactAddress address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public Phone phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public Email email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public ContactInstantMessage instantMessage {
            get {
                return this.instantMessageField;
            }
            set {
                this.instantMessageField = value;
            }
        }
        
        /// <remarks/>
        public ContactSocial social {
            get {
                return this.socialField;
            }
            set {
                this.socialField = value;
            }
        }
        
        /// <remarks/>
        public ContactWebsite website {
            get {
                return this.websiteField;
            }
            set {
                this.websiteField = value;
            }
        }
        
        /// <remarks/>
        public TimeOfDayType timeOfDay {
            get {
                return this.timeOfDayField;
            }
            set {
                this.timeOfDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeOfDaySpecified {
            get {
                return this.timeOfDayFieldSpecified;
            }
            set {
                this.timeOfDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DemonstratedAccess demonstratedAccess {
            get {
                return this.demonstratedAccessField;
            }
            set {
                this.demonstratedAccessField = value;
            }
        }
        
        /// <remarks/>
        public bool badContactPoint {
            get {
                return this.badContactPointField;
            }
            set {
                this.badContactPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool badContactPointSpecified {
            get {
                return this.badContactPointFieldSpecified;
            }
            set {
                this.badContactPointFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum ContactType {
        
        /// <remarks/>
        Address,
        
        /// <remarks/>
        Phone,
        
        /// <remarks/>
        Email,
        
        /// <remarks/>
        InstantMessaging,
        
        /// <remarks/>
        Social,
        
        /// <remarks/>
        Website,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class Email {
        
        private EmailType typeField;
        
        private bool typeFieldSpecified;
        
        private string addressField;
        
        /// <remarks/>
        public EmailType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum EmailType {
        
        /// <remarks/>
        Home,
        
        /// <remarks/>
        Work,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class ContactInstantMessage {
        
        private string messagingServiceField;
        
        private string userField;
        
        /// <remarks/>
        public string messagingService {
            get {
                return this.messagingServiceField;
            }
            set {
                this.messagingServiceField = value;
            }
        }
        
        /// <remarks/>
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class ContactSocial {
        
        private string socialServiceField;
        
        private string userField;
        
        /// <remarks/>
        public string socialService {
            get {
                return this.socialServiceField;
            }
            set {
                this.socialServiceField = value;
            }
        }
        
        /// <remarks/>
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class ContactWebsite {
        
        private string sitenameField;
        
        private string userField;
        
        /// <remarks/>
        public string sitename {
            get {
                return this.sitenameField;
            }
            set {
                this.sitenameField = value;
            }
        }
        
        /// <remarks/>
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public enum TimeOfDayType {
        
        /// <remarks/>
        Afternoon,
        
        /// <remarks/>
        Evening,
        
        /// <remarks/>
        Morning,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class DemonstratedAccess {
        
        private System.DateTime dateTimeField;
        
        private bool dateTimeFieldSpecified;
        
        private string fullNameField;
        
        private string userNameField;
        
        /// <remarks/>
        public System.DateTime dateTime {
            get {
                return this.dateTimeField;
            }
            set {
                this.dateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateTimeSpecified {
            get {
                return this.dateTimeFieldSpecified;
            }
            set {
                this.dateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string fullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ApplicationFilter.xsd")]
    public partial class ApplicationFilter {
        
        private string[] applicationIdListField;
        
        private System.Nullable<AccountType>[] productTypeListField;
        
        private string productSubTypeListField;
        
        private string[] relationshipIdListField;
        
        private string[] partyIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("applicationId", Namespace="http://cufxstandards.com/v2/Application.xsd", IsNullable=false)]
        public string[] applicationIdList {
            get {
                return this.applicationIdListField;
            }
            set {
                this.applicationIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("productType", Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
        public System.Nullable<AccountType>[] productTypeList {
            get {
                return this.productTypeListField;
            }
            set {
                this.productTypeListField = value;
            }
        }
        
        /// <remarks/>
        public string productSubTypeList {
            get {
                return this.productSubTypeListField;
            }
            set {
                this.productSubTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Artifact.xsd")]
    public partial class ArtifactList {
        
        private Artifact[] artifactField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artifact")]
        public Artifact[] artifact {
            get {
                return this.artifactField;
            }
            set {
                this.artifactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Artifact.xsd")]
    public partial class Artifact {
        
        private ArtifactId artifactIdField;
        
        private string artifactTypeField;
        
        private string externalIdField;
        
        private byte[] artifactField;
        
        private string artifactNameField;
        
        private string artifactDescriptionField;
        
        private string artifactOwnerField;
        
        private System.Nullable<System.DateTime> artifactCreationDateField;
        
        private bool artifactCreationDateFieldSpecified;
        
        private System.Nullable<System.DateTime> artifactModifiedDateField;
        
        private bool artifactModifiedDateFieldSpecified;
        
        private System.Nullable<System.DateTime> artifactArchivedDateField;
        
        private bool artifactArchivedDateFieldSpecified;
        
        private System.Nullable<System.DateTime> artifactDeletedDateField;
        
        private bool artifactDeletedDateFieldSpecified;
        
        private string artifactCompressionTypeField;
        
        private bool artifactArchivedField;
        
        private bool artifactArchivedFieldSpecified;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public ArtifactId artifactId {
            get {
                return this.artifactIdField;
            }
            set {
                this.artifactIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string artifactType {
            get {
                return this.artifactTypeField;
            }
            set {
                this.artifactTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] artifact {
            get {
                return this.artifactField;
            }
            set {
                this.artifactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string artifactName {
            get {
                return this.artifactNameField;
            }
            set {
                this.artifactNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string artifactDescription {
            get {
                return this.artifactDescriptionField;
            }
            set {
                this.artifactDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string artifactOwner {
            get {
                return this.artifactOwnerField;
            }
            set {
                this.artifactOwnerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> artifactCreationDate {
            get {
                return this.artifactCreationDateField;
            }
            set {
                this.artifactCreationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool artifactCreationDateSpecified {
            get {
                return this.artifactCreationDateFieldSpecified;
            }
            set {
                this.artifactCreationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> artifactModifiedDate {
            get {
                return this.artifactModifiedDateField;
            }
            set {
                this.artifactModifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool artifactModifiedDateSpecified {
            get {
                return this.artifactModifiedDateFieldSpecified;
            }
            set {
                this.artifactModifiedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> artifactArchivedDate {
            get {
                return this.artifactArchivedDateField;
            }
            set {
                this.artifactArchivedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool artifactArchivedDateSpecified {
            get {
                return this.artifactArchivedDateFieldSpecified;
            }
            set {
                this.artifactArchivedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> artifactDeletedDate {
            get {
                return this.artifactDeletedDateField;
            }
            set {
                this.artifactDeletedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool artifactDeletedDateSpecified {
            get {
                return this.artifactDeletedDateFieldSpecified;
            }
            set {
                this.artifactDeletedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string artifactCompressionType {
            get {
                return this.artifactCompressionTypeField;
            }
            set {
                this.artifactCompressionTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool artifactArchived {
            get {
                return this.artifactArchivedField;
            }
            set {
                this.artifactArchivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool artifactArchivedSpecified {
            get {
                return this.artifactArchivedFieldSpecified;
            }
            set {
                this.artifactArchivedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Artifact.xsd")]
    public partial class ArtifactId {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artifactIdKeyValueList", typeof(CustomData))]
        [System.Xml.Serialization.XmlElementAttribute("artifactUniqueId", typeof(object))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class CustomData {
        
        private ValuePair[] valuePairField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valuePair")]
        public ValuePair[] valuePair {
            get {
                return this.valuePairField;
            }
            set {
                this.valuePairField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Card.xsd")]
    public partial class CardList {
        
        private Card[] cardField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("card")]
        public Card[] card {
            get {
                return this.cardField;
            }
            set {
                this.cardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Card.xsd")]
    public partial class Card {
        
        private string cardIdField;
        
        private string cardNumberField;
        
        private CardType cardTypeField;
        
        private string cardSubTypeField;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private string pinField;
        
        private string cvv2Field;
        
        private LinkedAccount[] linkedAccountListField;
        
        private string partyIdField;
        
        private string overrideAddressContactIdField;
        
        private string[] nameOnCardField;
        
        /// <remarks/>
        public string cardId {
            get {
                return this.cardIdField;
            }
            set {
                this.cardIdField = value;
            }
        }
        
        /// <remarks/>
        public string cardNumber {
            get {
                return this.cardNumberField;
            }
            set {
                this.cardNumberField = value;
            }
        }
        
        /// <remarks/>
        public CardType cardType {
            get {
                return this.cardTypeField;
            }
            set {
                this.cardTypeField = value;
            }
        }
        
        /// <remarks/>
        public string cardSubType {
            get {
                return this.cardSubTypeField;
            }
            set {
                this.cardSubTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string pin {
            get {
                return this.pinField;
            }
            set {
                this.pinField = value;
            }
        }
        
        /// <remarks/>
        public string cvv2 {
            get {
                return this.cvv2Field;
            }
            set {
                this.cvv2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("linkedAccount", IsNullable=false)]
        public LinkedAccount[] linkedAccountList {
            get {
                return this.linkedAccountListField;
            }
            set {
                this.linkedAccountListField = value;
            }
        }
        
        /// <remarks/>
        public string partyId {
            get {
                return this.partyIdField;
            }
            set {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        public string overrideAddressContactId {
            get {
                return this.overrideAddressContactIdField;
            }
            set {
                this.overrideAddressContactIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nameOnCard")]
        public string[] nameOnCard {
            get {
                return this.nameOnCardField;
            }
            set {
                this.nameOnCardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Card.xsd")]
    public enum CardType {
        
        /// <remarks/>
        Atm,
        
        /// <remarks/>
        Credit,
        
        /// <remarks/>
        Debit,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Card.xsd")]
    public partial class LinkedAccount {
        
        private string accountIdField;
        
        private string priorityField;
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CardFilter.xsd")]
    public partial class CardFilter {
        
        private string[] cardIdListField;
        
        private string[] partyIdListField;
        
        private string[] accountIdListField;
        
        private System.DateTime transactionStartDateTimeField;
        
        private bool transactionStartDateTimeFieldSpecified;
        
        private System.DateTime transactionEndDateTimeField;
        
        private bool transactionEndDateTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cardId", Namespace="http://cufxstandards.com/v2/Card.xsd", IsNullable=false)]
        public string[] cardIdList {
            get {
                return this.cardIdListField;
            }
            set {
                this.cardIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime transactionStartDateTime {
            get {
                return this.transactionStartDateTimeField;
            }
            set {
                this.transactionStartDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionStartDateTimeSpecified {
            get {
                return this.transactionStartDateTimeFieldSpecified;
            }
            set {
                this.transactionStartDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime transactionEndDateTime {
            get {
                return this.transactionEndDateTimeField;
            }
            set {
                this.transactionEndDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionEndDateTimeSpecified {
            get {
                return this.transactionEndDateTimeFieldSpecified;
            }
            set {
                this.transactionEndDateTimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Collateral.xsd")]
    public partial class CollateralList {
        
        private Collateral[] collateralField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("collateral")]
        public Collateral[] collateral {
            get {
                return this.collateralField;
            }
            set {
                this.collateralField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CollateralFilter.xsd")]
    public partial class CollateralFilter {
        
        private string[] collateralIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("collateralId", Namespace="http://cufxstandards.com/v2/Collateral.xsd", IsNullable=false)]
        public string[] collateralIdList {
            get {
                return this.collateralIdListField;
            }
            set {
                this.collateralIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class ConfigurationList {
        
        private Configuration[] configurationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("configuration")]
        public Configuration[] configuration {
            get {
                return this.configurationField;
            }
            set {
                this.configurationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class Configuration {
        
        private string[] fiIdListField;
        
        private string endPointTimeZoneUTOffsetField;
        
        private Service[] serviceListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fiId", IsNullable=false)]
        public string[] fiIdList {
            get {
                return this.fiIdListField;
            }
            set {
                this.fiIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string endPointTimeZoneUTOffset {
            get {
                return this.endPointTimeZoneUTOffsetField;
            }
            set {
                this.endPointTimeZoneUTOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("service", IsNullable=false)]
        public Service[] serviceList {
            get {
                return this.serviceListField;
            }
            set {
                this.serviceListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class Service {
        
        private ServiceName serviceNameField;
        
        private Protocol protocolField;
        
        private CufxVersion cufxVersionField;
        
        private string wsdlUriField;
        
        private ISOCurrencyCodeType[] currencySupportListField;
        
        private string[] acceptLanguageListField;
        
        private FieldNotSupported[] fieldNotSupportedListField;
        
        private string serviceTimeZoneUTOffsetField;
        
        private CustomDataUse[] customDataUseListField;
        
        private MethodList methodListField;
        
        /// <remarks/>
        public ServiceName serviceName {
            get {
                return this.serviceNameField;
            }
            set {
                this.serviceNameField = value;
            }
        }
        
        /// <remarks/>
        public Protocol protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        
        /// <remarks/>
        public CufxVersion cufxVersion {
            get {
                return this.cufxVersionField;
            }
            set {
                this.cufxVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string wsdlUri {
            get {
                return this.wsdlUriField;
            }
            set {
                this.wsdlUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("currencySupport", IsNullable=false)]
        public ISOCurrencyCodeType[] currencySupportList {
            get {
                return this.currencySupportListField;
            }
            set {
                this.currencySupportListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("acceptLanguage", IsNullable=false)]
        public string[] acceptLanguageList {
            get {
                return this.acceptLanguageListField;
            }
            set {
                this.acceptLanguageListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldNotSupported", IsNullable=false)]
        public FieldNotSupported[] fieldNotSupportedList {
            get {
                return this.fieldNotSupportedListField;
            }
            set {
                this.fieldNotSupportedListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string serviceTimeZoneUTOffset {
            get {
                return this.serviceTimeZoneUTOffsetField;
            }
            set {
                this.serviceTimeZoneUTOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customDataUse", IsNullable=false)]
        public CustomDataUse[] customDataUseList {
            get {
                return this.customDataUseListField;
            }
            set {
                this.customDataUseListField = value;
            }
        }
        
        /// <remarks/>
        public MethodList methodList {
            get {
                return this.methodListField;
            }
            set {
                this.methodListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public enum ServiceName {
        
        /// <remarks/>
        Account,
        
        /// <remarks/>
        Application,
        
        /// <remarks/>
        Artifact,
        
        /// <remarks/>
        Card,
        
        /// <remarks/>
        Configuration,
        
        /// <remarks/>
        Contact,
        
        /// <remarks/>
        CredentialGroup,
        
        /// <remarks/>
        Deposit,
        
        /// <remarks/>
        DepositFunding,
        
        /// <remarks/>
        EligibilityRequirement,
        
        /// <remarks/>
        Loan,
        
        /// <remarks/>
        LoanDisbursement,
        
        /// <remarks/>
        OverdraftPriority,
        
        /// <remarks/>
        Party,
        
        /// <remarks/>
        PartyAssociation,
        
        /// <remarks/>
        Preference,
        
        /// <remarks/>
        ProductOffering,
        
        /// <remarks/>
        ProductServiceRequest,
        
        /// <remarks/>
        Relationship,
        
        /// <remarks/>
        SimpleValidationRequest,
        
        /// <remarks/>
        CreditReporting,
        
        /// <remarks/>
        Identification,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public enum Protocol {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("REST-XML")]
        RESTXML,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("REST-JSON")]
        RESTJSON,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SOAP1.1")]
        SOAP11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SOAP1.2")]
        SOAP12,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public enum CufxVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.0.3")]
        Item103,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.0.6")]
        Item106,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.0.0")]
        Item200,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class FieldNotSupported {
        
        private string xsdFileField;
        
        private string xsdXPathField;
        
        private string commentField;
        
        /// <remarks/>
        public string xsdFile {
            get {
                return this.xsdFileField;
            }
            set {
                this.xsdFileField = value;
            }
        }
        
        /// <remarks/>
        public string xsdXPath {
            get {
                return this.xsdXPathField;
            }
            set {
                this.xsdXPathField = value;
            }
        }
        
        /// <remarks/>
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class CustomDataUse {
        
        private string xsdFileField;
        
        private string xsdXPathField;
        
        private string[] nameField;
        
        private string commentField;
        
        /// <remarks/>
        public string xsdFile {
            get {
                return this.xsdFileField;
            }
            set {
                this.xsdFileField = value;
            }
        }
        
        /// <remarks/>
        public string xsdXPath {
            get {
                return this.xsdXPathField;
            }
            set {
                this.xsdXPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class MethodList {
        
        private Method methodField;
        
        /// <remarks/>
        public Method method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class Method {
        
        private MethodName methodNameField;
        
        private string uriField;
        
        private MethodDependencyList methodDependencyListField;
        
        /// <remarks/>
        public MethodName methodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
        
        /// <remarks/>
        public MethodDependencyList methodDependencyList {
            get {
                return this.methodDependencyListField;
            }
            set {
                this.methodDependencyListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public enum MethodName {
        
        /// <remarks/>
        Create,
        
        /// <remarks/>
        Read,
        
        /// <remarks/>
        Update,
        
        /// <remarks/>
        Delete,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class MethodDependencyList {
        
        private MethodDependency methodDependencyField;
        
        /// <remarks/>
        public MethodDependency methodDependency {
            get {
                return this.methodDependencyField;
            }
            set {
                this.methodDependencyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Configuration.xsd")]
    public partial class MethodDependency {
        
        private ServiceName serviceNameField;
        
        private string methodNameField;
        
        private CufxVersion cufxVersionField;
        
        /// <remarks/>
        public ServiceName serviceName {
            get {
                return this.serviceNameField;
            }
            set {
                this.serviceNameField = value;
            }
        }
        
        /// <remarks/>
        public string methodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
            }
        }
        
        /// <remarks/>
        public CufxVersion cufxVersion {
            get {
                return this.cufxVersionField;
            }
            set {
                this.cufxVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Contact.xsd")]
    public partial class ContactList {
        
        private Contact[] contactField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Contact[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ContactFilter.xsd")]
    public partial class ContactFilter {
        
        private string[] contactIdListField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private string[] taxIdListField;
        
        private ContactType[] contactTypeListField;
        
        private bool badContactPointField;
        
        private bool badContactPointFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("taxId", Namespace="http://cufxstandards.com/v2/Party.xsd", DataType="token", IsNullable=false)]
        public string[] taxIdList {
            get {
                return this.taxIdListField;
            }
            set {
                this.taxIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactType", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public ContactType[] contactTypeList {
            get {
                return this.contactTypeListField;
            }
            set {
                this.contactTypeListField = value;
            }
        }
        
        /// <remarks/>
        public bool badContactPoint {
            get {
                return this.badContactPointField;
            }
            set {
                this.badContactPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool badContactPointSpecified {
            get {
                return this.badContactPointFieldSpecified;
            }
            set {
                this.badContactPointFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd")]
    public partial class CredentialGroupList {
        
        private CredentialGroup[] credentialGroupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credentialGroup", IsNullable=true)]
        public CredentialGroup[] credentialGroup {
            get {
                return this.credentialGroupField;
            }
            set {
                this.credentialGroupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd")]
    public partial class CredentialGroup {
        
        private string fiUserIdField;
        
        private Credential[] credentialListField;
        
        private DeliveryChannel[] deliveryChannelListField;
        
        /// <remarks/>
        public string fiUserId {
            get {
                return this.fiUserIdField;
            }
            set {
                this.fiUserIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("credential", IsNullable=false)]
        public Credential[] credentialList {
            get {
                return this.credentialListField;
            }
            set {
                this.credentialListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("deliveryChannel", IsNullable=false)]
        public DeliveryChannel[] deliveryChannelList {
            get {
                return this.deliveryChannelListField;
            }
            set {
                this.deliveryChannelListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd")]
    public partial class Credential {
        
        private CredentialType typeField;
        
        private bool encryptedField;
        
        private bool encryptedFieldSpecified;
        
        private string valueField;
        
        private System.DateTime expirationDateTimeField;
        
        private bool expirationDateTimeFieldSpecified;
        
        private bool temporaryField;
        
        private bool temporaryFieldSpecified;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public CredentialType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public bool encrypted {
            get {
                return this.encryptedField;
            }
            set {
                this.encryptedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool encryptedSpecified {
            get {
                return this.encryptedFieldSpecified;
            }
            set {
                this.encryptedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN")]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime expirationDateTime {
            get {
                return this.expirationDateTimeField;
            }
            set {
                this.expirationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateTimeSpecified {
            get {
                return this.expirationDateTimeFieldSpecified;
            }
            set {
                this.expirationDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool temporary {
            get {
                return this.temporaryField;
            }
            set {
                this.temporaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool temporarySpecified {
            get {
                return this.temporaryFieldSpecified;
            }
            set {
                this.temporaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd")]
    public enum CredentialType {
        
        /// <remarks/>
        Username,
        
        /// <remarks/>
        Password,
        
        /// <remarks/>
        AtmPin,
        
        /// <remarks/>
        Codeword,
        
        /// <remarks/>
        Token,
        
        /// <remarks/>
        SecurityQuestion,
        
        /// <remarks/>
        SecurityAnswer,
        
        /// <remarks/>
        ChallengeQuestion,
        
        /// <remarks/>
        ChallengeAnswer,
        
        /// <remarks/>
        AntiphishingPhrase,
        
        /// <remarks/>
        AntiphishingImageUrl,
        
        /// <remarks/>
        AntiphishingImageArtifactId,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd")]
    public enum DeliveryChannel {
        
        /// <remarks/>
        LiveSupport,
        
        /// <remarks/>
        OnlineBanking,
        
        /// <remarks/>
        Mobile,
        
        /// <remarks/>
        Kiosk,
        
        /// <remarks/>
        ATM,
        
        /// <remarks/>
        IVR,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CredentialGroupFilter.xsd")]
    public partial class CredentialGroupFilter {
        
        private string[] fiUserIdListField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fiUserId", Namespace="http://cufxstandards.com/v2/CredentialGroup.xsd", IsNullable=false)]
        public string[] fiUserIdList {
            get {
                return this.fiUserIdListField;
            }
            set {
                this.fiUserIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CreditReport.xsd")]
    public partial class CreditReportList {
        
        private CreditReport[] creditReportField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditReport")]
        public CreditReport[] creditReport {
            get {
                return this.creditReportField;
            }
            set {
                this.creditReportField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CreditReportFilter.xsd")]
    public partial class CreditReportFilter {
        
        private string[] creditReportIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("creditReportId", Namespace="http://cufxstandards.com/v2/CreditReport.xsd", IsNullable=false)]
        public string[] creditReportIdList {
            get {
                return this.creditReportIdListField;
            }
            set {
                this.creditReportIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/CreditReportRequest.xsd")]
    public partial class CreditReportRequest {
        
        private Party[] applicantListField;
        
        private string maxReportAgeInDaysField;
        
        private string[] reportTypeListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("applicant", IsNullable=false)]
        public Party[] applicantList {
            get {
                return this.applicantListField;
            }
            set {
                this.applicantListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string maxReportAgeInDays {
            get {
                return this.maxReportAgeInDaysField;
            }
            set {
                this.maxReportAgeInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("reportType", IsNullable=false)]
        public string[] reportTypeList {
            get {
                return this.reportTypeListField;
            }
            set {
                this.reportTypeListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Deposit.xsd")]
    public partial class DepositList {
        
        private Deposit[] depositField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deposit")]
        public Deposit[] deposit {
            get {
                return this.depositField;
            }
            set {
                this.depositField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/DepositFunding.xsd")]
    public partial class DepositFundingList {
        
        private DepositFunding[] depositFundingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("depositFunding")]
        public DepositFunding[] depositFunding {
            get {
                return this.depositFundingField;
            }
            set {
                this.depositFundingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/DepositFunding.xsd")]
    public partial class DepositFunding {
        
        private string targetAccountIdField;
        
        private string fundingSourceIdField;
        
        private SourceOfFunds sourceOfFundsField;
        
        private bool sourceOfFundsFieldSpecified;
        
        private Money fundingAmountField;
        
        private Money holdAmountField;
        
        private System.DateTime holdExpirationDateField;
        
        private bool holdExpirationDateFieldSpecified;
        
        /// <remarks/>
        public string targetAccountId {
            get {
                return this.targetAccountIdField;
            }
            set {
                this.targetAccountIdField = value;
            }
        }
        
        /// <remarks/>
        public string fundingSourceId {
            get {
                return this.fundingSourceIdField;
            }
            set {
                this.fundingSourceIdField = value;
            }
        }
        
        /// <remarks/>
        public SourceOfFunds sourceOfFunds {
            get {
                return this.sourceOfFundsField;
            }
            set {
                this.sourceOfFundsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sourceOfFundsSpecified {
            get {
                return this.sourceOfFundsFieldSpecified;
            }
            set {
                this.sourceOfFundsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Money fundingAmount {
            get {
                return this.fundingAmountField;
            }
            set {
                this.fundingAmountField = value;
            }
        }
        
        /// <remarks/>
        public Money holdAmount {
            get {
                return this.holdAmountField;
            }
            set {
                this.holdAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime holdExpirationDate {
            get {
                return this.holdExpirationDateField;
            }
            set {
                this.holdExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool holdExpirationDateSpecified {
            get {
                return this.holdExpirationDateFieldSpecified;
            }
            set {
                this.holdExpirationDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/DepositFunding.xsd")]
    public enum SourceOfFunds {
        
        /// <remarks/>
        Cash,
        
        /// <remarks/>
        Check,
        
        /// <remarks/>
        Transfer,
        
        /// <remarks/>
        ACH,
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Credit Card")]
        CreditCard,
        
        /// <remarks/>
        Wire,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public partial class DocumentList {
        
        private Document[] documentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("document")]
        public Document[] document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public partial class Document {
        
        private string documentIdField;
        
        private string documentTitleField;
        
        private DocumentType documentTypeField;
        
        private bool documentTypeFieldSpecified;
        
        private string documentSubTypeField;
        
        private ValuePair[] appliesToField;
        
        private DocumentStatus documentStatusField;
        
        private bool documentStatusFieldSpecified;
        
        private string documentVersionField;
        
        private System.DateTime effectiveDateTimeField;
        
        private bool effectiveDateTimeFieldSpecified;
        
        private System.DateTime expirationDateTimeField;
        
        private bool expirationDateTimeFieldSpecified;
        
        private ArtifactId[] documentArtifactIdListField;
        
        private string[] partyIdListField;
        
        private string relationshipIdField;
        
        private string[] accountIdListField;
        
        private bool prefillableField;
        
        private bool prefillableFieldSpecified;
        
        private bool prefilledField;
        
        private bool prefilledFieldSpecified;
        
        private DocumentSignature[] documentSignatureListField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string documentId {
            get {
                return this.documentIdField;
            }
            set {
                this.documentIdField = value;
            }
        }
        
        /// <remarks/>
        public string documentTitle {
            get {
                return this.documentTitleField;
            }
            set {
                this.documentTitleField = value;
            }
        }
        
        /// <remarks/>
        public DocumentType documentType {
            get {
                return this.documentTypeField;
            }
            set {
                this.documentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentTypeSpecified {
            get {
                return this.documentTypeFieldSpecified;
            }
            set {
                this.documentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string documentSubType {
            get {
                return this.documentSubTypeField;
            }
            set {
                this.documentSubTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] appliesTo {
            get {
                return this.appliesToField;
            }
            set {
                this.appliesToField = value;
            }
        }
        
        /// <remarks/>
        public DocumentStatus documentStatus {
            get {
                return this.documentStatusField;
            }
            set {
                this.documentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentStatusSpecified {
            get {
                return this.documentStatusFieldSpecified;
            }
            set {
                this.documentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string documentVersion {
            get {
                return this.documentVersionField;
            }
            set {
                this.documentVersionField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime effectiveDateTime {
            get {
                return this.effectiveDateTimeField;
            }
            set {
                this.effectiveDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateTimeSpecified {
            get {
                return this.effectiveDateTimeFieldSpecified;
            }
            set {
                this.effectiveDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime expirationDateTime {
            get {
                return this.expirationDateTimeField;
            }
            set {
                this.expirationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateTimeSpecified {
            get {
                return this.expirationDateTimeFieldSpecified;
            }
            set {
                this.expirationDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("artifactId", Namespace="http://cufxstandards.com/v2/Artifact.xsd")]
        public ArtifactId[] documentArtifactIdList {
            get {
                return this.documentArtifactIdListField;
            }
            set {
                this.documentArtifactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        public string relationshipId {
            get {
                return this.relationshipIdField;
            }
            set {
                this.relationshipIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        public bool prefillable {
            get {
                return this.prefillableField;
            }
            set {
                this.prefillableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prefillableSpecified {
            get {
                return this.prefillableFieldSpecified;
            }
            set {
                this.prefillableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool prefilled {
            get {
                return this.prefilledField;
            }
            set {
                this.prefilledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prefilledSpecified {
            get {
                return this.prefilledFieldSpecified;
            }
            set {
                this.prefilledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentSignature", IsNullable=false)]
        public DocumentSignature[] documentSignatureList {
            get {
                return this.documentSignatureListField;
            }
            set {
                this.documentSignatureListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public enum DocumentType {
        
        /// <remarks/>
        CheckImage,
        
        /// <remarks/>
        Dislcosure,
        
        /// <remarks/>
        IdentifcationDocument,
        
        /// <remarks/>
        LoanDocument,
        
        /// <remarks/>
        MembershipDocument,
        
        /// <remarks/>
        Notice,
        
        /// <remarks/>
        Receipt,
        
        /// <remarks/>
        Statement,
        
        /// <remarks/>
        Report,
        
        /// <remarks/>
        SignatureCard,
        
        /// <remarks/>
        TaxForm,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public enum DocumentStatus {
        
        /// <remarks/>
        Template,
        
        /// <remarks/>
        Sent,
        
        /// <remarks/>
        Viewed,
        
        /// <remarks/>
        Returned,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public partial class DocumentSignature {
        
        private DocumentSignatureType documentSignatureTypeField;
        
        private bool documentSignatureTypeFieldSpecified;
        
        private System.DateTime documentSignedDateTimeField;
        
        private bool documentSignedDateTimeFieldSpecified;
        
        private string signaturePartyIdField;
        
        private string signedWithIpAddressField;
        
        private string documentDigitalFingerprintField;
        
        private string documentDigitalAlgorithmField;
        
        private string documentDigitalCertificateField;
        
        private string usersPublicKeyField;
        
        /// <remarks/>
        public DocumentSignatureType documentSignatureType {
            get {
                return this.documentSignatureTypeField;
            }
            set {
                this.documentSignatureTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentSignatureTypeSpecified {
            get {
                return this.documentSignatureTypeFieldSpecified;
            }
            set {
                this.documentSignatureTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime documentSignedDateTime {
            get {
                return this.documentSignedDateTimeField;
            }
            set {
                this.documentSignedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentSignedDateTimeSpecified {
            get {
                return this.documentSignedDateTimeFieldSpecified;
            }
            set {
                this.documentSignedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string signaturePartyId {
            get {
                return this.signaturePartyIdField;
            }
            set {
                this.signaturePartyIdField = value;
            }
        }
        
        /// <remarks/>
        public string signedWithIpAddress {
            get {
                return this.signedWithIpAddressField;
            }
            set {
                this.signedWithIpAddressField = value;
            }
        }
        
        /// <remarks/>
        public string documentDigitalFingerprint {
            get {
                return this.documentDigitalFingerprintField;
            }
            set {
                this.documentDigitalFingerprintField = value;
            }
        }
        
        /// <remarks/>
        public string documentDigitalAlgorithm {
            get {
                return this.documentDigitalAlgorithmField;
            }
            set {
                this.documentDigitalAlgorithmField = value;
            }
        }
        
        /// <remarks/>
        public string documentDigitalCertificate {
            get {
                return this.documentDigitalCertificateField;
            }
            set {
                this.documentDigitalCertificateField = value;
            }
        }
        
        /// <remarks/>
        public string usersPublicKey {
            get {
                return this.usersPublicKeyField;
            }
            set {
                this.usersPublicKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Document.xsd")]
    public enum DocumentSignatureType {
        
        /// <remarks/>
        Unsigned,
        
        /// <remarks/>
        ElectronicSignature,
        
        /// <remarks/>
        SingleClickAcceptance,
        
        /// <remarks/>
        WetSignature,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/DocumentFilter.xsd")]
    public partial class DocumentFilter {
        
        private string[] documentIdListField;
        
        private string[] documentTitleListField;
        
        private DocumentType[] documentTypeListField;
        
        private string[] documentSubTypeListField;
        
        private ValuePair[] appliesToField;
        
        private System.DateTime filterDateTimeField;
        
        private bool filterDateTimeFieldSpecified;
        
        private string documentVersionField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private DocumentStatus[] documentStatusListField;
        
        private DocumentSignatureType[] documentSignatureTypeListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentId", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public string[] documentIdList {
            get {
                return this.documentIdListField;
            }
            set {
                this.documentIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentTitle", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public string[] documentTitleList {
            get {
                return this.documentTitleListField;
            }
            set {
                this.documentTitleListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentType", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public DocumentType[] documentTypeList {
            get {
                return this.documentTypeListField;
            }
            set {
                this.documentTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentSubType", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public string[] documentSubTypeList {
            get {
                return this.documentSubTypeListField;
            }
            set {
                this.documentSubTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] appliesTo {
            get {
                return this.appliesToField;
            }
            set {
                this.appliesToField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime filterDateTime {
            get {
                return this.filterDateTimeField;
            }
            set {
                this.filterDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterDateTimeSpecified {
            get {
                return this.filterDateTimeFieldSpecified;
            }
            set {
                this.filterDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string documentVersion {
            get {
                return this.documentVersionField;
            }
            set {
                this.documentVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentStatus", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public DocumentStatus[] documentStatusList {
            get {
                return this.documentStatusListField;
            }
            set {
                this.documentStatusListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentSignatureType", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public DocumentSignatureType[] documentSignatureTypeList {
            get {
                return this.documentSignatureTypeListField;
            }
            set {
                this.documentSignatureTypeListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/EligibilityRequirement.xsd")]
    public partial class EligibilityRequirementList {
        
        private EligibilityRequirement[] eligibilityRequirementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eligibilityRequirement", IsNullable=true)]
        public EligibilityRequirement[] eligibilityRequirement {
            get {
                return this.eligibilityRequirementField;
            }
            set {
                this.eligibilityRequirementField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/EligibilityRequirement.xsd")]
    public partial class EligibilityRequirement {
        
        private string requirementIDField;
        
        private string descriptionField;
        
        private string[] affinityBrandListField;
        
        private string nextActionRequiredIdField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string requirementID {
            get {
                return this.requirementIDField;
            }
            set {
                this.requirementIDField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("affinityBrand")]
        public string[] affinityBrandList {
            get {
                return this.affinityBrandListField;
            }
            set {
                this.affinityBrandListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string nextActionRequiredId {
            get {
                return this.nextActionRequiredIdField;
            }
            set {
                this.nextActionRequiredIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/EligibilityRequirementFilter.xsd")]
    public partial class EligibilityRequirementFilter {
        
        private string[] eligibilityRequirementIdListField;
        
        private string[] affinityBrandListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("requirementID", Namespace="http://cufxstandards.com/v2/EligibilityRequirement.xsd", IsNullable=false)]
        public string[] eligibilityRequirementIdList {
            get {
                return this.eligibilityRequirementIdListField;
            }
            set {
                this.eligibilityRequirementIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("affinityBrand", Namespace="http://cufxstandards.com/v2/EligibilityRequirement.xsd")]
        public string[] affinityBrandList {
            get {
                return this.affinityBrandListField;
            }
            set {
                this.affinityBrandListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Error.xsd")]
    public partial class ErrorList {
        
        private Error[] errorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error", IsNullable=true)]
        public Error[] error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Error.xsd")]
    public partial class Error {
        
        private Code codeField;
        
        private Type typeField;
        
        private string subCodeField;
        
        private string messageField;
        
        private Substitution[] substitutionListField;
        
        /// <remarks/>
        public Code code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public Type type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string subCode {
            get {
                return this.subCodeField;
            }
            set {
                this.subCodeField = value;
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("substitution", IsNullable=false)]
        public Substitution[] substitutionList {
            get {
                return this.substitutionListField;
            }
            set {
                this.substitutionListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Error.xsd")]
    public enum Code {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302")]
        Item302,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("401")]
        Item401,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("402")]
        Item402,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("403")]
        Item403,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("409")]
        Item409,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("411")]
        Item411,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("412")]
        Item412,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("413")]
        Item413,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("415")]
        Item415,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("422")]
        Item422,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("423")]
        Item423,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("424")]
        Item424,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("425")]
        Item425,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("426")]
        Item426,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("429")]
        Item429,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("430")]
        Item430,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("431")]
        Item431,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("432")]
        Item432,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("433")]
        Item433,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("434")]
        Item434,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("435")]
        Item435,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("436")]
        Item436,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("437")]
        Item437,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("438")]
        Item438,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("439")]
        Item439,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("440")]
        Item440,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("441")]
        Item441,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("442")]
        Item442,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("443")]
        Item443,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("444")]
        Item444,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("445")]
        Item445,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("475")]
        Item475,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("497")]
        Item497,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("498")]
        Item498,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("499")]
        Item499,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("503")]
        Item503,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Error.xsd")]
    public enum Type {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100")]
        Item100,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("200")]
        Item200,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("310")]
        Item310,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("320")]
        Item320,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Error.xsd")]
    public partial class Substitution {
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Loan.xsd")]
    public partial class LoanList {
        
        private Loan[] loanField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("loan")]
        public Loan[] loan {
            get {
                return this.loanField;
            }
            set {
                this.loanField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementList {
        
        private LoanDisbursement[] loanDisbursementField;
        
        private string loanIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("loanDisbursement")]
        public LoanDisbursement[] loanDisbursement {
            get {
                return this.loanDisbursementField;
            }
            set {
                this.loanDisbursementField = value;
            }
        }
        
        /// <remarks/>
        public string loanId {
            get {
                return this.loanIdField;
            }
            set {
                this.loanIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursement {
        
        private LoanDisbursementBase itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("loanDisbursementCheck", typeof(LoanDisbursementCheck))]
        [System.Xml.Serialization.XmlElementAttribute("loanDisbursementDealerAch", typeof(LoanDisbursementDealerAch))]
        [System.Xml.Serialization.XmlElementAttribute("loanDisbursementDepositToAccount", typeof(LoanDisbursementDepositToAccount))]
        [System.Xml.Serialization.XmlElementAttribute("loanDisbursementGL", typeof(LoanDisbursementGL))]
        public LoanDisbursementBase Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementCheck : LoanDisbursementBase {
        
        private string[] payeeLinesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payeeLines")]
        public string[] payeeLines {
            get {
                return this.payeeLinesField;
            }
            set {
                this.payeeLinesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementBase {
        
        private string loanDisbursementIdField;
        
        private decimal amountField;
        
        private string descriptionField;
        
        private string commentField;
        
        /// <remarks/>
        public string loanDisbursementId {
            get {
                return this.loanDisbursementIdField;
            }
            set {
                this.loanDisbursementIdField = value;
            }
        }
        
        /// <remarks/>
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementGL : LoanDisbursementBase {
        
        private string gLAccountField;
        
        /// <remarks/>
        public string GLAccount {
            get {
                return this.gLAccountField;
            }
            set {
                this.gLAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementDealerAch : LoanDisbursementBase {
        
        private string dealerIDField;
        
        private string dealerNameField;
        
        private string dealerRtnField;
        
        private string dealerAccountNumberField;
        
        /// <remarks/>
        public string dealerID {
            get {
                return this.dealerIDField;
            }
            set {
                this.dealerIDField = value;
            }
        }
        
        /// <remarks/>
        public string dealerName {
            get {
                return this.dealerNameField;
            }
            set {
                this.dealerNameField = value;
            }
        }
        
        /// <remarks/>
        public string dealerRtn {
            get {
                return this.dealerRtnField;
            }
            set {
                this.dealerRtnField = value;
            }
        }
        
        /// <remarks/>
        public string dealerAccountNumber {
            get {
                return this.dealerAccountNumberField;
            }
            set {
                this.dealerAccountNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanDisbursement.xsd")]
    public partial class LoanDisbursementDepositToAccount : LoanDisbursementBase {
        
        private string toAccountField;
        
        private AccountType toAccountTypeField;
        
        /// <remarks/>
        public string toAccount {
            get {
                return this.toAccountField;
            }
            set {
                this.toAccountField = value;
            }
        }
        
        /// <remarks/>
        public AccountType toAccountType {
            get {
                return this.toAccountTypeField;
            }
            set {
                this.toAccountTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LoanFilter.xsd")]
    public partial class LoanFilter {
        
        private LoanAccountCategory[] loanCategoryListField;
        
        private string[] accountIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] partyIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("loanCategory", Namespace="http://cufxstandards.com/v2/Loan.xsd", IsNullable=false)]
        public LoanAccountCategory[] loanCategoryList {
            get {
                return this.loanCategoryListField;
            }
            set {
                this.loanCategoryListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Location.xsd")]
    public partial class LocationList {
        
        private Location[] locationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public Location[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Location.xsd")]
    public partial class Location {
        
        private string locationIdField;
        
        private string nameField;
        
        private Distance distanceField;
        
        private LocationType typeField;
        
        private bool typeFieldSpecified;
        
        private Address addressField;
        
        private Phone phoneField;
        
        private string mapUrlField;
        
        private string networkField;
        
        private bool depositTakingField;
        
        private bool depositTakingFieldSpecified;
        
        private LocationHours[] locationHoursListField;
        
        private ValuePair[] servicesListField;
        
        private ValuePair[] additionalDataListField;
        
        /// <remarks/>
        public string locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public Distance distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
        
        /// <remarks/>
        public LocationType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Address address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public Phone phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string mapUrl {
            get {
                return this.mapUrlField;
            }
            set {
                this.mapUrlField = value;
            }
        }
        
        /// <remarks/>
        public string network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        public bool depositTaking {
            get {
                return this.depositTakingField;
            }
            set {
                this.depositTakingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositTakingSpecified {
            get {
                return this.depositTakingFieldSpecified;
            }
            set {
                this.depositTakingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("locationHours", IsNullable=false)]
        public LocationHours[] locationHoursList {
            get {
                return this.locationHoursListField;
            }
            set {
                this.locationHoursListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("servicesList", IsNullable=false)]
        public ValuePair[] servicesList {
            get {
                return this.servicesListField;
            }
            set {
                this.servicesListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("additionalDataList", IsNullable=false)]
        public ValuePair[] additionalDataList {
            get {
                return this.additionalDataListField;
            }
            set {
                this.additionalDataListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Common.xsd")]
    public partial class Distance {
        
        private string unitField;
        
        private decimal valueField;
        
        /// <remarks/>
        public string unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        
        /// <remarks/>
        public decimal value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Location.xsd")]
    public enum LocationType {
        
        /// <remarks/>
        ATM,
        
        /// <remarks/>
        SharedATM,
        
        /// <remarks/>
        Branch,
        
        /// <remarks/>
        SharedBranch,
        
        /// <remarks/>
        Kiosk,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Location.xsd")]
    public partial class LocationHours {
        
        private LocationHoursLocationHoursType locationHoursTypeField;
        
        private bool locationHoursTypeFieldSpecified;
        
        private string descriptionField;
        
        private DayOfTheWeek dayOfTheWeekField;
        
        private bool dayOfTheWeekFieldSpecified;
        
        private System.DateTime openTimeField;
        
        private bool openTimeFieldSpecified;
        
        private System.DateTime closeTimeField;
        
        private bool closeTimeFieldSpecified;
        
        private bool closedAllDayField;
        
        private bool closedAllDayFieldSpecified;
        
        private bool openAllDayField;
        
        private bool openAllDayFieldSpecified;
        
        /// <remarks/>
        public LocationHoursLocationHoursType locationHoursType {
            get {
                return this.locationHoursTypeField;
            }
            set {
                this.locationHoursTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationHoursTypeSpecified {
            get {
                return this.locationHoursTypeFieldSpecified;
            }
            set {
                this.locationHoursTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public DayOfTheWeek dayOfTheWeek {
            get {
                return this.dayOfTheWeekField;
            }
            set {
                this.dayOfTheWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dayOfTheWeekSpecified {
            get {
                return this.dayOfTheWeekFieldSpecified;
            }
            set {
                this.dayOfTheWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime openTime {
            get {
                return this.openTimeField;
            }
            set {
                this.openTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openTimeSpecified {
            get {
                return this.openTimeFieldSpecified;
            }
            set {
                this.openTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime closeTime {
            get {
                return this.closeTimeField;
            }
            set {
                this.closeTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool closeTimeSpecified {
            get {
                return this.closeTimeFieldSpecified;
            }
            set {
                this.closeTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool closedAllDay {
            get {
                return this.closedAllDayField;
            }
            set {
                this.closedAllDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool closedAllDaySpecified {
            get {
                return this.closedAllDayFieldSpecified;
            }
            set {
                this.closedAllDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool openAllDay {
            get {
                return this.openAllDayField;
            }
            set {
                this.openAllDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openAllDaySpecified {
            get {
                return this.openAllDayFieldSpecified;
            }
            set {
                this.openAllDayFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Location.xsd")]
    public enum LocationHoursLocationHoursType {
        
        /// <remarks/>
        Lobby,
        
        /// <remarks/>
        DriveUp,
        
        /// <remarks/>
        ATM,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/LocationFilter.xsd")]
    public partial class LocationFilter {
        
        private string locationIdField;
        
        private LocationFilterType typeField;
        
        private bool typeFieldSpecified;
        
        private Address searchFromAddressField;
        
        private bool depositTakingField;
        
        private bool depositTakingFieldSpecified;
        
        private string maxNumberOfResultsField;
        
        private Distance maxDistanceField;
        
        /// <remarks/>
        public string locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }
        
        /// <remarks/>
        public LocationFilterType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Address searchFromAddress {
            get {
                return this.searchFromAddressField;
            }
            set {
                this.searchFromAddressField = value;
            }
        }
        
        /// <remarks/>
        public bool depositTaking {
            get {
                return this.depositTakingField;
            }
            set {
                this.depositTakingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositTakingSpecified {
            get {
                return this.depositTakingFieldSpecified;
            }
            set {
                this.depositTakingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string maxNumberOfResults {
            get {
                return this.maxNumberOfResultsField;
            }
            set {
                this.maxNumberOfResultsField = value;
            }
        }
        
        /// <remarks/>
        public Distance maxDistance {
            get {
                return this.maxDistanceField;
            }
            set {
                this.maxDistanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/LocationFilter.xsd")]
    public enum LocationFilterType {
        
        /// <remarks/>
        ATM,
        
        /// <remarks/>
        SharedATM,
        
        /// <remarks/>
        Branch,
        
        /// <remarks/>
        SharedBranch,
        
        /// <remarks/>
        Kiosk,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/OverdraftPriorityList.xsd")]
    public partial class overdraftPriorityList {
        
        private OverdraftPriority[] overdraftPriorityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overdraftPriority")]
        public OverdraftPriority[] overdraftPriority {
            get {
                return this.overdraftPriorityField;
            }
            set {
                this.overdraftPriorityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/OverdraftPriorityList.xsd")]
    public partial class OverdraftPriority {
        
        private string accountIdField;
        
        private OverdraftPriorityAccount[] overdraftPriorityAccountField;
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overdraftPriorityAccount")]
        public OverdraftPriorityAccount[] overdraftPriorityAccount {
            get {
                return this.overdraftPriorityAccountField;
            }
            set {
                this.overdraftPriorityAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/OverdraftPriorityList.xsd")]
    public partial class OverdraftPriorityAccount {
        
        private string overdraftPriorityIdField;
        
        private int priorityField;
        
        private bool priorityFieldSpecified;
        
        private string accountIdField;
        
        /// <remarks/>
        public string overdraftPriorityId {
            get {
                return this.overdraftPriorityIdField;
            }
            set {
                this.overdraftPriorityIdField = value;
            }
        }
        
        /// <remarks/>
        public int priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified {
            get {
                return this.priorityFieldSpecified;
            }
            set {
                this.priorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/OverdraftPriorityListFilter.xsd")]
    public partial class OverdraftPriorityListFilter {
        
        private string accountIdField;
        
        private string[] overdraftPriorityIdListField;
        
        private int[] priorityListField;
        
        private string[] overdraftFromAccountIdListField;
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("overdraftPriorityId", Namespace="http://cufxstandards.com/v2/OverdraftPriorityList.xsd", IsNullable=false)]
        public string[] overdraftPriorityIdList {
            get {
                return this.overdraftPriorityIdListField;
            }
            set {
                this.overdraftPriorityIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("priority", Namespace="http://cufxstandards.com/v2/OverdraftPriorityList.xsd", IsNullable=false)]
        public int[] priorityList {
            get {
                return this.priorityListField;
            }
            set {
                this.priorityListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] overdraftFromAccountIdList {
            get {
                return this.overdraftFromAccountIdListField;
            }
            set {
                this.overdraftFromAccountIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Party.xsd")]
    public partial class PartyList {
        
        private Party[] partyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("party")]
        public Party[] party {
            get {
                return this.partyField;
            }
            set {
                this.partyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class PartyAssociationList {
        
        private PartyAssociation[] partyAssociationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("partyAssociation")]
        public PartyAssociation[] partyAssociation {
            get {
                return this.partyAssociationField;
            }
            set {
                this.partyAssociationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class PartyAssociation {
        
        private string partyAssociationIdField;
        
        private string parentPartyIdField;
        
        private string childPartyIdField;
        
        private PartyAssociationType partyAssociationTypeField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string partyAssociationId {
            get {
                return this.partyAssociationIdField;
            }
            set {
                this.partyAssociationIdField = value;
            }
        }
        
        /// <remarks/>
        public string parentPartyId {
            get {
                return this.parentPartyIdField;
            }
            set {
                this.parentPartyIdField = value;
            }
        }
        
        /// <remarks/>
        public string childPartyId {
            get {
                return this.childPartyIdField;
            }
            set {
                this.childPartyIdField = value;
            }
        }
        
        /// <remarks/>
        public PartyAssociationType partyAssociationType {
            get {
                return this.partyAssociationTypeField;
            }
            set {
                this.partyAssociationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class PartyAssociationType {
        
        private Partner partnerField;
        
        private OfficerManager officerManagerField;
        
        private Agent1 agentField;
        
        private NextOfKin nextOfKinField;
        
        private Trustor trustorField;
        
        /// <remarks/>
        public Partner partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }
        
        /// <remarks/>
        public OfficerManager officerManager {
            get {
                return this.officerManagerField;
            }
            set {
                this.officerManagerField = value;
            }
        }
        
        /// <remarks/>
        public Agent1 agent {
            get {
                return this.agentField;
            }
            set {
                this.agentField = value;
            }
        }
        
        /// <remarks/>
        public NextOfKin nextOfKin {
            get {
                return this.nextOfKinField;
            }
            set {
                this.nextOfKinField = value;
            }
        }
        
        /// <remarks/>
        public Trustor trustor {
            get {
                return this.trustorField;
            }
            set {
                this.trustorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class Partner {
        
        private PartnerQualifer qualifierField;
        
        /// <remarks/>
        public PartnerQualifer qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public enum PartnerQualifer {
        
        /// <remarks/>
        GeneralPartner,
        
        /// <remarks/>
        LimitedPartner,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class OfficerManager {
        
        private OfficerManagerQualifer qualifierField;
        
        /// <remarks/>
        public OfficerManagerQualifer qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public enum OfficerManagerQualifer {
        
        /// <remarks/>
        BoardOfDirectors,
        
        /// <remarks/>
        CxO,
        
        /// <remarks/>
        FinancialOfficer,
        
        /// <remarks/>
        President,
        
        /// <remarks/>
        SoleProprietor,
        
        /// <remarks/>
        VicePresident,
        
        /// <remarks/>
        ExecutiveDirector,
        
        /// <remarks/>
        Director,
        
        /// <remarks/>
        Manager,
        
        /// <remarks/>
        Treasurer,
        
        /// <remarks/>
        Secretary,
        
        /// <remarks/>
        OtherManager,
        
        /// <remarks/>
        NonManager,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Agent", Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class Agent1 {
        
        private AgentQualifier1 qualiferField;
        
        /// <remarks/>
        public AgentQualifier1 qualifer {
            get {
                return this.qualiferField;
            }
            set {
                this.qualiferField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="AgentQualifier", Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public enum AgentQualifier1 {
        
        /// <remarks/>
        Custodian,
        
        /// <remarks/>
        Trustee,
        
        /// <remarks/>
        PowerOfAttorney,
        
        /// <remarks/>
        Representative,
        
        /// <remarks/>
        Guardian,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class NextOfKin {
        
        private NextOfKinQualifer qualifierField;
        
        /// <remarks/>
        public NextOfKinQualifer qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public enum NextOfKinQualifer {
        
        /// <remarks/>
        NotSpecified,
        
        /// <remarks/>
        Parent,
        
        /// <remarks/>
        Spouse,
        
        /// <remarks/>
        FirstCousin,
        
        /// <remarks/>
        Child,
        
        /// <remarks/>
        Sibling,
        
        /// <remarks/>
        GrandChild,
        
        /// <remarks/>
        GreatGrandchild,
        
        /// <remarks/>
        NieceNephew,
        
        /// <remarks/>
        AuntUncle,
        
        /// <remarks/>
        GreatGrandparent,
        
        /// <remarks/>
        GreatNieceNephew,
        
        /// <remarks/>
        GreatAuntUncle,
        
        /// <remarks/>
        GreatGreatGrandparent,
        
        /// <remarks/>
        GreatGreatGrandChild,
        
        /// <remarks/>
        FirstCousinOnceRemoved,
        
        /// <remarks/>
        GreatGrandAuntUncle,
        
        /// <remarks/>
        GreatGreatGreatGrandChild,
        
        /// <remarks/>
        GreatGreatGreatGrandParent,
        
        /// <remarks/>
        FirstCousinTwiceRemoved,
        
        /// <remarks/>
        SecondCousin,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public partial class Trustor {
        
        private TrustorQualifer qualifierField;
        
        /// <remarks/>
        public TrustorQualifer qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd")]
    public enum TrustorQualifer {
        
        /// <remarks/>
        ProvidesFunds,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyAssociationFilter.xsd")]
    public partial class PartyAssociationFilter {
        
        private string[] partyAssociationIdListField;
        
        private string[] parentPartyIdListField;
        
        private string[] childPartyIdListField;
        
        private PartyAssociationType[] partyAssociationTypeListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyAssociationId", Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd", IsNullable=false)]
        public string[] partyAssociationIdList {
            get {
                return this.partyAssociationIdListField;
            }
            set {
                this.partyAssociationIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] parentPartyIdList {
            get {
                return this.parentPartyIdListField;
            }
            set {
                this.parentPartyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] childPartyIdList {
            get {
                return this.childPartyIdListField;
            }
            set {
                this.childPartyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyAssociationType", Namespace="http://cufxstandards.com/v2/PartyAssociation.xsd", IsNullable=false)]
        public PartyAssociationType[] partyAssociationTypeList {
            get {
                return this.partyAssociationTypeListField;
            }
            set {
                this.partyAssociationTypeListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PartyFilter.xsd")]
    public partial class PartyFilter {
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] contactIdListField;
        
        private string[] accountIdListField;
        
        private string[] taxIdListField;
        
        private PartyType[] partyTypeListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("taxId", Namespace="http://cufxstandards.com/v2/Party.xsd", DataType="token", IsNullable=false)]
        public string[] taxIdList {
            get {
                return this.taxIdListField;
            }
            set {
                this.taxIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyType", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public PartyType[] partyTypeList {
            get {
                return this.partyTypeListField;
            }
            set {
                this.partyTypeListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public partial class PreferenceList {
        
        private Preference[] preferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preference", IsNullable=true)]
        public Preference[] preference {
            get {
                return this.preferenceField;
            }
            set {
                this.preferenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public partial class Preference {
        
        private string preferenceIdField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private string[] cardIdListField;
        
        private string[] contactIdListField;
        
        private Type1 typeField;
        
        private bool typeFieldSpecified;
        
        private SubType subTypeField;
        
        private System.DateTime lastChangedDateTimeField;
        
        private bool lastChangedDateTimeFieldSpecified;
        
        private PreferenceStatus preferenceStatusField;
        
        private string valueField;
        
        private string alertCustomTextField;
        
        private bool actionableAlertField;
        
        private bool actionableAlertFieldSpecified;
        
        private string widgetNameField;
        
        private ValuePair[] customDataField;
        
        public Preference() {
            this.preferenceStatusField = PreferenceStatus.Active;
        }
        
        /// <remarks/>
        public string preferenceId {
            get {
                return this.preferenceIdField;
            }
            set {
                this.preferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cardId", Namespace="http://cufxstandards.com/v2/Card.xsd", IsNullable=false)]
        public string[] cardIdList {
            get {
                return this.cardIdListField;
            }
            set {
                this.cardIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        public Type1 type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SubType subType {
            get {
                return this.subTypeField;
            }
            set {
                this.subTypeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime lastChangedDateTime {
            get {
                return this.lastChangedDateTimeField;
            }
            set {
                this.lastChangedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastChangedDateTimeSpecified {
            get {
                return this.lastChangedDateTimeFieldSpecified;
            }
            set {
                this.lastChangedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PreferenceStatus.Active)]
        public PreferenceStatus preferenceStatus {
            get {
                return this.preferenceStatusField;
            }
            set {
                this.preferenceStatusField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string alertCustomText {
            get {
                return this.alertCustomTextField;
            }
            set {
                this.alertCustomTextField = value;
            }
        }
        
        /// <remarks/>
        public bool actionableAlert {
            get {
                return this.actionableAlertField;
            }
            set {
                this.actionableAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionableAlertSpecified {
            get {
                return this.actionableAlertFieldSpecified;
            }
            set {
                this.actionableAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string widgetName {
            get {
                return this.widgetNameField;
            }
            set {
                this.widgetNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Type", Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public enum Type1 {
        
        /// <remarks/>
        EAlert,
        
        /// <remarks/>
        EStatement,
        
        /// <remarks/>
        ENotice,
        
        /// <remarks/>
        Newsletter,
        
        /// <remarks/>
        Communication,
        
        /// <remarks/>
        ContactHours,
        
        /// <remarks/>
        Language,
        
        /// <remarks/>
        WebsiteFormatStylesheet,
        
        /// <remarks/>
        MobileSiteFormatStylesheet,
        
        /// <remarks/>
        EmailFormat,
        
        /// <remarks/>
        Widget,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public partial class SubType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eAlertSubType", typeof(EAlertSubType))]
        [System.Xml.Serialization.XmlElementAttribute("emailFormatSubType", typeof(EmailFormatSubType))]
        [System.Xml.Serialization.XmlElementAttribute("widgetSubType", typeof(WidgetSubType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public enum EAlertSubType {
        
        /// <remarks/>
        SsnChanged,
        
        /// <remarks/>
        AddressChanged,
        
        /// <remarks/>
        ApproachingCreditLimit,
        
        /// <remarks/>
        AtmWithdrawalExceeds,
        
        /// <remarks/>
        AtmDepositExceeds,
        
        /// <remarks/>
        AutomatedTransferExceeds,
        
        /// <remarks/>
        BalanceFellBelow,
        
        /// <remarks/>
        BalanceExceeds,
        
        /// <remarks/>
        BillPayExceeds,
        
        /// <remarks/>
        BillPayPayeeAdded,
        
        /// <remarks/>
        BillPayPaymentRejected,
        
        /// <remarks/>
        BillPayPaymentPaid,
        
        /// <remarks/>
        CheckNumberWithinRangeHasCleared,
        
        /// <remarks/>
        CheckWithdrawalExceeds,
        
        /// <remarks/>
        CourtesyPayExceeds,
        
        /// <remarks/>
        CourtesyPayFallsBelow,
        
        /// <remarks/>
        CreditCardAuthorizationDeclined,
        
        /// <remarks/>
        CreditCardAuthorizationExceeds,
        
        /// <remarks/>
        CreditCardFuelDispenserAuthorizationExceeds,
        
        /// <remarks/>
        CreditCardInternationalAuthorizationExceeds,
        
        /// <remarks/>
        CreditCardOnlineAuthorizationExceeds,
        
        /// <remarks/>
        CreditCardOutOfStateAuthorizationExceeds,
        
        /// <remarks/>
        CreditCardRefundExceeds,
        
        /// <remarks/>
        DebitCardAuthorizationDeclined,
        
        /// <remarks/>
        DebitCardAuthorizationExceeds,
        
        /// <remarks/>
        DebitCardFuelDispenserAuthorizationExceeds,
        
        /// <remarks/>
        DebitCardInternationalAuthorizationExceeds,
        
        /// <remarks/>
        DebitCardOnlineAuthorizationExceeds,
        
        /// <remarks/>
        DebitCardOutOfStateAuthorizationExceeds,
        
        /// <remarks/>
        DebitCardRefundExceeds,
        
        /// <remarks/>
        DepositedFundsHaveBeenReturned,
        
        /// <remarks/>
        DirectDepositExceeds,
        
        /// <remarks/>
        DirectDepositFellBelow,
        
        /// <remarks/>
        EmailAddressChanged,
        
        /// <remarks/>
        ExternalTransferExceeds,
        
        /// <remarks/>
        PotentialFraud,
        
        /// <remarks/>
        IncomingWireExceeds,
        
        /// <remarks/>
        InsufficientFundsToPayCheck,
        
        /// <remarks/>
        HoldPlacedOnAccountExceeded,
        
        /// <remarks/>
        HoldThatExceededWasRemovedFromAccount,
        
        /// <remarks/>
        PhoneNumberChanged,
        
        /// <remarks/>
        LoginOccurred,
        
        /// <remarks/>
        LoginFailed,
        
        /// <remarks/>
        NameChangeAttempted,
        
        /// <remarks/>
        NameChangeOccurred,
        
        /// <remarks/>
        OutgoingWireExceeds,
        
        /// <remarks/>
        PasswordResetSuccess,
        
        /// <remarks/>
        PasswordResetFailure,
        
        /// <remarks/>
        PaymentDueInXDays,
        
        /// <remarks/>
        PinChanged,
        
        /// <remarks/>
        PreferenceChanged,
        
        /// <remarks/>
        ScheduledMessage,
        
        /// <remarks/>
        ScheduledPaymentHasFailed,
        
        /// <remarks/>
        ScheduledPaymentHasStopped,
        
        /// <remarks/>
        SpecificCheckNumberHasCleared,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SsnChanged")]
        SsnChanged1,
        
        /// <remarks/>
        SystemNotification,
        
        /// <remarks/>
        StatementAvailable,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public enum EmailFormatSubType {
        
        /// <remarks/>
        Html,
        
        /// <remarks/>
        Text,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public enum WidgetSubType {
        
        /// <remarks/>
        DisplayStatus,
        
        /// <remarks/>
        DisplayOrder,
        
        /// <remarks/>
        ShortCutKey,
        
        /// <remarks/>
        DisplayPage,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Preference.xsd")]
    public enum PreferenceStatus {
        
        /// <remarks/>
        Template,
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        Inactive,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/PreferenceFilter.xsd")]
    public partial class PreferenceFilter {
        
        private string[] preferenceIdListField;
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private string[] cardIdListField;
        
        private string[] contactIdListField;
        
        private Type1[] preferenceTypeListField;
        
        private SubType[] preferenceSubTypeListField;
        
        private PreferenceStatus[] preferenceStatusListField;
        
        private string[] widgetNameListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("preferenceId", Namespace="http://cufxstandards.com/v2/Preference.xsd", IsNullable=false)]
        public string[] preferenceIdList {
            get {
                return this.preferenceIdListField;
            }
            set {
                this.preferenceIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cardId", Namespace="http://cufxstandards.com/v2/Card.xsd", IsNullable=false)]
        public string[] cardIdList {
            get {
                return this.cardIdListField;
            }
            set {
                this.cardIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("type", Namespace="http://cufxstandards.com/v2/Preference.xsd", IsNullable=false)]
        public Type1[] preferenceTypeList {
            get {
                return this.preferenceTypeListField;
            }
            set {
                this.preferenceTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("subType", Namespace="http://cufxstandards.com/v2/Preference.xsd", IsNullable=false)]
        public SubType[] preferenceSubTypeList {
            get {
                return this.preferenceSubTypeListField;
            }
            set {
                this.preferenceSubTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("preferenceStatus", Namespace="http://cufxstandards.com/v2/Preference.xsd", IsNullable=false)]
        public PreferenceStatus[] preferenceStatusList {
            get {
                return this.preferenceStatusListField;
            }
            set {
                this.preferenceStatusListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("widgetName", Namespace="http://cufxstandards.com/v2/Preference.xsd", IsNullable=false)]
        public string[] widgetNameList {
            get {
                return this.widgetNameListField;
            }
            set {
                this.widgetNameListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
    public partial class ProductOfferingList {
        
        private ProductOffering[] productOfferingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("productOffering")]
        public ProductOffering[] productOffering {
            get {
                return this.productOfferingField;
            }
            set {
                this.productOfferingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
    public partial class ProductOffering {
        
        private string productIdField;
        
        private AccountType productTypeField;
        
        private string productSubTypeField;
        
        private ValuePair[] systemProductKeysField;
        
        private string descriptionField;
        
        private bool pointsRewardsProgramField;
        
        private bool pointsRewardsProgramFieldSpecified;
        
        private InterestRate[] interestRateListField;
        
        private Money minimumBalanceField;
        
        private Money maximumBalanceField;
        
        private string brandField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
            }
        }
        
        /// <remarks/>
        public AccountType productType {
            get {
                return this.productTypeField;
            }
            set {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        public string productSubType {
            get {
                return this.productSubTypeField;
            }
            set {
                this.productSubTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] systemProductKeys {
            get {
                return this.systemProductKeysField;
            }
            set {
                this.systemProductKeysField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public bool pointsRewardsProgram {
            get {
                return this.pointsRewardsProgramField;
            }
            set {
                this.pointsRewardsProgramField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pointsRewardsProgramSpecified {
            get {
                return this.pointsRewardsProgramFieldSpecified;
            }
            set {
                this.pointsRewardsProgramFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("interestRate", IsNullable=false)]
        public InterestRate[] interestRateList {
            get {
                return this.interestRateListField;
            }
            set {
                this.interestRateListField = value;
            }
        }
        
        /// <remarks/>
        public Money minimumBalance {
            get {
                return this.minimumBalanceField;
            }
            set {
                this.minimumBalanceField = value;
            }
        }
        
        /// <remarks/>
        public Money maximumBalance {
            get {
                return this.maximumBalanceField;
            }
            set {
                this.maximumBalanceField = value;
            }
        }
        
        /// <remarks/>
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
    public partial class InterestRate {
        
        private string interestRateIdField;
        
        private bool interestPointsRewardsProgramField;
        
        private bool interestPointsRewardsProgramFieldSpecified;
        
        private bool introductoryRateField;
        
        private bool introductoryRateFieldSpecified;
        
        private bool balanceConsolidationRateField;
        
        private bool balanceConsolidationRateFieldSpecified;
        
        private bool riskRateField;
        
        private bool riskRateFieldSpecified;
        
        private string riskRateClassificationMinimumField;
        
        private string riskRateClassificationMaximumField;
        
        private string interestRateDescriptionField;
        
        private string interestRateCriteriaField;
        
        private System.DateTime effectiveDateTimeField;
        
        private bool effectiveDateTimeFieldSpecified;
        
        private System.DateTime expirationDateTimeField;
        
        private bool expirationDateTimeFieldSpecified;
        
        private decimal interestRateField;
        
        private bool interestRateFieldSpecified;
        
        /// <remarks/>
        public string interestRateId {
            get {
                return this.interestRateIdField;
            }
            set {
                this.interestRateIdField = value;
            }
        }
        
        /// <remarks/>
        public bool interestPointsRewardsProgram {
            get {
                return this.interestPointsRewardsProgramField;
            }
            set {
                this.interestPointsRewardsProgramField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestPointsRewardsProgramSpecified {
            get {
                return this.interestPointsRewardsProgramFieldSpecified;
            }
            set {
                this.interestPointsRewardsProgramFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool introductoryRate {
            get {
                return this.introductoryRateField;
            }
            set {
                this.introductoryRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool introductoryRateSpecified {
            get {
                return this.introductoryRateFieldSpecified;
            }
            set {
                this.introductoryRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool balanceConsolidationRate {
            get {
                return this.balanceConsolidationRateField;
            }
            set {
                this.balanceConsolidationRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceConsolidationRateSpecified {
            get {
                return this.balanceConsolidationRateFieldSpecified;
            }
            set {
                this.balanceConsolidationRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool riskRate {
            get {
                return this.riskRateField;
            }
            set {
                this.riskRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool riskRateSpecified {
            get {
                return this.riskRateFieldSpecified;
            }
            set {
                this.riskRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string riskRateClassificationMinimum {
            get {
                return this.riskRateClassificationMinimumField;
            }
            set {
                this.riskRateClassificationMinimumField = value;
            }
        }
        
        /// <remarks/>
        public string riskRateClassificationMaximum {
            get {
                return this.riskRateClassificationMaximumField;
            }
            set {
                this.riskRateClassificationMaximumField = value;
            }
        }
        
        /// <remarks/>
        public string interestRateDescription {
            get {
                return this.interestRateDescriptionField;
            }
            set {
                this.interestRateDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string interestRateCriteria {
            get {
                return this.interestRateCriteriaField;
            }
            set {
                this.interestRateCriteriaField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime effectiveDateTime {
            get {
                return this.effectiveDateTimeField;
            }
            set {
                this.effectiveDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateTimeSpecified {
            get {
                return this.effectiveDateTimeFieldSpecified;
            }
            set {
                this.effectiveDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime expirationDateTime {
            get {
                return this.expirationDateTimeField;
            }
            set {
                this.expirationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateTimeSpecified {
            get {
                return this.expirationDateTimeFieldSpecified;
            }
            set {
                this.expirationDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal interestRate {
            get {
                return this.interestRateField;
            }
            set {
                this.interestRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestRateSpecified {
            get {
                return this.interestRateFieldSpecified;
            }
            set {
                this.interestRateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductOfferingFilter.xsd")]
    public partial class ProductOfferingFilter {
        
        private string[] productIdListField;
        
        private System.Nullable<AccountType>[] productTypeListField;
        
        private string[] productSubTypeListField;
        
        private System.DateTime interestDateTimeField;
        
        private bool interestDateTimeFieldSpecified;
        
        private bool pointsRewardsProgramField;
        
        private bool pointsRewardsProgramFieldSpecified;
        
        private string brandField;
        
        private string riskRateClassificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("productId", Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
        public string[] productIdList {
            get {
                return this.productIdListField;
            }
            set {
                this.productIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("productType", Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
        public System.Nullable<AccountType>[] productTypeList {
            get {
                return this.productTypeListField;
            }
            set {
                this.productTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("productSubType", Namespace="http://cufxstandards.com/v2/ProductOffering.xsd")]
        public string[] productSubTypeList {
            get {
                return this.productSubTypeListField;
            }
            set {
                this.productSubTypeListField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime interestDateTime {
            get {
                return this.interestDateTimeField;
            }
            set {
                this.interestDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interestDateTimeSpecified {
            get {
                return this.interestDateTimeFieldSpecified;
            }
            set {
                this.interestDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool pointsRewardsProgram {
            get {
                return this.pointsRewardsProgramField;
            }
            set {
                this.pointsRewardsProgramField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pointsRewardsProgramSpecified {
            get {
                return this.pointsRewardsProgramFieldSpecified;
            }
            set {
                this.pointsRewardsProgramFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        public string riskRateClassification {
            get {
                return this.riskRateClassificationField;
            }
            set {
                this.riskRateClassificationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class ProductServiceRequestList {
        
        private ProductServiceRequest[] productServiceRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("productServiceRequest", IsNullable=true)]
        public ProductServiceRequest[] productServiceRequest {
            get {
                return this.productServiceRequestField;
            }
            set {
                this.productServiceRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class ProductServiceRequest {
        
        private string productServiceRequestIdField;
        
        private Request[] requestListField;
        
        private string sourceField;
        
        private Status statusField;
        
        private bool statusFieldSpecified;
        
        private System.DateTime createDateTimeField;
        
        private bool createDateTimeFieldSpecified;
        
        private RelatedTo productServiceRequestRelatedToField;
        
        private Note[] productServiceRequestNoteListField;
        
        private ValuePair[] productServiceRequestCustomDataField;
        
        /// <remarks/>
        public string productServiceRequestId {
            get {
                return this.productServiceRequestIdField;
            }
            set {
                this.productServiceRequestIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("request", IsNullable=false)]
        public Request[] requestList {
            get {
                return this.requestListField;
            }
            set {
                this.requestListField = value;
            }
        }
        
        /// <remarks/>
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        public Status status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime createDateTime {
            get {
                return this.createDateTimeField;
            }
            set {
                this.createDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createDateTimeSpecified {
            get {
                return this.createDateTimeFieldSpecified;
            }
            set {
                this.createDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RelatedTo productServiceRequestRelatedTo {
            get {
                return this.productServiceRequestRelatedToField;
            }
            set {
                this.productServiceRequestRelatedToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("note", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public Note[] productServiceRequestNoteList {
            get {
                return this.productServiceRequestNoteListField;
            }
            set {
                this.productServiceRequestNoteListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] productServiceRequestCustomData {
            get {
                return this.productServiceRequestCustomDataField;
            }
            set {
                this.productServiceRequestCustomDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class Request {
        
        private string requestIdField;
        
        private RequestItem requestItemField;
        
        private ActivityStatus requestStatusField;
        
        private bool requestStatusFieldSpecified;
        
        private System.DateTime requestedDateTimeField;
        
        private bool requestedDateTimeFieldSpecified;
        
        private System.DateTime dueDateTimeField;
        
        private bool dueDateTimeFieldSpecified;
        
        private System.DateTime startDateTimeField;
        
        private bool startDateTimeFieldSpecified;
        
        private System.DateTime completedDateTimeField;
        
        private bool completedDateTimeFieldSpecified;
        
        private Note[] requestNoteListField;
        
        private RelatedTo requestRelatedToField;
        
        private Activity[] activityListField;
        
        private SecureMessageList secureMessageListField;
        
        private DocumentIdList1 documentListField;
        
        private ValuePair[] requestCustomDataField;
        
        /// <remarks/>
        public string requestId {
            get {
                return this.requestIdField;
            }
            set {
                this.requestIdField = value;
            }
        }
        
        /// <remarks/>
        public RequestItem requestItem {
            get {
                return this.requestItemField;
            }
            set {
                this.requestItemField = value;
            }
        }
        
        /// <remarks/>
        public ActivityStatus requestStatus {
            get {
                return this.requestStatusField;
            }
            set {
                this.requestStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestStatusSpecified {
            get {
                return this.requestStatusFieldSpecified;
            }
            set {
                this.requestStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime requestedDateTime {
            get {
                return this.requestedDateTimeField;
            }
            set {
                this.requestedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestedDateTimeSpecified {
            get {
                return this.requestedDateTimeFieldSpecified;
            }
            set {
                this.requestedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dueDateTime {
            get {
                return this.dueDateTimeField;
            }
            set {
                this.dueDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateTimeSpecified {
            get {
                return this.dueDateTimeFieldSpecified;
            }
            set {
                this.dueDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime startDateTime {
            get {
                return this.startDateTimeField;
            }
            set {
                this.startDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateTimeSpecified {
            get {
                return this.startDateTimeFieldSpecified;
            }
            set {
                this.startDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime completedDateTime {
            get {
                return this.completedDateTimeField;
            }
            set {
                this.completedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completedDateTimeSpecified {
            get {
                return this.completedDateTimeFieldSpecified;
            }
            set {
                this.completedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("note", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public Note[] requestNoteList {
            get {
                return this.requestNoteListField;
            }
            set {
                this.requestNoteListField = value;
            }
        }
        
        /// <remarks/>
        public RelatedTo requestRelatedTo {
            get {
                return this.requestRelatedToField;
            }
            set {
                this.requestRelatedToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("activity", IsNullable=false)]
        public Activity[] activityList {
            get {
                return this.activityListField;
            }
            set {
                this.activityListField = value;
            }
        }
        
        /// <remarks/>
        public SecureMessageList secureMessageList {
            get {
                return this.secureMessageListField;
            }
            set {
                this.secureMessageListField = value;
            }
        }
        
        /// <remarks/>
        public DocumentIdList1 documentList {
            get {
                return this.documentListField;
            }
            set {
                this.documentListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] requestCustomData {
            get {
                return this.requestCustomDataField;
            }
            set {
                this.requestCustomDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class RequestItem {
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("productOfInterest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("question", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("serviceOfInterest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        productOfInterest,
        
        /// <remarks/>
        question,
        
        /// <remarks/>
        serviceOfInterest,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public enum ActivityStatus {
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        Assigned,
        
        /// <remarks/>
        InProgressActive,
        
        /// <remarks/>
        InProgressInactive,
        
        /// <remarks/>
        Completed,
        
        /// <remarks/>
        Cancelled,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class RelatedTo {
        
        private string[] contactIdListField;
        
        private string[] partyIdListField;
        
        private Party[] partyListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("party", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public Party[] partyList {
            get {
                return this.partyListField;
            }
            set {
                this.partyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class Activity {
        
        private string activityIdField;
        
        private string[] previousActivityIdField;
        
        private string activityNameField;
        
        private ActivityStatus activityStatusField;
        
        private bool activityStatusFieldSpecified;
        
        private string creatorField;
        
        private System.DateTime requestedDateTimeField;
        
        private bool requestedDateTimeFieldSpecified;
        
        private System.DateTime dueDateTimeField;
        
        private bool dueDateTimeFieldSpecified;
        
        private System.DateTime startDateTimeField;
        
        private bool startDateTimeFieldSpecified;
        
        private System.DateTime completedDateTimeField;
        
        private bool completedDateTimeFieldSpecified;
        
        private Note[] activityNoteListField;
        
        private RelatedTo activityRelatedToField;
        
        private ValuePair[] activityCustomDataField;
        
        /// <remarks/>
        public string activityId {
            get {
                return this.activityIdField;
            }
            set {
                this.activityIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("previousActivityId")]
        public string[] previousActivityId {
            get {
                return this.previousActivityIdField;
            }
            set {
                this.previousActivityIdField = value;
            }
        }
        
        /// <remarks/>
        public string activityName {
            get {
                return this.activityNameField;
            }
            set {
                this.activityNameField = value;
            }
        }
        
        /// <remarks/>
        public ActivityStatus activityStatus {
            get {
                return this.activityStatusField;
            }
            set {
                this.activityStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activityStatusSpecified {
            get {
                return this.activityStatusFieldSpecified;
            }
            set {
                this.activityStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string creator {
            get {
                return this.creatorField;
            }
            set {
                this.creatorField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime requestedDateTime {
            get {
                return this.requestedDateTimeField;
            }
            set {
                this.requestedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestedDateTimeSpecified {
            get {
                return this.requestedDateTimeFieldSpecified;
            }
            set {
                this.requestedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dueDateTime {
            get {
                return this.dueDateTimeField;
            }
            set {
                this.dueDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateTimeSpecified {
            get {
                return this.dueDateTimeFieldSpecified;
            }
            set {
                this.dueDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime startDateTime {
            get {
                return this.startDateTimeField;
            }
            set {
                this.startDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateTimeSpecified {
            get {
                return this.startDateTimeFieldSpecified;
            }
            set {
                this.startDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime completedDateTime {
            get {
                return this.completedDateTimeField;
            }
            set {
                this.completedDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completedDateTimeSpecified {
            get {
                return this.completedDateTimeFieldSpecified;
            }
            set {
                this.completedDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("note", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public Note[] activityNoteList {
            get {
                return this.activityNoteListField;
            }
            set {
                this.activityNoteListField = value;
            }
        }
        
        /// <remarks/>
        public RelatedTo activityRelatedTo {
            get {
                return this.activityRelatedToField;
            }
            set {
                this.activityRelatedToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] activityCustomData {
            get {
                return this.activityCustomDataField;
            }
            set {
                this.activityCustomDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class SecureMessageList {
        
        private string[] secureMessageIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secureMessageId")]
        public string[] secureMessageId {
            get {
                return this.secureMessageIdField;
            }
            set {
                this.secureMessageIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DocumentIdList", Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public partial class DocumentIdList1 {
        
        private string[] documentIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentId")]
        public string[] documentId {
            get {
                return this.documentIdField;
            }
            set {
                this.documentIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
    public enum Status {
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        Assigned,
        
        /// <remarks/>
        InDiscussion,
        
        /// <remarks/>
        InProposal,
        
        /// <remarks/>
        VerbalCommitment,
        
        /// <remarks/>
        Converted,
        
        /// <remarks/>
        Lost,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ProductServiceRequestFilter.xsd")]
    public partial class ProductServiceRequestFilter {
        
        private string[] productServiceRequestIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private string[] partyIdListField;
        
        private string[] contactIdListField;
        
        private Status[] productServiceRequestStatusListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("productServiceRequestId", Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd")]
        public string[] productServiceRequestIdList {
            get {
                return this.productServiceRequestIdListField;
            }
            set {
                this.productServiceRequestIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("status", Namespace="http://cufxstandards.com/v2/ProductServiceRequest.xsd", IsNullable=false)]
        public Status[] productServiceRequestStatusList {
            get {
                return this.productServiceRequestStatusListField;
            }
            set {
                this.productServiceRequestStatusListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/QuestionList.xsd")]
    public partial class QuestionList {
        
        private Question[] questionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("question")]
        public Question[] question {
            get {
                return this.questionField;
            }
            set {
                this.questionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/QuestionList.xsd")]
    public partial class Question {
        
        private Choice[] choiceListField;
        
        private string questionIdField;
        
        private string questionTextField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("choice", IsNullable=false)]
        public Choice[] choiceList {
            get {
                return this.choiceListField;
            }
            set {
                this.choiceListField = value;
            }
        }
        
        /// <remarks/>
        public string questionId {
            get {
                return this.questionIdField;
            }
            set {
                this.questionIdField = value;
            }
        }
        
        /// <remarks/>
        public string questionText {
            get {
                return this.questionTextField;
            }
            set {
                this.questionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/QuestionList.xsd")]
    public partial class Choice {
        
        private string choiceIdField;
        
        private string choiceTextField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string choiceId {
            get {
                return this.choiceIdField;
            }
            set {
                this.choiceIdField = value;
            }
        }
        
        /// <remarks/>
        public string choiceText {
            get {
                return this.choiceTextField;
            }
            set {
                this.choiceTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://cufxstandards.com/v2/Ratings.xsd")]
    public partial class ratingsList {
        
        private Rating[] ratingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rating")]
        public Rating[] rating {
            get {
                return this.ratingField;
            }
            set {
                this.ratingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Ratings.xsd")]
    public partial class Rating {
        
        private string reviewIdField;
        
        private System.DateTime reviewDateTimeField;
        
        private bool reviewDateTimeFieldSpecified;
        
        private string reviewerNameField;
        
        private string productCodeField;
        
        private string productNameField;
        
        private decimal overallRatingField;
        
        private bool overallRatingFieldSpecified;
        
        private bool featureReviewField;
        
        private bool featureReviewFieldSpecified;
        
        private bool recommendedField;
        
        private bool recommendedFieldSpecified;
        
        private string reviewSubjectField;
        
        private string reviewDescriptionField;
        
        private string reviewerEmailField;
        
        private string reviewerUserIdField;
        
        private string reviewerLocationField;
        
        private string reviewerAgeField;
        
        private string reviewerGenderField;
        
        private string productDescriptionField;
        
        private string productTypeField;
        
        private string productURLField;
        
        /// <remarks/>
        public string reviewId {
            get {
                return this.reviewIdField;
            }
            set {
                this.reviewIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime reviewDateTime {
            get {
                return this.reviewDateTimeField;
            }
            set {
                this.reviewDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reviewDateTimeSpecified {
            get {
                return this.reviewDateTimeFieldSpecified;
            }
            set {
                this.reviewDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string reviewerName {
            get {
                return this.reviewerNameField;
            }
            set {
                this.reviewerNameField = value;
            }
        }
        
        /// <remarks/>
        public string productCode {
            get {
                return this.productCodeField;
            }
            set {
                this.productCodeField = value;
            }
        }
        
        /// <remarks/>
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        public decimal overallRating {
            get {
                return this.overallRatingField;
            }
            set {
                this.overallRatingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overallRatingSpecified {
            get {
                return this.overallRatingFieldSpecified;
            }
            set {
                this.overallRatingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool featureReview {
            get {
                return this.featureReviewField;
            }
            set {
                this.featureReviewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool featureReviewSpecified {
            get {
                return this.featureReviewFieldSpecified;
            }
            set {
                this.featureReviewFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool recommended {
            get {
                return this.recommendedField;
            }
            set {
                this.recommendedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recommendedSpecified {
            get {
                return this.recommendedFieldSpecified;
            }
            set {
                this.recommendedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string reviewSubject {
            get {
                return this.reviewSubjectField;
            }
            set {
                this.reviewSubjectField = value;
            }
        }
        
        /// <remarks/>
        public string reviewDescription {
            get {
                return this.reviewDescriptionField;
            }
            set {
                this.reviewDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string reviewerEmail {
            get {
                return this.reviewerEmailField;
            }
            set {
                this.reviewerEmailField = value;
            }
        }
        
        /// <remarks/>
        public string reviewerUserId {
            get {
                return this.reviewerUserIdField;
            }
            set {
                this.reviewerUserIdField = value;
            }
        }
        
        /// <remarks/>
        public string reviewerLocation {
            get {
                return this.reviewerLocationField;
            }
            set {
                this.reviewerLocationField = value;
            }
        }
        
        /// <remarks/>
        public string reviewerAge {
            get {
                return this.reviewerAgeField;
            }
            set {
                this.reviewerAgeField = value;
            }
        }
        
        /// <remarks/>
        public string reviewerGender {
            get {
                return this.reviewerGenderField;
            }
            set {
                this.reviewerGenderField = value;
            }
        }
        
        /// <remarks/>
        public string productDescription {
            get {
                return this.productDescriptionField;
            }
            set {
                this.productDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string productType {
            get {
                return this.productTypeField;
            }
            set {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        public string productURL {
            get {
                return this.productURLField;
            }
            set {
                this.productURLField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class RelationshipList {
        
        private Relationship[] relationshipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relationship")]
        public Relationship[] relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class Relationship {
        
        private string relationshipIdField;
        
        private string rewardsCodeField;
        
        private RelationshipParty[] relationshipPartyListField;
        
        private string[] accountIdListField;
        
        /// <remarks/>
        public string relationshipId {
            get {
                return this.relationshipIdField;
            }
            set {
                this.relationshipIdField = value;
            }
        }
        
        /// <remarks/>
        public string rewardsCode {
            get {
                return this.rewardsCodeField;
            }
            set {
                this.rewardsCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipParty")]
        public RelationshipParty[] relationshipPartyList {
            get {
                return this.relationshipPartyListField;
            }
            set {
                this.relationshipPartyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class RelationshipParty {
        
        private string idField;
        
        private PartyRelationshipType partyRelationshipTypeField;
        
        private bool ssnOverrideField;
        
        private string[] contactIdListField;
        
        private ValuePair[] customDataField;
        
        public RelationshipParty() {
            this.ssnOverrideField = false;
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public PartyRelationshipType partyRelationshipType {
            get {
                return this.partyRelationshipTypeField;
            }
            set {
                this.partyRelationshipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ssnOverride {
            get {
                return this.ssnOverrideField;
            }
            set {
                this.ssnOverrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/Relationship.xsd")]
    public partial class PartyRelationshipType {
        
        private Holder holderField;
        
        private Beneficiary beneficiaryField;
        
        private Agent agentField;
        
        private Payee payeeField;
        
        private Guarantor guarantorField;
        
        private CollateralGrantor collateralGrantorField;
        
        private SafeDepositBoxUser safeDepositBoxUserField;
        
        /// <remarks/>
        public Holder holder {
            get {
                return this.holderField;
            }
            set {
                this.holderField = value;
            }
        }
        
        /// <remarks/>
        public Beneficiary beneficiary {
            get {
                return this.beneficiaryField;
            }
            set {
                this.beneficiaryField = value;
            }
        }
        
        /// <remarks/>
        public Agent agent {
            get {
                return this.agentField;
            }
            set {
                this.agentField = value;
            }
        }
        
        /// <remarks/>
        public Payee payee {
            get {
                return this.payeeField;
            }
            set {
                this.payeeField = value;
            }
        }
        
        /// <remarks/>
        public Guarantor guarantor {
            get {
                return this.guarantorField;
            }
            set {
                this.guarantorField = value;
            }
        }
        
        /// <remarks/>
        public CollateralGrantor collateralGrantor {
            get {
                return this.collateralGrantorField;
            }
            set {
                this.collateralGrantorField = value;
            }
        }
        
        /// <remarks/>
        public SafeDepositBoxUser safeDepositBoxUser {
            get {
                return this.safeDepositBoxUserField;
            }
            set {
                this.safeDepositBoxUserField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/RelationshipFilter.xsd")]
    public partial class RelationshipFilter {
        
        private string[] partyIdListField;
        
        private string[] relationshipIdListField;
        
        private string[] accountIdListField;
        
        private string[] contactIdListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partyId", Namespace="http://cufxstandards.com/v2/Party.xsd", IsNullable=false)]
        public string[] partyIdList {
            get {
                return this.partyIdListField;
            }
            set {
                this.partyIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationshipId", Namespace="http://cufxstandards.com/v2/Relationship.xsd", IsNullable=false)]
        public string[] relationshipIdList {
            get {
                return this.relationshipIdListField;
            }
            set {
                this.relationshipIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("accountId", Namespace="http://cufxstandards.com/v2/Account.xsd", IsNullable=false)]
        public string[] accountIdList {
            get {
                return this.accountIdListField;
            }
            set {
                this.accountIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contactId", Namespace="http://cufxstandards.com/v2/Contact.xsd", IsNullable=false)]
        public string[] contactIdList {
            get {
                return this.contactIdListField;
            }
            set {
                this.contactIdListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/RemoteDepositCapture.xsd")]
    public partial class RemoteDepositCaptureList {
        
        private RemoteDepositCapture[] remoteDepositCaptureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("remoteDepositCapture")]
        public RemoteDepositCapture[] remoteDepositCapture {
            get {
                return this.remoteDepositCaptureField;
            }
            set {
                this.remoteDepositCaptureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/RemoteDepositCapture.xsd")]
    public partial class RemoteDepositCapture {
        
        private string routingTransitNumberField;
        
        private Money amountField;
        
        private bool croppedField;
        
        private bool croppedFieldSpecified;
        
        private byte[] frontImageField;
        
        private byte[] backImageField;
        
        private string accountIdField;
        
        private Contact[] contactField;
        
        private mode[] modeField;
        
        /// <remarks/>
        public string routingTransitNumber {
            get {
                return this.routingTransitNumberField;
            }
            set {
                this.routingTransitNumberField = value;
            }
        }
        
        /// <remarks/>
        public Money amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public bool cropped {
            get {
                return this.croppedField;
            }
            set {
                this.croppedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool croppedSpecified {
            get {
                return this.croppedFieldSpecified;
            }
            set {
                this.croppedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] frontImage {
            get {
                return this.frontImageField;
            }
            set {
                this.frontImageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] backImage {
            get {
                return this.backImageField;
            }
            set {
                this.backImageField = value;
            }
        }
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Contact[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mode")]
        public mode[] mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/RemoteDepositCapture.xsd")]
    public enum mode {
        
        /// <remarks/>
        Test,
        
        /// <remarks/>
        Production,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SecureMessageList", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public partial class SecureMessageList1 {
        
        private SecureMessage[] secureMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secureMessage")]
        public SecureMessage[] secureMessage {
            get {
                return this.secureMessageField;
            }
            set {
                this.secureMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public partial class SecureMessage {
        
        private string secureMessageIdField;
        
        private string previousSecureMessageIdField;
        
        private string subjectLineField;
        
        private SecureMessageUser[] messageFromListField;
        
        private SecureMessageUser[] messageToListField;
        
        private SecureMessageUser[] carbonCopyListField;
        
        private SecureMessageUser[] blindCarbonCopyListField;
        
        private SecureMessageUser[] replyToListField;
        
        private SecureMessageType typeField;
        
        private bool typeFieldSpecified;
        
        private SecureMessageStatus currentStatusField;
        
        private bool currentStatusFieldSpecified;
        
        private StatusLogEntry[] statusLogField;
        
        private string bodyField;
        
        private BodyFormat bodyFormatField;
        
        private bool bodyFormatFieldSpecified;
        
        private string[] documentIdListField;
        
        private System.DateTime doNotDeliverBeforeDateTimeField;
        
        private bool doNotDeliverBeforeDateTimeFieldSpecified;
        
        private System.DateTime expirationDateTimeField;
        
        private bool expirationDateTimeFieldSpecified;
        
        private string requestIdField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string secureMessageId {
            get {
                return this.secureMessageIdField;
            }
            set {
                this.secureMessageIdField = value;
            }
        }
        
        /// <remarks/>
        public string previousSecureMessageId {
            get {
                return this.previousSecureMessageIdField;
            }
            set {
                this.previousSecureMessageIdField = value;
            }
        }
        
        /// <remarks/>
        public string subjectLine {
            get {
                return this.subjectLineField;
            }
            set {
                this.subjectLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", IsNullable=false)]
        public SecureMessageUser[] messageFromList {
            get {
                return this.messageFromListField;
            }
            set {
                this.messageFromListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", IsNullable=false)]
        public SecureMessageUser[] messageToList {
            get {
                return this.messageToListField;
            }
            set {
                this.messageToListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", IsNullable=false)]
        public SecureMessageUser[] carbonCopyList {
            get {
                return this.carbonCopyListField;
            }
            set {
                this.carbonCopyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", IsNullable=false)]
        public SecureMessageUser[] blindCarbonCopyList {
            get {
                return this.blindCarbonCopyListField;
            }
            set {
                this.blindCarbonCopyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", IsNullable=false)]
        public SecureMessageUser[] replyToList {
            get {
                return this.replyToListField;
            }
            set {
                this.replyToListField = value;
            }
        }
        
        /// <remarks/>
        public SecureMessageType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SecureMessageStatus currentStatus {
            get {
                return this.currentStatusField;
            }
            set {
                this.currentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentStatusSpecified {
            get {
                return this.currentStatusFieldSpecified;
            }
            set {
                this.currentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("statusLogEntry", IsNullable=false)]
        public StatusLogEntry[] statusLog {
            get {
                return this.statusLogField;
            }
            set {
                this.statusLogField = value;
            }
        }
        
        /// <remarks/>
        public string body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        public BodyFormat bodyFormat {
            get {
                return this.bodyFormatField;
            }
            set {
                this.bodyFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyFormatSpecified {
            get {
                return this.bodyFormatFieldSpecified;
            }
            set {
                this.bodyFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("documentId", Namespace="http://cufxstandards.com/v2/Document.xsd", IsNullable=false)]
        public string[] documentIdList {
            get {
                return this.documentIdListField;
            }
            set {
                this.documentIdListField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime doNotDeliverBeforeDateTime {
            get {
                return this.doNotDeliverBeforeDateTimeField;
            }
            set {
                this.doNotDeliverBeforeDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool doNotDeliverBeforeDateTimeSpecified {
            get {
                return this.doNotDeliverBeforeDateTimeFieldSpecified;
            }
            set {
                this.doNotDeliverBeforeDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime expirationDateTime {
            get {
                return this.expirationDateTimeField;
            }
            set {
                this.expirationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateTimeSpecified {
            get {
                return this.expirationDateTimeFieldSpecified;
            }
            set {
                this.expirationDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string requestId {
            get {
                return this.requestIdField;
            }
            set {
                this.requestIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public partial class SecureMessageUser : User {
        
        private string partyIdField;
        
        private string relationshipIdField;
        
        private string accountIdField;
        
        private string cardIdField;
        
        /// <remarks/>
        public string partyId {
            get {
                return this.partyIdField;
            }
            set {
                this.partyIdField = value;
            }
        }
        
        /// <remarks/>
        public string relationshipId {
            get {
                return this.relationshipIdField;
            }
            set {
                this.relationshipIdField = value;
            }
        }
        
        /// <remarks/>
        public string accountId {
            get {
                return this.accountIdField;
            }
            set {
                this.accountIdField = value;
            }
        }
        
        /// <remarks/>
        public string cardId {
            get {
                return this.cardIdField;
            }
            set {
                this.cardIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/MessageContext.xsd")]
    public partial class User {
        
        private string userIdField;
        
        private UserType userTypeField;
        
        private bool userTypeFieldSpecified;
        
        /// <remarks/>
        public string userId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public UserType userType {
            get {
                return this.userTypeField;
            }
            set {
                this.userTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userTypeSpecified {
            get {
                return this.userTypeFieldSpecified;
            }
            set {
                this.userTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/MessageContext.xsd")]
    public enum UserType {
        
        /// <remarks/>
        EmployeeId,
        
        /// <remarks/>
        VendorEmployeeId,
        
        /// <remarks/>
        Anonymous,
        
        /// <remarks/>
        FIUserId,
        
        /// <remarks/>
        SystemAccountId,
        
        /// <remarks/>
        Custom,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public enum SecureMessageType {
        
        /// <remarks/>
        Alert,
        
        /// <remarks/>
        GeneralMessage,
        
        /// <remarks/>
        Notice,
        
        /// <remarks/>
        ProductOffering,
        
        /// <remarks/>
        ScheduleMeeting,
        
        /// <remarks/>
        ServiceUpdate,
        
        /// <remarks/>
        SignatureRequired,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public enum SecureMessageStatus {
        
        /// <remarks/>
        Template,
        
        /// <remarks/>
        Draft,
        
        /// <remarks/>
        Outbox,
        
        /// <remarks/>
        Sent,
        
        /// <remarks/>
        Read,
        
        /// <remarks/>
        Replied,
        
        /// <remarks/>
        Forwarded,
        
        /// <remarks/>
        Archived,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public partial class StatusLogEntry {
        
        private SecureMessageStatus statusField;
        
        private bool statusFieldSpecified;
        
        private System.DateTime statusDateTimeField;
        
        private bool statusDateTimeFieldSpecified;
        
        /// <remarks/>
        public SecureMessageStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime statusDateTime {
            get {
                return this.statusDateTimeField;
            }
            set {
                this.statusDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusDateTimeSpecified {
            get {
                return this.statusDateTimeFieldSpecified;
            }
            set {
                this.statusDateTimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessage.xsd")]
    public enum BodyFormat {
        
        /// <remarks/>
        Html,
        
        /// <remarks/>
        Text,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SecureMessageFilter.xsd")]
    public partial class SecureMessageFilter {
        
        private string[] secureMessageIdListField;
        
        private string[] subjectLineListField;
        
        private SecureMessageUser[] messageFromListField;
        
        private SecureMessageUser[] messageToListField;
        
        private SecureMessageUser[] carbonCopyListField;
        
        private SecureMessageUser[] blindCarbonCopyListField;
        
        private SecureMessageUser[] replyToListField;
        
        private SecureMessageType[] secureMessageTypeListField;
        
        private SecureMessageStatus[] currentStatusListField;
        
        private SecureMessageStatus[] statusLogListField;
        
        private System.DateTime statusLogBeginDateField;
        
        private bool statusLogBeginDateFieldSpecified;
        
        private System.DateTime statusLogEndDateField;
        
        private bool statusLogEndDateFieldSpecified;
        
        private string bodyContainsField;
        
        private bool returnConversationField;
        
        private bool returnConversationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageId", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public string[] secureMessageIdList {
            get {
                return this.secureMessageIdListField;
            }
            set {
                this.secureMessageIdListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("subjectLine", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public string[] subjectLineList {
            get {
                return this.subjectLineListField;
            }
            set {
                this.subjectLineListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageUser[] messageFromList {
            get {
                return this.messageFromListField;
            }
            set {
                this.messageFromListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageUser[] messageToList {
            get {
                return this.messageToListField;
            }
            set {
                this.messageToListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageUser[] carbonCopyList {
            get {
                return this.carbonCopyListField;
            }
            set {
                this.carbonCopyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageUser[] blindCarbonCopyList {
            get {
                return this.blindCarbonCopyListField;
            }
            set {
                this.blindCarbonCopyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageUser", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageUser[] replyToList {
            get {
                return this.replyToListField;
            }
            set {
                this.replyToListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageType", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageType[] secureMessageTypeList {
            get {
                return this.secureMessageTypeListField;
            }
            set {
                this.secureMessageTypeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageStatus", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageStatus[] currentStatusList {
            get {
                return this.currentStatusListField;
            }
            set {
                this.currentStatusListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("secureMessageStatus", Namespace="http://cufxstandards.com/v2/SecureMessage.xsd", IsNullable=false)]
        public SecureMessageStatus[] statusLogList {
            get {
                return this.statusLogListField;
            }
            set {
                this.statusLogListField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime statusLogBeginDate {
            get {
                return this.statusLogBeginDateField;
            }
            set {
                this.statusLogBeginDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusLogBeginDateSpecified {
            get {
                return this.statusLogBeginDateFieldSpecified;
            }
            set {
                this.statusLogBeginDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime statusLogEndDate {
            get {
                return this.statusLogEndDateField;
            }
            set {
                this.statusLogEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusLogEndDateSpecified {
            get {
                return this.statusLogEndDateFieldSpecified;
            }
            set {
                this.statusLogEndDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string bodyContains {
            get {
                return this.bodyContainsField;
            }
            set {
                this.bodyContainsField = value;
            }
        }
        
        /// <remarks/>
        public bool returnConversation {
            get {
                return this.returnConversationField;
            }
            set {
                this.returnConversationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnConversationSpecified {
            get {
                return this.returnConversationFieldSpecified;
            }
            set {
                this.returnConversationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/SimpleValidationRequest.xsd")]
    public partial class SimpleValidationRequest {
        
        private string validationTypeField;
        
        private Applicant applicantField;
        
        private ValuePair[] customDataField;
        
        /// <remarks/>
        public string validationType {
            get {
                return this.validationTypeField;
            }
            set {
                this.validationTypeField = value;
            }
        }
        
        /// <remarks/>
        public Applicant applicant {
            get {
                return this.applicantField;
            }
            set {
                this.applicantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("valuePair", Namespace="http://cufxstandards.com/v2/Common.xsd", IsNullable=false)]
        public ValuePair[] customData {
            get {
                return this.customDataField;
            }
            set {
                this.customDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://cufxstandards.com/v2/ValidationStatus.xsd")]
    public enum ValidationStatus {
        
        /// <remarks/>
        Pass,
        
        /// <remarks/>
        Fail,
        
        /// <remarks/>
        Indeterminate,
        
        /// <remarks/>
        Error,
    }
}
