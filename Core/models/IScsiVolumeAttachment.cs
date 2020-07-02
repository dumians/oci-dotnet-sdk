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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// An ISCSI volume attachment.
    /// </summary>
    public class IScsiVolumeAttachment : VolumeAttachment
    {
        
        /// <value>
        /// The Challenge-Handshake-Authentication-Protocol (CHAP) secret valid for the associated CHAP user name.
        /// (Also called the \"CHAP password\".)
        /// <br/>
        /// 
        /// </value>
        [JsonProperty(PropertyName = "chapSecret")]
        public string ChapSecret { get; set; }

        /// <value>
        /// The volume's system-generated Challenge-Handshake-Authentication-Protocol (CHAP) user name. See [RFC 1994](https://tools.ietf.org/html/rfc1994) for more on CHAP.
        /// <br/>
        /// Example: ocid1.volume.oc1.phx.<unique_ID>
        /// </value>
        [JsonProperty(PropertyName = "chapUsername")]
        public string ChapUsername { get; set; }

        /// <value>
        /// The volume's iSCSI IP address.
        /// <br/>
        /// Example: 169.254.0.2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ipv4 is required.")]
        [JsonProperty(PropertyName = "ipv4")]
        public string Ipv4 { get; set; }

        /// <value>
        /// The target volume's iSCSI Qualified Name in the format defined by [RFC 3720](https://tools.ietf.org/html/rfc3720#page-32).
        /// <br/>
        /// Example: iqn.2015-12.us.oracle.com:<CHAP_username>
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Iqn is required.")]
        [JsonProperty(PropertyName = "iqn")]
        public string Iqn { get; set; }

        /// <value>
        /// The volume's iSCSI port, usually port 860 or 3260.
        /// <br/>
        /// Example: 3260
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
    }
}