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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An updated set of path route rules that overwrites the existing set of rules.
    /// </summary>
    public class UpdatePathRouteSetDetails 
    {
        
        /// <value>
        /// The set of path route rules.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PathRoutes is required.")]
        [JsonProperty(PropertyName = "pathRoutes")]
        public System.Collections.Generic.List<PathRoute> PathRoutes { get; set; }
    }
}