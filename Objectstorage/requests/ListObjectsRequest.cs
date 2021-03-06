/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Requests
{
    public class ListObjectsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Object Storage namespace used for the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// Example: my-new-bucket1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The string to use for matching against the start of object names in a list query.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be greater or equal to this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "start")]
        public string Start { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be strictly less than this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "end")]
        public string End { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// When this parameter is set, only objects whose names do not contain the delimiter character
        /// (after an optionally specified prefix) are returned in the objects key of the response body.
        /// Scanned objects whose names contain the delimiter have the part of their name up to the first
        /// occurrence of the delimiter (including the optional prefix) returned as a set of prefixes.
        /// Note that only '/' is a supported delimiter character at this time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "delimiter")]
        public string Delimiter { get; set; }
        
        ///
        /// <value>
        /// Object summary in list of objects includes the 'name' field. This parameter can also include 'size'
        /// (object size in bytes), 'etag', 'md5', 'timeCreated' (object creation date and time) and 'timeModified'
        /// (object modification date and time).
        /// Value of this parameter should be a comma-separated, case-insensitive list of those field names.
        /// For example 'name,etag,timeCreated,md5,timeModified'
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "size")]
            Size,
            [EnumMember(Value = "etag")]
            Etag,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "md5")]
            Md5,
            [EnumMember(Value = "timeModified")]
            TimeModified
        };

        /// <value>
        /// Object summary in list of objects includes the 'name' field. This parameter can also include 'size'
        /// (object size in bytes), 'etag', 'md5', 'timeCreated' (object creation date and time) and 'timeModified'
        /// (object modification date and time).
        /// Value of this parameter should be a comma-separated, case-insensitive list of those field names.
        /// For example 'name,etag,timeCreated,md5,timeModified'
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Nullable<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be greater than this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startAfter")]
        public string StartAfter { get; set; }
    }
}