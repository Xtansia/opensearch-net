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
namespace OpenSearch.Net.Specification.LtrApi
{
    /// <summary>
    /// Ltr APIs.
    /// <para>Not intended to be instantiated directly. Use the <see cref="IOpenSearchLowLevelClient.Ltr"/> property
    /// on <see cref="IOpenSearchLowLevelClient"/>.
    /// </para>
    /// </summary>
    public partial class LowLevelLtrNamespace : NamespacedClientProxy
    {
        internal LowLevelLtrNamespace(OpenSearchLowLevelClient client)
            : base(client) { }

        /// <summary>GET on /_ltr/_cachestats</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse CacheStats<TResponse>(CacheStatsRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(GET, "_ltr/_cachestats", null, RequestParams(requestParameters));

        /// <summary>GET on /_ltr/_cachestats</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.cache_stats", "")]
        public Task<TResponse> CacheStatsAsync<TResponse>(
            CacheStatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                "_ltr/_cachestats",
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>POST on /_ltr/_clearcache</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse ClearCache<TResponse>(ClearCacheRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(POST, "_ltr/_clearcache", null, RequestParams(requestParameters));

        /// <summary>POST on /_ltr/_clearcache</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.clear_cache", "")]
        public Task<TResponse> ClearCacheAsync<TResponse>(
            ClearCacheRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                POST,
                "_ltr/_clearcache",
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>POST on /_ltr/{store}/_clearcache</summary>
        /// <param name="store">The name of the feature store for which to clear the cache.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse ClearCache<TResponse>(
            string store,
            ClearCacheRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                POST,
                Url($"_ltr/{store:store}/_clearcache"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>POST on /_ltr/{store}/_clearcache</summary>
        /// <param name="store">The name of the feature store for which to clear the cache.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.clear_cache", "store")]
        public Task<TResponse> ClearCacheAsync<TResponse>(
            string store,
            ClearCacheRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                POST,
                Url($"_ltr/{store:store}/_clearcache"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>PUT on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse CreateDefaultStore<TResponse>(
            CreateDefaultStoreRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(PUT, "_ltr", null, RequestParams(requestParameters));

        /// <summary>PUT on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.create_default_store", "")]
        public Task<TResponse> CreateDefaultStoreAsync<TResponse>(
            CreateDefaultStoreRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(PUT, "_ltr", ctx, null, RequestParams(requestParameters));

        /// <summary>PUT on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse CreateStore<TResponse>(
            string store,
            CreateStoreRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                PUT,
                Url($"_ltr/{store:store}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>PUT on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.create_store", "store")]
        public Task<TResponse> CreateStoreAsync<TResponse>(
            string store,
            CreateStoreRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                PUT,
                Url($"_ltr/{store:store}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>DELETE on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse DeleteDefaultStore<TResponse>(
            DeleteDefaultStoreRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(DELETE, "_ltr", null, RequestParams(requestParameters));

        /// <summary>DELETE on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.delete_default_store", "")]
        public Task<TResponse> DeleteDefaultStoreAsync<TResponse>(
            DeleteDefaultStoreRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(DELETE, "_ltr", ctx, null, RequestParams(requestParameters));

        /// <summary>DELETE on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse DeleteStore<TResponse>(
            string store,
            DeleteStoreRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                DELETE,
                Url($"_ltr/{store:store}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>DELETE on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.delete_store", "store")]
        public Task<TResponse> DeleteStoreAsync<TResponse>(
            string store,
            DeleteStoreRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                DELETE,
                Url($"_ltr/{store:store}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse GetStore<TResponse>(
            string store,
            GetStoreRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                Url($"_ltr/{store:store}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_ltr/{store}</summary>
        /// <param name="store">The name of the feature store.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.get_store", "store")]
        public Task<TResponse> GetStoreAsync<TResponse>(
            string store,
            GetStoreRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                Url($"_ltr/{store:store}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        public TResponse ListStores<TResponse>(ListStoresRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(GET, "_ltr", null, RequestParams(requestParameters));

        /// <summary>GET on /_ltr</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.17.1 or greater.</remarks>
        [MapsApi("ltr.list_stores", "")]
        public Task<TResponse> ListStoresAsync<TResponse>(
            ListStoresRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(GET, "_ltr", ctx, null, RequestParams(requestParameters));

        /// <summary>GET on /_plugins/_ltr/stats</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse StatsForAll<TResponse>(StatsRequestParameters requestParameters = null)
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                "_plugins/_ltr/stats",
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/stats</summary>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.stats", "")]
        public Task<TResponse> StatsForAllAsync<TResponse>(
            StatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                "_plugins/_ltr/stats",
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/{node_id}/stats</summary>
        /// <param name="nodeId">A comma-separated list of node IDs or names to limit the returned information; use &lt;c&gt;_local&lt;/c&gt; to return information from the node you&#x27;re connecting to, leave empty to get information from all nodes.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse Stats<TResponse>(
            string nodeId,
            StatsRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                Url($"_plugins/_ltr/{nodeId:nodeId}/stats"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/{node_id}/stats</summary>
        /// <param name="nodeId">A comma-separated list of node IDs or names to limit the returned information; use &lt;c&gt;_local&lt;/c&gt; to return information from the node you&#x27;re connecting to, leave empty to get information from all nodes.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.stats", "node_id")]
        public Task<TResponse> StatsAsync<TResponse>(
            string nodeId,
            StatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                Url($"_plugins/_ltr/{nodeId:nodeId}/stats"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/{node_id}/stats/{stat}</summary>
        /// <param name="nodeId">A comma-separated list of node IDs or names to limit the returned information; use &lt;c&gt;_local&lt;/c&gt; to return information from the node you&#x27;re connecting to, leave empty to get information from all nodes.</param>
        /// <param name="stat">A comma-separated list of stats to retrieve; use &lt;c&gt;_all&lt;/c&gt; or empty string to retrieve all stats.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse Stats<TResponse>(
            string nodeId,
            string stat,
            StatsRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                Url($"_plugins/_ltr/{nodeId:nodeId}/stats/{stat:stat}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/{node_id}/stats/{stat}</summary>
        /// <param name="nodeId">A comma-separated list of node IDs or names to limit the returned information; use &lt;c&gt;_local&lt;/c&gt; to return information from the node you&#x27;re connecting to, leave empty to get information from all nodes.</param>
        /// <param name="stat">A comma-separated list of stats to retrieve; use &lt;c&gt;_all&lt;/c&gt; or empty string to retrieve all stats.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.stats", "node_id, stat")]
        public Task<TResponse> StatsAsync<TResponse>(
            string nodeId,
            string stat,
            StatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                Url($"_plugins/_ltr/{nodeId:nodeId}/stats/{stat:stat}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/stats/{stat}</summary>
        /// <param name="stat">A comma-separated list of stats to retrieve; use &lt;c&gt;_all&lt;/c&gt; or empty string to retrieve all stats.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        public TResponse StatsForAll<TResponse>(
            string stat,
            StatsRequestParameters requestParameters = null
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequest<TResponse>(
                GET,
                Url($"_plugins/_ltr/stats/{stat:stat}"),
                null,
                RequestParams(requestParameters)
            );

        /// <summary>GET on /_plugins/_ltr/stats/{stat}</summary>
        /// <param name="stat">A comma-separated list of stats to retrieve; use &lt;c&gt;_all&lt;/c&gt; or empty string to retrieve all stats.</param>
        /// <param name="requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
        /// <remarks>Supported by OpenSearch servers of version 2.19.0 or greater.</remarks>
        [MapsApi("ltr.stats", "stat")]
        public Task<TResponse> StatsForAllAsync<TResponse>(
            string stat,
            StatsRequestParameters requestParameters = null,
            CancellationToken ctx = default
        )
            where TResponse : class, IOpenSearchResponse, new() =>
            DoRequestAsync<TResponse>(
                GET,
                Url($"_plugins/_ltr/stats/{stat:stat}"),
                ctx,
                null,
                RequestParams(requestParameters)
            );
    }
}
