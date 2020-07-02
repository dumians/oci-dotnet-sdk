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


namespace Oci.CoreService.Models
{
    
    public class CreateVolumeBackupPolicyAssignmentDetails 
    {
        
        /// <value>
        /// The OCID of the volume to assign the policy to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssetId is required.")]
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

        /// <value>
        /// The OCID of the volume backup policy to assign to the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyId is required.")]
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }
    }
}