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
    /// Microsoft.Dynamics.CRM.sdkmessageprocessingstepimage
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessageprocessingstepimage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepimage class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepimage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepimage class.
        /// </summary>
        /// <param name="sdkmessageprocessingstepimageid">Unique identifier of
        /// the SDK message processing step image entity.</param>
        /// <param name="_sdkmessageprocessingstepidValue">Unique identifier of
        /// the SDK message processing step.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the SDK message processing step image.</param>
        /// <param name="customizationlevel">Customization level of the SDK
        /// message processing step image.</param>
        /// <param name="description">Description of the SDK message processing
        /// step image.</param>
        /// <param name="messagepropertyname">Name of the property on the
        /// Request message.</param>
        /// <param name="relatedattributename">Name of the related
        /// entity.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="iscustomizable">Information that specifies whether
        /// this component can be customized.</param>
        /// <param name="sdkmessageprocessingstepimageidunique">Unique
        /// identifier of the SDK message processing step image.</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="entityalias">Key name used to access the pre-image or
        /// post-image property bags in a step.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the
        /// sdkmessageprocessingstepimage.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the
        /// sdkmessageprocessingstepimage.</param>
        /// <param name="imagetype">Type of image requested.</param>
        /// <param name="versionnumber">Number that identifies a specific
        /// revision of the step image. </param>
        /// <param name="createdon">Date and time when the SDK message
        /// processing step image was created.</param>
        /// <param name="name">Name of SdkMessage processing step
        /// image.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the SDK message processing step.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="modifiedon">Date and time when the SDK message
        /// processing step was last modified.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message processing step is
        /// associated.</param>
        /// <param name="attributes">Comma-separated list of attributes that
        /// are to be passed into the SDK message processing step
        /// image.</param>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepimage(string sdkmessageprocessingstepimageid = default(string), string _sdkmessageprocessingstepidValue = default(string), string _createdbyValue = default(string), int? customizationlevel = default(int?), string description = default(string), string messagepropertyname = default(string), string relatedattributename = default(string), int? componentstate = default(int?), string iscustomizable = default(string), string sdkmessageprocessingstepimageidunique = default(string), string introducedversion = default(string), bool? ismanaged = default(bool?), string entityalias = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), int? imagetype = default(int?), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string solutionid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string attributes = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsdkmessageprocessingstep sdkmessageprocessingstepid = default(MicrosoftDynamicsCRMsdkmessageprocessingstep))
        {
            Sdkmessageprocessingstepimageid = sdkmessageprocessingstepimageid;
            this._sdkmessageprocessingstepidValue = _sdkmessageprocessingstepidValue;
            this._createdbyValue = _createdbyValue;
            Customizationlevel = customizationlevel;
            Description = description;
            Messagepropertyname = messagepropertyname;
            Relatedattributename = relatedattributename;
            Componentstate = componentstate;
            Iscustomizable = iscustomizable;
            Sdkmessageprocessingstepimageidunique = sdkmessageprocessingstepimageidunique;
            Introducedversion = introducedversion;
            Ismanaged = ismanaged;
            Entityalias = entityalias;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Imagetype = imagetype;
            Versionnumber = versionnumber;
            Createdon = createdon;
            Name = name;
            this._modifiedbyValue = _modifiedbyValue;
            Overwritetime = overwritetime;
            Solutionid = solutionid;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Attributes = attributes;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Sdkmessageprocessingstepid = sdkmessageprocessingstepid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the SDK message processing step
        /// image entity.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepimageid")]
        public string Sdkmessageprocessingstepimageid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message processing step.
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageprocessingstepid_value")]
        public string _sdkmessageprocessingstepidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the SDK
        /// message processing step image.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets customization level of the SDK message processing step
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// Gets or sets description of the SDK message processing step image.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of the property on the Request message.
        /// </summary>
        [JsonProperty(PropertyName = "messagepropertyname")]
        public string Messagepropertyname { get; set; }

        /// <summary>
        /// Gets or sets name of the related entity.
        /// </summary>
        [JsonProperty(PropertyName = "relatedattributename")]
        public string Relatedattributename { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be customized.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message processing step
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepimageidunique")]
        public string Sdkmessageprocessingstepimageidunique { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets key name used to access the pre-image or post-image
        /// property bags in a step.
        /// </summary>
        [JsonProperty(PropertyName = "entityalias")]
        public string Entityalias { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the sdkmessageprocessingstepimage.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// sdkmessageprocessingstepimage.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets type of image requested.
        /// </summary>
        [JsonProperty(PropertyName = "imagetype")]
        public int? Imagetype { get; set; }

        /// <summary>
        /// Gets or sets number that identifies a specific revision of the step
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message processing step
        /// image was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets name of SdkMessage processing step image.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// SDK message processing step.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message processing step was
        /// last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message processing step is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets comma-separated list of attributes that are to be
        /// passed into the SDK message processing step image.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepid")]
        public MicrosoftDynamicsCRMsdkmessageprocessingstep Sdkmessageprocessingstepid { get; set; }

    }
}
