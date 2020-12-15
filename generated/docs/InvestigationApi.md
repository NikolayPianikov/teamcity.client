# TeamCity.Api.InvestigationApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstance**](InvestigationApi.md#createinstance) | **POST** /app/rest/investigations | 
[**CreateInstances**](InvestigationApi.md#createinstances) | **POST** /app/rest/investigations/multiple | 
[**DeleteInstance**](InvestigationApi.md#deleteinstance) | **DELETE** /app/rest/investigations/{investigationLocator} | 
[**GetInvestigations1**](InvestigationApi.md#getinvestigations1) | **GET** /app/rest/investigations | 
[**ReplaceInstance**](InvestigationApi.md#replaceinstance) | **PUT** /app/rest/investigations/{investigationLocator} | 
[**ServeInvestigationInstance**](InvestigationApi.md#serveinvestigationinstance) | **GET** /app/rest/investigations/{investigationLocator} | 


<a name="createinstance"></a>
# **CreateInstance**
> InvestigationDto CreateInstance (InvestigationDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateInstanceExample
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var body = new InvestigationDto(); // InvestigationDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationDto result = apiInstance.CreateInstance(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.CreateInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvestigationDto**](InvestigationDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**InvestigationDto**](InvestigationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinstances"></a>
# **CreateInstances**
> InvestigationsDto CreateInstances (InvestigationsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateInstancesExample
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var body = new InvestigationsDto(); // InvestigationsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationsDto result = apiInstance.CreateInstances(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.CreateInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InvestigationsDto**](InvestigationsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**InvestigationsDto**](InvestigationsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstance"></a>
# **DeleteInstance**
> void DeleteInstance (string investigationLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteInstanceExample
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var investigationLocator = investigationLocator_example;  // string | 

            try
            {
                apiInstance.DeleteInstance(investigationLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.DeleteInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investigationLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvestigations1"></a>
# **GetInvestigations1**
> InvestigationsDto GetInvestigations1 (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetInvestigations1Example
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationsDto result = apiInstance.GetInvestigations1(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.GetInvestigations1: " + e.Message );
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

[**InvestigationsDto**](InvestigationsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceinstance"></a>
# **ReplaceInstance**
> InvestigationDto ReplaceInstance (string investigationLocator, InvestigationDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceInstanceExample
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var investigationLocator = investigationLocator_example;  // string | 
            var body = new InvestigationDto(); // InvestigationDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationDto result = apiInstance.ReplaceInstance(investigationLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.ReplaceInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investigationLocator** | **string**|  | 
 **body** | [**InvestigationDto**](InvestigationDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**InvestigationDto**](InvestigationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinvestigationinstance"></a>
# **ServeInvestigationInstance**
> InvestigationDto ServeInvestigationInstance (string investigationLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInvestigationInstanceExample
    {
        public void main()
        {
            var apiInstance = new InvestigationApi();
            var investigationLocator = investigationLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationDto result = apiInstance.ServeInvestigationInstance(investigationLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvestigationApi.ServeInvestigationInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **investigationLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**InvestigationDto**](InvestigationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

