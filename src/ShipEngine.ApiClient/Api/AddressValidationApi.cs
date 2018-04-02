/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressValidationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>List&lt;AddressValidationResponseDTO&gt;</returns>
        List<AddressValidationResponseDTO> AddressValidationValidateAddresses (List<AddressDTO> addresses, string apiKey);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of List&lt;AddressValidationResponseDTO&gt;</returns>
        ApiResponse<List<AddressValidationResponseDTO>> AddressValidationValidateAddressesWithHttpInfo (List<AddressDTO> addresses, string apiKey);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of List&lt;AddressValidationResponseDTO&gt;</returns>
        System.Threading.Tasks.Task<List<AddressValidationResponseDTO>> AddressValidationValidateAddressesAsync (List<AddressDTO> addresses, string apiKey);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (List&lt;AddressValidationResponseDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AddressValidationResponseDTO>>> AddressValidationValidateAddressesAsyncWithHttpInfo (List<AddressDTO> addresses, string apiKey);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressValidationApi : IAddressValidationApi
    {
        private ShipEngine.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressValidationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressValidationApi(String basePath)
        {
            this.Configuration = new ShipEngine.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ShipEngine.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressValidationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressValidationApi(ShipEngine.ApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ShipEngine.ApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ShipEngine.ApiClient.Client.Configuration.DefaultExceptionFactory;
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
        public ShipEngine.ApiClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ShipEngine.ApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>List&lt;AddressValidationResponseDTO&gt;</returns>
        public List<AddressValidationResponseDTO> AddressValidationValidateAddresses (List<AddressDTO> addresses, string apiKey)
        {
             ApiResponse<List<AddressValidationResponseDTO>> localVarResponse = AddressValidationValidateAddressesWithHttpInfo(addresses, apiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of List&lt;AddressValidationResponseDTO&gt;</returns>
        public ApiResponse< List<AddressValidationResponseDTO> > AddressValidationValidateAddressesWithHttpInfo (List<AddressDTO> addresses, string apiKey)
        {
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling AddressValidationApi->AddressValidationValidateAddresses");
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling AddressValidationApi->AddressValidationValidateAddresses");

            var localVarPath = "/v1/addresses/validate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarHeaderParams.Add("api-key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            if (addresses != null && addresses.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(addresses); // http body (model) parameter
            }
            else
            {
                localVarPostBody = addresses; // byte array
            }

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressValidationValidateAddresses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AddressValidationResponseDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<AddressValidationResponseDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AddressValidationResponseDTO>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of List&lt;AddressValidationResponseDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<AddressValidationResponseDTO>> AddressValidationValidateAddressesAsync (List<AddressDTO> addresses, string apiKey)
        {
             ApiResponse<List<AddressValidationResponseDTO>> localVarResponse = await AddressValidationValidateAddressesAsyncWithHttpInfo(addresses, apiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (List&lt;AddressValidationResponseDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AddressValidationResponseDTO>>> AddressValidationValidateAddressesAsyncWithHttpInfo (List<AddressDTO> addresses, string apiKey)
        {
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling AddressValidationApi->AddressValidationValidateAddresses");
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling AddressValidationApi->AddressValidationValidateAddresses");

            var localVarPath = "/v1/addresses/validate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarHeaderParams.Add("api-key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            if (addresses != null && addresses.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(addresses); // http body (model) parameter
            }
            else
            {
                localVarPostBody = addresses; // byte array
            }

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddressValidationValidateAddresses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AddressValidationResponseDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<AddressValidationResponseDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AddressValidationResponseDTO>)));
        }

    }
}
