# TeamCity.Api.MuteApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstance1**](MuteApi.md#createinstance1) | **POST** /app/rest/mutes | 
[**CreateInstances1**](MuteApi.md#createinstances1) | **POST** /app/rest/mutes/multiple | 
[**DeleteInstance1**](MuteApi.md#deleteinstance1) | **DELETE** /app/rest/mutes/{muteLocator} | 
[**GetMutes**](MuteApi.md#getmutes) | **GET** /app/rest/mutes | 
[**ServeInstance1**](MuteApi.md#serveinstance1) | **GET** /app/rest/mutes/{muteLocator} | 


<a name="createinstance1"></a>
# **CreateInstance1**
> MuteDto CreateInstance1 (MuteDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateInstance1Example
    {
        public void main()
        {
            var apiInstance = new MuteApi();
            var body = new MuteDto(); // MuteDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MuteDto result = apiInstance.CreateInstance1(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MuteApi.CreateInstance1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MuteDto**](MuteDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MuteDto**](MuteDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinstances1"></a>
# **CreateInstances1**
> MutesDto CreateInstances1 (MutesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateInstances1Example
    {
        public void main()
        {
            var apiInstance = new MuteApi();
            var body = new MutesDto(); // MutesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MutesDto result = apiInstance.CreateInstances1(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MuteApi.CreateInstances1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MutesDto**](MutesDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MutesDto**](MutesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstance1"></a>
# **DeleteInstance1**
> void DeleteInstance1 (string muteLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteInstance1Example
    {
        public void main()
        {
            var apiInstance = new MuteApi();
            var muteLocator = muteLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                apiInstance.DeleteInstance1(muteLocator, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MuteApi.DeleteInstance1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **muteLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmutes"></a>
# **GetMutes**
> MutesDto GetMutes (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMutesExample
    {
        public void main()
        {
            var apiInstance = new MuteApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MutesDto result = apiInstance.GetMutes(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MuteApi.GetMutes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MutesDto**](MutesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance1"></a>
# **ServeInstance1**
> MuteDto ServeInstance1 (string muteLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance1Example
    {
        public void main()
        {
            var apiInstance = new MuteApi();
            var muteLocator = muteLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MuteDto result = apiInstance.ServeInstance1(muteLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MuteApi.ServeInstance1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **muteLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**MuteDto**](MuteDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

