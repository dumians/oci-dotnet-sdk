/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CloudguardService.Models
{
  /// <summary>
  /// Possible cloud guard list types
  /// </summary>
  public enum ManagedListType {
      [EnumMember(Value = "CIDR_BLOCK")]
      CidrBlock,
      [EnumMember(Value = "USERS")]
      Users,
      [EnumMember(Value = "GROUPS")]
      Groups,
      [EnumMember(Value = "IPV4ADDRESS")]
      Ipv4Address,
      [EnumMember(Value = "IPV6ADDRESS")]
      Ipv6Address,
      [EnumMember(Value = "RESOURCE_OCID")]
      ResourceOcid,
      [EnumMember(Value = "REGION")]
      Region,
      [EnumMember(Value = "COUNTRY")]
      Country,
      [EnumMember(Value = "STATE")]
      State,
      [EnumMember(Value = "CITY")]
      City,
      [EnumMember(Value = "TAGS")]
      Tags
  }
}
