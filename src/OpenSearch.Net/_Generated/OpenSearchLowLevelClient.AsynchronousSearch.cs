/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*   http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net;
using static OpenSearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace OpenSearch.Net.Specification.AsynchronousSearchApi
{
    /// <summary>
    /// Asynchronous Search APIs.
    /// <para>Not intended to be instantiated directly. Use the <see cref="IOpenSearchLowLevelClient.AsynchronousSearch"/> property
    /// on <see cref="IOpenSearchLowLevelClient"/>.
    /// </para>
    /// </summary>
    public partial class LowLevelAsynchronousSearchNamespace : NamespacedClientProxy
    {
        internal LowLevelAsynchronousSearchNamespace(OpenSearchLowLevelClient client)
            : base(client) { }

        /// <summary>DELETE on /_plugins/_asynchronous_search/{id} <para>https://opensearch.org/docs/latest/search-plugins/async/index/#delete-searches-and-results</para></summary>
        /// <param name="id"></param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        public TResponse Delete<TResponse>(
            string id,
            DeleteRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                DELETE,
                Url($"_plugins/_asynchronous_search/{id:id}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>DELETE on /_plugins/_asynchronous_search/{id} <para>https://opensearch.org/docs/latest/search-plugins/async/index/#delete-searches-and-results</para></summary>
        /// <param name="id"></param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        [MapsApi("asynchronous_search.delete", "id")]
        public Task<TResponse> DeleteAsync<TResponse>(
            string id,
            DeleteRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                DELETE,
                Url($"_plugins/_asynchronous_search/{id:id}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_asynchronous_search/{id} <para>https://opensearch.org/docs/latest/search-plugins/async/index/#get-partial-results</para></summary>
        /// <param name="id"></param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        public TResponse Get<TResponse>(string id, GetRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                Url($"_plugins/_asynchronous_search/{id:id}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_asynchronous_search/{id} <para>https://opensearch.org/docs/latest/search-plugins/async/index/#get-partial-results</para></summary>
        /// <param name="id"></param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        [MapsApi("asynchronous_search.get", "id")]
        public Task<TResponse> GetAsync<TResponse>(
            string id,
            GetRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                Url($"_plugins/_asynchronous_search/{id:id}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>POST on /_plugins/_asynchronous_search <para>https://opensearch.org/docs/latest/search-plugins/async/index/#rest-api</para></summary>
        /// <param name="body">The search definition using the Query DSL.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        public TResponse Search<TResponse>(
            PostData body,
            SearchRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                POST,
                "_plugins/_asynchronous_search",
                body,
                RequestParams(requestParameters)
            );

        /// <summary>POST on /_plugins/_asynchronous_search <para>https://opensearch.org/docs/latest/search-plugins/async/index/#rest-api</para></summary>
        /// <param name="body">The search definition using the Query DSL.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        [MapsApi("asynchronous_search.search", "body")]
        public Task<TResponse> SearchAsync<TResponse>(
            PostData body,
            SearchRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                POST,
                "_plugins/_asynchronous_search",
                ctx,
                body,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_asynchronous_search/stats <para>https://opensearch.org/docs/latest/search-plugins/async/index/#monitor-stats</para></summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        public TResponse Stats<TResponse>(StatsRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                "_plugins/_asynchronous_search/stats",
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_asynchronous_search/stats <para>https://opensearch.org/docs/latest/search-plugins/async/index/#monitor-stats</para></summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        [MapsApi("asynchronous_search.stats", "")]
        public Task<TResponse> StatsAsync<TResponse>(
            StatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                "_plugins/_asynchronous_search/stats",
                ctx,
                null,
                RequestParams(requestParameters)
            );
    }
}
