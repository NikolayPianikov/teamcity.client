# TeamCity.Api.BuildQueueApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTags**](BuildQueueApi.md#addtags) | **POST** /app/rest/buildQueue/{buildLocator}/tags | 
[**CancelBuild**](BuildQueueApi.md#cancelbuild) | **POST** /app/rest/buildQueue/{queuedBuildLocator} | 
[**DeleteBuildsExperimental**](BuildQueueApi.md#deletebuildsexperimental) | **DELETE** /app/rest/buildQueue | 
[**DeleteQueuedBuild**](BuildQueueApi.md#deletequeuedbuild) | **DELETE** /app/rest/buildQueue/{queuedBuildLocator} | 
[**GetBuild**](BuildQueueApi.md#getbuild) | **GET** /app/rest/buildQueue/{queuedBuildLocator} | 
[**GetBuildQueuePosition**](BuildQueueApi.md#getbuildqueueposition) | **GET** /app/rest/buildQueue/order/{queuePosition} | 
[**GetBuilds**](BuildQueueApi.md#getbuilds) | **GET** /app/rest/buildQueue | 
[**QueueNewBuild**](BuildQueueApi.md#queuenewbuild) | **POST** /app/rest/buildQueue | 
[**ReplaceBuilds**](BuildQueueApi.md#replacebuilds) | **PUT** /app/rest/buildQueue | 
[**ReplaceTags**](BuildQueueApi.md#replacetags) | **PUT** /app/rest/buildQueue/{buildLocator}/tags | 
[**ServeBuildFieldByBuildOnly**](BuildQueueApi.md#servebuildfieldbybuildonly) | **GET** /app/rest/buildQueue/{buildLocator}/{field} | 
[**ServeCompatibleAgents**](BuildQueueApi.md#servecompatibleagents) | **GET** /app/rest/buildQueue/{queuedBuildLocator}/compatibleAgents | 
[**ServeTags**](BuildQueueApi.md#servetags) | **GET** /app/rest/buildQueue/{buildLocator}/tags | 
[**SetBuildQueueOrder**](BuildQueueApi.md#setbuildqueueorder) | **PUT** /app/rest/buildQueue/order | 
[**SetBuildQueuePosition**](BuildQueueApi.md#setbuildqueueposition) | **PUT** /app/rest/buildQueue/order/{queuePosition} | 


<a name="addtags"></a>
# **AddTags**
> void AddTags (string buildLocator, TagsDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddTagsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new TagsDto(); // TagsDto |  (optional) 

            try
            {
                apiInstance.AddTags(buildLocator, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.AddTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | [**TagsDto**](TagsDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbuild"></a>
# **CancelBuild**
> BuildDto CancelBuild (string queuedBuildLocator, BuildCancelRequestDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CancelBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuedBuildLocator = queuedBuildLocator_example;  // string | 
            var body = new BuildCancelRequestDto(); // BuildCancelRequestDto |  (optional) 

            try
            {
                BuildDto result = apiInstance.CancelBuild(queuedBuildLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.CancelBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuedBuildLocator** | **string**|  | 
 **body** | [**BuildCancelRequestDto**](BuildCancelRequestDto.md)|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuildsexperimental"></a>
# **DeleteBuildsExperimental**
> void DeleteBuildsExperimental (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteBuildsExperimentalExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                apiInstance.DeleteBuildsExperimental(locator, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.DeleteBuildsExperimental: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedbuild"></a>
# **DeleteQueuedBuild**
> void DeleteQueuedBuild (string queuedBuildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteQueuedBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuedBuildLocator = queuedBuildLocator_example;  // string | 

            try
            {
                apiInstance.DeleteQueuedBuild(queuedBuildLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.DeleteQueuedBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuedBuildLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuild"></a>
# **GetBuild**
> BuildDto GetBuild (string queuedBuildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuedBuildLocator = queuedBuildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.GetBuild(queuedBuildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.GetBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuedBuildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildqueueposition"></a>
# **GetBuildQueuePosition**
> BuildDto GetBuildQueuePosition (string queuePosition, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildQueuePositionExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuePosition = queuePosition_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.GetBuildQueuePosition(queuePosition, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.GetBuildQueuePosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuePosition** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuilds"></a>
# **GetBuilds**
> BuildsDto GetBuilds (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.GetBuilds(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.GetBuilds: " + e.Message );
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

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuenewbuild"></a>
# **QueueNewBuild**
> BuildDto QueueNewBuild (BuildDto body = null, bool? moveToTop = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class QueueNewBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var body = new BuildDto(); // BuildDto |  (optional) 
            var moveToTop = true;  // bool? |  (optional) 

            try
            {
                BuildDto result = apiInstance.QueueNewBuild(body, moveToTop);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.QueueNewBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildDto**](BuildDto.md)|  | [optional] 
 **moveToTop** | **bool?**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacebuilds"></a>
# **ReplaceBuilds**
> BuildsDto ReplaceBuilds (BuildsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceBuildsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var body = new BuildsDto(); // BuildsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.ReplaceBuilds(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.ReplaceBuilds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildsDto**](BuildsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacetags"></a>
# **ReplaceTags**
> TagsDto ReplaceTags (string buildLocator, string locator = null, TagsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceTagsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var buildLocator = buildLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var body = new TagsDto(); // TagsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.ReplaceTags(buildLocator, locator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.ReplaceTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **body** | [**TagsDto**](TagsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**TagsDto**](TagsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildfieldbybuildonly"></a>
# **ServeBuildFieldByBuildOnly**
> string ServeBuildFieldByBuildOnly (string buildLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildFieldByBuildOnlyExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var buildLocator = buildLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildFieldByBuildOnly(buildLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.ServeBuildFieldByBuildOnly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servecompatibleagents"></a>
# **ServeCompatibleAgents**
> AgentsDto ServeCompatibleAgents (string queuedBuildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeCompatibleAgentsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuedBuildLocator = queuedBuildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentsDto result = apiInstance.ServeCompatibleAgents(queuedBuildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.ServeCompatibleAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuedBuildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentsDto**](AgentsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servetags"></a>
# **ServeTags**
> TagsDto ServeTags (string buildLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeTagsExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var buildLocator = buildLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.ServeTags(buildLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.ServeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**TagsDto**](TagsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbuildqueueorder"></a>
# **SetBuildQueueOrder**
> BuildsDto SetBuildQueueOrder (BuildsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildQueueOrderExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var body = new BuildsDto(); // BuildsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.SetBuildQueueOrder(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.SetBuildQueueOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BuildsDto**](BuildsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbuildqueueposition"></a>
# **SetBuildQueuePosition**
> BuildDto SetBuildQueuePosition (string queuePosition, BuildDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildQueuePositionExample
    {
        public void main()
        {
            var apiInstance = new BuildQueueApi();
            var queuePosition = queuePosition_example;  // string | 
            var body = new BuildDto(); // BuildDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.SetBuildQueuePosition(queuePosition, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildQueueApi.SetBuildQueuePosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queuePosition** | **string**|  | 
 **body** | [**BuildDto**](BuildDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

