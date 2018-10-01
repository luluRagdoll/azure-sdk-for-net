// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the target region information.
    /// </summary>
    public partial class TargetRegion
    {
        /// <summary>
        /// Initializes a new instance of the TargetRegion class.
        /// </summary>
        public TargetRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetRegion class.
        /// </summary>
        /// <param name="name">The name of the region.</param>
        /// <param name="regionalReplicaCount">The number of replicas of the
        /// Image Version to be created per region. This property is
        /// updateable.</param>
        public TargetRegion(string name, int? regionalReplicaCount = default(int?))
        {
            Name = name;
            RegionalReplicaCount = regionalReplicaCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the region.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of replicas of the Image Version to be
        /// created per region. This property is updateable.
        /// </summary>
        [JsonProperty(PropertyName = "regionalReplicaCount")]
        public int? RegionalReplicaCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
