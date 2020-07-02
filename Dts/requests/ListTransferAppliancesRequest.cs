/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DtsService.Models;

namespace Oci.DtsService.Requests
{
    public class ListTransferAppliancesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// ID of the Transfer Job
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "id")]
        public string Id { get; set; }
        
        ///
        /// <value>
        /// filtering by lifecycleState
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "REQUESTED")]
            Requested,
            [EnumMember(Value = "ORACLE_PREPARING")]
            OraclePreparing,
            [EnumMember(Value = "SHIPPING")]
            Shipping,
            [EnumMember(Value = "DELIVERED")]
            Delivered,
            [EnumMember(Value = "PREPARING")]
            Preparing,
            [EnumMember(Value = "FINALIZED")]
            Finalized,
            [EnumMember(Value = "RETURN_DELAYED")]
            ReturnDelayed,
            [EnumMember(Value = "RETURN_SHIPPED")]
            ReturnShipped,
            [EnumMember(Value = "RETURN_SHIPPED_CANCELLED")]
            ReturnShippedCancelled,
            [EnumMember(Value = "ORACLE_RECEIVED")]
            OracleReceived,
            [EnumMember(Value = "ORACLE_RECEIVED_CANCELLED")]
            OracleReceivedCancelled,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "COMPLETE")]
            Complete,
            [EnumMember(Value = "CUSTOMER_NEVER_RECEIVED")]
            CustomerNeverReceived,
            [EnumMember(Value = "ORACLE_NEVER_RECEIVED")]
            OracleNeverReceived,
            [EnumMember(Value = "CUSTOMER_LOST")]
            CustomerLost,
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "REJECTED")]
            Rejected,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// filtering by lifecycleState
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
    }
}