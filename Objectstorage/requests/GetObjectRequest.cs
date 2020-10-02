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
    public class GetObjectRequest : Oci.Common.IOciRequest
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
        /// The name of the object. Avoid entering confidential information.
        /// Example: test/object1.log
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// VersionId used to identify a particular version of the object
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "versionId")]
        public string VersionId { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to match. For creating and committing a multipart upload to an object, this is the entity tag of the target object.
        /// For uploading a part, this is the entity tag of the target part.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to avoid matching. The only valid value is '*', which indicates that the request should fail if the object
        /// already exists. For creating and committing a multipart upload, this is the entity tag of the target object. For uploading a
        /// part, this is the entity tag of the target part.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
        
        /// <value>
        /// Optional byte range to fetch, as described in [RFC 7233](https://tools.ietf.org/html/rfc7233#section-2.1).
        /// Note that only a single range of bytes is supported.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "range")]
        public Oci.Common.Model.Range Range { get; set; }
        
        /// <value>
        /// The optional header that specifies \"AES256\" as the encryption algorithm. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-algorithm")]
        public string OpcSseCustomerAlgorithm { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded 256-bit encryption key to use to encrypt or
        /// decrypt the data. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key")]
        public string OpcSseCustomerKey { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded SHA256 hash of the encryption key. This
        /// value is used to check the integrity of the encryption key. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key-sha256")]
        public string OpcSseCustomerKeySha256 { get; set; }
        
        /// <value>
        /// This value will be used in Content-Disposition header of the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseContentDisposition")]
        public string HttpResponseContentDisposition { get; set; }
        
        /// <value>
        /// This value will be used in Cache-Control header of the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseCacheControl")]
        public string HttpResponseCacheControl { get; set; }
        
        /// <value>
        /// This value will be used in Content-Type header of the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseContentType")]
        public string HttpResponseContentType { get; set; }
        
        /// <value>
        /// This value will be used in Content-Language header of the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseContentLanguage")]
        public string HttpResponseContentLanguage { get; set; }
        
        /// <value>
        /// This value will be used in Content-Encoding header of the response
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseContentEncoding")]
        public string HttpResponseContentEncoding { get; set; }
        
        /// <value>
        /// This value will be used in Expires header of the response
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "httpResponseExpires")]
        public string HttpResponseExpires { get; set; }
    }
}