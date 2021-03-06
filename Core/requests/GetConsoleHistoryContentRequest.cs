/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    public class GetConsoleHistoryContentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the console history.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceConsoleHistoryId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "instanceConsoleHistoryId")]
        public string InstanceConsoleHistoryId { get; set; }
        
        /// <value>
        /// Offset of the snapshot data to retrieve.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "offset")]
        public System.Nullable<int> Offset { get; set; }
        
        /// <value>
        /// Length of the snapshot data to retrieve.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "length")]
        public System.Nullable<int> Length { get; set; }
    }
}