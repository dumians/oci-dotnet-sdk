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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Geographical Location of a problem
    /// </summary>
    public class GeographicalLocation 
    {
        
        /// <value>
        /// Latitude
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Latitude is required.")]
        [JsonProperty(PropertyName = "latitude")]
        public System.Double Latitude { get; set; }

        /// <value>
        /// Longitude
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Longitude is required.")]
        [JsonProperty(PropertyName = "longitude")]
        public System.Double Longitude { get; set; }
    }
}