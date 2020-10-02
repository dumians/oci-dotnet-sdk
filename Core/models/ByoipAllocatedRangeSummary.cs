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
    /// <summary>
    /// Subrange of ByoipRange which is allocated to a PublicIpPool
    /// </summary>
    public class ByoipAllocatedRangeSummary 
    {
        
        /// <value>
        /// The address range part of the ByoipRange which is used for a publicIpPool.
        /// </value>
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }

        /// <value>
        /// The OCID of the PublicIpPool containing the part of the Byoip range.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicIpPoolId")]
        public string PublicIpPoolId { get; set; }
    }
}
