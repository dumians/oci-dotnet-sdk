/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Http.Internal;
using Oci.Common.Model;

namespace Oci.Common.Http
{
    /// <summary>A REST client implementation.</summary>
    public class RestClient
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public RestClient(RestClientHandler handler)
        {
            this.httpClient = new HttpClient(handler);
        }

        public RestClient(RestClientHandler handler, ClientConfiguration clientConfiguration)
        {
            this.httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMilliseconds(clientConfiguration.TimeoutMillis),
                MaxResponseContentBufferSize = clientConfiguration.ResponseContentBufferBytes
            };
        }

        public RestClient() : this(null) { }

        /// <summary>Disposes the HTTP client</summary>
        public void Dispose()
        {
            if (this.httpClient != null)
            {
                this.httpClient.Dispose();
            }
        }

        /// <summary>Sets the base address for the HTTPS client.</summary>
        /// <param name="endpoint">The service endpoint.</param>
        public void SetEndpoint(string endpoint)
        {
            logger.Debug($"Setting endpoint to: {endpoint}");
            //TODO: Ensure HTTPS 
            this.httpClient.BaseAddress = new Uri(endpoint);
        }

        /// <summary>Retrieves the endpoint Uri.</summary>
        /// <returns>The base address of the HTTPS client.</returns>
        public Uri GetEndpoint()
        {
            return this.httpClient.BaseAddress;
        }

        /// <summary>Sets the default user agent in HTTP client.</summary>
        /// <param name="userAgent">A user agent string.</param>
        public void SetDefaultUserAgent(string userAgent)
        {
            this.httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd(userAgent);
        }

        /// <summary>Sends HTTP request.</summary>
        /// <param name="httpRequest">The HttpRequestMessage to be sent.</param>
        /// <param name="cancellationToken">The CancellationToken to be used.</param>
        /// <returns>A Task of HttpResponseMessage returned.</returns>
        /// <exception>Throws HttpRequestException, InvalidOperationException, or OperationCanceledException depending on the type of error.</exception>
        public async Task<HttpResponseMessage> HttpSend(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default)
        {
            var opcRequestId = httpRequest.Headers.Contains("opc-request-id") ?
                httpRequest.Headers.GetValues("opc-request-id").FirstOrDefault() : string.Empty;

            try
            {
                HttpResponseMessage response = await this.httpClient.SendAsync(httpRequest, cancellationToken);
                logger.Debug("Dumping HttpResponse:\n{0}", response.ToString());
                // Check for success immediately to avoid unnecessary processing of failure responses.
                if (!response.IsSuccessStatusCode)
                {
                    ResponseHelper.HandleNonSuccessfulResponse(response);
                }
                return response;
            }
            catch (HttpRequestException ex)
            {
                logger.Warn($"HttpRequestException has occured while processing the request: {ex.Message}");
                throw new OciException(ex.Message, "Unknown", opcRequestId, ex);
            }
            catch (InvalidOperationException ex)
            {
                logger.Warn($"InvalidOperationException has occured while processing the request: {ex.Message}");
                throw new OciException(ex.Message, "Unknown", opcRequestId, ex);
            }
            catch (OperationCanceledException e)
            {
                logger.Warn($"Request has been cancelled using CancellationToken, IsCancellationRequested: {cancellationToken.IsCancellationRequested}, errorMessage: {e.Message}");
                throw;
            }
        }

        private readonly HttpClient httpClient = null;
    }
}
