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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Returns a listing of all of the specified job's properties and their values.
    /// </summary>
    public class JobSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the job.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stack that is associated with the specified job.
        /// </value>
        [JsonProperty(PropertyName = "stackId")]
        public string StackId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment where the stack of the associated job resides.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The job's display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The type of job executing
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Job.OperationEnum> Operation { get; set; }

        [JsonProperty(PropertyName = "jobOperationDetails")]
        public JobOperationDetailsSummary JobOperationDetails { get; set; }

        [JsonProperty(PropertyName = "applyJobPlanResolution")]
        public ApplyJobPlanResolution ApplyJobPlanResolution { get; set; }

        /// <value>
        /// Deprecated. Use the property `executionPlanJobId` in `jobOperationDetails` instead.
        /// The plan job [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) that was used (if this was an apply job and was not auto-approved).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resolvedPlanJobId")]
        public string ResolvedPlanJobId { get; set; }

        /// <value>
        /// The date and time the job was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The date and time the job succeeded or failed.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }

        /// <value>
        /// Current state of the specified job.
        /// For more information about resource states in Resource Manager, see
        /// [Key Concepts](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/resourcemanager.htm#concepts).
        /// <br/>
        /// Allowable values:
        /// - ACCEPTED
        /// - IN_PROGRESS
        /// - FAILED
        /// - SUCCEEDED
        /// - CANCELING
        /// - CANCELED
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Job.LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// Free-form tags associated with this resource. Each tag is a key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}