# TeamCity.Api.TestApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTests1**](TestApi.md#gettests1) | **GET** /app/rest/tests | 
[**ServeInstance5**](TestApi.md#serveinstance5) | **GET** /app/rest/tests/{testLocator} | 


<a name="gettests1"></a>
# **GetTests1**
> TestsDto GetTests1 (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTests1Example
    {
        public void main()
        {
            var apiInstance = new TestApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TestsDto result = apiInstance.GetTests1(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.GetTests1: " + e.Message );
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

[**TestsDto**](TestsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance5"></a>
# **ServeInstance5**
> TestDto ServeInstance5 (string testLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance5Example
    {
        public void main()
        {
            var apiInstance = new TestApi();
            var testLocator = testLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TestDto result = apiInstance.ServeInstance5(testLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestApi.ServeInstance5: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TestDto**](TestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

