# TeamCity.Api.BuildApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLogMessage**](BuildApi.md#addlogmessage) | **POST** /app/rest/builds/{buildLocator}/log | Adds a message to the build log. Service messages are accepted.
[**AddProblemToBuild**](BuildApi.md#addproblemtobuild) | **POST** /app/rest/builds/{buildLocator}/problemOccurrences | 
[**AddTagsMultipleToBuild**](BuildApi.md#addtagsmultipletobuild) | **POST** /app/rest/builds/multiple/{buildLocator}/tags | 
[**AddTagsToBuild**](BuildApi.md#addtagstobuild) | **POST** /app/rest/builds/{buildLocator}/tags | 
[**CancelBuild1**](BuildApi.md#cancelbuild1) | **POST** /app/rest/builds/{buildLocator} | 
[**CancelMultiple**](BuildApi.md#cancelmultiple) | **POST** /app/rest/builds/multiple/{buildLocator} | 
[**DeleteBuild**](BuildApi.md#deletebuild) | **DELETE** /app/rest/builds/{buildLocator} | 
[**DeleteComment**](BuildApi.md#deletecomment) | **DELETE** /app/rest/builds/{buildLocator}/comment | 
[**DeleteCommentMultiple**](BuildApi.md#deletecommentmultiple) | **DELETE** /app/rest/builds/multiple/{buildLocator}/comment | 
[**DeleteMultiple**](BuildApi.md#deletemultiple) | **DELETE** /app/rest/builds/multiple/{buildLocator} | 
[**GetArtifactDependencyChanges**](BuildApi.md#getartifactdependencychanges) | **GET** /app/rest/builds/{buildLocator}/artifactDependencyChanges | 
[**GetArtifactsDirectory**](BuildApi.md#getartifactsdirectory) | **GET** /app/rest/builds/{buildLocator}/artifactsDirectory | 
[**GetBuildFinishDate**](BuildApi.md#getbuildfinishdate) | **GET** /app/rest/builds/{buildLocator}/finishDate | 
[**GetBuildNumber**](BuildApi.md#getbuildnumber) | **GET** /app/rest/builds/{buildLocator}/number | 
[**GetBuildStatusText**](BuildApi.md#getbuildstatustext) | **GET** /app/rest/builds/{buildLocator}/statusText | 
[**GetCanceledInfo**](BuildApi.md#getcanceledinfo) | **GET** /app/rest/builds/{buildLocator}/canceledInfo | 
[**GetChildren**](BuildApi.md#getchildren) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/children{path} | 
[**GetChildren1**](BuildApi.md#getchildren1) | **GET** /app/rest/builds/{buildLocator}/artifacts/children{path} | 
[**GetChildrenAlias**](BuildApi.md#getchildrenalias) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/{path} | 
[**GetChildrenAlias1**](BuildApi.md#getchildrenalias1) | **GET** /app/rest/builds/{buildLocator}/artifacts/{path} | 
[**GetContent**](BuildApi.md#getcontent) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/content{path} | 
[**GetContent1**](BuildApi.md#getcontent1) | **GET** /app/rest/builds/{buildLocator}/artifacts/content{path} | 
[**GetContentAlias**](BuildApi.md#getcontentalias) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/files{path} | 
[**GetContentAlias1**](BuildApi.md#getcontentalias1) | **GET** /app/rest/builds/{buildLocator}/artifacts/files{path} | 
[**GetMetadata**](BuildApi.md#getmetadata) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/metadata{path} | 
[**GetMetadata1**](BuildApi.md#getmetadata1) | **GET** /app/rest/builds/{buildLocator}/artifacts/metadata{path} | 
[**GetMultiple**](BuildApi.md#getmultiple) | **GET** /app/rest/builds/multiple/{buildLocator} | 
[**GetParameter**](BuildApi.md#getparameter) | **GET** /app/rest/builds/{buildLocator}/resulting-properties/{propertyName} | 
[**GetPinData**](BuildApi.md#getpindata) | **GET** /app/rest/builds/{buildLocator}/pinInfo | 
[**GetProblems**](BuildApi.md#getproblems) | **GET** /app/rest/builds/{buildLocator}/problemOccurrences | 
[**GetResolvedParameter**](BuildApi.md#getresolvedparameter) | **GET** /app/rest/builds/{buildLocator}/resolved/{value} | 
[**GetRoot**](BuildApi.md#getroot) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts | 
[**GetRoot1**](BuildApi.md#getroot1) | **GET** /app/rest/builds/{buildLocator}/artifacts | 
[**GetTests**](BuildApi.md#gettests) | **GET** /app/rest/builds/{buildLocator}/testOccurrences | 
[**GetVcsLabels**](BuildApi.md#getvcslabels) | **GET** /app/rest/builds/{buildLocator}/vcsLabels | 
[**GetZipped**](BuildApi.md#getzipped) | **GET** /app/rest/builds/aggregated/{buildLocator}/artifacts/archived{path} | 
[**GetZipped1**](BuildApi.md#getzipped1) | **GET** /app/rest/builds/{buildLocator}/artifacts/archived{path} | 
[**MarkBuildAsRunning**](BuildApi.md#markbuildasrunning) | **PUT** /app/rest/builds/{buildLocator}/runningData | Starts the queued build as an agent-less build and returns the corresponding running build.
[**PinMultiple**](BuildApi.md#pinmultiple) | **PUT** /app/rest/builds/multiple/{buildLocator}/pinInfo | 
[**RemoveTagsMultiple**](BuildApi.md#removetagsmultiple) | **DELETE** /app/rest/builds/multiple/{buildLocator}/tags | 
[**ReplaceComment**](BuildApi.md#replacecomment) | **PUT** /app/rest/builds/{buildLocator}/comment | 
[**ReplaceCommentMultiple**](BuildApi.md#replacecommentmultiple) | **PUT** /app/rest/builds/multiple/{buildLocator}/comment | 
[**ReplaceTagsOnBuild**](BuildApi.md#replacetagsonbuild) | **PUT** /app/rest/builds/{buildLocator}/tags | 
[**ResetBuildFinishParameters**](BuildApi.md#resetbuildfinishparameters) | **DELETE** /app/rest/builds/{buildLocator}/caches/finishProperties | 
[**ServeAggregatedBuildStatus**](BuildApi.md#serveaggregatedbuildstatus) | **GET** /app/rest/builds/aggregated/{buildLocator}/status | 
[**ServeAggregatedBuildStatusIcon**](BuildApi.md#serveaggregatedbuildstatusicon) | **GET** /app/rest/builds/aggregated/{buildLocator}/statusIcon{suffix} | 
[**ServeAllBuilds**](BuildApi.md#serveallbuilds) | **GET** /app/rest/builds | 
[**ServeBuild**](BuildApi.md#servebuild) | **GET** /app/rest/builds/{buildLocator} | 
[**ServeBuildActualParameters**](BuildApi.md#servebuildactualparameters) | **GET** /app/rest/builds/{buildLocator}/resulting-properties | 
[**ServeBuildFieldFromBuildOnly**](BuildApi.md#servebuildfieldfrombuildonly) | **GET** /app/rest/builds/{buildLocator}/{field} | 
[**ServeBuildRelatedIssues**](BuildApi.md#servebuildrelatedissues) | **GET** /app/rest/builds/{buildLocator}/relatedIssues | 
[**ServeBuildStatisticValue**](BuildApi.md#servebuildstatisticvalue) | **GET** /app/rest/builds/{buildLocator}/statistics/{name} | 
[**ServeBuildStatisticValues**](BuildApi.md#servebuildstatisticvalues) | **GET** /app/rest/builds/{buildLocator}/statistics | 
[**ServeBuildStatusIcon**](BuildApi.md#servebuildstatusicon) | **GET** /app/rest/builds/{buildLocator}/statusIcon{suffix} | 
[**ServeSourceFile**](BuildApi.md#servesourcefile) | **GET** /app/rest/builds/{buildLocator}/sources/files/{fileName} | 
[**ServeTagsFromBuild**](BuildApi.md#servetagsfrombuild) | **GET** /app/rest/builds/{buildLocator}/tags | 
[**SetBuildNumber**](BuildApi.md#setbuildnumber) | **PUT** /app/rest/builds/{buildLocator}/number | 
[**SetBuildPinData**](BuildApi.md#setbuildpindata) | **PUT** /app/rest/builds/{buildLocator}/pinInfo | 
[**SetBuildStatusText**](BuildApi.md#setbuildstatustext) | **PUT** /app/rest/builds/{buildLocator}/statusText | 
[**SetFinishedTime**](BuildApi.md#setfinishedtime) | **PUT** /app/rest/builds/{buildLocator}/finishDate | Marks the running build as finished by passing agent the current time of the build to finish.
[**SetFinishedTime1**](BuildApi.md#setfinishedtime1) | **PUT** /app/rest/builds/{buildLocator}/finish | Marks the running build as finished by passing agent the current time of the build to finish.
[**SetVcsLabel**](BuildApi.md#setvcslabel) | **POST** /app/rest/builds/{buildLocator}/vcsLabels | 


<a name="addlogmessage"></a>
# **AddLogMessage**
> void AddLogMessage (string buildLocator, string body = null, string fields = null)

Adds a message to the build log. Service messages are accepted.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddLogMessageExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                // Adds a message to the build log. Service messages are accepted.
                apiInstance.AddLogMessage(buildLocator, body, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.AddLogMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproblemtobuild"></a>
# **AddProblemToBuild**
> ProblemOccurrenceDto AddProblemToBuild (string buildLocator, string body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddProblemToBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemOccurrenceDto result = apiInstance.AddProblemToBuild(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.AddProblemToBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**ProblemOccurrenceDto**](ProblemOccurrenceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagsmultipletobuild"></a>
# **AddTagsMultipleToBuild**
> MultipleOperationResultDto AddTagsMultipleToBuild (string buildLocator, TagsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddTagsMultipleToBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new TagsDto(); // TagsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.AddTagsMultipleToBuild(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.AddTagsMultipleToBuild: " + e.Message );
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
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagstobuild"></a>
# **AddTagsToBuild**
> TagsDto AddTagsToBuild (string buildLocator, TagsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddTagsToBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new TagsDto(); // TagsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.AddTagsToBuild(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.AddTagsToBuild: " + e.Message );
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
 **fields** | **string**|  | [optional] 

### Return type

[**TagsDto**](TagsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbuild1"></a>
# **CancelBuild1**
> BuildDto CancelBuild1 (string buildLocator, BuildCancelRequestDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CancelBuild1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new BuildCancelRequestDto(); // BuildCancelRequestDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.CancelBuild1(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.CancelBuild1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | [**BuildCancelRequestDto**](BuildCancelRequestDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelmultiple"></a>
# **CancelMultiple**
> MultipleOperationResultDto CancelMultiple (string buildLocator, BuildCancelRequestDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CancelMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new BuildCancelRequestDto(); // BuildCancelRequestDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.CancelMultiple(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.CancelMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | [**BuildCancelRequestDto**](BuildCancelRequestDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuild"></a>
# **DeleteBuild**
> void DeleteBuild (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                apiInstance.DeleteBuild(buildLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.DeleteBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecomment"></a>
# **DeleteComment**
> void DeleteComment (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                apiInstance.DeleteComment(buildLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.DeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommentmultiple"></a>
# **DeleteCommentMultiple**
> MultipleOperationResultDto DeleteCommentMultiple (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteCommentMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.DeleteCommentMultiple(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.DeleteCommentMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemultiple"></a>
# **DeleteMultiple**
> MultipleOperationResultDto DeleteMultiple (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.DeleteMultiple(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.DeleteMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartifactdependencychanges"></a>
# **GetArtifactDependencyChanges**
> BuildChangesDto GetArtifactDependencyChanges (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetArtifactDependencyChangesExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildChangesDto result = apiInstance.GetArtifactDependencyChanges(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetArtifactDependencyChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildChangesDto**](BuildChangesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartifactsdirectory"></a>
# **GetArtifactsDirectory**
> string GetArtifactsDirectory (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetArtifactsDirectoryExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetArtifactsDirectory(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetArtifactsDirectory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildfinishdate"></a>
# **GetBuildFinishDate**
> string GetBuildFinishDate (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildFinishDateExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetBuildFinishDate(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildFinishDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildnumber"></a>
# **GetBuildNumber**
> string GetBuildNumber (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildNumberExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetBuildNumber(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildstatustext"></a>
# **GetBuildStatusText**
> string GetBuildStatusText (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildStatusTextExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetBuildStatusText(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildStatusText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcanceledinfo"></a>
# **GetCanceledInfo**
> CommentDto GetCanceledInfo (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetCanceledInfoExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CommentDto result = apiInstance.GetCanceledInfo(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetCanceledInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CommentDto**](CommentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren"></a>
# **GetChildren**
> FilesDto GetChildren (string path, string buildLocator, string basePath = null, string locator = null, string fields = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildren(path, buildLocator, basePath, locator, fields, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren1"></a>
# **GetChildren1**
> FilesDto GetChildren1 (string path, string buildLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildren1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildren1(path, buildLocator, basePath, locator, fields, resolveParameters, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetChildren1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildrenalias"></a>
# **GetChildrenAlias**
> FilesDto GetChildrenAlias (string path, string buildLocator, string basePath = null, string locator = null, string fields = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenAliasExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildrenAlias(path, buildLocator, basePath, locator, fields, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetChildrenAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildrenalias1"></a>
# **GetChildrenAlias1**
> FilesDto GetChildrenAlias1 (string path, string buildLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenAlias1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildrenAlias1(path, buildLocator, basePath, locator, fields, resolveParameters, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetChildrenAlias1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontent"></a>
# **GetContent**
> void GetContent (string path, string buildLocator, string responseBuilder = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var responseBuilder = responseBuilder_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContent(path, buildLocator, responseBuilder, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **responseBuilder** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontent1"></a>
# **GetContent1**
> void GetContent1 (string path, string buildLocator, string responseBuilder = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContent1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var responseBuilder = responseBuilder_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContent1(path, buildLocator, responseBuilder, resolveParameters, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetContent1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **responseBuilder** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentalias"></a>
# **GetContentAlias**
> void GetContentAlias (string path, string buildLocator, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentAliasExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContentAlias(path, buildLocator, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetContentAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentalias1"></a>
# **GetContentAlias1**
> void GetContentAlias1 (string path, string buildLocator, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentAlias1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContentAlias1(path, buildLocator, resolveParameters, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetContentAlias1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata"></a>
# **GetMetadata**
> FileDto GetMetadata (string path, string buildLocator, string fields = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMetadataExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FileDto result = apiInstance.GetMetadata(path, buildLocator, fields, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FileDto**](FileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata1"></a>
# **GetMetadata1**
> FileDto GetMetadata1 (string path, string buildLocator, string fields = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMetadata1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FileDto result = apiInstance.GetMetadata1(path, buildLocator, fields, resolveParameters, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetMetadata1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FileDto**](FileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmultiple"></a>
# **GetMultiple**
> BuildsDto GetMultiple (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.GetMultiple(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparameter"></a>
# **GetParameter**
> string GetParameter (string buildLocator, string propertyName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var propertyName = propertyName_example;  // string | 

            try
            {
                string result = apiInstance.GetParameter(buildLocator, propertyName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **propertyName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpindata"></a>
# **GetPinData**
> PinInfoDto GetPinData (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPinDataExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PinInfoDto result = apiInstance.GetPinData(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetPinData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PinInfoDto**](PinInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproblems"></a>
# **GetProblems**
> ProblemOccurrencesDto GetProblems (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetProblemsExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProblemOccurrencesDto result = apiInstance.GetProblems(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetProblems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProblemOccurrencesDto**](ProblemOccurrencesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresolvedparameter"></a>
# **GetResolvedParameter**
> string GetResolvedParameter (string buildLocator, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetResolvedParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                string result = apiInstance.GetResolvedParameter(buildLocator, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetResolvedParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **value** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroot"></a>
# **GetRoot**
> FilesDto GetRoot (string buildLocator, string basePath = null, string locator = null, string fields = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRootExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetRoot(buildLocator, basePath, locator, fields, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroot1"></a>
# **GetRoot1**
> FilesDto GetRoot1 (string buildLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRoot1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetRoot1(buildLocator, basePath, locator, fields, resolveParameters, logBuildUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetRoot1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettests"></a>
# **GetTests**
> TestOccurrencesDto GetTests (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTestsExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TestOccurrencesDto result = apiInstance.GetTests(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetTests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TestOccurrencesDto**](TestOccurrencesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvcslabels"></a>
# **GetVcsLabels**
> VcsLabelsDto GetVcsLabels (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetVcsLabelsExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsLabelsDto result = apiInstance.GetVcsLabels(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetVcsLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsLabelsDto**](VcsLabelsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipped"></a>
# **GetZipped**
> void GetZipped (string path, string buildLocator, string basePath = null, string locator = null, string name = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetZippedExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetZipped(path, buildLocator, basePath, locator, name, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetZipped: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipped1"></a>
# **GetZipped1**
> void GetZipped1 (string path, string buildLocator, string basePath = null, string locator = null, string name = null, bool? resolveParameters = null, bool? logBuildUsage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetZipped1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var path = path_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 
            var logBuildUsage = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetZipped1(path, buildLocator, basePath, locator, name, resolveParameters, logBuildUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.GetZipped1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **buildLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 
 **logBuildUsage** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markbuildasrunning"></a>
# **MarkBuildAsRunning**
> BuildDto MarkBuildAsRunning (string buildLocator, string body = null, string fields = null)

Starts the queued build as an agent-less build and returns the corresponding running build.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class MarkBuildAsRunningExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                // Starts the queued build as an agent-less build and returns the corresponding running build.
                BuildDto result = apiInstance.MarkBuildAsRunning(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.MarkBuildAsRunning: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pinmultiple"></a>
# **PinMultiple**
> MultipleOperationResultDto PinMultiple (string buildLocator, PinInfoDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class PinMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new PinInfoDto(); // PinInfoDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.PinMultiple(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.PinMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | [**PinInfoDto**](PinInfoDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetagsmultiple"></a>
# **RemoveTagsMultiple**
> MultipleOperationResultDto RemoveTagsMultiple (string buildLocator, TagsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveTagsMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new TagsDto(); // TagsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.RemoveTagsMultiple(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.RemoveTagsMultiple: " + e.Message );
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
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacecomment"></a>
# **ReplaceComment**
> void ReplaceComment (string buildLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceCommentExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                apiInstance.ReplaceComment(buildLocator, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ReplaceComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacecommentmultiple"></a>
# **ReplaceCommentMultiple**
> MultipleOperationResultDto ReplaceCommentMultiple (string buildLocator, string body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceCommentMultipleExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MultipleOperationResultDto result = apiInstance.ReplaceCommentMultiple(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ReplaceCommentMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**MultipleOperationResultDto**](MultipleOperationResultDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacetagsonbuild"></a>
# **ReplaceTagsOnBuild**
> TagsDto ReplaceTagsOnBuild (string buildLocator, string locator = null, TagsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceTagsOnBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var body = new TagsDto(); // TagsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.ReplaceTagsOnBuild(buildLocator, locator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ReplaceTagsOnBuild: " + e.Message );
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

<a name="resetbuildfinishparameters"></a>
# **ResetBuildFinishParameters**
> void ResetBuildFinishParameters (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ResetBuildFinishParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                apiInstance.ResetBuildFinishParameters(buildLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ResetBuildFinishParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveaggregatedbuildstatus"></a>
# **ServeAggregatedBuildStatus**
> string ServeAggregatedBuildStatus (string buildLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAggregatedBuildStatusExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                string result = apiInstance.ServeAggregatedBuildStatus(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeAggregatedBuildStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveaggregatedbuildstatusicon"></a>
# **ServeAggregatedBuildStatusIcon**
> void ServeAggregatedBuildStatusIcon (string buildLocator, string suffix)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAggregatedBuildStatusIconExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var suffix = suffix_example;  // string | 

            try
            {
                apiInstance.ServeAggregatedBuildStatusIcon(buildLocator, suffix);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeAggregatedBuildStatusIcon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **suffix** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveallbuilds"></a>
# **ServeAllBuilds**
> BuildsDto ServeAllBuilds (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAllBuildsExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.ServeAllBuilds(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeAllBuilds: " + e.Message );
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

<a name="servebuild"></a>
# **ServeBuild**
> BuildDto ServeBuild (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.ServeBuild(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildDto**](BuildDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildactualparameters"></a>
# **ServeBuildActualParameters**
> PropertiesDto ServeBuildActualParameters (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildActualParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeBuildActualParameters(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildActualParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildfieldfrombuildonly"></a>
# **ServeBuildFieldFromBuildOnly**
> string ServeBuildFieldFromBuildOnly (string buildLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildFieldFromBuildOnlyExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildFieldFromBuildOnly(buildLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildFieldFromBuildOnly: " + e.Message );
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

<a name="servebuildrelatedissues"></a>
# **ServeBuildRelatedIssues**
> IssuesUsagesDto ServeBuildRelatedIssues (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildRelatedIssuesExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                IssuesUsagesDto result = apiInstance.ServeBuildRelatedIssues(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildRelatedIssues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**IssuesUsagesDto**](IssuesUsagesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildstatisticvalue"></a>
# **ServeBuildStatisticValue**
> string ServeBuildStatisticValue (string buildLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildStatisticValueExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildStatisticValue(buildLocator, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildStatisticValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildstatisticvalues"></a>
# **ServeBuildStatisticValues**
> PropertiesDto ServeBuildStatisticValues (string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildStatisticValuesExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeBuildStatisticValues(buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildStatisticValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildstatusicon"></a>
# **ServeBuildStatusIcon**
> void ServeBuildStatusIcon (string buildLocator, string suffix)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildStatusIconExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var suffix = suffix_example;  // string | 

            try
            {
                apiInstance.ServeBuildStatusIcon(buildLocator, suffix);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeBuildStatusIcon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **suffix** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servesourcefile"></a>
# **ServeSourceFile**
> void ServeSourceFile (string buildLocator, string fileName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeSourceFileExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var fileName = fileName_example;  // string | 

            try
            {
                apiInstance.ServeSourceFile(buildLocator, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeSourceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **fileName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servetagsfrombuild"></a>
# **ServeTagsFromBuild**
> TagsDto ServeTagsFromBuild (string buildLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeTagsFromBuildExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.ServeTagsFromBuild(buildLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.ServeTagsFromBuild: " + e.Message );
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

<a name="setbuildnumber"></a>
# **SetBuildNumber**
> string SetBuildNumber (string buildLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildNumberExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetBuildNumber(buildLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetBuildNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbuildpindata"></a>
# **SetBuildPinData**
> PinInfoDto SetBuildPinData (string buildLocator, PinInfoDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildPinDataExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = new PinInfoDto(); // PinInfoDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PinInfoDto result = apiInstance.SetBuildPinData(buildLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetBuildPinData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | [**PinInfoDto**](PinInfoDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PinInfoDto**](PinInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbuildstatustext"></a>
# **SetBuildStatusText**
> string SetBuildStatusText (string buildLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildStatusTextExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetBuildStatusText(buildLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetBuildStatusText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfinishedtime"></a>
# **SetFinishedTime**
> string SetFinishedTime (string buildLocator, string body = null)

Marks the running build as finished by passing agent the current time of the build to finish.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetFinishedTimeExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                // Marks the running build as finished by passing agent the current time of the build to finish.
                string result = apiInstance.SetFinishedTime(buildLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetFinishedTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfinishedtime1"></a>
# **SetFinishedTime1**
> string SetFinishedTime1 (string buildLocator)

Marks the running build as finished by passing agent the current time of the build to finish.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetFinishedTime1Example
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 

            try
            {
                // Marks the running build as finished by passing agent the current time of the build to finish.
                string result = apiInstance.SetFinishedTime1(buildLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetFinishedTime1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvcslabel"></a>
# **SetVcsLabel**
> VcsLabelsDto SetVcsLabel (string buildLocator, string locator = null, string fields = null, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetVcsLabelExample
    {
        public void main()
        {
            var apiInstance = new BuildApi();
            var buildLocator = buildLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var body = body_example;  // string |  (optional) 

            try
            {
                VcsLabelsDto result = apiInstance.SetVcsLabel(buildLocator, locator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildApi.SetVcsLabel: " + e.Message );
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
 **body** | **string**|  | [optional] 

### Return type

[**VcsLabelsDto**](VcsLabelsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

