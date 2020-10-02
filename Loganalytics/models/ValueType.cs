/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LoganalyticsService.Models
{
  /// <summary>
  /// Data type for fields, columns or parameters.
  /// </summary>
  public enum ValueType {
      [EnumMember(Value = "BOOLEAN")]
      Boolean,
      [EnumMember(Value = "STRING")]
      String,
      [EnumMember(Value = "DOUBLE")]
      Double,
      [EnumMember(Value = "FLOAT")]
      Float,
      [EnumMember(Value = "LONG")]
      Long,
      [EnumMember(Value = "INTEGER")]
      Integer,
      [EnumMember(Value = "TIMESTAMP")]
      Timestamp,
      [EnumMember(Value = "FACET")]
      Facet
  }
}