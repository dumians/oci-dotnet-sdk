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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Configures the logging policies for the execution logs of an API Deployment.
    /// 
    /// </summary>
    public class ExecutionLogPolicy 
    {
        
        /// <value>
        /// Enables pushing of execution logs to the legacy OCI Object Storage log archival bucket.
        /// <br/>
        /// Oracle recommends using the OCI Logging service to enable, retrieve, and query execution logs
        /// for an API Deployment. If there is an active log object for the API Deployment and its
        /// category is set to 'execution' in OCI Logging service, the logs will not be uploaded to the legacy
        /// OCI Object Storage log archival bucket.
        /// <br/>
        /// Please note that the functionality to push to the legacy OCI Object Storage log
        /// archival bucket has been deprecated and will be removed in the future.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        ///
        /// <value>
        /// Specifies the log level used to control logging output of execution logs.
        /// Enabling logging at a given level also enables logging at all higher levels.
        /// 
        /// </value>
        ///
        public enum LogLevelEnum {
            [EnumMember(Value = "INFO")]
            Info,
            [EnumMember(Value = "WARN")]
            Warn,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// Specifies the log level used to control logging output of execution logs.
        /// Enabling logging at a given level also enables logging at all higher levels.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LogLevelEnum> LogLevel { get; set; }
    }
}
