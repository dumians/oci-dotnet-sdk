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
    /// The configuration details for creating a load balancer.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class CreateLoadBalancerDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which to create the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: example_load_balancer
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// A template that determines the total pre-provisioned bandwidth (ingress plus egress).
        /// To get a list of available shapes, use the {@link #listShapes(ListShapesRequest) listShapes}
        /// operation.
        /// <br/>
        /// Example: 100Mbps
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }

        /// <value>
        /// Whether the load balancer has a VCN-local (private) IP address.
        /// <br/>
        /// If \"true\", the service assigns a private IP address to the load balancer.
        /// <br/>
        /// If \"false\", the service assigns a public IP address to the load balancer.
        /// <br/>
        /// A public load balancer is accessible from the internet, depending on your VCN's
        /// [security list rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securitylists.htm). For more information about public and
        /// private load balancers, see [How Load Balancing Works](https://docs.cloud.oracle.com/Content/Balance/Concepts/balanceoverview.htm#how-load-balancing-works).
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isPrivate")]
        public System.Nullable<bool> IsPrivate { get; set; }
        ///
        /// <value>
        /// Whether the load balancer has an IPv4 or IPv6 IP address.
        /// <br/>
        /// If \"IPV4\", the service assigns an IPv4 address and the load balancer supports IPv4 traffic.
        /// <br/>
        /// If \"IPV6\", the service assigns an IPv6 address and the load balancer supports IPv6 traffic.
        /// <br/>
        /// Example: &quot;ipMode&quot;:&quot;IPV6&quot;
        /// </value>
        ///
        public enum IpModeEnum {
            [EnumMember(Value = "IPV4")]
            Ipv4,
            [EnumMember(Value = "IPV6")]
            Ipv6
        };

        /// <value>
        /// Whether the load balancer has an IPv4 or IPv6 IP address.
        /// <br/>
        /// If \"IPV4\", the service assigns an IPv4 address and the load balancer supports IPv4 traffic.
        /// <br/>
        /// If \"IPV6\", the service assigns an IPv6 address and the load balancer supports IPv6 traffic.
        /// <br/>
        /// Example: &quot;ipMode&quot;:&quot;IPV6&quot;
        /// </value>
        [JsonProperty(PropertyName = "ipMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IpModeEnum> IpMode { get; set; }

        [JsonProperty(PropertyName = "listeners")]
        public System.Collections.Generic.Dictionary<string, ListenerDetails> Listeners { get; set; }

        [JsonProperty(PropertyName = "hostnames")]
        public System.Collections.Generic.Dictionary<string, HostnameDetails> Hostnames { get; set; }

        [JsonProperty(PropertyName = "backendSets")]
        public System.Collections.Generic.Dictionary<string, BackendSetDetails> BackendSets { get; set; }

        /// <value>
        /// An array of NSG [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with this load balancer.
        /// <br/>
        /// During the load balancer's creation, the service adds the new load balancer to the specified NSGs.
        /// <br/>
        /// The benefits of using NSGs with the load balancer include:
        /// <br/>
        /// *  NSGs define network security rules to govern ingress and egress traffic for the load balancer.
        /// <br/>
        /// *  The network security rules of other resources can reference the NSGs associated with the load balancer
        ///    to ensure access.
        /// <br/>
        /// Example: [&quot;ocid1.nsg.oc1.phx.unique_ID&quot;]
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }

        /// <value>
        /// An array of subnet [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetIds is required.")]
        [JsonProperty(PropertyName = "subnetIds")]
        public System.Collections.Generic.List<string> SubnetIds { get; set; }

        [JsonProperty(PropertyName = "certificates")]
        public System.Collections.Generic.Dictionary<string, CertificateDetails> Certificates { get; set; }

        [JsonProperty(PropertyName = "pathRouteSets")]
        public System.Collections.Generic.Dictionary<string, PathRouteSetDetails> PathRouteSets { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        [JsonProperty(PropertyName = "ruleSets")]
        public System.Collections.Generic.Dictionary<string, RuleSetDetails> RuleSets { get; set; }
    }
}