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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// A list of job execution logs.
    /// A job log is an audit log record inserted during the lifecycle of a job execution instance.
    /// There can be one or more logs for an execution instance.
    /// 
    /// </summary>
    public class JobLogSummary 
    {
        
        /// <value>
        /// Unique key of the job log that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// The unique key of the parent job execution for which the log resource was created.
        /// </value>
        [JsonProperty(PropertyName = "jobExecutionKey")]
        public string JobExecutionKey { get; set; }

        /// <value>
        /// URI to the job log instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <value>
        /// The date and time the job log was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// Severity level for this log.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <value>
        /// Message for this job log.
        /// </value>
        [JsonProperty(PropertyName = "logMessage")]
        public string LogMessage { get; set; }
    }
}