# TeamCity.Api.ProblemOccurrenceApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProblems1**](ProblemOccurrenceApi.md#getproblems1) | **GET** /app/rest/problemOccurrences | 
[**ServeInstance2**](ProblemOccurrenceApi.md#serveinstance2) | **GET** /app/rest/problemOccurrences/{problemLocator} | 


<a name="getproblems1"></a>
# **GetProblems1**
> ProblemOccurrencesDto GetProblems1 (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetProblems1Example
    {
        public void main()
        {
            var apiInstance = new ProblemOccurrenceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemOccurrencesDto result = apiInstance.GetProblems1(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProblemOccurrenceApi.GetProblems1: " + e.Message );
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

[**ProblemOccurrencesDto**](ProblemOccurrencesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance2"></a>
# **ServeInstance2**
> ProblemOccurrenceDto ServeInstance2 (string problemLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance2Example
    {
        public void main()
        {
            var apiInstance = new ProblemOccurrenceApi();
            var problemLocator = problemLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemOccurrenceDto result = apiInstance.ServeInstance2(problemLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProblemOccurrenceApi.ServeInstance2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **problemLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProblemOccurrenceDto**](ProblemOccurrenceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

