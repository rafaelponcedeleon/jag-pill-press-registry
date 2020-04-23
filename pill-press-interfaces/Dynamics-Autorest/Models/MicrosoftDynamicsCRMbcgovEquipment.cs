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
    /// Microsoft.Dynamics.CRM.bcgov_equipment
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovEquipment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovEquipment class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovEquipment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovEquipment class.
        /// </summary>
        /// <param name="statuscode">Reason for the status of the
        /// Equipment</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_stageidValue">Contains the id of the stage where the
        /// entity is located.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="traversedpath">A comma separated list of string values
        /// representing the unique identifiers of stages in a Business Process
        /// Flow Instance in the order that they occur.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="bcgovName">The name of the custom entity.</param>
        /// <param name="bcgovEquipmentid">Unique identifier for entity
        /// instances</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="bcgovIdentifyingmarkings">Serial #/ Key Part/ Make/
        /// Model/ Type - wf populated based on above mentioned values for Mail
        /// Merge usage</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="statecode">Status of the Equipment</param>
        /// <param name="processid">Contains the id of the process associated
        /// with the entity.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="emailaddress">The primary email address for the
        /// entity.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        public MicrosoftDynamicsCRMbcgovEquipment(int? statuscode = default(int?), int? bcgovPillpressencapsulatorsize = default(int?), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), int? bcgovEquipmenttype = default(int?), int? bcgovLocationchangetimes = default(int?), string bcgovPillpressencapsulatorsizeother = default(string), string _stageidValue = default(string), string bcgovModel = default(string), string versionnumber = default(string), string _owneridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string traversedpath = default(string), string _modifiedbyValue = default(string), string bcgovNameofmanufacturer = default(string), int? bcgovHowwasequipmentbuilt = default(int?), int? bcgovLevelofautomation = default(int?), string bcgovName = default(string), string bcgovEquipmentid = default(string), string _bcgovCurrentbusinessownerValue = default(string), string bcgovMake = default(string), int? bcgovPillpressmaxcapacity = default(int?), string _bcgovCurrentlocationValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string bcgovSerialnumber = default(string), string _owninguserValue = default(string), string bcgovIdentifyingmarkings = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), string processid = default(string), string bcgovCustombuiltorkeypartserialnumber = default(string), string bcgovEquipmenttypeother = default(string), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string emailaddress = default(string), string _owningteamValue = default(string), int? bcgovEncapsulatormaxcapacity = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovEquipmentActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovEquipmentAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovEquipmentEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovEquipmentFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovEquipmentLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovEquipmentPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovEquipmentServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovEquipmentTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovEquipmentRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovEquipmentSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bcgovEquipmentAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> bcgovEquipmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bcgovEquipmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> bcgovEquipmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> bcgovEquipmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovEquipmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovEquipmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMqueueitem> bcgovEquipmentQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> bcgovEquipmentAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovEquipmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovEquipmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMaccount bcgovCurrentBusinessOwner = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMbcgovCertificate> bcgovEquipmentBcgovCertificateEquipment = default(IList<MicrosoftDynamicsCRMbcgovCertificate>), IList<MicrosoftDynamicsCRMbcgovEquipmentlocation> bcgovEquipmentEquipmentlocationEquipment = default(IList<MicrosoftDynamicsCRMbcgovEquipmentlocation>), IList<MicrosoftDynamicsCRMincident> bcgovEquipmentIncident = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> bcgovEquipmentIncidentEquipmentRecord = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMbcgovLocation> bcgovLocationEquipment = default(IList<MicrosoftDynamicsCRMbcgovLocation>), MicrosoftDynamicsCRMbcgovLocation bcgovCurrentLocation = default(MicrosoftDynamicsCRMbcgovLocation), IList<MicrosoftDynamicsCRMbcgovInspection> bcgovEquipmentInspectionEquipmentRecord = default(IList<MicrosoftDynamicsCRMbcgovInspection>), IList<MicrosoftDynamicsCRMbcgovComplaint> bcgovComplaintEquipment = default(IList<MicrosoftDynamicsCRMbcgovComplaint>))
        {
            Statuscode = statuscode;
            BcgovPillpressencapsulatorsize = bcgovPillpressencapsulatorsize;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            BcgovEquipmenttype = bcgovEquipmenttype;
            BcgovLocationchangetimes = bcgovLocationchangetimes;
            BcgovPillpressencapsulatorsizeother = bcgovPillpressencapsulatorsizeother;
            this._stageidValue = _stageidValue;
            BcgovModel = bcgovModel;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            Createdon = createdon;
            Traversedpath = traversedpath;
            this._modifiedbyValue = _modifiedbyValue;
            BcgovNameofmanufacturer = bcgovNameofmanufacturer;
            BcgovHowwasequipmentbuilt = bcgovHowwasequipmentbuilt;
            BcgovLevelofautomation = bcgovLevelofautomation;
            BcgovName = bcgovName;
            BcgovEquipmentid = bcgovEquipmentid;
            this._bcgovCurrentbusinessownerValue = _bcgovCurrentbusinessownerValue;
            BcgovMake = bcgovMake;
            BcgovPillpressmaxcapacity = bcgovPillpressmaxcapacity;
            this._bcgovCurrentlocationValue = _bcgovCurrentlocationValue;
            Overriddencreatedon = overriddencreatedon;
            BcgovSerialnumber = bcgovSerialnumber;
            this._owninguserValue = _owninguserValue;
            BcgovIdentifyingmarkings = bcgovIdentifyingmarkings;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Processid = processid;
            BcgovCustombuiltorkeypartserialnumber = bcgovCustombuiltorkeypartserialnumber;
            BcgovEquipmenttypeother = bcgovEquipmenttypeother;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Emailaddress = emailaddress;
            this._owningteamValue = _owningteamValue;
            BcgovEncapsulatormaxcapacity = bcgovEncapsulatormaxcapacity;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovEquipmentActivityPointers = bcgovEquipmentActivityPointers;
            BcgovEquipmentAppointments = bcgovEquipmentAppointments;
            BcgovEquipmentEmails = bcgovEquipmentEmails;
            BcgovEquipmentFaxes = bcgovEquipmentFaxes;
            BcgovEquipmentLetters = bcgovEquipmentLetters;
            BcgovEquipmentPhoneCalls = bcgovEquipmentPhoneCalls;
            BcgovEquipmentServiceAppointments = bcgovEquipmentServiceAppointments;
            BcgovEquipmentTasks = bcgovEquipmentTasks;
            BcgovEquipmentRecurringAppointmentMasters = bcgovEquipmentRecurringAppointmentMasters;
            BcgovEquipmentSocialActivities = bcgovEquipmentSocialActivities;
            BcgovEquipmentAbsScheduledprocessexecutions = bcgovEquipmentAbsScheduledprocessexecutions;
            BcgovEquipmentSyncErrors = bcgovEquipmentSyncErrors;
            BcgovEquipmentActivityParties = bcgovEquipmentActivityParties;
            BcgovEquipmentConnections1 = bcgovEquipmentConnections1;
            BcgovEquipmentConnections2 = bcgovEquipmentConnections2;
            BcgovEquipmentDuplicateMatchingRecord = bcgovEquipmentDuplicateMatchingRecord;
            BcgovEquipmentDuplicateBaseRecord = bcgovEquipmentDuplicateBaseRecord;
            BcgovEquipmentQueueItems = bcgovEquipmentQueueItems;
            BcgovEquipmentAnnotations = bcgovEquipmentAnnotations;
            BcgovEquipmentAsyncOperations = bcgovEquipmentAsyncOperations;
            BcgovEquipmentBulkDeleteFailures = bcgovEquipmentBulkDeleteFailures;
            Stageid = stageid;
            BcgovCurrentBusinessOwner = bcgovCurrentBusinessOwner;
            BcgovEquipmentBcgovCertificateEquipment = bcgovEquipmentBcgovCertificateEquipment;
            BcgovEquipmentEquipmentlocationEquipment = bcgovEquipmentEquipmentlocationEquipment;
            BcgovEquipmentIncident = bcgovEquipmentIncident;
            BcgovEquipmentIncidentEquipmentRecord = bcgovEquipmentIncidentEquipmentRecord;
            BcgovLocationEquipment = bcgovLocationEquipment;
            BcgovCurrentLocation = bcgovCurrentLocation;
            BcgovEquipmentInspectionEquipmentRecord = bcgovEquipmentInspectionEquipmentRecord;
            BcgovComplaintEquipment = bcgovComplaintEquipment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reason for the status of the Equipment
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_pillpressencapsulatorsize")]
        public int? BcgovPillpressencapsulatorsize { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmenttype")]
        public int? BcgovEquipmenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_locationchangetimes")]
        public int? BcgovLocationchangetimes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_pillpressencapsulatorsizeother")]
        public string BcgovPillpressencapsulatorsizeother { get; set; }

        /// <summary>
        /// Gets or sets contains the id of the stage where the entity is
        /// located.
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_model")]
        public string BcgovModel { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets a comma separated list of string values representing
        /// the unique identifiers of stages in a Business Process Flow
        /// Instance in the order that they occur.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_nameofmanufacturer")]
        public string BcgovNameofmanufacturer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_howwasequipmentbuilt")]
        public int? BcgovHowwasequipmentbuilt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_levelofautomation")]
        public int? BcgovLevelofautomation { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmentid")]
        public string BcgovEquipmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_currentbusinessowner_value")]
        public string _bcgovCurrentbusinessownerValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_make")]
        public string BcgovMake { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_pillpressmaxcapacity")]
        public int? BcgovPillpressmaxcapacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_currentlocation_value")]
        public string _bcgovCurrentlocationValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_serialnumber")]
        public string BcgovSerialnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets serial #/ Key Part/ Make/ Model/ Type - wf populated
        /// based on above mentioned values for Mail Merge usage
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_identifyingmarkings")]
        public string BcgovIdentifyingmarkings { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets status of the Equipment
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets contains the id of the process associated with the
        /// entity.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_custombuiltorkeypartserialnumber")]
        public string BcgovCustombuiltorkeypartserialnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipmenttypeother")]
        public string BcgovEquipmenttypeother { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets the primary email address for the entity.
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_encapsulatormaxcapacity")]
        public int? BcgovEncapsulatormaxcapacity { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_equipment_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovEquipmentActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovEquipmentAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovEquipmentEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovEquipmentFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovEquipmentLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovEquipmentPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovEquipmentServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovEquipmentTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovEquipmentRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovEquipmentSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BcgovEquipmentAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovEquipmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BcgovEquipmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovEquipmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> BcgovEquipmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovEquipmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovEquipmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovEquipmentQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BcgovEquipmentAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovEquipmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovEquipmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_CurrentBusinessOwner")]
        public MicrosoftDynamicsCRMaccount BcgovCurrentBusinessOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_bcgov_certificate_Equipment")]
        public IList<MicrosoftDynamicsCRMbcgovCertificate> BcgovEquipmentBcgovCertificateEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_equipmentlocation_Equipment")]
        public IList<MicrosoftDynamicsCRMbcgovEquipmentlocation> BcgovEquipmentEquipmentlocationEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_incident")]
        public IList<MicrosoftDynamicsCRMincident> BcgovEquipmentIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_incident_EquipmentRecord")]
        public IList<MicrosoftDynamicsCRMincident> BcgovEquipmentIncidentEquipmentRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_location_equipment")]
        public IList<MicrosoftDynamicsCRMbcgovLocation> BcgovLocationEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_CurrentLocation")]
        public MicrosoftDynamicsCRMbcgovLocation BcgovCurrentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_equipment_inspection_EquipmentRecord")]
        public IList<MicrosoftDynamicsCRMbcgovInspection> BcgovEquipmentInspectionEquipmentRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_equipment")]
        public IList<MicrosoftDynamicsCRMbcgovComplaint> BcgovComplaintEquipment { get; set; }

    }
}
