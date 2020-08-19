/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Blockchain Platform details for creating a new service.
    /// </summary>
    public class CreateBlockchainPlatformDetails 
    {
        
        /// <value>
        /// Platform Instance Display name, can be renamed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Platform Instance Description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// Role of platform - founder or participant
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlatformRole is required.")]
        [JsonProperty(PropertyName = "platformRole")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BlockchainPlatform.PlatformRoleEnum> PlatformRole { get; set; }

        /// <value>
        /// Type of compute shape - one of Standard, (Enterprise) Small, Medium, Large or Extra Large
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeShape is required.")]
        [JsonProperty(PropertyName = "computeShape")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BlockchainPlatform.ComputeShapeEnum> ComputeShape { get; set; }

        /// <value>
        /// Bring your own license
        /// </value>
        [JsonProperty(PropertyName = "isByol")]
        public System.Nullable<bool> IsByol { get; set; }

        /// <value>
        /// IDCS access token
        /// </value>
        [JsonProperty(PropertyName = "idcsAccessToken")]
        public string IdcsAccessToken { get; set; }

        /// <value>
        /// Identifier for a federated user
        /// </value>
        [JsonProperty(PropertyName = "federatedUserId")]
        public string FederatedUserId { get; set; }

        /// <value>
        /// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file.
        /// The Archive file is a zip file containing third part CA Certificates,
        /// the ca key and certificate files used when issuing enrollment certificates
        /// (ECerts) and transaction certificates (TCerts). The chainfile (if it exists)
        /// contains the certificate chain which should be trusted for this CA, where
        /// the 1st in the chain is always the root CA certificate.
        /// File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
        /// 
        /// </value>
        [JsonProperty(PropertyName = "caCertArchiveText")]
        public string CaCertArchiveText { get; set; }

        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
