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
    /// Ocpu utilization for a VM host
    /// </summary>
    public class OcpuUtilizationInfo 
    {
        
        /// <value>
        /// Host name of VM
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <value>
        /// Number of OCPU utilized
        /// </value>
        [JsonProperty(PropertyName = "ocpuUtilizationNumber")]
        public System.Nullable<float> OcpuUtilizationNumber { get; set; }

        /// <value>
        /// Number of total OCPU capacity on the host
        /// </value>
        [JsonProperty(PropertyName = "ocpuCapacityNumber")]
        public System.Nullable<float> OcpuCapacityNumber { get; set; }
    }
}