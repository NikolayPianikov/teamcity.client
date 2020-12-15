/* 
 * TeamCity REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2018.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using TeamCity.Client;
using TeamCity.Model;

namespace TeamCity.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>AuditEventsDto</returns>
        AuditEventsDto Get (string locator = null, string fields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>ApiResponse of AuditEventsDto</returns>
        ApiResponse<AuditEventsDto> GetWithHttpInfo (string locator = null, string fields = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>AuditEventDto</returns>
        AuditEventDto GetSingle (string auditEventLocator, string fields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>ApiResponse of AuditEventDto</returns>
        ApiResponse<AuditEventDto> GetSingleWithHttpInfo (string auditEventLocator, string fields = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of AuditEventsDto</returns>
        System.Threading.Tasks.Task<AuditEventsDto> GetAsync (string locator = null, string fields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of ApiResponse (AuditEventsDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditEventsDto>> GetAsyncWithHttpInfo (string locator = null, string fields = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of AuditEventDto</returns>
        System.Threading.Tasks.Task<AuditEventDto> GetSingleAsync (string auditEventLocator, string fields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of ApiResponse (AuditEventDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditEventDto>> GetSingleAsyncWithHttpInfo (string auditEventLocator, string fields = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditApi : IAuditApi
    {
        private TeamCity.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditApi(String basePath)
        {
            this.Configuration = new TeamCity.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TeamCity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditApi(TeamCity.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TeamCity.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TeamCity.Client.Configuration.DefaultExceptionFactory;
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
        public TeamCity.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TeamCity.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>AuditEventsDto</returns>
        public AuditEventsDto Get (string locator = null, string fields = null)
        {
             ApiResponse<AuditEventsDto> localVarResponse = GetWithHttpInfo(locator, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>ApiResponse of AuditEventsDto</returns>
        public ApiResponse< AuditEventsDto > GetWithHttpInfo (string locator = null, string fields = null)
        {

            var localVarPath = "/app/rest/audit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locator != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "locator", locator)); // query parameter
            if (fields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fields", fields)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuditEventsDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditEventsDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditEventsDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of AuditEventsDto</returns>
        public async System.Threading.Tasks.Task<AuditEventsDto> GetAsync (string locator = null, string fields = null)
        {
             ApiResponse<AuditEventsDto> localVarResponse = await GetAsyncWithHttpInfo(locator, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locator"> (optional)</param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of ApiResponse (AuditEventsDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditEventsDto>> GetAsyncWithHttpInfo (string locator = null, string fields = null)
        {

            var localVarPath = "/app/rest/audit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locator != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "locator", locator)); // query parameter
            if (fields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fields", fields)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuditEventsDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditEventsDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditEventsDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>AuditEventDto</returns>
        public AuditEventDto GetSingle (string auditEventLocator, string fields = null)
        {
             ApiResponse<AuditEventDto> localVarResponse = GetSingleWithHttpInfo(auditEventLocator, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>ApiResponse of AuditEventDto</returns>
        public ApiResponse< AuditEventDto > GetSingleWithHttpInfo (string auditEventLocator, string fields = null)
        {
            // verify the required parameter 'auditEventLocator' is set
            if (auditEventLocator == null)
                throw new ApiException(400, "Missing required parameter 'auditEventLocator' when calling AuditApi->GetSingle");

            var localVarPath = "/app/rest/audit/{auditEventLocator}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (auditEventLocator != null) localVarPathParams.Add("auditEventLocator", this.Configuration.ApiClient.ParameterToString(auditEventLocator)); // path parameter
            if (fields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fields", fields)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSingle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuditEventDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditEventDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditEventDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of AuditEventDto</returns>
        public async System.Threading.Tasks.Task<AuditEventDto> GetSingleAsync (string auditEventLocator, string fields = null)
        {
             ApiResponse<AuditEventDto> localVarResponse = await GetSingleAsyncWithHttpInfo(auditEventLocator, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TeamCity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auditEventLocator"></param>
        /// <param name="fields"> (optional)</param>
        /// <returns>Task of ApiResponse (AuditEventDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditEventDto>> GetSingleAsyncWithHttpInfo (string auditEventLocator, string fields = null)
        {
            // verify the required parameter 'auditEventLocator' is set
            if (auditEventLocator == null)
                throw new ApiException(400, "Missing required parameter 'auditEventLocator' when calling AuditApi->GetSingle");

            var localVarPath = "/app/rest/audit/{auditEventLocator}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (auditEventLocator != null) localVarPathParams.Add("auditEventLocator", this.Configuration.ApiClient.ParameterToString(auditEventLocator)); // path parameter
            if (fields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fields", fields)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSingle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuditEventDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditEventDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditEventDto)));
        }

    }
}
