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
    /// Microsoft.Dynamics.CRM.equipment
    /// </summary>
    public partial class MicrosoftDynamicsCRMequipment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMequipment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMequipment
        /// class.
        /// </summary>
        /// <param name="_businessunitidValue">Unique identifier of the
        /// associated business unit.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the equipment.</param>
        /// <param name="isdisabled">Whether the facility/equipment is disabled
        /// or operational.</param>
        /// <param name="skills">Skills needed to operate the
        /// facility/equipment.</param>
        /// <param name="_siteidValue">Site where the facility/equipment is
        /// located.</param>
        /// <param name="timezonecode">Local time zone where the
        /// facility/equipment is located.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="displayinserviceviews">For internal use only.</param>
        /// <param name="emailaddress">Email address of person to contact about
        /// the use of the facility/equipment.</param>
        /// <param name="createdon">Date and time when the facility/equipment
        /// entry was created.</param>
        /// <param name="description">Description of the
        /// facility/equipment.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the equipment.</param>
        /// <param name="name">Name of the facility/equipment.</param>
        /// <param name="_organizationidValue">Unique identifier of the parent
        /// business unit.</param>
        /// <param name="versionnumber">Version number of the
        /// equipment.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the facility/equipment.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the facility/equipment entry.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the equipment.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the equipment with respect to the base
        /// currency.</param>
        /// <param name="modifiedon">Date and time when the facility/equipment
        /// entry was last modified.</param>
        /// <param name="_calendaridValue">Fiscal calendar associated with the
        /// facility/equipment.</param>
        /// <param name="equipmentid">Unique identifier of the
        /// facility/equipment.</param>
        public MicrosoftDynamicsCRMequipment(string _businessunitidValue = default(string), int? timezoneruleversionnumber = default(int?), string _transactioncurrencyidValue = default(string), bool? isdisabled = default(bool?), string skills = default(string), string _siteidValue = default(string), int? timezonecode = default(int?), int? utcconversiontimezonecode = default(int?), bool? displayinserviceviews = default(bool?), string emailaddress = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string description = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string name = default(string), string _organizationidValue = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _calendaridValue = default(string), string equipmentid = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), IList<MicrosoftDynamicsCRMasyncoperation> equipmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> equipmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMaccount> equipmentAccounts = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> equipmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMconnection> equipmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMannotation> equipmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMresource> equipmentResources = default(IList<MicrosoftDynamicsCRMresource>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> equipmentEmailEmailSender = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMcontact> equipmentContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMactivityparty> equipmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> equipmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> equipmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._businessunitidValue = _businessunitidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Isdisabled = isdisabled;
            Skills = skills;
            this._siteidValue = _siteidValue;
            Timezonecode = timezonecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Displayinserviceviews = displayinserviceviews;
            Emailaddress = emailaddress;
            Createdon = createdon;
            Description = description;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Name = name;
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Exchangerate = exchangerate;
            Modifiedon = modifiedon;
            this._calendaridValue = _calendaridValue;
            Equipmentid = equipmentid;
            Modifiedby = modifiedby;
            Calendarid = calendarid;
            EquipmentAsyncOperations = equipmentAsyncOperations;
            EquipmentDuplicateBaseRecord = equipmentDuplicateBaseRecord;
            EquipmentDuplicateMatchingRecord = equipmentDuplicateMatchingRecord;
            EquipmentAccounts = equipmentAccounts;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            BusinessunitidSystemuser = businessunitidSystemuser;
            EquipmentBulkDeleteFailures = equipmentBulkDeleteFailures;
            EquipmentConnections1 = equipmentConnections1;
            Organizationid = organizationid;
            Siteid = siteid;
            Transactioncurrencyid = transactioncurrencyid;
            EquipmentAnnotation = equipmentAnnotation;
            EquipmentResources = equipmentResources;
            Modifiedonbehalfby = modifiedonbehalfby;
            EquipmentEmailEmailSender = equipmentEmailEmailSender;
            EquipmentContacts = equipmentContacts;
            EquipmentActivityParties = equipmentActivityParties;
            Createdby = createdby;
            EquipmentConnections2 = equipmentConnections2;
            EquipmentSyncErrors = equipmentSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the associated business unit.
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// equipment.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets whether the facility/equipment is disabled or
        /// operational.
        /// </summary>
        [JsonProperty(PropertyName = "isdisabled")]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// Gets or sets skills needed to operate the facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "skills")]
        public string Skills { get; set; }

        /// <summary>
        /// Gets or sets site where the facility/equipment is located.
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// Gets or sets local time zone where the facility/equipment is
        /// located.
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "displayinserviceviews")]
        public bool? Displayinserviceviews { get; set; }

        /// <summary>
        /// Gets or sets email address of person to contact about the use of
        /// the facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// Gets or sets date and time when the facility/equipment entry was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets description of the facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the equipment.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets name of the facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the parent business unit.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets version number of the equipment.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// facility/equipment entry.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// equipment.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// equipment with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets date and time when the facility/equipment entry was
        /// last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets fiscal calendar associated with the
        /// facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the facility/equipment.
        /// </summary>
        [JsonProperty(PropertyName = "equipmentid")]
        public string Equipmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EquipmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EquipmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> EquipmentAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EquipmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> EquipmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_resources")]
        public IList<MicrosoftDynamicsCRMresource> EquipmentResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_Email_EmailSender")]
        public IList<MicrosoftDynamicsCRMemail> EquipmentEmailEmailSender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_contacts")]
        public IList<MicrosoftDynamicsCRMcontact> EquipmentContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> EquipmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "equipment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EquipmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Equipment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EquipmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
