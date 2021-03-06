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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Describes the modification parameters for the maintenance run.
    /// 
    /// </summary>
    public class UpdateMaintenanceRunDetails 
    {
        
        /// <value>
        /// If `FALSE`, skips the maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }

        /// <value>
        /// The scheduled date and time of the maintenance run to update.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduled")]
        public System.Nullable<System.DateTime> TimeScheduled { get; set; }

        /// <value>
        /// If set to `TRUE`, starts patching immediately.
        /// </value>
        [JsonProperty(PropertyName = "isPatchNowEnabled")]
        public System.Nullable<bool> IsPatchNowEnabled { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the patch to be applied in the maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; set; }
    }
}
