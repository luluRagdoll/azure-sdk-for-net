// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// All possible faces that may qualify.
    /// </summary>
    public partial class IdentifyCandidate
    {
        /// <summary>
        /// Initializes a new instance of the IdentifyCandidate class.
        /// </summary>
        public IdentifyCandidate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentifyCandidate class.
        /// </summary>
        /// <param name="personId">Id of candidate</param>
        /// <param name="confidence">Confidence threshold of identification,
        /// used to judge whether one face belong to one person. The range of
        /// confidenceThreshold is [0, 1] (default specified by
        /// algorithm).</param>
        public IdentifyCandidate(System.Guid personId, double confidence)
        {
            PersonId = personId;
            Confidence = confidence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of candidate
        /// </summary>
        [JsonProperty(PropertyName = "personId")]
        public System.Guid PersonId { get; set; }

        /// <summary>
        /// Gets or sets confidence threshold of identification, used to judge
        /// whether one face belong to one person. The range of
        /// confidenceThreshold is [0, 1] (default specified by algorithm).
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
