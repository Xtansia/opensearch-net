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
using System.Runtime.Serialization;
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
    [InterfaceDataContract]
    public partial interface IAddIndexBlockRequest : IRequest<AddIndexBlockRequestParameters>
    {
        [IgnoreDataMember]
        IndexBlock Block { get; }

        [IgnoreDataMember]
        Indices Index { get; }
    }

    /// <summary>Request for AddBlock <para>https://opensearch.org/docs/latest</para></summary>
    public partial class AddIndexBlockRequest
        : PlainRequestBase<AddIndexBlockRequestParameters>,
            IAddIndexBlockRequest
    {
        protected IAddIndexBlockRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAddBlock;

        /// <summary>/{index}/_block/{block}</summary>
        /// <param name="index">this parameter is required</param>
        /// <param name="block">this parameter is required</param>
        public AddIndexBlockRequest(Indices index, IndexBlock block)
            : base(r => r.Required("index", index).Required("block", block)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected AddIndexBlockRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        IndexBlock IAddIndexBlockRequest.Block => Self.RouteValues.Get<IndexBlock>("block");

        [IgnoreDataMember]
        Indices IAddIndexBlockRequest.Index => Self.RouteValues.Get<Indices>("index");

        // Request parameters
        /// <summary>
        /// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
        /// been specified).
        /// </summary>
        public bool? AllowNoIndices
        {
            get => Q<bool?>("allow_no_indices");
            set => Q("allow_no_indices", value);
        }

        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        public ExpandWildcards? ExpandWildcards
        {
            get => Q<ExpandWildcards?>("expand_wildcards");
            set => Q("expand_wildcards", value);
        }

        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed).</summary>
        public bool? IgnoreUnavailable
        {
            get => Q<bool?>("ignore_unavailable");
            set => Q("ignore_unavailable", value);
        }

        /// <summary>Specify timeout for connection to master.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>Explicit operation timeout.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IAnalyzeRequest : IRequest<AnalyzeRequestParameters>
    {
        [IgnoreDataMember]
        IndexName Index { get; }
    }

    /// <summary>Request for Analyze <para>https://opensearch.org/docs/latest/api-reference/analyze-apis/perform-text-analysis/</para></summary>
    public partial class AnalyzeRequest
        : PlainRequestBase<AnalyzeRequestParameters>,
            IAnalyzeRequest
    {
        protected IAnalyzeRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesAnalyze;

        /// <summary>/_analyze</summary>
        public AnalyzeRequest()
            : base() { }

        /// <summary>/{index}/_analyze</summary>
        /// <param name="index">Optional, accepts null</param>
        public AnalyzeRequest(IndexName index)
            : base(r => r.Optional("index", index)) { }

        // values part of the url path
        [IgnoreDataMember]
        IndexName IAnalyzeRequest.Index => Self.RouteValues.Get<IndexName>("index");

        // Request parameters
    }

    [InterfaceDataContract]
    public partial interface IDeleteComposableIndexTemplateRequest
        : IRequest<DeleteComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for DeleteComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/#delete-a-template</para></summary>
    public partial class DeleteComposableIndexTemplateRequest
        : PlainRequestBase<DeleteComposableIndexTemplateRequestParameters>,
            IDeleteComposableIndexTemplateRequest
    {
        protected IDeleteComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesDeleteComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public DeleteComposableIndexTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteComposableIndexTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IDeleteComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IComposableIndexTemplateExistsRequest
        : IRequest<ComposableIndexTemplateExistsRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for ComposableTemplateExists <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class ComposableIndexTemplateExistsRequest
        : PlainRequestBase<ComposableIndexTemplateExistsRequestParameters>,
            IComposableIndexTemplateExistsRequest
    {
        protected IComposableIndexTemplateExistsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesComposableTemplateExists;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public ComposableIndexTemplateExistsRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected ComposableIndexTemplateExistsRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IComposableIndexTemplateExistsRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Return settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>Return local information, do not retrieve the state from cluster-manager node.</summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IGetComposableIndexTemplateRequest
        : IRequest<GetComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for GetComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class GetComposableIndexTemplateRequest
        : PlainRequestBase<GetComposableIndexTemplateRequestParameters>,
            IGetComposableIndexTemplateRequest
    {
        protected IGetComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesGetComposableTemplate;

        /// <summary>/_index_template</summary>
        public GetComposableIndexTemplateRequest()
            : base() { }

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">Optional, accepts null</param>
        public GetComposableIndexTemplateRequest(Name name)
            : base(r => r.Optional("name", name)) { }

        // values part of the url path
        [IgnoreDataMember]
        Name IGetComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If true, returns settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>
        /// If true, the request retrieves information from the local node only. Defaults to false, which means information is retrieved from the
        /// master node.
        /// </summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }

        /// <summary>
        /// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns
        /// an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IPutComposableIndexTemplateRequest
        : IRequest<PutComposableIndexTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for PutComposableTemplate <para>https://opensearch.org/docs/latest/im-plugin/index-templates/</para></summary>
    public partial class PutComposableIndexTemplateRequest
        : PlainRequestBase<PutComposableIndexTemplateRequestParameters>,
            IPutComposableIndexTemplateRequest
    {
        protected IPutComposableIndexTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesPutComposableTemplate;

        /// <summary>/_index_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public PutComposableIndexTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected PutComposableIndexTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IPutComposableIndexTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>User defined reason for creating/updating the index template.</summary>
        public string Cause
        {
            get => Q<string>("cause");
            set => Q("cause", value);
        }

        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, this request cannot replace or update existing index templates.</summary>
        public bool? Create
        {
            get => Q<bool?>("create");
            set => Q("create", value);
        }

        /// <summary>Operation timeout for connection to master node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use 'cluster_manager_timeout' instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }
}
