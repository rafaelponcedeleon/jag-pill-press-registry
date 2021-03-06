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
    /// bcgov_inspectionchecklist
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovInspectionchecklist
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionchecklist class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionchecklist()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionchecklist class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionchecklist(string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string bcgovInspectionchecklistid = default(string), int? statuscode = default(int?), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), int? bcgovOffences = default(int?), bool? bcgovVtservedonbusiness = default(bool?), int? bcgovOutcome = default(int?), bool? bcgovVtteamleadapproval = default(bool?), string _owningteamValue = default(string), string bcgovName = default(string), long? versionnumber = default(long?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _bcgovInspectionValue = default(string), string bcgovNotes = default(string), int? timezoneruleversionnumber = default(int?), bool? bcgovVtsendpaperworktocoordinator = default(bool?), string _bcgovViolationticketValue = default(string), bool? bcgovVtupload = default(bool?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _bcgovActregulationreferenceValue = default(string), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bcgovInspectionchecklistSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionchecklistDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionchecklistDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovInspectionchecklistAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovInspectionchecklistBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbcgovActregulationreference bcgovActRegulationReference = default(MicrosoftDynamicsCRMbcgovActregulationreference), IList<MicrosoftDynamicsCRMbcgovInspection> bcgovInspectionInspectionchecklis = default(IList<MicrosoftDynamicsCRMbcgovInspection>), IList<MicrosoftDynamicsCRMbcgovActregulationreference> bcgovInspectionchecklistActregula = default(IList<MicrosoftDynamicsCRMbcgovActregulationreference>), MicrosoftDynamicsCRMbcgovInspection bcgovInspection = default(MicrosoftDynamicsCRMbcgovInspection), IList<MicrosoftDynamicsCRMbcgovViolationticket> bcgovInspectionchecklistViolationticketActRegulationViolated = default(IList<MicrosoftDynamicsCRMbcgovViolationticket>), MicrosoftDynamicsCRMbcgovViolationticket bcgovViolationTicket = default(MicrosoftDynamicsCRMbcgovViolationticket))
        {
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            BcgovInspectionchecklistid = bcgovInspectionchecklistid;
            Statuscode = statuscode;
            Statecode = statecode;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            BcgovOffences = bcgovOffences;
            BcgovVtservedonbusiness = bcgovVtservedonbusiness;
            BcgovOutcome = bcgovOutcome;
            BcgovVtteamleadapproval = bcgovVtteamleadapproval;
            this._owningteamValue = _owningteamValue;
            BcgovName = bcgovName;
            Versionnumber = versionnumber;
            Createdon = createdon;
            this._bcgovInspectionValue = _bcgovInspectionValue;
            BcgovNotes = bcgovNotes;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            BcgovVtsendpaperworktocoordinator = bcgovVtsendpaperworktocoordinator;
            this._bcgovViolationticketValue = _bcgovViolationticketValue;
            BcgovVtupload = bcgovVtupload;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._bcgovActregulationreferenceValue = _bcgovActregulationreferenceValue;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovInspectionchecklistSyncErrors = bcgovInspectionchecklistSyncErrors;
            BcgovInspectionchecklistDuplicateMatchingRecord = bcgovInspectionchecklistDuplicateMatchingRecord;
            BcgovInspectionchecklistDuplicateBaseRecord = bcgovInspectionchecklistDuplicateBaseRecord;
            BcgovInspectionchecklistAsyncOperations = bcgovInspectionchecklistAsyncOperations;
            BcgovInspectionchecklistBulkDeleteFailures = bcgovInspectionchecklistBulkDeleteFailures;
            BcgovActRegulationReference = bcgovActRegulationReference;
            BcgovInspectionInspectionchecklis = bcgovInspectionInspectionchecklis;
            BcgovInspectionchecklistActregula = bcgovInspectionchecklistActregula;
            BcgovInspection = bcgovInspection;
            BcgovInspectionchecklistViolationticketActRegulationViolated = bcgovInspectionchecklistViolationticketActRegulationViolated;
            BcgovViolationTicket = bcgovViolationTicket;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklistid")]
        public string BcgovInspectionchecklistid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_offences")]
        public int? BcgovOffences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_vtservedonbusiness")]
        public bool? BcgovVtservedonbusiness { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_outcome")]
        public int? BcgovOutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_vtteamleadapproval")]
        public bool? BcgovVtteamleadapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_inspection_value")]
        public string _bcgovInspectionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_notes")]
        public string BcgovNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_vtsendpaperworktocoordinator")]
        public bool? BcgovVtsendpaperworktocoordinator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_violationticket_value")]
        public string _bcgovViolationticketValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_vtupload")]
        public bool? BcgovVtupload { get; set; }

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
        [JsonProperty(PropertyName = "_bcgov_actregulationreference_value")]
        public string _bcgovActregulationreferenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovInspectionchecklistSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionchecklistDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionchecklistDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovInspectionchecklistAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovInspectionchecklistBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_ActRegulationReference")]
        public MicrosoftDynamicsCRMbcgovActregulationreference BcgovActRegulationReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_inspectionchecklis")]
        public IList<MicrosoftDynamicsCRMbcgovInspection> BcgovInspectionInspectionchecklis { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_actregula")]
        public IList<MicrosoftDynamicsCRMbcgovActregulationreference> BcgovInspectionchecklistActregula { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Inspection")]
        public MicrosoftDynamicsCRMbcgovInspection BcgovInspection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionchecklist_violationticket_ActRegulationViolated")]
        public IList<MicrosoftDynamicsCRMbcgovViolationticket> BcgovInspectionchecklistViolationticketActRegulationViolated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_ViolationTicket")]
        public MicrosoftDynamicsCRMbcgovViolationticket BcgovViolationTicket { get; set; }

    }
}
