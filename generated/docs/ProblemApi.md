# TeamCity.Api.ProblemApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProblems2**](ProblemApi.md#getproblems2) | **GET** /app/rest/problems | 
[**ServeInstance3**](ProblemApi.md#serveinstance3) | **GET** /app/rest/problems/{problemLocator} | 


<a name="getproblems2"></a>
# **GetProblems2**
> ProblemsDto GetProblems2 (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetProblems2Example
    {
        public void main()
        {
            var apiInstance = new ProblemApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemsDto result = apiInstance.GetProblems2(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProblemApi.GetProblems2: " + e.Message );
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

[**ProblemsDto**](ProblemsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance3"></a>
# **ServeInstance3**
> ProblemDto ServeInstance3 (string problemLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance3Example
    {
        public void main()
        {
            var apiInstance = new ProblemApi();
            var problemLocator = problemLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemDto result = apiInstance.ServeInstance3(problemLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProblemApi.ServeInstance3: " + e.Message );
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

[**ProblemDto**](ProblemDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

