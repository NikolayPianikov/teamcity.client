# TeamCity.Api.TestOccurrenceApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTestOccurrences**](TestOccurrenceApi.md#gettestoccurrences) | **GET** /app/rest/testOccurrences | 
[**ServeInstance4**](TestOccurrenceApi.md#serveinstance4) | **GET** /app/rest/testOccurrences/{testLocator} | 


<a name="gettestoccurrences"></a>
# **GetTestOccurrences**
> TestOccurrencesDto GetTestOccurrences (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTestOccurrencesExample
    {
        public void main()
        {
            var apiInstance = new TestOccurrenceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TestOccurrencesDto result = apiInstance.GetTestOccurrences(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestOccurrenceApi.GetTestOccurrences: " + e.Message );
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

[**TestOccurrencesDto**](TestOccurrencesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance4"></a>
# **ServeInstance4**
> TestOccurrenceDto ServeInstance4 (string testLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance4Example
    {
        public void main()
        {
            var apiInstance = new TestOccurrenceApi();
            var testLocator = testLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TestOccurrenceDto result = apiInstance.ServeInstance4(testLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestOccurrenceApi.ServeInstance4: " + e.Message );
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

[**TestOccurrenceDto**](TestOccurrenceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

