# TeamCity.Api.VcsRootApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRoot**](VcsRootApi.md#addroot) | **POST** /app/rest/vcs-roots | 
[**ChangeProperties**](VcsRootApi.md#changeproperties) | **PUT** /app/rest/vcs-roots/{vcsRootLocator}/properties | 
[**DeleteAllProperties**](VcsRootApi.md#deleteallproperties) | **DELETE** /app/rest/vcs-roots/{vcsRootLocator}/properties | 
[**DeleteParameter2**](VcsRootApi.md#deleteparameter2) | **DELETE** /app/rest/vcs-roots/{vcsRootLocator}/properties/{name} | 
[**DeleteRoot**](VcsRootApi.md#deleteroot) | **DELETE** /app/rest/vcs-roots/{vcsRootLocator} | 
[**GetSettingsFile2**](VcsRootApi.md#getsettingsfile2) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/settingsFile | 
[**PutParameter**](VcsRootApi.md#putparameter) | **PUT** /app/rest/vcs-roots/{vcsRootLocator}/properties/{name} | 
[**ServeField**](VcsRootApi.md#servefield) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/{field} | 
[**ServeInstanceField1**](VcsRootApi.md#serveinstancefield1) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/instances/{vcsRootInstanceLocator}/{field} | 
[**ServeProperties**](VcsRootApi.md#serveproperties) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/properties | 
[**ServeProperty**](VcsRootApi.md#serveproperty) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/properties/{name} | 
[**ServeRoot1**](VcsRootApi.md#serveroot1) | **GET** /app/rest/vcs-roots/{vcsRootLocator} | 
[**ServeRootInstance**](VcsRootApi.md#serverootinstance) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/instances/{vcsRootInstanceLocator} | 
[**ServeRootInstanceProperties1**](VcsRootApi.md#serverootinstanceproperties1) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/instances/{vcsRootInstanceLocator}/properties | 
[**ServeRootInstances**](VcsRootApi.md#serverootinstances) | **GET** /app/rest/vcs-roots/{vcsRootLocator}/instances | 
[**ServeRoots**](VcsRootApi.md#serveroots) | **GET** /app/rest/vcs-roots | 
[**SetField1**](VcsRootApi.md#setfield1) | **PUT** /app/rest/vcs-roots/{vcsRootLocator}/{field} | 
[**SetInstanceField1**](VcsRootApi.md#setinstancefield1) | **PUT** /app/rest/vcs-roots/{vcsRootLocator}/instances/{vcsRootInstanceLocator}/{field} | 


<a name="addroot"></a>
# **AddRoot**
> VcsRootDto AddRoot (VcsRootDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddRootExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var body = new VcsRootDto(); // VcsRootDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootDto result = apiInstance.AddRoot(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.AddRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VcsRootDto**](VcsRootDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootDto**](VcsRootDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeproperties"></a>
# **ChangeProperties**
> PropertiesDto ChangeProperties (string vcsRootLocator, PropertiesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangePropertiesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var body = new PropertiesDto(); // PropertiesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ChangeProperties(vcsRootLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ChangeProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **body** | [**PropertiesDto**](PropertiesDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallproperties"></a>
# **DeleteAllProperties**
> void DeleteAllProperties (string vcsRootLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteAllPropertiesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 

            try
            {
                apiInstance.DeleteAllProperties(vcsRootLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.DeleteAllProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparameter2"></a>
# **DeleteParameter2**
> void DeleteParameter2 (string vcsRootLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteParameter2Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                apiInstance.DeleteParameter2(vcsRootLocator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.DeleteParameter2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroot"></a>
# **DeleteRoot**
> void DeleteRoot (string vcsRootLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteRootExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 

            try
            {
                apiInstance.DeleteRoot(vcsRootLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.DeleteRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettingsfile2"></a>
# **GetSettingsFile2**
> string GetSettingsFile2 (string vcsRootLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSettingsFile2Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetSettingsFile2(vcsRootLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.GetSettingsFile2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putparameter"></a>
# **PutParameter**
> string PutParameter (string vcsRootLocator, string name, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class PutParameterExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var name = name_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.PutParameter(vcsRootLocator, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.PutParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **name** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servefield"></a>
# **ServeField**
> string ServeField (string vcsRootLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeFieldExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeField(vcsRootLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstancefield1"></a>
# **ServeInstanceField1**
> string ServeInstanceField1 (string vcsRootLocator, string vcsRootInstanceLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstanceField1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeInstanceField1(vcsRootLocator, vcsRootInstanceLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeInstanceField1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveproperties"></a>
# **ServeProperties**
> PropertiesDto ServeProperties (string vcsRootLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServePropertiesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeProperties(vcsRootLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveproperty"></a>
# **ServeProperty**
> string ServeProperty (string vcsRootLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServePropertyExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                string result = apiInstance.ServeProperty(vcsRootLocator, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveroot1"></a>
# **ServeRoot1**
> VcsRootDto ServeRoot1 (string vcsRootLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRoot1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootDto result = apiInstance.ServeRoot1(vcsRootLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeRoot1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootDto**](VcsRootDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverootinstance"></a>
# **ServeRootInstance**
> VcsRootInstanceDto ServeRootInstance (string vcsRootLocator, string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootInstanceExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstanceDto result = apiInstance.ServeRootInstance(vcsRootLocator, vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeRootInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstanceDto**](VcsRootInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverootinstanceproperties1"></a>
# **ServeRootInstanceProperties1**
> PropertiesDto ServeRootInstanceProperties1 (string vcsRootLocator, string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootInstanceProperties1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeRootInstanceProperties1(vcsRootLocator, vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeRootInstanceProperties1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverootinstances"></a>
# **ServeRootInstances**
> VcsRootInstancesDto ServeRootInstances (string vcsRootLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootInstancesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstancesDto result = apiInstance.ServeRootInstances(vcsRootLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeRootInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstancesDto**](VcsRootInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveroots"></a>
# **ServeRoots**
> VcsRootsDto ServeRoots (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootsExample
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootsDto result = apiInstance.ServeRoots(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.ServeRoots: " + e.Message );
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

[**VcsRootsDto**](VcsRootsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfield1"></a>
# **SetField1**
> string SetField1 (string vcsRootLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetField1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetField1(vcsRootLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.SetField1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **field** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setinstancefield1"></a>
# **SetInstanceField1**
> string SetInstanceField1 (string vcsRootLocator, string vcsRootInstanceLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetInstanceField1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootApi();
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetInstanceField1(vcsRootLocator, vcsRootInstanceLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootApi.SetInstanceField1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootLocator** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **field** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

