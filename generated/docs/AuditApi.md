# TeamCity.Api.AuditApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](AuditApi.md#get) | **GET** /app/rest/audit | 
[**GetSingle**](AuditApi.md#getsingle) | **GET** /app/rest/audit/{auditEventLocator} | 


<a name="get"></a>
# **Get**
> AuditEventsDto Get (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new AuditApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AuditEventsDto result = apiInstance.Get(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.Get: " + e.Message );
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

[**AuditEventsDto**](AuditEventsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsingle"></a>
# **GetSingle**
> AuditEventDto GetSingle (string auditEventLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSingleExample
    {
        public void main()
        {
            var apiInstance = new AuditApi();
            var auditEventLocator = auditEventLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AuditEventDto result = apiInstance.GetSingle(auditEventLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.GetSingle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **auditEventLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AuditEventDto**](AuditEventDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

