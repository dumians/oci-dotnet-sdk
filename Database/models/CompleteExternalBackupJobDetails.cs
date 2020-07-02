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
    
    public class CompleteExternalBackupJobDetails 
    {
        
        /// <value>
        /// If the database being backed up is TDE enabled, this will be the path to the associated TDE wallet in Object Storage.
        /// </value>
        [JsonProperty(PropertyName = "tdeWalletPath")]
        public string TdeWalletPath { get; set; }

        /// <value>
        /// The handle of the control file backup.
        /// </value>
        [JsonProperty(PropertyName = "cfBackupHandle")]
        public string CfBackupHandle { get; set; }

        /// <value>
        /// The handle of the spfile backup.
        /// </value>
        [JsonProperty(PropertyName = "spfBackupHandle")]
        public string SpfBackupHandle { get; set; }

        /// <value>
        /// The list of SQL patches that need to be applied to the backup during the restore.
        /// </value>
        [JsonProperty(PropertyName = "sqlPatches")]
        public System.Collections.Generic.List<string> SqlPatches { get; set; }

        /// <value>
        /// The size of the data in the database, in megabytes.
        /// </value>
        [JsonProperty(PropertyName = "dataSize")]
        public System.Nullable<long> DataSize { get; set; }

        /// <value>
        /// The size of the redo in the database, in megabytes.
        /// </value>
        [JsonProperty(PropertyName = "redoSize")]
        public System.Nullable<long> RedoSize { get; set; }
    }
}