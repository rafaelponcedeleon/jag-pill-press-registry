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
    /// Collection of bcgov_inspectionchecklist
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.bcgov_inspectionchecklistCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMbcgovInspectionchecklistCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionchecklistCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionchecklistCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspectionchecklistCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspectionchecklistCollection(IList<MicrosoftDynamicsCRMbcgovInspectionchecklist> value = default(IList<MicrosoftDynamicsCRMbcgovInspectionchecklist>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMbcgovInspectionchecklist> Value { get; set; }

    }
}
