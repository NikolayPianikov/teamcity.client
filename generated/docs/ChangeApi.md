# TeamCity.Api.ChangeApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChangeAttributes**](ChangeApi.md#getchangeattributes) | **GET** /app/rest/changes/{changeLocator}/attributes | 
[**GetChangeDuplicates**](ChangeApi.md#getchangeduplicates) | **GET** /app/rest/changes/{changeLocator}/duplicates | 
[**GetChangeField**](ChangeApi.md#getchangefield) | **GET** /app/rest/changes/{changeLocator}/{field} | 
[**GetChangeFirstBuilds**](ChangeApi.md#getchangefirstbuilds) | **GET** /app/rest/changes/{changeLocator}/firstBuilds | 
[**GetChangeIssue**](ChangeApi.md#getchangeissue) | **GET** /app/rest/changes/{changeLocator}/issues | 
[**GetChangeParentRevisions**](ChangeApi.md#getchangeparentrevisions) | **GET** /app/rest/changes/{changeLocator}/parentRevisions | 
[**GetChangeVCSRootInstance**](ChangeApi.md#getchangevcsrootinstance) | **GET** /app/rest/changes/{changeLocator}/vcsRootInstance | 
[**GetParentChanges**](ChangeApi.md#getparentchanges) | **GET** /app/rest/changes/{changeLocator}/parentChanges | 
[**GetRelatedBuildTypes**](ChangeApi.md#getrelatedbuildtypes) | **GET** /app/rest/changes/{changeLocator}/buildTypes | 
[**ServeChange**](ChangeApi.md#servechange) | **GET** /app/rest/changes/{changeLocator} | 
[**ServeChanges**](ChangeApi.md#servechanges) | **GET** /app/rest/changes | 


<a name="getchangeattributes"></a>
# **GetChangeAttributes**
> EntriesDto GetChangeAttributes (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeAttributesExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                EntriesDto result = apiInstance.GetChangeAttributes(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**EntriesDto**](EntriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangeduplicates"></a>
# **GetChangeDuplicates**
> ChangesDto GetChangeDuplicates (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeDuplicatesExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ChangesDto result = apiInstance.GetChangeDuplicates(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeDuplicates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ChangesDto**](ChangesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangefield"></a>
# **GetChangeField**
> string GetChangeField (string changeLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeFieldExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.GetChangeField(changeLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangefirstbuilds"></a>
# **GetChangeFirstBuilds**
> BuildsDto GetChangeFirstBuilds (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeFirstBuildsExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.GetChangeFirstBuilds(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeFirstBuilds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangeissue"></a>
# **GetChangeIssue**
> IssuesDto GetChangeIssue (string changeLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeIssueExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 

            try
            {
                IssuesDto result = apiInstance.GetChangeIssue(changeLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeIssue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 

### Return type

[**IssuesDto**](IssuesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangeparentrevisions"></a>
# **GetChangeParentRevisions**
> ItemsDto GetChangeParentRevisions (string changeLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeParentRevisionsExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 

            try
            {
                ItemsDto result = apiInstance.GetChangeParentRevisions(changeLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeParentRevisions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 

### Return type

[**ItemsDto**](ItemsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchangevcsrootinstance"></a>
# **GetChangeVCSRootInstance**
> VcsRootInstanceDto GetChangeVCSRootInstance (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChangeVCSRootInstanceExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstanceDto result = apiInstance.GetChangeVCSRootInstance(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetChangeVCSRootInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstanceDto**](VcsRootInstanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentchanges"></a>
# **GetParentChanges**
> ChangesDto GetParentChanges (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParentChangesExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ChangesDto result = apiInstance.GetParentChanges(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetParentChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ChangesDto**](ChangesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelatedbuildtypes"></a>
# **GetRelatedBuildTypes**
> BuildTypesDto GetRelatedBuildTypes (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRelatedBuildTypesExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.GetRelatedBuildTypes(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.GetRelatedBuildTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servechange"></a>
# **ServeChange**
> ChangeDto ServeChange (string changeLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeChangeExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var changeLocator = changeLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ChangeDto result = apiInstance.ServeChange(changeLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.ServeChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ChangeDto**](ChangeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servechanges"></a>
# **ServeChanges**
> ChangesDto ServeChanges (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeChangesExample
    {
        public void main()
        {
            var apiInstance = new ChangeApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ChangesDto result = apiInstance.ServeChanges(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangeApi.ServeChanges: " + e.Message );
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

[**ChangesDto**](ChangesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

