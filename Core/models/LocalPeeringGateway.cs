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
    /// A local peering gateway (LPG) is an object on a VCN that lets that VCN peer
    /// with another VCN in the same region. *Peering* means that the two VCNs can
    /// communicate using private IP addresses, but without the traffic traversing the
    /// internet or routing through your on-premises network. For more information,
    /// see [VCN Peering](https://docs.cloud.oracle.com/Content/Network/Tasks/VCNpeering.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class LocalPeeringGateway 
    {
        
        /// <value>
        /// The OCID of the compartment containing the LPG.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid
        /// entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// The LPG's Oracle ID (OCID).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// Whether the VCN at the other end of the peering is in a different tenancy.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsCrossTenancyPeering is required.")]
        [JsonProperty(PropertyName = "isCrossTenancyPeering")]
        public System.Nullable<bool> IsCrossTenancyPeering { get; set; }
        ///
        /// <value>
        /// The LPG's current lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The LPG's current lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// The smallest aggregate CIDR that contains all the CIDR routes advertised by the VCN
        /// at the other end of the peering from this LPG. See `peerAdvertisedCidrDetails` for
        /// the individual CIDRs. The value is `null` if the LPG is not peered.
        /// <br/>
        /// Example: 192.168.0.0/16, or if aggregated with 172.16.0.0/24 then 128.0.0.0/1
        /// </value>
        [JsonProperty(PropertyName = "peerAdvertisedCidr")]
        public string PeerAdvertisedCidr { get; set; }

        /// <value>
        /// The specific ranges of IP addresses available on or via the VCN at the other
        /// end of the peering from this LPG. The value is `null` if the LPG is not peered.
        /// You can use these as destination CIDRs for route rules to route a subnet's
        /// traffic to this LPG.
        /// <br/>
        /// Example: [192.168.0.0/16, 172.16.0.0/24]
        /// </value>
        [JsonProperty(PropertyName = "peerAdvertisedCidrDetails")]
        public System.Collections.Generic.List<string> PeerAdvertisedCidrDetails { get; set; }
        ///
        /// <value>
        /// Whether the LPG is peered with another LPG. `NEW` means the LPG has not yet been
        /// peered. `PENDING` means the peering is being established. `REVOKED` means the
        /// LPG at the other end of the peering has been deleted.
        /// 
        /// </value>
        ///
        public enum PeeringStatusEnum {
            [EnumMember(Value = "INVALID")]
            Invalid,
            [EnumMember(Value = "NEW")]
            New,
            [EnumMember(Value = "PEERED")]
            Peered,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "REVOKED")]
            Revoked
        };

        /// <value>
        /// Whether the LPG is peered with another LPG. `NEW` means the LPG has not yet been
        /// peered. `PENDING` means the peering is being established. `REVOKED` means the
        /// LPG at the other end of the peering has been deleted.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeeringStatus is required.")]
        [JsonProperty(PropertyName = "peeringStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PeeringStatusEnum> PeeringStatus { get; set; }

        /// <value>
        /// Additional information regarding the peering status, if applicable.
        /// </value>
        [JsonProperty(PropertyName = "peeringStatusDetails")]
        public string PeeringStatusDetails { get; set; }

        /// <value>
        /// The OCID of the route table the LPG is using.
        /// <br/>
        /// For information about why you would associate a route table with an LPG, see
        /// [Transit Routing: Access to Multiple VCNs in Same Region](https://docs.cloud.oracle.com/Content/Network/Tasks/transitrouting.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }

        /// <value>
        /// The date and time the LPG was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The OCID of the VCN the LPG belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
    }
}