# TeamCity.Api.AgentPoolApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAgent**](AgentPoolApi.md#addagent) | **POST** /app/rest/agentPools/{agentPoolLocator}/agents | 
[**AddProject**](AgentPoolApi.md#addproject) | **POST** /app/rest/agentPools/{agentPoolLocator}/projects | 
[**CreatePool**](AgentPoolApi.md#createpool) | **POST** /app/rest/agentPools | 
[**DeletePool**](AgentPoolApi.md#deletepool) | **DELETE** /app/rest/agentPools/{agentPoolLocator} | 
[**DeletePoolProject**](AgentPoolApi.md#deletepoolproject) | **DELETE** /app/rest/agentPools/{agentPoolLocator}/projects/{projectLocator} | 
[**DeleteProjects**](AgentPoolApi.md#deleteprojects) | **DELETE** /app/rest/agentPools/{agentPoolLocator}/projects | 
[**GetField**](AgentPoolApi.md#getfield) | **GET** /app/rest/agentPools/{agentPoolLocator}/{field} | 
[**GetPool**](AgentPoolApi.md#getpool) | **GET** /app/rest/agentPools/{agentPoolLocator} | 
[**GetPoolAgents**](AgentPoolApi.md#getpoolagents) | **GET** /app/rest/agentPools/{agentPoolLocator}/agents | 
[**GetPoolProject**](AgentPoolApi.md#getpoolproject) | **GET** /app/rest/agentPools/{agentPoolLocator}/projects/{projectLocator} | 
[**GetPoolProjects**](AgentPoolApi.md#getpoolprojects) | **GET** /app/rest/agentPools/{agentPoolLocator}/projects | 
[**GetPools**](AgentPoolApi.md#getpools) | **GET** /app/rest/agentPools | 
[**ReplaceProjects**](AgentPoolApi.md#replaceprojects) | **PUT** /app/rest/agentPools/{agentPoolLocator}/projects | 
[**SetField**](AgentPoolApi.md#setfield) | **PUT** /app/rest/agentPools/{agentPoolLocator}/{field} | 


<a name="addagent"></a>
# **AddAgent**
> AgentDto AddAgent (string agentPoolLocator, AgentDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var body = new AgentDto(); // AgentDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentDto result = apiInstance.AddAgent(agentPoolLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.AddAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **body** | [**AgentDto**](AgentDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentDto**](AgentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproject"></a>
# **AddProject**
> ProjectDto AddProject (string agentPoolLocator, ProjectDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddProjectExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var body = new ProjectDto(); // ProjectDto |  (optional) 

            try
            {
                ProjectDto result = apiInstance.AddProject(agentPoolLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.AddProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **body** | [**ProjectDto**](ProjectDto.md)|  | [optional] 

### Return type

[**ProjectDto**](ProjectDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpool"></a>
# **CreatePool**
> AgentPoolDto CreatePool (AgentPoolDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreatePoolExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var body = new AgentPoolDto(); // AgentPoolDto |  (optional) 

            try
            {
                AgentPoolDto result = apiInstance.CreatePool(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.CreatePool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AgentPoolDto**](AgentPoolDto.md)|  | [optional] 

### Return type

[**AgentPoolDto**](AgentPoolDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepool"></a>
# **DeletePool**
> void DeletePool (string agentPoolLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeletePoolExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 

            try
            {
                apiInstance.DeletePool(agentPoolLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.DeletePool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepoolproject"></a>
# **DeletePoolProject**
> void DeletePoolProject (string agentPoolLocator, string projectLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeletePoolProjectExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 

            try
            {
                apiInstance.DeletePoolProject(agentPoolLocator, projectLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.DeletePoolProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **projectLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojects"></a>
# **DeleteProjects**
> void DeleteProjects (string agentPoolLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteProjectsExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 

            try
            {
                apiInstance.DeleteProjects(agentPoolLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.DeleteProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfield"></a>
# **GetField**
> string GetField (string agentPoolLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFieldExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.GetField(agentPoolLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpool"></a>
# **GetPool**
> AgentPoolDto GetPool (string agentPoolLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPoolExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolDto result = apiInstance.GetPool(agentPoolLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentPoolDto**](AgentPoolDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoolagents"></a>
# **GetPoolAgents**
> AgentsDto GetPoolAgents (string agentPoolLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPoolAgentsExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentsDto result = apiInstance.GetPoolAgents(agentPoolLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetPoolAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentsDto**](AgentsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoolproject"></a>
# **GetPoolProject**
> ProjectDto GetPoolProject (string agentPoolLocator, string projectLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPoolProjectExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var projectLocator = projectLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectDto result = apiInstance.GetPoolProject(agentPoolLocator, projectLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetPoolProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
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

<a name="getpoolprojects"></a>
# **GetPoolProjects**
> ProjectsDto GetPoolProjects (string agentPoolLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPoolProjectsExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ProjectsDto result = apiInstance.GetPoolProjects(agentPoolLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetPoolProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ProjectsDto**](ProjectsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpools"></a>
# **GetPools**
> AgentPoolsDto GetPools (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPoolsExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolsDto result = apiInstance.GetPools(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.GetPools: " + e.Message );
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

[**AgentPoolsDto**](AgentPoolsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceprojects"></a>
# **ReplaceProjects**
> ProjectsDto ReplaceProjects (string agentPoolLocator, ProjectsDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceProjectsExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var body = new ProjectsDto(); // ProjectsDto |  (optional) 

            try
            {
                ProjectsDto result = apiInstance.ReplaceProjects(agentPoolLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.ReplaceProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
 **body** | [**ProjectsDto**](ProjectsDto.md)|  | [optional] 

### Return type

[**ProjectsDto**](ProjectsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfield"></a>
# **SetField**
> string SetField (string agentPoolLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetFieldExample
    {
        public void main()
        {
            var apiInstance = new AgentPoolApi();
            var agentPoolLocator = agentPoolLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetField(agentPoolLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentPoolApi.SetField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentPoolLocator** | **string**|  | 
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

