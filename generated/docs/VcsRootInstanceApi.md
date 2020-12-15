# TeamCity.Api.VcsRootInstanceApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstanceField**](VcsRootInstanceApi.md#deleteinstancefield) | **DELETE** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/{field} | 
[**DeleteRepositoryState**](VcsRootInstanceApi.md#deleterepositorystate) | **DELETE** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/repositoryState | 
[**GetChildren4**](VcsRootInstanceApi.md#getchildren4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/children{path} | 
[**GetChildrenAlias4**](VcsRootInstanceApi.md#getchildrenalias4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/{path} | 
[**GetContent4**](VcsRootInstanceApi.md#getcontent4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/content{path} | 
[**GetContentAlias4**](VcsRootInstanceApi.md#getcontentalias4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/files{path} | 
[**GetMetadata4**](VcsRootInstanceApi.md#getmetadata4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/metadata{path} | 
[**GetRepositoryState**](VcsRootInstanceApi.md#getrepositorystate) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/repositoryState | 
[**GetRepositoryStateCreationDate**](VcsRootInstanceApi.md#getrepositorystatecreationdate) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/repositoryState/creationDate | 
[**GetRoot4**](VcsRootInstanceApi.md#getroot4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest | 
[**GetZipped4**](VcsRootInstanceApi.md#getzipped4) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/files/latest/archived{path} | 
[**ScheduleCheckingForChanges**](VcsRootInstanceApi.md#schedulecheckingforchanges) | **POST** /app/rest/vcs-root-instances/checkingForChangesQueue | 
[**ScheduleCheckingForChanges1**](VcsRootInstanceApi.md#schedulecheckingforchanges1) | **POST** /app/rest/vcs-root-instances/commitHookNotification | 
[**ServeInstance6**](VcsRootInstanceApi.md#serveinstance6) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator} | 
[**ServeInstanceField**](VcsRootInstanceApi.md#serveinstancefield) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/{field} | 
[**ServeInstances1**](VcsRootInstanceApi.md#serveinstances1) | **GET** /app/rest/vcs-root-instances | 
[**ServeRootInstanceProperties**](VcsRootInstanceApi.md#serverootinstanceproperties) | **GET** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/properties | 
[**SetInstanceField**](VcsRootInstanceApi.md#setinstancefield) | **PUT** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/{field} | 
[**SetRepositoryState**](VcsRootInstanceApi.md#setrepositorystate) | **PUT** /app/rest/vcs-root-instances/{vcsRootInstanceLocator}/repositoryState | 


<a name="deleteinstancefield"></a>
# **DeleteInstanceField**
> void DeleteInstanceField (string vcsRootInstanceLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteInstanceFieldExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                apiInstance.DeleteInstanceField(vcsRootInstanceLocator, field);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.DeleteInstanceField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterepositorystate"></a>
# **DeleteRepositoryState**
> void DeleteRepositoryState (string vcsRootInstanceLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteRepositoryStateExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 

            try
            {
                apiInstance.DeleteRepositoryState(vcsRootInstanceLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.DeleteRepositoryState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren4"></a>
# **GetChildren4**
> FilesDto GetChildren4 (string path, string vcsRootInstanceLocator, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildren4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildren4(path, vcsRootInstanceLocator, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetChildren4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildrenalias4"></a>
# **GetChildrenAlias4**
> FilesDto GetChildrenAlias4 (string path, string vcsRootInstanceLocator, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenAlias4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildrenAlias4(path, vcsRootInstanceLocator, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetChildrenAlias4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontent4"></a>
# **GetContent4**
> void GetContent4 (string path, string vcsRootInstanceLocator, string responseBuilder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContent4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var responseBuilder = responseBuilder_example;  // string |  (optional) 

            try
            {
                apiInstance.GetContent4(path, vcsRootInstanceLocator, responseBuilder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetContent4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **responseBuilder** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentalias4"></a>
# **GetContentAlias4**
> void GetContentAlias4 (string path, string vcsRootInstanceLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentAlias4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 

            try
            {
                apiInstance.GetContentAlias4(path, vcsRootInstanceLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetContentAlias4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata4"></a>
# **GetMetadata4**
> FileDto GetMetadata4 (string path, string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMetadata4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FileDto result = apiInstance.GetMetadata4(path, vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetMetadata4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**FileDto**](FileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepositorystate"></a>
# **GetRepositoryState**
> EntriesDto GetRepositoryState (string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRepositoryStateExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                EntriesDto result = apiInstance.GetRepositoryState(vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetRepositoryState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**EntriesDto**](EntriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrepositorystatecreationdate"></a>
# **GetRepositoryStateCreationDate**
> string GetRepositoryStateCreationDate (string vcsRootInstanceLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRepositoryStateCreationDateExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetRepositoryStateCreationDate(vcsRootInstanceLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetRepositoryStateCreationDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroot4"></a>
# **GetRoot4**
> FilesDto GetRoot4 (string vcsRootInstanceLocator, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRoot4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetRoot4(vcsRootInstanceLocator, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetRoot4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipped4"></a>
# **GetZipped4**
> void GetZipped4 (string path, string vcsRootInstanceLocator, string basePath = null, string locator = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetZipped4Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var path = path_example;  // string | 
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.GetZipped4(path, vcsRootInstanceLocator, basePath, locator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.GetZipped4: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **vcsRootInstanceLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulecheckingforchanges"></a>
# **ScheduleCheckingForChanges**
> VcsRootInstancesDto ScheduleCheckingForChanges (string locator = null, string requestor = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ScheduleCheckingForChangesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var requestor = requestor_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstancesDto result = apiInstance.ScheduleCheckingForChanges(locator, requestor, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ScheduleCheckingForChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locator** | **string**|  | [optional] 
 **requestor** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstancesDto**](VcsRootInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulecheckingforchanges1"></a>
# **ScheduleCheckingForChanges1**
> void ScheduleCheckingForChanges1 (string locator = null, bool? okOnNothingFound = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ScheduleCheckingForChanges1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var okOnNothingFound = true;  // bool? |  (optional) 

            try
            {
                apiInstance.ScheduleCheckingForChanges1(locator, okOnNothingFound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ScheduleCheckingForChanges1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locator** | **string**|  | [optional] 
 **okOnNothingFound** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveinstance6"></a>
# **ServeInstance6**
> VcsRootInstanceDto ServeInstance6 (string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstance6Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstanceDto result = apiInstance.ServeInstance6(vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ServeInstance6: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="serveinstancefield"></a>
# **ServeInstanceField**
> string ServeInstanceField (string vcsRootInstanceLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstanceFieldExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeInstanceField(vcsRootInstanceLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ServeInstanceField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="serveinstances1"></a>
# **ServeInstances1**
> VcsRootInstancesDto ServeInstances1 (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeInstances1Example
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstancesDto result = apiInstance.ServeInstances1(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ServeInstances1: " + e.Message );
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

[**VcsRootInstancesDto**](VcsRootInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverootinstanceproperties"></a>
# **ServeRootInstanceProperties**
> PropertiesDto ServeRootInstanceProperties (string vcsRootInstanceLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeRootInstancePropertiesExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeRootInstanceProperties(vcsRootInstanceLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.ServeRootInstanceProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="setinstancefield"></a>
# **SetInstanceField**
> string SetInstanceField (string vcsRootInstanceLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetInstanceFieldExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetInstanceField(vcsRootInstanceLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.SetInstanceField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="setrepositorystate"></a>
# **SetRepositoryState**
> EntriesDto SetRepositoryState (string vcsRootInstanceLocator, EntriesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetRepositoryStateExample
    {
        public void main()
        {
            var apiInstance = new VcsRootInstanceApi();
            var vcsRootInstanceLocator = vcsRootInstanceLocator_example;  // string | 
            var body = new EntriesDto(); // EntriesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                EntriesDto result = apiInstance.SetRepositoryState(vcsRootInstanceLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VcsRootInstanceApi.SetRepositoryState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcsRootInstanceLocator** | **string**|  | 
 **body** | [**EntriesDto**](EntriesDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**EntriesDto**](EntriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

