# TeamCity.Api.AgentApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAgent**](AgentApi.md#deleteagent) | **DELETE** /app/rest/agents/{agentLocator} | 
[**GeIncompatibleBuildTypes**](AgentApi.md#geincompatiblebuildtypes) | **GET** /app/rest/agents/{agentLocator}/incompatibleBuildTypes | 
[**GetAgentPool**](AgentApi.md#getagentpool) | **GET** /app/rest/agents/{agentLocator}/pool | 
[**GetAllowedRunConfigurations**](AgentApi.md#getallowedrunconfigurations) | **GET** /app/rest/agents/{agentLocator}/compatibilityPolicy | 
[**GetAuthorizedInfo**](AgentApi.md#getauthorizedinfo) | **GET** /app/rest/agents/{agentLocator}/authorizedInfo | 
[**GetCompatibleBuildTypes**](AgentApi.md#getcompatiblebuildtypes) | **GET** /app/rest/agents/{agentLocator}/compatibleBuildTypes | 
[**GetEnabledInfo**](AgentApi.md#getenabledinfo) | **GET** /app/rest/agents/{agentLocator}/enabledInfo | 
[**ServeAgent**](AgentApi.md#serveagent) | **GET** /app/rest/agents/{agentLocator} | 
[**ServeAgentField**](AgentApi.md#serveagentfield) | **GET** /app/rest/agents/{agentLocator}/{field} | 
[**ServeAgents**](AgentApi.md#serveagents) | **GET** /app/rest/agents | 
[**SetAgentField**](AgentApi.md#setagentfield) | **PUT** /app/rest/agents/{agentLocator}/{field} | 
[**SetAgentPool**](AgentApi.md#setagentpool) | **PUT** /app/rest/agents/{agentLocator}/pool | 
[**SetAllowedRunConfigurations**](AgentApi.md#setallowedrunconfigurations) | **PUT** /app/rest/agents/{agentLocator}/compatibilityPolicy | 
[**SetAuthorizedInfo**](AgentApi.md#setauthorizedinfo) | **PUT** /app/rest/agents/{agentLocator}/authorizedInfo | 
[**SetEnabledInfo**](AgentApi.md#setenabledinfo) | **PUT** /app/rest/agents/{agentLocator}/enabledInfo | 


<a name="deleteagent"></a>
# **DeleteAgent**
> void DeleteAgent (string agentLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 

            try
            {
                apiInstance.DeleteAgent(agentLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.DeleteAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geincompatiblebuildtypes"></a>
# **GeIncompatibleBuildTypes**
> CompatibilitiesDto GeIncompatibleBuildTypes (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GeIncompatibleBuildTypesExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CompatibilitiesDto result = apiInstance.GeIncompatibleBuildTypes(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GeIncompatibleBuildTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CompatibilitiesDto**](CompatibilitiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentpool"></a>
# **GetAgentPool**
> AgentPoolDto GetAgentPool (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAgentPoolExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolDto result = apiInstance.GetAgentPool(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAgentPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentPoolDto**](AgentPoolDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallowedrunconfigurations"></a>
# **GetAllowedRunConfigurations**
> CompatibilityPolicyDto GetAllowedRunConfigurations (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAllowedRunConfigurationsExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CompatibilityPolicyDto result = apiInstance.GetAllowedRunConfigurations(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAllowedRunConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**CompatibilityPolicyDto**](CompatibilityPolicyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthorizedinfo"></a>
# **GetAuthorizedInfo**
> AuthorizedInfoDto GetAuthorizedInfo (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAuthorizedInfoExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AuthorizedInfoDto result = apiInstance.GetAuthorizedInfo(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetAuthorizedInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AuthorizedInfoDto**](AuthorizedInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcompatiblebuildtypes"></a>
# **GetCompatibleBuildTypes**
> BuildTypesDto GetCompatibleBuildTypes (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetCompatibleBuildTypesExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.GetCompatibleBuildTypes(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetCompatibleBuildTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenabledinfo"></a>
# **GetEnabledInfo**
> EnabledInfoDto GetEnabledInfo (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetEnabledInfoExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                EnabledInfoDto result = apiInstance.GetEnabledInfo(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.GetEnabledInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**EnabledInfoDto**](EnabledInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveagent"></a>
# **ServeAgent**
> AgentDto ServeAgent (string agentLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentDto result = apiInstance.ServeAgent(agentLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.ServeAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentDto**](AgentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveagentfield"></a>
# **ServeAgentField**
> string ServeAgentField (string agentLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAgentFieldExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeAgentField(agentLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.ServeAgentField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveagents"></a>
# **ServeAgents**
> AgentsDto ServeAgents (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeAgentsExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentsDto result = apiInstance.ServeAgents(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.ServeAgents: " + e.Message );
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

[**AgentsDto**](AgentsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setagentfield"></a>
# **SetAgentField**
> string SetAgentField (string agentLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetAgentFieldExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetAgentField(agentLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.SetAgentField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
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

<a name="setagentpool"></a>
# **SetAgentPool**
> AgentPoolDto SetAgentPool (string agentLocator, AgentPoolDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetAgentPoolExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var body = new AgentPoolDto(); // AgentPoolDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentPoolDto result = apiInstance.SetAgentPool(agentLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.SetAgentPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **body** | [**AgentPoolDto**](AgentPoolDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentPoolDto**](AgentPoolDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setallowedrunconfigurations"></a>
# **SetAllowedRunConfigurations**
> CompatibilityPolicyDto SetAllowedRunConfigurations (string agentLocator, CompatibilityPolicyDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetAllowedRunConfigurationsExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var body = new CompatibilityPolicyDto(); // CompatibilityPolicyDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                CompatibilityPolicyDto result = apiInstance.SetAllowedRunConfigurations(agentLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.SetAllowedRunConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **body** | [**CompatibilityPolicyDto**](CompatibilityPolicyDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**CompatibilityPolicyDto**](CompatibilityPolicyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setauthorizedinfo"></a>
# **SetAuthorizedInfo**
> AuthorizedInfoDto SetAuthorizedInfo (string agentLocator, AuthorizedInfoDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetAuthorizedInfoExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var body = new AuthorizedInfoDto(); // AuthorizedInfoDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AuthorizedInfoDto result = apiInstance.SetAuthorizedInfo(agentLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.SetAuthorizedInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **body** | [**AuthorizedInfoDto**](AuthorizedInfoDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**AuthorizedInfoDto**](AuthorizedInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setenabledinfo"></a>
# **SetEnabledInfo**
> EnabledInfoDto SetEnabledInfo (string agentLocator, EnabledInfoDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetEnabledInfoExample
    {
        public void main()
        {
            var apiInstance = new AgentApi();
            var agentLocator = agentLocator_example;  // string | 
            var body = new EnabledInfoDto(); // EnabledInfoDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                EnabledInfoDto result = apiInstance.SetEnabledInfo(agentLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentApi.SetEnabledInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentLocator** | **string**|  | 
 **body** | [**EnabledInfoDto**](EnabledInfoDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**EnabledInfoDto**](EnabledInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

