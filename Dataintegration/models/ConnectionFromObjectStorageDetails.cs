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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The Object Storage connection details.
    /// </summary>
    public class ConnectionFromObjectStorageDetails : ConnectionDetails
    {
        
        /// <value>
        /// The credential file content from a wallet for the data asset.
        /// </value>
        [JsonProperty(PropertyName = "credentialFileContent")]
        public string CredentialFileContent { get; set; }

        /// <value>
        /// The OCI user OCID for the user to connect to.
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <value>
        /// The fingeprint for the user.
        /// </value>
        [JsonProperty(PropertyName = "fingerPrint")]
        public string FingerPrint { get; set; }

        /// <value>
        /// The pass phrase for the connection.
        /// </value>
        [JsonProperty(PropertyName = "passPhrase")]
        public string PassPhrase { get; set; }
    }
}
