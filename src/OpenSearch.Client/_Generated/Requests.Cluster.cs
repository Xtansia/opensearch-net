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
using OpenSearch.Net.Specification.ClusterApi;
using OpenSearch.Net.Utf8Json;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
    [InterfaceDataContract]
    public partial interface IClusterAllocationExplainRequest
        : IRequest<ClusterAllocationExplainRequestParameters> { }

    /// <summary>Request for AllocationExplain <para>https://opensearch.org/docs/latest/api-reference/cluster-api/cluster-allocation/</para></summary>
    public partial class ClusterAllocationExplainRequest
        : PlainRequestBase<ClusterAllocationExplainRequestParameters>,
            IClusterAllocationExplainRequest
    {
        protected IClusterAllocationExplainRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;

        // values part of the url path

        // Request parameters
        /// <summary>If true, returns information about disk usage and shard sizes.</summary>
        public bool? IncludeDiskInfo
        {
            get => Q<bool?>("include_disk_info");
            set => Q("include_disk_info", value);
        }

        /// <summary>If true, returns YES decisions in explanation.</summary>
        public bool? IncludeYesDecisions
        {
            get => Q<bool?>("include_yes_decisions");
            set => Q("include_yes_decisions", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IDeleteComponentTemplateRequest
        : IRequest<DeleteComponentTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for DeleteComponentTemplate <para>https://opensearch.org/docs/latest</para></summary>
    public partial class DeleteComponentTemplateRequest
        : PlainRequestBase<DeleteComponentTemplateRequestParameters>,
            IDeleteComponentTemplateRequest
    {
        protected IDeleteComponentTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;

        /// <summary>/_component_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public DeleteComponentTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteComponentTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IDeleteComponentTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

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
    public partial interface IDeleteVotingConfigExclusionsRequest
        : IRequest<DeleteVotingConfigExclusionsRequestParameters> { }

    /// <summary>Request for DeleteVotingConfigExclusions <para>https://opensearch.org/docs/latest</para></summary>
    public partial class DeleteVotingConfigExclusionsRequest
        : PlainRequestBase<DeleteVotingConfigExclusionsRequestParameters>,
            IDeleteVotingConfigExclusionsRequest
    {
        protected IDeleteVotingConfigExclusionsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteVotingConfigExclusions;

        // values part of the url path

        // Request parameters
        /// <summary>
        /// Specifies whether to wait for all excluded nodes to be removed from the cluster before clearing the voting configuration exclusions list.
        /// Defaults to true, meaning that all excluded nodes must be removed from the cluster before this API takes any action. If set to false then
        /// the voting configuration exclusions list is cleared even if some excluded nodes are still in the cluster.
        /// </summary>
        public bool? WaitForRemoval
        {
            get => Q<bool?>("wait_for_removal");
            set => Q("wait_for_removal", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IComponentTemplateExistsRequest
        : IRequest<ComponentTemplateExistsRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for ComponentTemplateExists <para>https://opensearch.org/docs/latest</para></summary>
    public partial class ComponentTemplateExistsRequest
        : PlainRequestBase<ComponentTemplateExistsRequestParameters>,
            IComponentTemplateExistsRequest
    {
        protected IComponentTemplateExistsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterComponentTemplateExists;

        /// <summary>/_component_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public ComponentTemplateExistsRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected ComponentTemplateExistsRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IComponentTemplateExistsRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
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
    public partial interface IGetComponentTemplateRequest
        : IRequest<GetComponentTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for GetComponentTemplate <para>https://opensearch.org/docs/latest</para></summary>
    public partial class GetComponentTemplateRequest
        : PlainRequestBase<GetComponentTemplateRequestParameters>,
            IGetComponentTemplateRequest
    {
        protected IGetComponentTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetComponentTemplate;

        /// <summary>/_component_template</summary>
        public GetComponentTemplateRequest()
            : base() { }

        /// <summary>/_component_template/{name}</summary>
        /// <param name="name">Optional, accepts null</param>
        public GetComponentTemplateRequest(Name name)
            : base(r => r.Optional("name", name)) { }

        // values part of the url path
        [IgnoreDataMember]
        Name IGetComponentTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, the request retrieves information from the local node only. If `false`, information is retrieved from the master node.</summary>
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
    public partial interface IClusterGetSettingsRequest
        : IRequest<ClusterGetSettingsRequestParameters> { }

    /// <summary>Request for GetSettings <para>https://opensearch.org/docs/latest/api-reference/cluster-api/cluster-settings/</para></summary>
    public partial class ClusterGetSettingsRequest
        : PlainRequestBase<ClusterGetSettingsRequestParameters>,
            IClusterGetSettingsRequest
    {
        protected IClusterGetSettingsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;

        // values part of the url path

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, returns settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>If `true`, returns default cluster settings from the local node.</summary>
        public bool? IncludeDefaults
        {
            get => Q<bool?>("include_defaults");
            set => Q("include_defaults", value);
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
    public partial interface IClusterHealthRequest : IRequest<ClusterHealthRequestParameters>
    {
        [IgnoreDataMember]
        Indices Index { get; }
    }

    /// <summary>Request for Health <para>https://opensearch.org/docs/latest/api-reference/cluster-api/cluster-health/</para></summary>
    public partial class ClusterHealthRequest
        : PlainRequestBase<ClusterHealthRequestParameters>,
            IClusterHealthRequest
    {
        protected IClusterHealthRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;

        /// <summary>/_cluster/health</summary>
        public ClusterHealthRequest()
            : base() { }

        /// <summary>/_cluster/health/{index}</summary>
        /// <param name="index">Optional, accepts null</param>
        public ClusterHealthRequest(Indices index)
            : base(r => r.Optional("index", index)) { }

        // values part of the url path
        [IgnoreDataMember]
        Indices IClusterHealthRequest.Index => Self.RouteValues.Get<Indices>("index");

        // Request parameters
        /// <summary>The awareness attribute for which the health is required.</summary>
        public string AwarenessAttribute
        {
            get => Q<string>("awareness_attribute");
            set => Q("awareness_attribute", value);
        }

        /// <summary>Specify the level of detail for returned information.</summary>
        public ClusterHealthLevel? ClusterHealthLevel
        {
            get => Q<ClusterHealthLevel?>("level");
            set => Q("level", value);
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

        /// <summary>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }

        /// <summary>A number controlling to how many active shards to wait for, all to wait for all shards in the cluster to be active, or 0 to not wait.</summary>
        public string WaitForActiveShards
        {
            get => Q<string>("wait_for_active_shards");
            set => Q("wait_for_active_shards", value);
        }

        /// <summary>Can be one of immediate, urgent, high, normal, low, languid. Wait until all currently queued events with the given priority are processed.</summary>
        public WaitForEvents? WaitForEvents
        {
            get => Q<WaitForEvents?>("wait_for_events");
            set => Q("wait_for_events", value);
        }

        /// <summary>
        /// The request waits until the specified number N of nodes is available. It also accepts >=N, <=N, >N and <N. Alternatively, it is possible
        /// to use ge(N), le(N), gt(N) and lt(N) notation.
        /// </summary>
        public string WaitForNodes
        {
            get => Q<string>("wait_for_nodes");
            set => Q("wait_for_nodes", value);
        }

        /// <summary>
        /// A boolean value which controls whether to wait (until the timeout provided) for the cluster to have no shard initializations. Defaults to
        /// false, which means it will not wait for initializing shards.
        /// </summary>
        public bool? WaitForNoInitializingShards
        {
            get => Q<bool?>("wait_for_no_initializing_shards");
            set => Q("wait_for_no_initializing_shards", value);
        }

        /// <summary>
        /// A boolean value which controls whether to wait (until the timeout provided) for the cluster to have no shard relocations. Defaults to
        /// false, which means it will not wait for relocating shards.
        /// </summary>
        public bool? WaitForNoRelocatingShards
        {
            get => Q<bool?>("wait_for_no_relocating_shards");
            set => Q("wait_for_no_relocating_shards", value);
        }

        /// <summary>Wait until cluster is in a specific state.</summary>
        public WaitForStatus? WaitForStatus
        {
            get => Q<WaitForStatus?>("wait_for_status");
            set => Q("wait_for_status", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IClusterPendingTasksRequest
        : IRequest<ClusterPendingTasksRequestParameters> { }

    /// <summary>Request for PendingTasks <para>https://opensearch.org/docs/latest</para></summary>
    public partial class ClusterPendingTasksRequest
        : PlainRequestBase<ClusterPendingTasksRequestParameters>,
            IClusterPendingTasksRequest
    {
        protected IClusterPendingTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;

        // values part of the url path

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, the request retrieves information from the local node only. If `false`, information is retrieved from the master node.</summary>
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
    public partial interface IPostVotingConfigExclusionsRequest
        : IRequest<PostVotingConfigExclusionsRequestParameters> { }

    /// <summary>Request for PostVotingConfigExclusions <para>https://opensearch.org/docs/latest</para></summary>
    public partial class PostVotingConfigExclusionsRequest
        : PlainRequestBase<PostVotingConfigExclusionsRequestParameters>,
            IPostVotingConfigExclusionsRequest
    {
        protected IPostVotingConfigExclusionsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;

        // values part of the url path

        // Request parameters
        /// <summary>
        /// A comma-separated list of the persistent ids of the nodes to exclude from the voting configuration. If specified, you may not also specify
        /// node_names.
        /// </summary>
        public string NodeIds
        {
            get => Q<string>("node_ids");
            set => Q("node_ids", value);
        }

        /// <summary>Comma-separated list of the names of the nodes to exclude from the voting configuration. If specified, you may not also specify ?node_ids.</summary>
        public string NodeNames
        {
            get => Q<string>("node_names");
            set => Q("node_names", value);
        }

        /// <summary>
        /// When adding a voting configuration exclusion, the API waits for the specified nodes to be excluded from the voting configuration before
        /// returning. If the timeout expires before the appropriate condition is satisfied, the request fails and returns an error.
        /// </summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IPutComponentTemplateRequest
        : IRequest<PutComponentTemplateRequestParameters>
    {
        [IgnoreDataMember]
        Name Name { get; }
    }

    /// <summary>Request for PutComponentTemplate</summary>
    public partial class PutComponentTemplateRequest
        : PlainRequestBase<PutComponentTemplateRequestParameters>,
            IPutComponentTemplateRequest
    {
        protected IPutComponentTemplateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;

        /// <summary>/_component_template/{name}</summary>
        /// <param name="name">this parameter is required</param>
        public PutComponentTemplateRequest(Name name)
            : base(r => r.Required("name", name)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected PutComponentTemplateRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IPutComponentTemplateRequest.Name => Self.RouteValues.Get<Name>("name");

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If `true`, this request cannot replace or update existing component templates.</summary>
        public bool? Create
        {
            get => Q<bool?>("create");
            set => Q("create", value);
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

        /// <summary>Operation timeout.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IClusterPutSettingsRequest
        : IRequest<ClusterPutSettingsRequestParameters> { }

    /// <summary>Request for PutSettings <para>https://opensearch.org/docs/latest/api-reference/cluster-settings/</para></summary>
    public partial class ClusterPutSettingsRequest
        : PlainRequestBase<ClusterPutSettingsRequestParameters>,
            IClusterPutSettingsRequest
    {
        protected IClusterPutSettingsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;

        // values part of the url path

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Return settings in flat format (default: false).</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>Explicit operation timeout for connection to master node.</summary>
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
    public partial interface IRemoteInfoRequest : IRequest<RemoteInfoRequestParameters> { }

    /// <summary>Request for RemoteInfo <para>https://opensearch.org/docs/latest/api-reference/remote-info/</para></summary>
    public partial class RemoteInfoRequest
        : PlainRequestBase<RemoteInfoRequestParameters>,
            IRemoteInfoRequest
    {
        protected IRemoteInfoRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
        // values part of the url path

        // Request parameters
    }

    [InterfaceDataContract]
    public partial interface IClusterRerouteRequest : IRequest<ClusterRerouteRequestParameters> { }

    /// <summary>Request for Reroute <para>https://opensearch.org/docs/latest</para></summary>
    public partial class ClusterRerouteRequest
        : PlainRequestBase<ClusterRerouteRequestParameters>,
            IClusterRerouteRequest
    {
        protected IClusterRerouteRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;

        // values part of the url path

        // Request parameters
        /// <summary>Operation timeout for connection to cluster-manager node.</summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>If true, then the request simulates the operation only and returns the resulting state.</summary>
        public bool? DryRun
        {
            get => Q<bool?>("dry_run");
            set => Q("dry_run", value);
        }

        /// <summary>If true, then the response contains an explanation of why the commands can or cannot be executed.</summary>
        public bool? Explain
        {
            get => Q<bool?>("explain");
            set => Q("explain", value);
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

        /// <summary>Limits the information returned to the specified metrics.</summary>
        public string[] Metric
        {
            get => Q<string[]>("metric");
            set => Q("metric", value);
        }

        /// <summary>If true, then retries allocation of shards that are blocked due to too many subsequent allocation failures.</summary>
        public bool? RetryFailed
        {
            get => Q<bool?>("retry_failed");
            set => Q("retry_failed", value);
        }

        /// <summary>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IClusterStateRequest : IRequest<ClusterStateRequestParameters>
    {
        [IgnoreDataMember]
        Indices Index { get; }

        [IgnoreDataMember]
        Metrics Metric { get; }
    }

    /// <summary>Request for State <para>https://opensearch.org/docs/latest</para></summary>
    public partial class ClusterStateRequest
        : PlainRequestBase<ClusterStateRequestParameters>,
            IClusterStateRequest
    {
        protected IClusterStateRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;

        /// <summary>/_cluster/state</summary>
        public ClusterStateRequest()
            : base() { }

        /// <summary>/_cluster/state/{metric}</summary>
        /// <param name="metric">Optional, accepts null</param>
        public ClusterStateRequest(Metrics metric)
            : base(r => r.Optional("metric", metric)) { }

        /// <summary>/_cluster/state/{metric}/{index}</summary>
        /// <param name="metric">Optional, accepts null</param>
        /// <param name="index">Optional, accepts null</param>
        public ClusterStateRequest(Metrics metric, Indices index)
            : base(r => r.Optional("metric", metric).Optional("index", index)) { }

        // values part of the url path
        [IgnoreDataMember]
        Indices IClusterStateRequest.Index => Self.RouteValues.Get<Indices>("index");

        [IgnoreDataMember]
        Metrics IClusterStateRequest.Metric => Self.RouteValues.Get<Metrics>("metric");

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

        /// <summary>Return settings in flat format (default: false).</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed).</summary>
        public bool? IgnoreUnavailable
        {
            get => Q<bool?>("ignore_unavailable");
            set => Q("ignore_unavailable", value);
        }

        /// <summary>Return local information, do not retrieve the state from cluster-manager node (default: false).</summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
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

        /// <summary>Wait for the metadata version to be equal or greater than the specified metadata version.</summary>
        public long? WaitForMetadataVersion
        {
            get => Q<long?>("wait_for_metadata_version");
            set => Q("wait_for_metadata_version", value);
        }

        /// <summary>The maximum time to wait for wait_for_metadata_version before timing out.</summary>
        public Time WaitForTimeout
        {
            get => Q<Time>("wait_for_timeout");
            set => Q("wait_for_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IClusterStatsRequest : IRequest<ClusterStatsRequestParameters>
    {
        [IgnoreDataMember]
        NodeIds NodeId { get; }
    }

    /// <summary>Request for Stats <para>https://opensearch.org/docs/latest/api-reference/cluster-api/cluster-stats/</para></summary>
    public partial class ClusterStatsRequest
        : PlainRequestBase<ClusterStatsRequestParameters>,
            IClusterStatsRequest
    {
        protected IClusterStatsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;

        /// <summary>/_cluster/stats</summary>
        public ClusterStatsRequest()
            : base() { }

        /// <summary>/_cluster/stats/nodes/{node_id}</summary>
        /// <param name="nodeId">Optional, accepts null</param>
        public ClusterStatsRequest(NodeIds nodeId)
            : base(r => r.Optional("node_id", nodeId)) { }

        // values part of the url path
        [IgnoreDataMember]
        NodeIds IClusterStatsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");

        // Request parameters
        /// <summary>If `true`, returns settings in flat format.</summary>
        public bool? FlatSettings
        {
            get => Q<bool?>("flat_settings");
            set => Q("flat_settings", value);
        }

        /// <summary>
        /// Period to wait for each node to respond. If a node does not respond before its timeout expires, the response does not include its stats.
        /// However, timed out nodes are included in the response’s `_nodes.failed` property. Defaults to no timeout.
        /// </summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }
}
