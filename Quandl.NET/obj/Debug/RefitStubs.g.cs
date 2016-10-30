﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Quandl.NET.Model;
using Quandl.NET.Model.Enum;
using Quandl.NET.Model.Response;
using Refit;
using System.IO;
using System.Text;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace Quandl.NET.Refit
{
    using RefitInternalGenerated;

    [Preserve]
    partial class AutoGeneratedIDatabaseApi : IDatabaseApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIDatabaseApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<HttpContent> GetAsync(string database_code,DownloadType? download_type,string api_key)
        {
            var arguments = new object[] { database_code,download_type,api_key };
            return (Task<HttpContent>) methodImpls["GetAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetMetadataAsync(string database_code,ReturnFormat return_format,string api_key)
        {
            var arguments = new object[] { database_code,return_format,api_key };
            return (Task<HttpContent>) methodImpls["GetMetadataAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetListAsync(ReturnFormat return_format,string query,int? per_page,int? page,string api_key)
        {
            var arguments = new object[] { return_format,query,per_page,page,api_key };
            return (Task<HttpContent>) methodImpls["GetListAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetDatasetListAsync(string database_code,string api_key)
        {
            var arguments = new object[] { database_code,api_key };
            return (Task<HttpContent>) methodImpls["GetDatasetListAsync"](Client, arguments);
        }

    }
}

namespace Quandl.NET.Refit
{
    using RefitInternalGenerated;

    [Preserve]
    partial class AutoGeneratedIDatatableApi : IDatatableApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIDatatableApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<HttpContent> GetAsync(string datatable_code,ReturnFormat format,Dictionary<string, string> rowFilter,string columnFilter,string api_key)
        {
            var arguments = new object[] { datatable_code,format,rowFilter,columnFilter,api_key };
            return (Task<HttpContent>) methodImpls["GetAsync"](Client, arguments);
        }

    }
}

namespace Quandl.NET.Refit
{
    using RefitInternalGenerated;

    [Preserve]
    partial class AutoGeneratedIDatasetApi : IDatasetApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIDatasetApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<HttpContent> GetAsync(string database_code,string dataset_code,ReturnFormat return_format,string api_key)
        {
            var arguments = new object[] { database_code,dataset_code,return_format,api_key };
            return (Task<HttpContent>) methodImpls["GetAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetMetadataAsync(string database_code,string dataset_code,ReturnFormat return_format,string api_key)
        {
            var arguments = new object[] { database_code,dataset_code,return_format,api_key };
            return (Task<HttpContent>) methodImpls["GetMetadataAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetDataAndMetadataAsync(string database_code,string dataset_code,ReturnFormat return_format,int? limit,int? column_index,DateTime? start_date,DateTime? end_date,Order? order,Collapse? collapse,Transform? transform,string api_key)
        {
            var arguments = new object[] { database_code,dataset_code,return_format,limit,column_index,start_date,end_date,order,collapse,transform,api_key };
            return (Task<HttpContent>) methodImpls["GetDataAndMetadataAsync"](Client, arguments);
        }

        public virtual Task<HttpContent> GetListAsync(ReturnFormat return_format,string query,string database_code,int? per_page,int? page,string api_key)
        {
            var arguments = new object[] { return_format,query,database_code,per_page,page,api_key };
            return (Task<HttpContent>) methodImpls["GetListAsync"](Client, arguments);
        }

    }
}