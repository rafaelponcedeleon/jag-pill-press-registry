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
    /// Collection of interactionforemails
    /// </summary>
    public partial class InteractionforemailsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InteractionforemailsGetResponseModel class.
        /// </summary>
        public InteractionforemailsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InteractionforemailsGetResponseModel class.
        /// </summary>
        public InteractionforemailsGetResponseModel(IList<MicrosoftDynamicsCRMinteractionforemail> value = default(IList<MicrosoftDynamicsCRMinteractionforemail>))
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
        public IList<MicrosoftDynamicsCRMinteractionforemail> Value { get; set; }

    }
}
