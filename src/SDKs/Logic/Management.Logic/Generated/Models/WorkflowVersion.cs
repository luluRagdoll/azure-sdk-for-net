// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The workflow version.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkflowVersion : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowVersion class.
        /// </summary>
        public WorkflowVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowVersion class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="createdTime">Gets the created time.</param>
        /// <param name="changedTime">Gets the changed time.</param>
        /// <param name="state">The state. Possible values include:
        /// 'NotSpecified', 'Completed', 'Enabled', 'Disabled', 'Deleted',
        /// 'Suspended'</param>
        /// <param name="version">Gets the version.</param>
        /// <param name="accessEndpoint">Gets the access endpoint.</param>
        /// <param name="sku">The sku.</param>
        /// <param name="integrationAccount">The integration account.</param>
        /// <param name="definition">The definition.</param>
        /// <param name="parameters">The parameters.</param>
        public WorkflowVersion(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), string state = default(string), string version = default(string), string accessEndpoint = default(string), Sku sku = default(Sku), ResourceReference integrationAccount = default(ResourceReference), object definition = default(object), IDictionary<string, WorkflowParameter> parameters = default(IDictionary<string, WorkflowParameter>))
            : base(id, name, type, location, tags)
        {
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            State = state;
            Version = version;
            AccessEndpoint = accessEndpoint;
            Sku = sku;
            IntegrationAccount = integrationAccount;
            Definition = definition;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the state. Possible values include: 'NotSpecified',
        /// 'Completed', 'Enabled', 'Disabled', 'Deleted', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the access endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessEndpoint")]
        public string AccessEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the integration account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.integrationAccount")]
        public ResourceReference IntegrationAccount { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.definition")]
        public object Definition { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, WorkflowParameter> Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
