# TeamCity.Api.RootApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServeApiVersion**](RootApi.md#serveapiversion) | **GET** /app/rest/apiVersion | 
[**ServePluginInfo**](RootApi.md#serveplugininfo) | **GET** /app/rest/info | 
[**ServeRoot**](RootApi.md#serveroot) | **GET** /app/rest | 
[**ServeVersion**](RootApi.md#serveversion) | **GET** /app/rest/version | 


<a name="serveapiversion"></a>
# **ServeApiVersion**
> string ServeApiVersion ()



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeApiVersionExample
    {
        public void main()
        {
            var apiInstance = new RootApi();

            try
            {
                string result = apiInstance.ServeApiVersion();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootApi.ServeApiVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveplugininfo"></a>
# **ServePluginInfo**
> PluginDto ServePluginInfo (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServePluginInfoExample
    {
        public void main()
        {
            var apiInstance = new RootApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PluginDto result = apiInstance.ServePluginInfo(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootApi.ServePluginInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**|  | [optional] 

### Return type

[**PluginDto**](PluginDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveroot"></a>
# **ServeRoot**
> string ServeRoot ()



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootExample
    {
        public void main()
        {
            var apiInstance = new RootApi();

            try
            {
                string result = apiInstance.ServeRoot();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootApi.ServeRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveversion"></a>
# **ServeVersion**
> string ServeVersion ()



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeVersionExample
    {
        public void main()
        {
            var apiInstance = new RootApi();

            try
            {
                string result = apiInstance.ServeVersion();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootApi.ServeVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

