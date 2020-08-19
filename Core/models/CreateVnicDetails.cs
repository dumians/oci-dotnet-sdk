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
    /// Contains properties for a VNIC. You use this object when creating the
    /// primary VNIC during instance launch or when creating a secondary VNIC.
    /// For more information about VNICs, see
    /// [Virtual Network Interface Cards (VNICs)](https://docs.cloud.oracle.com/Content/Network/Tasks/managingVNICs.htm).
    /// 
    /// </summary>
    public class CreateVnicDetails 
    {
        
        /// <value>
        /// Whether the VNIC should be assigned a public IP address. Defaults to whether
        /// the subnet is public or private. If not set and the VNIC is being created
        /// in a private subnet (that is, where `prohibitPublicIpOnVnic` = true in the
        /// {@link Subnet}), then no public IP address is assigned.
        /// If not set and the subnet is public (`prohibitPublicIpOnVnic` = false), then
        /// a public IP address is assigned. If set to true and
        /// `prohibitPublicIpOnVnic` = true, an error is returned.
        /// <br/>
        /// **Note:** This public IP address is associated with the primary private IP
        /// on the VNIC. For more information, see
        /// [IP Addresses](https://docs.cloud.oracle.com/Content/Network/Tasks/managingIPaddresses.htm).
        /// <br/>
        /// **Note:** There's a limit to the number of {@link PublicIp}
        /// a VNIC or instance can have. If you try to create a secondary VNIC
        /// with an assigned public IP for an instance that has already
        /// reached its public IP limit, an error is returned. For information
        /// about the public IP limits, see
        /// [Public IP Addresses](https://docs.cloud.oracle.com/Content/Network/Tasks/managingpublicIPs.htm).
        /// <br/>
        /// Example: falseIf you specify a vlanId, the assignPublicIp is required to be set to false. See{@link Vlan}.
        /// </value>
        [JsonProperty(PropertyName = "assignPublicIp")]
        public System.Nullable<bool> AssignPublicIp { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// A user-friendly name for the VNIC. Does not have to be unique.
        /// Avoid entering confidential information.
        /// 
        /// </value>
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
        /// The hostname for the VNIC's primary private IP. Used for DNS. The value is the hostname
        /// portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, `bminstance-1` in FQDN `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Must be unique across all VNICs in the subnet and comply with
        /// [RFC 952](https://tools.ietf.org/html/rfc952) and
        /// [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// The value appears in the {@link Vnic} object and also the
        /// {@link PrivateIp} object returned by
        /// {@link #listPrivateIps(ListPrivateIpsRequest) listPrivateIps} and
        /// {@link #getPrivateIp(GetPrivateIpRequest) getPrivateIp}.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// When launching an instance, use this `hostnameLabel` instead
        /// of the deprecated `hostnameLabel` in
        /// {@link #launchInstanceDetails(LaunchInstanceDetailsRequest) launchInstanceDetails}.
        /// If you provide both, the values must match.
        /// <br/>
        /// Example: bminstance-1If you specify a vlanId, the hostnameLabel cannot be specified. vnics on a Vlancan not be assigned a hostname  See {@link Vlan}.
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }

        /// <value>
        /// A list of the OCIDs of the network security groups (NSGs) to add the VNIC to. For more
        /// information about NSGs, see
        /// {@link NetworkSecurityGroup}.
        /// <br/>
        /// If a `vlanId` is specified, the `nsgIds` cannot be specified. The `vlanId`
        /// indicates that the VNIC will belong to a VLAN instead of a subnet. With VLANs,
        /// all VNICs in the VLAN belong to the NSGs that are associated with the VLAN.
        /// See {@link Vlan}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }

        /// <value>
        /// A private IP address of your choice to assign to the VNIC. Must be an
        /// available IP address within the subnet's CIDR. If you don't specify a
        /// value, Oracle automatically assigns a private IP address from the subnet.
        /// This is the VNIC's *primary* private IP address. The value appears in
        /// the {@link Vnic} object and also the
        /// {@link PrivateIp} object returned by
        /// {@link #listPrivateIps(ListPrivateIpsRequest) listPrivateIps} and
        /// {@link #getPrivateIp(GetPrivateIpRequest) getPrivateIp}.
        /// <br/>
        /// 
        /// If you specify a `vlanId`, the `privateIp` cannot be specified.
        /// See {@link Vlan}.
        /// <br/>
        /// Example: 10.0.3.3
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }

        /// <value>
        /// Whether the source/destination check is disabled on the VNIC.
        /// Defaults to `false`, which means the check is performed. For information
        /// about why you would skip the source/destination check, see
        /// [Using a Private IP as a Route Target](https://docs.cloud.oracle.com/Content/Network/Tasks/managingroutetables.htm#privateip).
        /// <br/>
        /// 
        /// If you specify a `vlanId`, the `skipSourceDestCheck` cannot be specified because the
        /// source/destination check is always disabled for VNICs in a VLAN. See
        /// {@link Vlan}.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "skipSourceDestCheck")]
        public System.Nullable<bool> SkipSourceDestCheck { get; set; }

        /// <value>
        /// The OCID of the subnet to create the VNIC in. When launching an instance,
        /// use this `subnetId` instead of the deprecated `subnetId` in
        /// {@link #launchInstanceDetails(LaunchInstanceDetailsRequest) launchInstanceDetails}.
        /// At least one of them is required; if you provide both, the values must match.
        /// <br/>
        /// If you are an Oracle Cloud VMware Solution customer and creating a secondary
        /// VNIC in a VLAN instead of a subnet, provide a `vlanId` instead of a `subnetId`.
        /// If you provide both a `vlanId` and `subnetId`, the request fails.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// Provide this attribute only if you are an Oracle Cloud VMware Solution
        /// customer and creating a secondary VNIC in a VLAN. The value is the OCID of the VLAN.
        /// See {@link Vlan}.
        /// <br/>
        /// Provide a `vlanId` instead of a `subnetId`. If you provide both a
        /// `vlanId` and `subnetId`, the request fails.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vlanId")]
        public string VlanId { get; set; }
    }
}
