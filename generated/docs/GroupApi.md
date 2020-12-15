# TeamCity.Api.GroupApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGroup**](GroupApi.md#addgroup) | **POST** /app/rest/userGroups | 
[**AddRole**](GroupApi.md#addrole) | **POST** /app/rest/userGroups/{groupLocator}/roles | 
[**AddRoleSimple**](GroupApi.md#addrolesimple) | **POST** /app/rest/userGroups/{groupLocator}/roles/{roleId}/{scope} | 
[**DeleteGroup**](GroupApi.md#deletegroup) | **DELETE** /app/rest/userGroups/{groupLocator} | 
[**DeleteRole**](GroupApi.md#deleterole) | **DELETE** /app/rest/userGroups/{groupLocator}/roles/{roleId}/{scope} | 
[**GetParentGroups**](GroupApi.md#getparentgroups) | **GET** /app/rest/userGroups/{groupLocator}/parent-groups | 
[**GetPermissions**](GroupApi.md#getpermissions) | **GET** /app/rest/userGroups/{groupLocator}/debug/permissions | 
[**GetProperties**](GroupApi.md#getproperties) | **GET** /app/rest/userGroups/{groupLocator}/properties | 
[**ListRole**](GroupApi.md#listrole) | **GET** /app/rest/userGroups/{groupLocator}/roles/{roleId}/{scope} | 
[**ListRoles**](GroupApi.md#listroles) | **GET** /app/rest/userGroups/{groupLocator}/roles | 
[**PutUserProperty**](GroupApi.md#putuserproperty) | **PUT** /app/rest/userGroups/{groupLocator}/properties/{name} | 
[**RemoveUserProperty**](GroupApi.md#removeuserproperty) | **DELETE** /app/rest/userGroups/{groupLocator}/properties/{name} | 
[**ServeGroup**](GroupApi.md#servegroup) | **GET** /app/rest/userGroups/{groupLocator} | 
[**ServeGroups**](GroupApi.md#servegroups) | **GET** /app/rest/userGroups | 
[**ServeUserProperties**](GroupApi.md#serveuserproperties) | **GET** /app/rest/userGroups/{groupLocator}/properties/{name} | 
[**SetParentGroups**](GroupApi.md#setparentgroups) | **PUT** /app/rest/userGroups/{groupLocator}/parent-groups | 
[**SetRoles**](GroupApi.md#setroles) | **PUT** /app/rest/userGroups/{groupLocator}/roles | 


<a name="addgroup"></a>
# **AddGroup**
> GroupDto AddGroup (GroupDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var body = new GroupDto(); // GroupDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupDto result = apiInstance.AddGroup(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.AddGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupDto**](GroupDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**GroupDto**](GroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addrole"></a>
# **AddRole**
> RoleDto AddRole (string groupLocator, RoleDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddRoleExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var body = new RoleDto(); // RoleDto |  (optional) 

            try
            {
                RoleDto result = apiInstance.AddRole(groupLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.AddRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **body** | [**RoleDto**](RoleDto.md)|  | [optional] 

### Return type

[**RoleDto**](RoleDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addrolesimple"></a>
# **AddRoleSimple**
> RoleDto AddRoleSimple (string groupLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddRoleSimpleExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                RoleDto result = apiInstance.AddRoleSimple(groupLocator, roleId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.AddRoleSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **roleId** | **string**|  | 
 **scope** | **string**|  | 

### Return type

[**RoleDto**](RoleDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string groupLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 

            try
            {
                apiInstance.DeleteGroup(groupLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string groupLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                apiInstance.DeleteRole(groupLocator, roleId, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **roleId** | **string**|  | 
 **scope** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentgroups"></a>
# **GetParentGroups**
> GroupsDto GetParentGroups (string groupLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParentGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupsDto result = apiInstance.GetParentGroups(groupLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetParentGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**GroupsDto**](GroupsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissions"></a>
# **GetPermissions**
> string GetPermissions (string groupLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetPermissions(groupLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproperties"></a>
# **GetProperties**
> PropertiesDto GetProperties (string groupLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPropertiesExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.GetProperties(groupLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrole"></a>
# **ListRole**
> RoleDto ListRole (string groupLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ListRoleExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                RoleDto result = apiInstance.ListRole(groupLocator, roleId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ListRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **roleId** | **string**|  | 
 **scope** | **string**|  | 

### Return type

[**RoleDto**](RoleDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listroles"></a>
# **ListRoles**
> RolesDto ListRoles (string groupLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ListRolesExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 

            try
            {
                RolesDto result = apiInstance.ListRoles(groupLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ListRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 

### Return type

[**RolesDto**](RolesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putuserproperty"></a>
# **PutUserProperty**
> string PutUserProperty (string groupLocator, string name, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class PutUserPropertyExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var name = name_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.PutUserProperty(groupLocator, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.PutUserProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
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

<a name="removeuserproperty"></a>
# **RemoveUserProperty**
> void RemoveUserProperty (string groupLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveUserPropertyExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                apiInstance.RemoveUserProperty(groupLocator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.RemoveUserProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servegroup"></a>
# **ServeGroup**
> GroupDto ServeGroup (string groupLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupDto result = apiInstance.ServeGroup(groupLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ServeGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**GroupDto**](GroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servegroups"></a>
# **ServeGroups**
> GroupsDto ServeGroups (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupsDto result = apiInstance.ServeGroups(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ServeGroups: " + e.Message );
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

[**GroupsDto**](GroupsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveuserproperties"></a>
# **ServeUserProperties**
> string ServeUserProperties (string groupLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUserPropertiesExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                string result = apiInstance.ServeUserProperties(groupLocator, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.ServeUserProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparentgroups"></a>
# **SetParentGroups**
> GroupsDto SetParentGroups (string groupLocator, GroupsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParentGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var body = new GroupsDto(); // GroupsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupsDto result = apiInstance.SetParentGroups(groupLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SetParentGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **body** | [**GroupsDto**](GroupsDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**GroupsDto**](GroupsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setroles"></a>
# **SetRoles**
> RolesDto SetRoles (string groupLocator, RolesDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetRolesExample
    {
        public void main()
        {
            var apiInstance = new GroupApi();
            var groupLocator = groupLocator_example;  // string | 
            var body = new RolesDto(); // RolesDto |  (optional) 

            try
            {
                RolesDto result = apiInstance.SetRoles(groupLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupLocator** | **string**|  | 
 **body** | [**RolesDto**](RolesDto.md)|  | [optional] 

### Return type

[**RolesDto**](RolesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

