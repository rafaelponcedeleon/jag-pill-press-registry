// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// bcgov_customaddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovCustomaddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCustomaddress class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCustomaddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCustomaddress class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCustomaddress(string _owningteamValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string _slaidValue = default(string), long? versionnumber = default(long?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string bcgovProvince = default(string), int? statecode = default(int?), string bcgovCity = default(string), string _owninguserValue = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string _stageidValue = default(string), int? onholdtime = default(int?), string _bcgovAddressesidValue = default(string), int? bcgovAddresstype = default(int?), string _owneridValue = default(string), string processid = default(string), string _owningbusinessunitValue = default(string), string bcgovStreetline3 = default(string), string _bcgovBusinessprofileValue = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string traversedpath = default(string), string emailaddress = default(string), string bcgovCustomaddressid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string bcgovCountrytxt = default(string), string _modifiedonbehalfbyValue = default(string), string bcgovStreetline2 = default(string), string bcgovPostalcode = default(string), int? importsequencenumber = default(int?), string bcgovName = default(string), string _slainvokedidValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovCustomaddressActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovCustomaddressAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovCustomaddressEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovCustomaddressFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovCustomaddressLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovCustomaddressPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovCustomaddressServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovCustomaddressTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovCustomaddressRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovCustomaddressSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bcgovCustomaddressAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> bcgovCustomaddressSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bcgovCustomaddressActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> bcgovCustomaddressConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> bcgovCustomaddressConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCustomaddressDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCustomaddressDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMqueueitem> bcgovCustomaddressQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> bcgovCustomaddressAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMfeedback> bcgovCustomaddressFeedback = default(IList<MicrosoftDynamicsCRMfeedback>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovCustomaddressAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovCustomaddressBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMknowledgebaserecord> bcgovCustomaddressKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMknowledgebaserecord>), IList<MicrosoftDynamicsCRMknowledgearticle> msdynBcgovCustomaddressKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slainvokedid = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMslakpiinstance> bcgovCustomaddressSLAKPIInstances = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMaccount bcgovAddressesId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount bcgovBusinessProfile = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMaccount> bcgovBcgovCustomaddressAccountCurrentBusinessMailingAddress = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMaccount> bcgovBcgovCustomaddressAccountCurrentBusinessPhysicalAddress = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMincident> bcgovBcgovCustomaddressIncidentAddressofBusinessthathasRentedorLeased = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentAddressofBusinessthathasGivenorLoaned = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentAddressofPersonBusiness = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentBCSellersAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentImportersAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentOriginatingSellersAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentOutsideBCSellersAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMbcgovLocation> bcgovCustomaddressLocationLocationAddress = default(IList<MicrosoftDynamicsCRMbcgovLocation>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentAddressWhereEquipmentWasDestroyed = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentCivicAddressofPurchaser = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentPurchasersCivicAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovCustomaddressIncidentPurchasersBusinessAddress = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMbcgovComplaint> bcgovBcgovCustomaddressBcgovComplaintLocationAddress = default(IList<MicrosoftDynamicsCRMbcgovComplaint>), IList<MicrosoftDynamicsCRMcontact> bcgovCustomaddressContactAddress = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMcontact> bcgovCustomaddressContactBusinessAddress = default(IList<MicrosoftDynamicsCRMcontact>))
        {
            this._owningteamValue = _owningteamValue;
            Overriddencreatedon = overriddencreatedon;
            Lastonholdtime = lastonholdtime;
            this._slaidValue = _slaidValue;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            BcgovProvince = bcgovProvince;
            Statecode = statecode;
            BcgovCity = bcgovCity;
            this._owninguserValue = _owninguserValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._stageidValue = _stageidValue;
            Onholdtime = onholdtime;
            this._bcgovAddressesidValue = _bcgovAddressesidValue;
            BcgovAddresstype = bcgovAddresstype;
            this._owneridValue = _owneridValue;
            Processid = processid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            BcgovStreetline3 = bcgovStreetline3;
            this._bcgovBusinessprofileValue = _bcgovBusinessprofileValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Traversedpath = traversedpath;
            Emailaddress = emailaddress;
            BcgovCustomaddressid = bcgovCustomaddressid;
            Createdon = createdon;
            Statuscode = statuscode;
            BcgovCountrytxt = bcgovCountrytxt;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BcgovStreetline2 = bcgovStreetline2;
            BcgovPostalcode = bcgovPostalcode;
            Importsequencenumber = importsequencenumber;
            BcgovName = bcgovName;
            this._slainvokedidValue = _slainvokedidValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovCustomaddressActivityPointers = bcgovCustomaddressActivityPointers;
            BcgovCustomaddressAppointments = bcgovCustomaddressAppointments;
            BcgovCustomaddressEmails = bcgovCustomaddressEmails;
            BcgovCustomaddressFaxes = bcgovCustomaddressFaxes;
            BcgovCustomaddressLetters = bcgovCustomaddressLetters;
            BcgovCustomaddressPhoneCalls = bcgovCustomaddressPhoneCalls;
            BcgovCustomaddressServiceAppointments = bcgovCustomaddressServiceAppointments;
            BcgovCustomaddressTasks = bcgovCustomaddressTasks;
            BcgovCustomaddressRecurringAppointmentMasters = bcgovCustomaddressRecurringAppointmentMasters;
            BcgovCustomaddressSocialActivities = bcgovCustomaddressSocialActivities;
            BcgovCustomaddressAbsScheduledprocessexecutions = bcgovCustomaddressAbsScheduledprocessexecutions;
            BcgovCustomaddressSyncErrors = bcgovCustomaddressSyncErrors;
            BcgovCustomaddressActivityParties = bcgovCustomaddressActivityParties;
            BcgovCustomaddressConnections1 = bcgovCustomaddressConnections1;
            BcgovCustomaddressConnections2 = bcgovCustomaddressConnections2;
            BcgovCustomaddressDuplicateMatchingRecord = bcgovCustomaddressDuplicateMatchingRecord;
            BcgovCustomaddressDuplicateBaseRecord = bcgovCustomaddressDuplicateBaseRecord;
            BcgovCustomaddressQueueItems = bcgovCustomaddressQueueItems;
            BcgovCustomaddressAnnotations = bcgovCustomaddressAnnotations;
            BcgovCustomaddressFeedback = bcgovCustomaddressFeedback;
            BcgovCustomaddressAsyncOperations = bcgovCustomaddressAsyncOperations;
            BcgovCustomaddressBulkDeleteFailures = bcgovCustomaddressBulkDeleteFailures;
            Stageid = stageid;
            BcgovCustomaddressKnowledgebaserecord = bcgovCustomaddressKnowledgebaserecord;
            MsdynBcgovCustomaddressKnowledgearticle = msdynBcgovCustomaddressKnowledgearticle;
            Slaid = slaid;
            Slainvokedid = slainvokedid;
            BcgovCustomaddressSLAKPIInstances = bcgovCustomaddressSLAKPIInstances;
            BcgovAddressesId = bcgovAddressesId;
            BcgovBusinessProfile = bcgovBusinessProfile;
            BcgovBcgovCustomaddressAccountCurrentBusinessMailingAddress = bcgovBcgovCustomaddressAccountCurrentBusinessMailingAddress;
            BcgovBcgovCustomaddressAccountCurrentBusinessPhysicalAddress = bcgovBcgovCustomaddressAccountCurrentBusinessPhysicalAddress;
            BcgovBcgovCustomaddressIncidentAddressofBusinessthathasRentedorLeased = bcgovBcgovCustomaddressIncidentAddressofBusinessthathasRentedorLeased;
            BcgovCustomaddressIncidentAddressofBusinessthathasGivenorLoaned = bcgovCustomaddressIncidentAddressofBusinessthathasGivenorLoaned;
            BcgovCustomaddressIncidentAddressofPersonBusiness = bcgovCustomaddressIncidentAddressofPersonBusiness;
            BcgovCustomaddressIncidentBCSellersAddress = bcgovCustomaddressIncidentBCSellersAddress;
            BcgovCustomaddressIncidentImportersAddress = bcgovCustomaddressIncidentImportersAddress;
            BcgovCustomaddressIncidentOriginatingSellersAddress = bcgovCustomaddressIncidentOriginatingSellersAddress;
            BcgovCustomaddressIncidentOutsideBCSellersAddress = bcgovCustomaddressIncidentOutsideBCSellersAddress;
            BcgovCustomaddressLocationLocationAddress = bcgovCustomaddressLocationLocationAddress;
            BcgovCustomaddressIncidentAddressWhereEquipmentWasDestroyed = bcgovCustomaddressIncidentAddressWhereEquipmentWasDestroyed;
            BcgovCustomaddressIncidentCivicAddressofPurchaser = bcgovCustomaddressIncidentCivicAddressofPurchaser;
            BcgovCustomaddressIncidentPurchasersCivicAddress = bcgovCustomaddressIncidentPurchasersCivicAddress;
            BcgovCustomaddressIncidentPurchasersBusinessAddress = bcgovCustomaddressIncidentPurchasersBusinessAddress;
            BcgovBcgovCustomaddressBcgovComplaintLocationAddress = bcgovBcgovCustomaddressBcgovComplaintLocationAddress;
            BcgovCustomaddressContactAddress = bcgovCustomaddressContactAddress;
            BcgovCustomaddressContactBusinessAddress = bcgovCustomaddressContactBusinessAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_province")]
        public string BcgovProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_city")]
        public string BcgovCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_addressesid_value")]
        public string _bcgovAddressesidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_addresstype")]
        public int? BcgovAddresstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_streetline3")]
        public string BcgovStreetline3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_businessprofile_value")]
        public string _bcgovBusinessprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddressid")]
        public string BcgovCustomaddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_countrytxt")]
        public string BcgovCountrytxt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_streetline2")]
        public string BcgovStreetline2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_postalcode")]
        public string BcgovPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovCustomaddressActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovCustomaddressAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovCustomaddressEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovCustomaddressFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovCustomaddressLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovCustomaddressPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovCustomaddressServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovCustomaddressTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovCustomaddressRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovCustomaddressSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BcgovCustomaddressAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovCustomaddressSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BcgovCustomaddressActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovCustomaddressConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovCustomaddressConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCustomaddressDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCustomaddressDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovCustomaddressQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BcgovCustomaddressAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_Feedback")]
        public IList<MicrosoftDynamicsCRMfeedback> BcgovCustomaddressFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovCustomaddressAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovCustomaddressBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMknowledgebaserecord> BcgovCustomaddressKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_bcgov_customaddress_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> MsdynBcgovCustomaddressKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid")]
        public MicrosoftDynamicsCRMsla Slainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_SLAKPIInstances")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> BcgovCustomaddressSLAKPIInstances { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_AddressesId")]
        public MicrosoftDynamicsCRMaccount BcgovAddressesId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_BusinessProfile")]
        public MicrosoftDynamicsCRMaccount BcgovBusinessProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_bcgov_customaddress_account_CurrentBusinessMailingAddress")]
        public IList<MicrosoftDynamicsCRMaccount> BcgovBcgovCustomaddressAccountCurrentBusinessMailingAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_bcgov_customaddress_account_CurrentBusinessPhysicalAddress")]
        public IList<MicrosoftDynamicsCRMaccount> BcgovBcgovCustomaddressAccountCurrentBusinessPhysicalAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_bcgov_customaddress_incident_AddressofBusinessthathasRentedorLeased")]
        public IList<MicrosoftDynamicsCRMincident> BcgovBcgovCustomaddressIncidentAddressofBusinessthathasRentedorLeased { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_AddressofBusinessthathasGivenorLoaned")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentAddressofBusinessthathasGivenorLoaned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_AddressofPersonBusiness")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentAddressofPersonBusiness { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_BCSellersAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentBCSellersAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_ImportersAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentImportersAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_OriginatingSellersAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentOriginatingSellersAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_OutsideBCSellersAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentOutsideBCSellersAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_location_LocationAddress")]
        public IList<MicrosoftDynamicsCRMbcgovLocation> BcgovCustomaddressLocationLocationAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_AddressWhereEquipmentWasDestroyed")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentAddressWhereEquipmentWasDestroyed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_CivicAddressofPurchaser")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentCivicAddressofPurchaser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_PurchasersCivicAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentPurchasersCivicAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_incident_PurchasersBusinessAddress")]
        public IList<MicrosoftDynamicsCRMincident> BcgovCustomaddressIncidentPurchasersBusinessAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_bcgov_customaddress_bcgov_complaint_LocationAddress")]
        public IList<MicrosoftDynamicsCRMbcgovComplaint> BcgovBcgovCustomaddressBcgovComplaintLocationAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_contact_Address")]
        public IList<MicrosoftDynamicsCRMcontact> BcgovCustomaddressContactAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddress_contact_BusinessAddress")]
        public IList<MicrosoftDynamicsCRMcontact> BcgovCustomaddressContactBusinessAddress { get; set; }

    }
}
