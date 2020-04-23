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
    /// Microsoft.Dynamics.CRM.roletemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMroletemplate
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMroletemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMroletemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMroletemplate
        /// class.
        /// </summary>
        /// <param name="name">Name of the role template.</param>
        /// <param name="roletemplateid">Unique identifier of the role
        /// template.</param>
        public MicrosoftDynamicsCRMroletemplate(string name = default(string), string roletemplateid = default(string), IList<MicrosoftDynamicsCRMprivilege> roletemplateprivilegesAssociation = default(IList<MicrosoftDynamicsCRMprivilege>), IList<MicrosoftDynamicsCRMrole> roleTemplateRoles = default(IList<MicrosoftDynamicsCRMrole>))
        {
            Name = name;
            Roletemplateid = roletemplateid;
            RoletemplateprivilegesAssociation = roletemplateprivilegesAssociation;
            RoleTemplateRoles = roleTemplateRoles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the role template.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the role template.
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateid")]
        public string Roletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateprivileges_association")]
        public IList<MicrosoftDynamicsCRMprivilege> RoletemplateprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_template_roles")]
        public IList<MicrosoftDynamicsCRMrole> RoleTemplateRoles { get; set; }

    }
}
