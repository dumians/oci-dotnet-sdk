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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// The configuration details of an Object Storage based collection rule to enable automatic log collection.
    /// 
    /// </summary>
    public class CreateLogAnalyticsObjectCollectionRuleDetails 
    {
        
        /// <value>
        /// A unique name given to the rule. The name must be unique within the tenancy, and cannot be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// A string that describes the details of the rule. It does not have to be unique, and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to which this rule belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Object Storage namespace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsNamespace is required.")]
        [JsonProperty(PropertyName = "osNamespace")]
        public string OsNamespace { get; set; }

        /// <value>
        /// Name of the Object Storage bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsBucketName is required.")]
        [JsonProperty(PropertyName = "osBucketName")]
        public string OsBucketName { get; set; }

        /// <value>
        /// The type of collection.
        /// Accepted values are: LIVE.
        /// Collection type LIVE indicates to enable log collection from the time of this rule creation,
        /// and continue until the rule exists.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "collectionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ObjectCollectionRuleCollectionTypes> CollectionType { get; set; }

        /// <value>
        /// The oldest time of the file in the bucket to consider for collection.
        /// Accepted values are: BEGINNING or CURRENT_TIME or RFC3339 formatted datetime string.
        /// When collectionType is LIVE, specifying pollSince value other than CURRENT_TIME will result in error.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pollSince")]
        public string PollSince { get; set; }

        /// <value>
        /// The oldest time of the file in the bucket to consider for collection.
        /// Accepted values are: CURRENT_TIME or RFC3339 formatted datetime string.
        /// When collectionType is LIVE, specifying pollTill will result in error.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pollTill")]
        public string PollTill { get; set; }

        /// <value>
        /// Log Analytics Log group OCID to associate the processed logs with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogGroupId is required.")]
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }

        /// <value>
        /// Name of the Log Analytics Source to use for the processing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogSourceName is required.")]
        [JsonProperty(PropertyName = "logSourceName")]
        public string LogSourceName { get; set; }

        /// <value>
        /// Log Analytics entity OCID. Associates the processed logs with the given entity (optional).
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

        /// <value>
        /// An optional character encoding to aid in detecting the character encoding of the contents of the objects while processing.
        /// It is recommended to set this value as ISO_8589_1 when configuring content of the objects having more numeric characters,
        /// and very few alphabets.
        /// For e.g. this applies when configuring VCN Flow Logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "charEncoding")]
        public string CharEncoding { get; set; }

        /// <value>
        /// The override is used to modify some important configuration properties for objects matching a specific pattern inside the bucket.
        /// Supported propeties for override are - logSourceName, charEncoding.
        /// Supported matchType for override are \"contains\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overrides")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PropertyOverride>> Overrides { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
    }
}
