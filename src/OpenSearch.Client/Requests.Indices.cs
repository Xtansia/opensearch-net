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
* 	http://www.apache.org/licenses/LICENSE-2.0
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
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
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
    public partial class CreateIndexRequest
    {
        ///<summary>Whether a type should be expected in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    /// <remarks>Deprecated as of OpenSearch 2.0</remarks>
    [InterfaceDataContract]
    public partial interface ITypeExistsRequest : IRequest<TypeExistsRequestParameters>
    {
        [IgnoreDataMember]
        Indices Index { get; }

        [IgnoreDataMember]
        Names Type { get; }
    }

    ///<summary>Request for TypeExists <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
    ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
    public partial class TypeExistsRequest
        : PlainRequestBase<TypeExistsRequestParameters>,
            ITypeExistsRequest
    {
        protected ITypeExistsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.IndicesTypeExists;

        ///<summary>/{index}/_mapping/{type}</summary>
        ///<param name = "index">this parameter is required</param>
        ///<param name = "type">this parameter is required</param>
        public TypeExistsRequest(Indices index, Names type)
            : base(r => r.Required("index", index).Required("type", type)) { }

        ///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected TypeExistsRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Indices ITypeExistsRequest.Index => Self.RouteValues.Get<Indices>("index");

        [IgnoreDataMember]
        Names ITypeExistsRequest.Type => Self.RouteValues.Get<Names>("type");

        // Request parameters
        ///<summary>
        /// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
        /// been specified)
        ///</summary>
        public bool? AllowNoIndices
        {
            get => Q<bool?>("allow_no_indices");
            set => Q("allow_no_indices", value);
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        public ExpandWildcards? ExpandWildcards
        {
            get => Q<ExpandWildcards?>("expand_wildcards");
            set => Q("expand_wildcards", value);
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        public bool? IgnoreUnavailable
        {
            get => Q<bool?>("ignore_unavailable");
            set => Q("ignore_unavailable", value);
        }

        ///<summary>Return local information, do not retrieve the state from cluster_manager node (default: false)</summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }
    }

    public partial class GetIndexRequest
    {
        ///<summary>Whether to add the type name to the response (default: false)</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class GetFieldMappingRequest
    {
        ///<summary>Whether a type should be returned in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class GetMappingRequest
    {
        ///<summary>Whether to add the type name to the response (default: false)</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class GetIndexTemplateRequest
    {
        ///<summary>Whether a type should be returned in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class PutMappingRequest
    {
        ///<summary>Whether a type should be expected in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class PutIndexTemplateRequest
    {
        ///<summary>Whether a type should be returned in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }

    public partial class RolloverIndexRequest
    {
        ///<summary>Whether a type should be included in the body of the mappings.</summary>
        ///<remarks>Deprecated as of OpenSearch 2.0</remarks>
        public bool? IncludeTypeName
        {
            get => Q<bool?>("include_type_name");
            set => Q("include_type_name", value);
        }
    }
}
