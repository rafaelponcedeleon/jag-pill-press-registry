// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.workflowlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMworkflowlog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        /// <param name="stepname">Name of the process step.</param>
        /// <param name="_childworkflowinstanceidValue">Unique identifier of
        /// the system job.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the process log.</param>
        /// <param name="message">Message related to process.</param>
        /// <param name="duration">Duration between completed on and started
        /// on, used by business process flow.</param>
        /// <param name="activityname">Name of the activity which the process
        /// step is currently processing.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier of the
        /// business unit that owns the process.</param>
        /// <param name="interactionactivityresult">String specifying the
        /// result of an interaction activity.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns the process.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the process log entry.</param>
        /// <param name="completedon">Date and time when the operation was
        /// completed.</param>
        /// <param name="workflowlogid">Unique identifier of the process log
        /// entry.</param>
        /// <param name="stagename">Name of the process stage.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the process log entry.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the process log.</param>
        /// <param name="status">Status of the process step for which process
        /// log record has been created: In Progress, Successfully Completed,
        /// or Failed.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the process log.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns the process log.</param>
        /// <param name="description">Description of the process step.</param>
        /// <param name="_regardingobjectidValue">Unique identifier of the
        /// associated record.</param>
        /// <param name="modifiedon">Date and time when the process log entry
        /// was last modified.</param>
        /// <param name="startedon">Date and time when the operation was
        /// started.</param>
        /// <param name="createdon">Date and time when the process log entry
        /// was created.</param>
        /// <param name="_asyncoperationidValue">Unique identifier of the
        /// parent record.</param>
        /// <param name="errorcode">Error code related to process.</param>
        public MicrosoftDynamicsCRMworkflowlog(string stepname = default(string), string _childworkflowinstanceidValue = default(string), string _owneridValue = default(string), string message = default(string), int? duration = default(int?), string activityname = default(string), string _owningbusinessunitValue = default(string), string interactionactivityresult = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string workflowlogid = default(string), string stagename = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), int? status = default(int?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), string description = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? startedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _asyncoperationidValue = default(string), int? errorcode = default(int?), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMasyncoperation childworkflowinstanceidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMleadtoopportunitysalesprocess leadToOpportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMleadtoopportunitysalesprocess), MicrosoftDynamicsCRMexpiredprocess expiredProcessAsyncoperationid = default(MicrosoftDynamicsCRMexpiredprocess), MicrosoftDynamicsCRMtranslationprocess translationProcessAsyncoperationid = default(MicrosoftDynamicsCRMtranslationprocess), MicrosoftDynamicsCRMopportunitysalesprocess opportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMopportunitysalesprocess), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMphonetocaseprocess phoneToCaseProcessAsyncoperationid = default(MicrosoftDynamicsCRMphonetocaseprocess), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMasyncoperation asyncoperationidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMnewprocess newProcessAsyncoperationid = default(MicrosoftDynamicsCRMnewprocess), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbcgovInspectionprocessflow asyncoperationidBcgovInspectionprocessflow = default(MicrosoftDynamicsCRMbcgovInspectionprocessflow), MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow asyncoperationidBcgovComplaintcomplaintprocessflow = default(MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow))
        {
            Stepname = stepname;
            this._childworkflowinstanceidValue = _childworkflowinstanceidValue;
            this._owneridValue = _owneridValue;
            Message = message;
            Duration = duration;
            Activityname = activityname;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Interactionactivityresult = interactionactivityresult;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Completedon = completedon;
            Workflowlogid = workflowlogid;
            Stagename = stagename;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Status = status;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Description = description;
            this._regardingobjectidValue = _regardingobjectidValue;
            Modifiedon = modifiedon;
            Startedon = startedon;
            Createdon = createdon;
            this._asyncoperationidValue = _asyncoperationidValue;
            Errorcode = errorcode;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            ChildworkflowinstanceidAsyncoperation = childworkflowinstanceidAsyncoperation;
            LeadToOpportunitySalesProcessAsyncoperationid = leadToOpportunitySalesProcessAsyncoperationid;
            ExpiredProcessAsyncoperationid = expiredProcessAsyncoperationid;
            TranslationProcessAsyncoperationid = translationProcessAsyncoperationid;
            OpportunitySalesProcessAsyncoperationid = opportunitySalesProcessAsyncoperationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            PhoneToCaseProcessAsyncoperationid = phoneToCaseProcessAsyncoperationid;
            Owningbusinessunit = owningbusinessunit;
            AsyncoperationidAsyncoperation = asyncoperationidAsyncoperation;
            NewProcessAsyncoperationid = newProcessAsyncoperationid;
            Createdby = createdby;
            AsyncoperationidBcgovInspectionprocessflow = asyncoperationidBcgovInspectionprocessflow;
            AsyncoperationidBcgovComplaintcomplaintprocessflow = asyncoperationidBcgovComplaintcomplaintprocessflow;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the process step.
        /// </summary>
        [JsonProperty(PropertyName = "stepname")]
        public string Stepname { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the system job.
        /// </summary>
        [JsonProperty(PropertyName = "_childworkflowinstanceid_value")]
        public string _childworkflowinstanceidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// process log.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets message related to process.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets duration between completed on and started on, used by
        /// business process flow.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or sets name of the activity which the process step is
        /// currently processing.
        /// </summary>
        [JsonProperty(PropertyName = "activityname")]
        public string Activityname { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// process.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets string specifying the result of an interaction
        /// activity.
        /// </summary>
        [JsonProperty(PropertyName = "interactionactivityresult")]
        public string Interactionactivityresult { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the process.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the process
        /// log entry.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the operation was completed.
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the process log entry.
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogid")]
        public string Workflowlogid { get; set; }

        /// <summary>
        /// Gets or sets name of the process stage.
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// process log entry.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// process log.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets status of the process step for which process log
        /// record has been created: In Progress, Successfully Completed, or
        /// Failed.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the process log.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the process
        /// log.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets description of the process step.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated record.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the process log entry was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the operation was started.
        /// </summary>
        [JsonProperty(PropertyName = "startedon")]
        public System.DateTimeOffset? Startedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the process log entry was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the parent record.
        /// </summary>
        [JsonProperty(PropertyName = "_asyncoperationid_value")]
        public string _asyncoperationidValue { get; set; }

        /// <summary>
        /// Gets or sets error code related to process.
        /// </summary>
        [JsonProperty(PropertyName = "errorcode")]
        public int? Errorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childworkflowinstanceid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation ChildworkflowinstanceidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadToOpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess LeadToOpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExpiredProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMexpiredprocess ExpiredProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMtranslationprocess TranslationProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMopportunitysalesprocess OpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneToCaseProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMphonetocaseprocess PhoneToCaseProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation AsyncoperationidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMnewprocess NewProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_bcgov_inspectionprocessflow")]
        public MicrosoftDynamicsCRMbcgovInspectionprocessflow AsyncoperationidBcgovInspectionprocessflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_bcgov_complaintcomplaintprocessflow")]
        public MicrosoftDynamicsCRMbcgovComplaintcomplaintprocessflow AsyncoperationidBcgovComplaintcomplaintprocessflow { get; set; }

    }
}
