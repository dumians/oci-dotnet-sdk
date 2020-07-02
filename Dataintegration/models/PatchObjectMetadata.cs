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
    /// A summary type containing information about the object including its key, name and when/who created/updated it
    /// </summary>
    public class PatchObjectMetadata 
    {
        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value can be edited by the user and it is restricted to 1000 characters
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The fully qualified path of the published object which would include its project and folder.
        /// </value>
        [JsonProperty(PropertyName = "namePath")]
        public string NamePath { get; set; }
        ///
        /// <value>
        /// The type of the object in patch.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "INTEGRATION_TASK")]
            IntegrationTask,
            [EnumMember(Value = "DATA_LOADER_TASK")]
            DataLoaderTask
        };

        /// <value>
        /// The type of the object in patch.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }

        /// <value>
        /// The object version.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }

        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be edited by the user.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        ///
        /// <value>
        /// The patch action, if object was created, updated or deleted.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "UPDATED")]
            Updated
        };

        /// <value>
        /// The patch action, if object was created, updated or deleted.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
    }
}