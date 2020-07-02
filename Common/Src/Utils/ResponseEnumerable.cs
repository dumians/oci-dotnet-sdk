/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Oci.Common.Utils
{
    /// <summary>
    /// Enumerable used to iterate over the responses returned by list operation. sSince
    /// this deals in responses, the returned response objects will contain a collection
    /// of results. This enumerable will handle calling the service to retrieve more results when required.
    /// </summary>
    /// <typeparam name="Request">List operation request</typeparam>
    /// <typeparam name="Response">Liest operation response</typeparam>
    public class ResponseEnumerable<Request, Response> : IEnumerable<Response>
    {
        // Function which returns nextpage from the response object.
        private readonly Func<Response, string> getNextPageTokenFunction;
        // Function which takes opcNextPageId as input and returns list request. 
        private readonly Func<string, Request> getListRequestFunction;
        // Function which invokes list request and returns response.
        private readonly Func<Request, Response> listRequestFunction;

        public ResponseEnumerable(Func<Response, string> getNextPageTokenFunction,
            Func<string, Request> getListRequestFunction,
            Func<Request, Response> listRequestFunction)
        {
            this.getNextPageTokenFunction = getNextPageTokenFunction;
            this.getListRequestFunction = getListRequestFunction;
            this.listRequestFunction = listRequestFunction;
        }

        public IEnumerator<Response> GetEnumerator()
        {
            var nextPageToken = "";
            Response response;

            do
            {
                response = listRequestFunction.Invoke(getListRequestFunction.Invoke(nextPageToken));
                yield return response;
            } while (!string.IsNullOrEmpty(nextPageToken = getNextPageTokenFunction(response)));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}