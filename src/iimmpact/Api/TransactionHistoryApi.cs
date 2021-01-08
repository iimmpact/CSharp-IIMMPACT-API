/* 
 * IIMMPACT API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2020-09-14T13:01:14Z
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using iimmpact.Client;
using iimmpact.Model;

namespace iimmpact.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionHistoryApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>BalanceStatementResponse</returns>
        BalanceStatementResponse V1BalanceStatementGet (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>ApiResponse of BalanceStatementResponse</returns>
        ApiResponse<BalanceStatementResponse> V1BalanceStatementGetWithHttpInfo (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>TransactionsResponse</returns>
        TransactionsResponse V1TransactionsGet (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>ApiResponse of TransactionsResponse</returns>
        ApiResponse<TransactionsResponse> V1TransactionsGetWithHttpInfo (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>Task of BalanceStatementResponse</returns>
        System.Threading.Tasks.Task<BalanceStatementResponse> V1BalanceStatementGetAsync (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>Task of ApiResponse (BalanceStatementResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BalanceStatementResponse>> V1BalanceStatementGetAsyncWithHttpInfo (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>Task of TransactionsResponse</returns>
        System.Threading.Tasks.Task<TransactionsResponse> V1TransactionsGetAsync (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>Task of ApiResponse (TransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionsResponse>> V1TransactionsGetAsyncWithHttpInfo (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionHistoryApi : ITransactionHistoryApi
    {
        private iimmpact.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionHistoryApi(String basePath)
        {
            this.Configuration = new iimmpact.Client.Configuration { BasePath = basePath };

            ExceptionFactory = iimmpact.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionHistoryApi(iimmpact.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = iimmpact.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = iimmpact.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public iimmpact.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public iimmpact.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>BalanceStatementResponse</returns>
        public BalanceStatementResponse V1BalanceStatementGet (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null)
        {
             ApiResponse<BalanceStatementResponse> localVarResponse = V1BalanceStatementGetWithHttpInfo(date, limit, remarks, sort, type, direction, page, amount);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>ApiResponse of BalanceStatementResponse</returns>
        public ApiResponse< BalanceStatementResponse > V1BalanceStatementGetWithHttpInfo (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null)
        {
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling TransactionHistoryApi->V1BalanceStatementGet");

            var localVarPath = "/v1/balance-statement";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (remarks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "remarks", remarks)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (date != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter

            // authentication (SSO) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1BalanceStatementGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceStatementResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BalanceStatementResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceStatementResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>Task of BalanceStatementResponse</returns>
        public async System.Threading.Tasks.Task<BalanceStatementResponse> V1BalanceStatementGetAsync (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null)
        {
             ApiResponse<BalanceStatementResponse> localVarResponse = await V1BalanceStatementGetAsyncWithHttpInfo(date, limit, remarks, sort, type, direction, page, amount);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="remarks"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="amount"> (optional)</param>
        /// <returns>Task of ApiResponse (BalanceStatementResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BalanceStatementResponse>> V1BalanceStatementGetAsyncWithHttpInfo (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null)
        {
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling TransactionHistoryApi->V1BalanceStatementGet");

            var localVarPath = "/v1/balance-statement";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (remarks != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "remarks", remarks)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (date != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter

            // authentication (SSO) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1BalanceStatementGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceStatementResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BalanceStatementResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceStatementResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>TransactionsResponse</returns>
        public TransactionsResponse V1TransactionsGet (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null)
        {
             ApiResponse<TransactionsResponse> localVarResponse = V1TransactionsGetWithHttpInfo(date, refid, limit, sort, offset, direction, status, account, acceptEncoding, sn, product);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>ApiResponse of TransactionsResponse</returns>
        public ApiResponse< TransactionsResponse > V1TransactionsGetWithHttpInfo (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null)
        {
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling TransactionHistoryApi->V1TransactionsGet");

            var localVarPath = "/v1/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (refid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "refid", refid)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (date != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (account != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "account", account)); // query parameter
            if (sn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sn", sn)); // query parameter
            if (product != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product", product)); // query parameter
            if (acceptEncoding != null) localVarHeaderParams.Add("Accept-Encoding", this.Configuration.ApiClient.ParameterToString(acceptEncoding)); // header parameter

            // authentication (SSO) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TransactionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>Task of TransactionsResponse</returns>
        public async System.Threading.Tasks.Task<TransactionsResponse> V1TransactionsGetAsync (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null)
        {
             ApiResponse<TransactionsResponse> localVarResponse = await V1TransactionsGetAsyncWithHttpInfo(date, refid, limit, sort, offset, direction, status, account, acceptEncoding, sn, product);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="iimmpact.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date"></param>
        /// <param name="refid"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="offset"> (optional)</param>
        /// <param name="direction"> (optional)</param>
        /// <param name="status"> (optional)</param>
        /// <param name="account"> (optional)</param>
        /// <param name="acceptEncoding"> (optional)</param>
        /// <param name="sn"> (optional)</param>
        /// <param name="product"> (optional)</param>
        /// <returns>Task of ApiResponse (TransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionsResponse>> V1TransactionsGetAsyncWithHttpInfo (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null)
        {
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling TransactionHistoryApi->V1TransactionsGet");

            var localVarPath = "/v1/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (refid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "refid", refid)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (date != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (account != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "account", account)); // query parameter
            if (sn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sn", sn)); // query parameter
            if (product != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product", product)); // query parameter
            if (acceptEncoding != null) localVarHeaderParams.Add("Accept-Encoding", this.Configuration.ApiClient.ParameterToString(acceptEncoding)); // header parameter

            // authentication (SSO) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TransactionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionsResponse)));
        }

    }
}
