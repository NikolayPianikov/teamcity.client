# TeamCity.Api.CloudInstanceApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServeImage**](CloudInstanceApi.md#serveimage) | **GET** /app/rest/cloud/images/{imageLocator} | 
[**ServeImages**](CloudInstanceApi.md#serveimages) | **GET** /app/rest/cloud/images | 
[**ServeInstance**](CloudInstanceApi.md#serveinstance) | **GET** /app/rest/cloud/instances/{instanceLocator} | 
[**ServeInstances**](CloudInstanceApi.md#serveinstances) | **GET** /app/rest/cloud/instances | 
[**ServeProfile**](CloudInstanceApi.md#serveprofile) | **GET** /app/rest/cloud/profiles/{profileLocator} | 
[**ServeProfiles**](CloudInstanceApi.md#serveprofiles) | **GET** /app/rest/cloud/profiles | 
[**StartInstance**](CloudInstanceApi.md#startinstance) | **POST** /app/rest/cloud/instances | 
[**StopInstance**](CloudInstanceApi.md#stopinstance) | **DELETE** /app/rest/cloud/instances/{instanceLocator} | 


<a name="serveimage"></a>
# **ServeImage**
> CloudImageDto ServeImage (string imageLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeImageExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var imageLocator = imageLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudImageDto result = apiInstance.ServeImage(imageLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CloudImageDto**](CloudImageDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveimages"></a>
# **ServeImages**
> CloudImagesDto ServeImages (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeImagesExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudImagesDto result = apiInstance.ServeImages(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeImages: " + e.Message );
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

[**CloudImagesDto**](CloudImagesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance"></a>
# **ServeInstance**
> CloudInstanceDto ServeInstance (string instanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstanceExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var instanceLocator = instanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudInstanceDto result = apiInstance.ServeInstance(instanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CloudInstanceDto**](CloudInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstances"></a>
# **ServeInstances**
> CloudInstancesDto ServeInstances (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstancesExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudInstancesDto result = apiInstance.ServeInstances(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeInstances: " + e.Message );
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

[**CloudInstancesDto**](CloudInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveprofile"></a>
# **ServeProfile**
> CloudProfileDto ServeProfile (string profileLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeProfileExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var profileLocator = profileLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudProfileDto result = apiInstance.ServeProfile(profileLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CloudProfileDto**](CloudProfileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveprofiles"></a>
# **ServeProfiles**
> CloudProfilesDto ServeProfiles (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeProfilesExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CloudProfilesDto result = apiInstance.ServeProfiles(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.ServeProfiles: " + e.Message );
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

[**CloudProfilesDto**](CloudProfilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startinstance"></a>
# **StartInstance**
> void StartInstance (CloudInstanceDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class StartInstanceExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var body = new CloudInstanceDto(); // CloudInstanceDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                apiInstance.StartInstance(body, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.StartInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloudInstanceDto**](CloudInstanceDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopinstance"></a>
# **StopInstance**
> void StopInstance (string instanceLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class StopInstanceExample
    {
        public void main()
        {
            var apiInstance = new CloudInstanceApi();
            var instanceLocator = instanceLocator_example;  // string | 

            try
            {
                apiInstance.StopInstance(instanceLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudInstanceApi.StopInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

