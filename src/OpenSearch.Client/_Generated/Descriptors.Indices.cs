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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using OpenSearch.Net;
using OpenSearch.Net.Specification.IndicesApi;
using OpenSearch.Net.Utf8Json;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
    /// <summary>Descriptor for AddBlock <para>https://opensearch.org/docs/latest</para></summary>
    public partial class AddIndexBlockDescriptor
        : RequestDescriptorBase<
            AddIndexBlockDescriptor,
            AddIndexBlockRequestParameters,
            IAddIndexBlockRequest
        >,
            IAddIndexBlockRequest
    {
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAddBlock;

        /// <summary>/{index}/_block/{block}</summary>
        /// <param name="index">this parameter is required</param>
        /// <param name="block">this parameter is required</param>
        public AddIndexBlockDescriptor(Indices index, IndexBlock block)
            : base(r => r.Required("index", index).Required("block", block)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected AddIndexBlockDescriptor()
            : base() { }

        // values part of the url path
        IndexBlock IAddIndexBlockRequest.Block => Self.RouteValues.Get<IndexBlock>("block");
        Indices IAddIndexBlockRequest.Index => Self.RouteValues.Get<Indices>("index");

        /// <summary>A comma separated list of indices to add a block to.</summary>
        public AddIndexBlockDescriptor Index(Indices index) =>
            Assign(index, (a, v) => a.RouteValues.Required("index", v));

        /// <summary>a shortcut into calling Index(typeof(TOther))</summary>
        public AddIndexBlockDescriptor Index<TOther>()
            where TOther : class =>
            Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (Indices)v));

        /// <summary>A shortcut into calling Index(Indices.All)</summary>
        public AddIndexBlockDescriptor AllIndices() => Index(Indices.All);

        // Request parameters
        /// <summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified).</summary>
        public AddIndexBlockDescriptor AllowNoIndices(bool? allownoindices = true) =>
            Qs("allow_no_indices", allownoindices);

        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public AddIndexBlockDescriptor ClusterManagerTimeout(Time clustermanagertimeout) =>
            Qs("cluster_manager_timeout", clustermanagertimeout);

        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        public AddIndexBlockDescriptor ExpandWildcards(ExpandWildcards? expandwildcards) =>
            Qs("expand_wildcards", expandwildcards);

        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed).</summary>
        public AddIndexBlockDescriptor IgnoreUnavailable(bool? ignoreunavailable = true) =>
            Qs("ignore_unavailable", ignoreunavailable);

        /// <summary>Specify timeout for connection to master.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public AddIndexBlockDescriptor MasterTimeout(Time mastertimeout) =>
            Qs("master_timeout", mastertimeout);

        /// <summary>Explicit operation timeout.</summary>
        public AddIndexBlockDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
    }

    /// <summary>Descriptor for DeleteComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/#delete-a-template</para></summary>
    public partial class DeleteComposableIndexTemplateDescriptor
        : RequestDescriptorBase<
            DeleteComposableIndexTemplateDescriptor,
            DeleteComposableIndexTemplateRequestParameters,
            IDeleteComposableIndexTemplateRequest
        >,
            IDeleteComposableIndexTemplateRequest
    {
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public DeleteComposableIndexTemplateDescriptor(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteComposableIndexTemplateDescriptor()
            : base() { }

        // values part of the url path
        Name IDeleteComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public DeleteComposableIndexTemplateDescriptor ClusterManagerTimeout(
            Time clustermanagertimeout
        ) => Qs("cluster_manager_timeout", clustermanagertimeout);

        /// <summary>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public DeleteComposableIndexTemplateDescriptor MasterTimeout(Time mastertimeout) =>
            Qs("master_timeout", mastertimeout);

        /// <summary>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        public DeleteComposableIndexTemplateDescriptor Timeout(Time timeout) =>
            Qs("timeout", timeout);
    }

    /// <summary>Descriptor for ComposableTemplateExists <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class ComposableIndexTemplateExistsDescriptor
        : RequestDescriptorBase<
            ComposableIndexTemplateExistsDescriptor,
            ComposableIndexTemplateExistsRequestParameters,
            IComposableIndexTemplateExistsRequest
        >,
            IComposableIndexTemplateExistsRequest
    {
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesComposableTemplateExists;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public ComposableIndexTemplateExistsDescriptor(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected ComposableIndexTemplateExistsDescriptor()
            : base() { }

        // values part of the url path
        Name IComposableIndexTemplateExistsRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public ComposableIndexTemplateExistsDescriptor ClusterManagerTimeout(
            Time clustermanagertimeout
        ) => Qs("cluster_manager_timeout", clustermanagertimeout);

        /// <summary>Return settings in flat format.</summary>
        public ComposableIndexTemplateExistsDescriptor FlatSettings(bool? flatsettings = true) =>
            Qs("flat_settings", flatsettings);

        /// <summary>Return local information, do not retrieve the state from cluster-manager node.</summary>
        public ComposableIndexTemplateExistsDescriptor Local(bool? local = true) =>
            Qs("local", local);

        /// <summary>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public ComposableIndexTemplateExistsDescriptor MasterTimeout(Time mastertimeout) =>
            Qs("master_timeout", mastertimeout);
    }

    /// <summary>Descriptor for GetComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class GetComposableIndexTemplateDescriptor
        : RequestDescriptorBase<
            GetComposableIndexTemplateDescriptor,
            GetComposableIndexTemplateRequestParameters,
            IGetComposableIndexTemplateRequest
        >,
            IGetComposableIndexTemplateRequest
    {
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetComposableTemplate;

        /// <summary>/_index_template</summary>
        public GetComposableIndexTemplateDescriptor()
            : base() { }

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">Optional, accepts null</param>
        public GetComposableIndexTemplateDescriptor(Name name)
            : base(r => r.Optional("name", name)) { }

        // values part of the url path
        Name IGetComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        /// <summary>Name of the index template to retrieve. Wildcard (*) expressions are supported.</summary>
        public GetComposableIndexTemplateDescriptor Name(Name name) =>
            Assign(name, (a, v) => a.RouteValues.Optional("name", v));

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public GetComposableIndexTemplateDescriptor ClusterManagerTimeout(
            Time clustermanagertimeout
        ) => Qs("cluster_manager_timeout", clustermanagertimeout);

        /// <summary>If true, returns settings in flat format.</summary>
        public GetComposableIndexTemplateDescriptor FlatSettings(bool? flatsettings = true) =>
            Qs("flat_settings", flatsettings);

        /// <summary>If true, the request retrieves information from the local node only. Defaults to false, which means information is retrieved from the master node.</summary>
        public GetComposableIndexTemplateDescriptor Local(bool? local = true) => Qs("local", local);

        /// <summary>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public GetComposableIndexTemplateDescriptor MasterTimeout(Time mastertimeout) =>
            Qs("master_timeout", mastertimeout);
    }

    /// <summary>Descriptor for PutComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class PutComposableIndexTemplateDescriptor
        : RequestDescriptorBase<
            PutComposableIndexTemplateDescriptor,
            PutComposableIndexTemplateRequestParameters,
            IPutComposableIndexTemplateRequest
        >,
            IPutComposableIndexTemplateRequest
    {
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public PutComposableIndexTemplateDescriptor(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected PutComposableIndexTemplateDescriptor()
            : base() { }

        // values part of the url path
        Name IPutComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>User defined reason for creating/updating the index template.</summary>
        public PutComposableIndexTemplateDescriptor Cause(string cause) => Qs("cause", cause);

        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public PutComposableIndexTemplateDescriptor ClusterManagerTimeout(
            Time clustermanagertimeout
        ) => Qs("cluster_manager_timeout", clustermanagertimeout);

        /// <summary>If `true`, this request cannot replace or update existing index templates.</summary>
        public PutComposableIndexTemplateDescriptor Create(bool? create = true) =>
            Qs("create", create);

        /// <summary>Operation timeout for connection to master node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public PutComposableIndexTemplateDescriptor MasterTimeout(Time mastertimeout) =>
            Qs("master_timeout", mastertimeout);
    }
}
