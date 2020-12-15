# TeamCity.Api.ProjectApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](ProjectApi.md#add) | **POST** /app/rest/projects/{projectLocator}/projectFeatures | 
[**CreateBuildType**](ProjectApi.md#createbuildtype) | **POST** /app/rest/projects/{projectLocator}/buildTypes | 
[**CreateBuildTypeTemplate**](ProjectApi.md#createbuildtypetemplate) | **POST** /app/rest/projects/{projectLocator}/templates | 
[**CreateProject**](ProjectApi.md#createproject) | **POST** /app/rest/projects | 
[**CreateSecureToken**](ProjectApi.md#createsecuretoken) | **POST** /app/rest/projects/{projectLocator}/secure/tokens | 
[**Delete**](ProjectApi.md#delete) | **DELETE** /app/rest/projects/{projectLocator}/projectFeatures/{featureLocator} | 
[**DeleteAllParameters1**](ProjectApi.md#deleteallparameters1) | **DELETE** /app/rest/projects/{projectLocator}/parameters | 
[**DeleteParameter1**](ProjectApi.md#deleteparameter1) | **DELETE** /app/rest/projects/{projectLocator}/parameters/{name} | 
[**DeleteProject**](ProjectApi.md#deleteproject) | **DELETE** /app/rest/projects/{projectLocator} | 
[**DeleteProjectAgentPools**](ProjectApi.md#deleteprojectagentpools) | **DELETE** /app/rest/projects/{projectLocator}/agentPools/{agentPoolLocator} | 
[**Get1**](ProjectApi.md#get1) | **GET** /app/rest/projects/{projectLocator}/projectFeatures | 
[**GetBranches**](ProjectApi.md#getbranches) | **GET** /app/rest/projects/{projectLocator}/branches | 
[**GetBuildTypesOrder**](ProjectApi.md#getbuildtypesorder) | **GET** /app/rest/projects/{projectLocator}/order/buildTypes | 
[**GetDefaultTemplate**](ProjectApi.md#getdefaulttemplate) | **GET** /app/rest/projects/{projectLocator}/defaultTemplate | 
[**GetParameter2**](ProjectApi.md#getparameter2) | **GET** /app/rest/projects/{projectLocator}/parameters/{name} | 
[**GetParameterType1**](ProjectApi.md#getparametertype1) | **GET** /app/rest/projects/{projectLocator}/parameters/{name}/type | 
[**GetParameterTypeRawValue1**](ProjectApi.md#getparametertyperawvalue1) | **GET** /app/rest/projects/{projectLocator}/parameters/{name}/type/rawValue | 
[**GetParameterValueLong1**](ProjectApi.md#getparametervaluelong1) | **GET** /app/rest/projects/{projectLocator}/parameters/{name}/value | 
[**GetParameters1**](ProjectApi.md#getparameters1) | **GET** /app/rest/projects/{projectLocator}/parameters | 
[**GetParentProject**](ProjectApi.md#getparentproject) | **GET** /app/rest/projects/{projectLocator}/parentProject | 
[**GetProjectAgentPools**](ProjectApi.md#getprojectagentpools) | **GET** /app/rest/projects/{projectLocator}/agentPools | 
[**GetProjectsOrder**](ProjectApi.md#getprojectsorder) | **GET** /app/rest/projects/{projectLocator}/order/projects | 
[**GetSecureValue**](ProjectApi.md#getsecurevalue) | **GET** /app/rest/projects/{projectLocator}/secure/values/{token} | 
[**GetSettingsFile1**](ProjectApi.md#getsettingsfile1) | **GET** /app/rest/projects/{projectLocator}/settingsFile | 
[**GetSingle1**](ProjectApi.md#getsingle1) | **GET** /app/rest/projects/{projectLocator}/projectFeatures/{featureLocator} | 
[**ReloadSettingsFile**](ProjectApi.md#reloadsettingsfile) | **GET** /app/rest/projects/{projectLocator}/latest | 
[**RemoveDefaultTemplate**](ProjectApi.md#removedefaulttemplate) | **DELETE** /app/rest/projects/{projectLocator}/defaultTemplate | 
[**Replace**](ProjectApi.md#replace) | **PUT** /app/rest/projects/{projectLocator}/projectFeatures/{featureLocator} | 
[**ReplaceAll**](ProjectApi.md#replaceall) | **PUT** /app/rest/projects/{projectLocator}/projectFeatures | 
[**ServeBuildFieldWithProject**](ProjectApi.md#servebuildfieldwithproject) | **GET** /app/rest/projects/{projectLocator}/buildTypes/{btLocator}/builds/{buildLocator}/{field} | 
[**ServeBuildType**](ProjectApi.md#servebuildtype) | **GET** /app/rest/projects/{projectLocator}/buildTypes/{btLocator} | 
[**ServeBuildTypeFieldWithProject**](ProjectApi.md#servebuildtypefieldwithproject) | **GET** /app/rest/projects/{projectLocator}/buildTypes/{btLocator}/{field} | 
[**ServeBuildTypeTemplates**](ProjectApi.md#servebuildtypetemplates) | **GET** /app/rest/projects/{projectLocator}/templates/{btLocator} | 
[**ServeBuildTypesInProject**](ProjectApi.md#servebuildtypesinproject) | **GET** /app/rest/projects/{projectLocator}/buildTypes | 
[**ServeBuildWithProject1**](ProjectApi.md#servebuildwithproject1) | **GET** /app/rest/projects/{projectLocator}/buildTypes/{btLocator}/builds/{buildLocator} | 
[**ServeBuilds1**](ProjectApi.md#servebuilds1) | **GET** /app/rest/projects/{projectLocator}/buildTypes/{btLocator}/builds | 
[**ServeProject**](ProjectApi.md#serveproject) | **GET** /app/rest/projects/{projectLocator} | 
[**ServeProjectField**](ProjectApi.md#serveprojectfield) | **GET** /app/rest/projects/{projectLocator}/{field} | 
[**ServeProjects**](ProjectApi.md#serveprojects) | **GET** /app/rest/projects | 
[**ServeTemplatesInProject**](ProjectApi.md#servetemplatesinproject) | **GET** /app/rest/projects/{projectLocator}/templates | 
[**SetBuildTypesOrder**](ProjectApi.md#setbuildtypesorder) | **PUT** /app/rest/projects/{projectLocator}/order/buildTypes | 
[**SetDefaultTemplate**](ProjectApi.md#setdefaulttemplate) | **PUT** /app/rest/projects/{projectLocator}/defaultTemplate | 
[**SetParameter2**](ProjectApi.md#setparameter2) | **PUT** /app/rest/projects/{projectLocator}/parameters/{name} | 
[**SetParameter3**](ProjectApi.md#setparameter3) | **POST** /app/rest/projects/{projectLocator}/parameters | 
[**SetParameterType1**](ProjectApi.md#setparametertype1) | **PUT** /app/rest/projects/{projectLocator}/parameters/{name}/type | 
[**SetParameterTypeRawValue1**](ProjectApi.md#setparametertyperawvalue1) | **PUT** /app/rest/projects/{projectLocator}/parameters/{name}/type/rawValue | 
[**SetParameterValueLong1**](ProjectApi.md#setparametervaluelong1) | **PUT** /app/rest/projects/{projectLocator}/parameters/{name}/value | 
[**SetParameters1**](ProjectApi.md#setparameters1) | **PUT** /app/rest/projects/{projectLocator}/parameters | 
[**SetParentProject**](ProjectApi.md#setparentproject) | **PUT** /app/rest/projects/{projectLocator}/parentProject | 
[**SetProjectAgentPools**](ProjectApi.md#setprojectagentpools) | **POST** /app/rest/projects/{projectLocator}/agentPools | 
[**SetProjectAgentPools1**](ProjectApi.md#setprojectagentpools1) | **PUT** /app/rest/projects/{projectLocator}/agentPools | 
[**SetProjectField**](ProjectApi.md#setprojectfield) | **PUT** /app/rest/projects/{projectLocator}/{field} | 
[**SetProjectsOrder**](ProjectApi.md#setprojectsorder) | **PUT** /app/rest/projects/{projectLocator}/order/projects | 


<a name="add"></a>
# **Add**
> Object Add (string projectLocator, ProjectFeatureDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new ProjectFeatureDto(); // ProjectFeatureDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.Add(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.Add: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**ProjectFeatureDto**](ProjectFeatureDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbuildtype"></a>
# **CreateBuildType**
> BuildTypeDto CreateBuildType (string projectLocator, NewBuildTypeDescriptionDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateBuildTypeExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new NewBuildTypeDescriptionDto(); // NewBuildTypeDescriptionDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.CreateBuildType(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.CreateBuildType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**NewBuildTypeDescriptionDto**](NewBuildTypeDescriptionDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbuildtypetemplate"></a>
# **CreateBuildTypeTemplate**
> BuildTypeDto CreateBuildTypeTemplate (string projectLocator, NewBuildTypeDescriptionDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateBuildTypeTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new NewBuildTypeDescriptionDto(); // NewBuildTypeDescriptionDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.CreateBuildTypeTemplate(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.CreateBuildTypeTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**NewBuildTypeDescriptionDto**](NewBuildTypeDescriptionDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproject"></a>
# **CreateProject**
> ProjectDto CreateProject (NewProjectDescriptionDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var body = new NewProjectDescriptionDto(); // NewProjectDescriptionDto |  (optional) 

            try
            {
                ProjectDto result = apiInstance.CreateProject(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.CreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewProjectDescriptionDto**](NewProjectDescriptionDto.md)|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsecuretoken"></a>
# **CreateSecureToken**
> string CreateSecureToken (string projectLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateSecureTokenExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.CreateSecureToken(projectLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.CreateSecureToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string featureLocator, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var featureLocator = featureLocator_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                apiInstance.Delete(featureLocator, projectLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureLocator** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallparameters1"></a>
# **DeleteAllParameters1**
> void DeleteAllParameters1 (string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteAllParameters1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                apiInstance.DeleteAllParameters1(projectLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteAllParameters1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparameter1"></a>
# **DeleteParameter1**
> void DeleteParameter1 (string name, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteParameter1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                apiInstance.DeleteParameter1(name, projectLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteParameter1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                apiInstance.DeleteProject(projectLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojectagentpools"></a>
# **DeleteProjectAgentPools**
> void DeleteProjectAgentPools (string projectLocator, string agentPoolLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteProjectAgentPoolsExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var agentPoolLocator = agentPoolLocator_example;  // string | 

            try
            {
                apiInstance.DeleteProjectAgentPools(projectLocator, agentPoolLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteProjectAgentPools: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **agentPoolLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get1"></a>
# **Get1**
> Object Get1 (string projectLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class Get1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.Get1(projectLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.Get1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbranches"></a>
# **GetBranches**
> BranchesDto GetBranches (string projectLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBranchesExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BranchesDto result = apiInstance.GetBranches(projectLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetBranches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BranchesDto**](BranchesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildtypesorder"></a>
# **GetBuildTypesOrder**
> BuildTypesDto GetBuildTypesOrder (string projectLocator, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildTypesOrderExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var field = field_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.GetBuildTypesOrder(projectLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetBuildTypesOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **field** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaulttemplate"></a>
# **GetDefaultTemplate**
> BuildTypeDto GetDefaultTemplate (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetDefaultTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.GetDefaultTemplate(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetDefaultTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparameter2"></a>
# **GetParameter2**
> PropertyDto GetParameter2 (string name, string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameter2Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.GetParameter2(name, projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParameter2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertyDto**](PropertyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametertype1"></a>
# **GetParameterType1**
> TypeDto GetParameterType1 (string name, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterType1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                TypeDto result = apiInstance.GetParameterType1(name, projectLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParameterType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

[**TypeDto**](TypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametertyperawvalue1"></a>
# **GetParameterTypeRawValue1**
> string GetParameterTypeRawValue1 (string name, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterTypeRawValue1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetParameterTypeRawValue1(name, projectLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParameterTypeRawValue1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametervaluelong1"></a>
# **GetParameterValueLong1**
> string GetParameterValueLong1 (string name, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterValueLong1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetParameterValueLong1(name, projectLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParameterValueLong1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparameters1"></a>
# **GetParameters1**
> PropertiesDto GetParameters1 (string projectLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameters1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.GetParameters1(projectLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParameters1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentproject"></a>
# **GetParentProject**
> ProjectDto GetParentProject (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParentProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectDto result = apiInstance.GetParentProject(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetParentProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectagentpools"></a>
# **GetProjectAgentPools**
> AgentPoolsDto GetProjectAgentPools (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetProjectAgentPoolsExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolsDto result = apiInstance.GetProjectAgentPools(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectAgentPools: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentPoolsDto**](AgentPoolsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectsorder"></a>
# **GetProjectsOrder**
> ProjectsDto GetProjectsOrder (string projectLocator, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetProjectsOrderExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var field = field_example;  // string |  (optional) 

            try
            {
                ProjectsDto result = apiInstance.GetProjectsOrder(projectLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **field** | **string**|  | [optional] 

### Return type

[**ProjectsDto**](ProjectsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecurevalue"></a>
# **GetSecureValue**
> string GetSecureValue (string projectLocator, string token)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSecureValueExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var token = token_example;  // string | 

            try
            {
                string result = apiInstance.GetSecureValue(projectLocator, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetSecureValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **token** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettingsfile1"></a>
# **GetSettingsFile1**
> string GetSettingsFile1 (string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSettingsFile1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetSettingsFile1(projectLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetSettingsFile1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsingle1"></a>
# **GetSingle1**
> Object GetSingle1 (string featureLocator, string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSingle1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var featureLocator = featureLocator_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.GetSingle1(featureLocator, projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetSingle1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureLocator** | **string**|  | 
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reloadsettingsfile"></a>
# **ReloadSettingsFile**
> ProjectDto ReloadSettingsFile (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReloadSettingsFileExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectDto result = apiInstance.ReloadSettingsFile(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ReloadSettingsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedefaulttemplate"></a>
# **RemoveDefaultTemplate**
> void RemoveDefaultTemplate (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveDefaultTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                apiInstance.RemoveDefaultTemplate(projectLocator, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.RemoveDefaultTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replace"></a>
# **Replace**
> Object Replace (string featureLocator, string projectLocator, ProjectFeatureDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var featureLocator = featureLocator_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var body = new ProjectFeatureDto(); // ProjectFeatureDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.Replace(featureLocator, projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.Replace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureLocator** | **string**|  | 
 **projectLocator** | **string**|  | 
 **body** | [**ProjectFeatureDto**](ProjectFeatureDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceall"></a>
# **ReplaceAll**
> Object ReplaceAll (string projectLocator, ProjectFeaturesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceAllExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new ProjectFeaturesDto(); // ProjectFeaturesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                Object result = apiInstance.ReplaceAll(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ReplaceAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**ProjectFeaturesDto**](ProjectFeaturesDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildfieldwithproject"></a>
# **ServeBuildFieldWithProject**
> string ServeBuildFieldWithProject (string projectLocator, string btLocator, string buildLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildFieldWithProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildFieldWithProject(projectLocator, btLocator, buildLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildFieldWithProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
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

<a name="servebuildtype"></a>
# **ServeBuildType**
> BuildTypeDto ServeBuildType (string projectLocator, string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.ServeBuildType(projectLocator, btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildtypefieldwithproject"></a>
# **ServeBuildTypeFieldWithProject**
> string ServeBuildTypeFieldWithProject (string projectLocator, string btLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeFieldWithProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildTypeFieldWithProject(projectLocator, btLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildTypeFieldWithProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildtypetemplates"></a>
# **ServeBuildTypeTemplates**
> BuildTypeDto ServeBuildTypeTemplates (string projectLocator, string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeTemplatesExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.ServeBuildTypeTemplates(projectLocator, btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildTypeTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildtypesinproject"></a>
# **ServeBuildTypesInProject**
> BuildTypesDto ServeBuildTypesInProject (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypesInProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.ServeBuildTypesInProject(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildTypesInProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildwithproject1"></a>
# **ServeBuildWithProject1**
> BuildDto ServeBuildWithProject1 (string projectLocator, string btLocator, string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildWithProject1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.ServeBuildWithProject1(projectLocator, btLocator, buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuildWithProject1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
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

<a name="servebuilds1"></a>
# **ServeBuilds1**
> BuildsDto ServeBuilds1 (string projectLocator, string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuilds1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.ServeBuilds1(projectLocator, btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeBuilds1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildsDto**](BuildsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveproject"></a>
# **ServeProject**
> ProjectDto ServeProject (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectDto result = apiInstance.ServeProject(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveprojectfield"></a>
# **ServeProjectField**
> string ServeProjectField (string projectLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeProjectFieldExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeProjectField(projectLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeProjectField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveprojects"></a>
# **ServeProjects**
> ProjectsDto ServeProjects (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeProjectsExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectsDto result = apiInstance.ServeProjects(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeProjects: " + e.Message );
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

[**ProjectsDto**](ProjectsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servetemplatesinproject"></a>
# **ServeTemplatesInProject**
> BuildTypesDto ServeTemplatesInProject (string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeTemplatesInProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.ServeTemplatesInProject(projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ServeTemplatesInProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbuildtypesorder"></a>
# **SetBuildTypesOrder**
> BuildTypesDto SetBuildTypesOrder (string projectLocator, BuildTypesDto body = null, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildTypesOrderExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new BuildTypesDto(); // BuildTypesDto |  (optional) 
            var field = field_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.SetBuildTypesOrder(projectLocator, body, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetBuildTypesOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**BuildTypesDto**](BuildTypesDto.md)|  | [optional] 
 **field** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdefaulttemplate"></a>
# **SetDefaultTemplate**
> BuildTypeDto SetDefaultTemplate (string projectLocator, BuildTypeDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetDefaultTemplateExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new BuildTypeDto(); // BuildTypeDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.SetDefaultTemplate(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetDefaultTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**BuildTypeDto**](BuildTypeDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparameter2"></a>
# **SetParameter2**
> PropertyDto SetParameter2 (string name, string projectLocator, PropertyDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameter2Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var body = new PropertyDto(); // PropertyDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.SetParameter2(name, projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameter2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 
 **body** | [**PropertyDto**](PropertyDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertyDto**](PropertyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparameter3"></a>
# **SetParameter3**
> PropertyDto SetParameter3 (string projectLocator, PropertyDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameter3Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new PropertyDto(); // PropertyDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.SetParameter3(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameter3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**PropertyDto**](PropertyDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertyDto**](PropertyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparametertype1"></a>
# **SetParameterType1**
> TypeDto SetParameterType1 (string name, string projectLocator, TypeDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterType1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var body = new TypeDto(); // TypeDto |  (optional) 

            try
            {
                TypeDto result = apiInstance.SetParameterType1(name, projectLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameterType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 
 **body** | [**TypeDto**](TypeDto.md)|  | [optional] 

### Return type

[**TypeDto**](TypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparametertyperawvalue1"></a>
# **SetParameterTypeRawValue1**
> string SetParameterTypeRawValue1 (string name, string projectLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterTypeRawValue1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetParameterTypeRawValue1(name, projectLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameterTypeRawValue1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparametervaluelong1"></a>
# **SetParameterValueLong1**
> string SetParameterValueLong1 (string name, string projectLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterValueLong1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var name = name_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetParameterValueLong1(name, projectLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameterValueLong1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **projectLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparameters1"></a>
# **SetParameters1**
> PropertiesDto SetParameters1 (string projectLocator, PropertiesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameters1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new PropertiesDto(); // PropertiesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.SetParameters1(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParameters1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
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

<a name="setparentproject"></a>
# **SetParentProject**
> ProjectDto SetParentProject (string projectLocator, ProjectDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParentProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new ProjectDto(); // ProjectDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectDto result = apiInstance.SetParentProject(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetParentProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**ProjectDto**](ProjectDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprojectagentpools"></a>
# **SetProjectAgentPools**
> AgentPoolDto SetProjectAgentPools (string projectLocator, AgentPoolDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetProjectAgentPoolsExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new AgentPoolDto(); // AgentPoolDto |  (optional) 

            try
            {
                AgentPoolDto result = apiInstance.SetProjectAgentPools(projectLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetProjectAgentPools: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**AgentPoolDto**](AgentPoolDto.md)|  | [optional] 

### Return type

[**AgentPoolDto**](AgentPoolDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprojectagentpools1"></a>
# **SetProjectAgentPools1**
> AgentPoolsDto SetProjectAgentPools1 (string projectLocator, AgentPoolsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetProjectAgentPools1Example
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new AgentPoolsDto(); // AgentPoolsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolsDto result = apiInstance.SetProjectAgentPools1(projectLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetProjectAgentPools1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**AgentPoolsDto**](AgentPoolsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentPoolsDto**](AgentPoolsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setprojectfield"></a>
# **SetProjectField**
> string SetProjectField (string projectLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetProjectFieldExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetProjectField(projectLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetProjectField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
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

<a name="setprojectsorder"></a>
# **SetProjectsOrder**
> ProjectsDto SetProjectsOrder (string projectLocator, ProjectsDto body = null, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetProjectsOrderExample
    {
        public void main()
        {
            var apiInstance = new ProjectApi();
            var projectLocator = projectLocator_example;  // string | 
            var body = new ProjectsDto(); // ProjectsDto |  (optional) 
            var field = field_example;  // string |  (optional) 

            try
            {
                ProjectsDto result = apiInstance.SetProjectsOrder(projectLocator, body, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.SetProjectsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectLocator** | **string**|  | 
 **body** | [**ProjectsDto**](ProjectsDto.md)|  | [optional] 
 **field** | **string**|  | [optional] 

### Return type

[**ProjectsDto**](ProjectsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

