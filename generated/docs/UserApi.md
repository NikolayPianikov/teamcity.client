# TeamCity.Api.UserApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGroupToUser**](UserApi.md#addgrouptouser) | **POST** /app/rest/users/{userLocator}/groups | 
[**AddRoleToUser**](UserApi.md#addroletouser) | **POST** /app/rest/users/{userLocator}/roles | 
[**AddRoleToUserSimple**](UserApi.md#addroletousersimple) | **PUT** /app/rest/users/{userLocator}/roles/{roleId}/{scope} | 
[**CreateToken**](UserApi.md#createtoken) | **POST** /app/rest/users/{userLocator}/tokens/{name} | 
[**CreateToken1**](UserApi.md#createtoken1) | **POST** /app/rest/users/{userLocator}/tokens | 
[**CreateUser**](UserApi.md#createuser) | **POST** /app/rest/users | 
[**DeleteRememberMe**](UserApi.md#deleterememberme) | **DELETE** /app/rest/users/{userLocator}/debug/rememberMe | 
[**DeleteRoleFromUser**](UserApi.md#deleterolefromuser) | **DELETE** /app/rest/users/{userLocator}/roles/{roleId}/{scope} | 
[**DeleteToken**](UserApi.md#deletetoken) | **DELETE** /app/rest/users/{userLocator}/tokens/{name} | 
[**DeleteUser**](UserApi.md#deleteuser) | **DELETE** /app/rest/users/{userLocator} | 
[**DeleteUserField**](UserApi.md#deleteuserfield) | **DELETE** /app/rest/users/{userLocator}/{field} | 
[**GetGroup**](UserApi.md#getgroup) | **GET** /app/rest/users/{userLocator}/groups/{groupLocator} | 
[**GetGroups**](UserApi.md#getgroups) | **GET** /app/rest/users/{userLocator}/groups | 
[**GetPermissions1**](UserApi.md#getpermissions1) | **GET** /app/rest/users/{userLocator}/permissions | 
[**GetPermissions2**](UserApi.md#getpermissions2) | **GET** /app/rest/users/{userLocator}/debug/permissions | 
[**GetTokens**](UserApi.md#gettokens) | **GET** /app/rest/users/{userLocator}/tokens | 
[**ListRoleForUser**](UserApi.md#listroleforuser) | **GET** /app/rest/users/{userLocator}/roles/{roleId}/{scope} | 
[**ListRolesForUser**](UserApi.md#listrolesforuser) | **GET** /app/rest/users/{userLocator}/roles | 
[**PutUserProperty1**](UserApi.md#putuserproperty1) | **PUT** /app/rest/users/{userLocator}/properties/{name} | 
[**RemoveGroup**](UserApi.md#removegroup) | **DELETE** /app/rest/users/{userLocator}/groups/{groupLocator} | 
[**RemoveUserProperty1**](UserApi.md#removeuserproperty1) | **DELETE** /app/rest/users/{userLocator}/properties/{name} | 
[**ReplaceGroups**](UserApi.md#replacegroups) | **PUT** /app/rest/users/{userLocator}/groups | 
[**ReplaceRoles**](UserApi.md#replaceroles) | **PUT** /app/rest/users/{userLocator}/roles | 
[**ServeUser**](UserApi.md#serveuser) | **GET** /app/rest/users/{userLocator} | 
[**ServeUserField**](UserApi.md#serveuserfield) | **GET** /app/rest/users/{userLocator}/{field} | 
[**ServeUserProperties1**](UserApi.md#serveuserproperties1) | **GET** /app/rest/users/{userLocator}/properties | 
[**ServeUserProperty**](UserApi.md#serveuserproperty) | **GET** /app/rest/users/{userLocator}/properties/{name} | 
[**ServeUsers**](UserApi.md#serveusers) | **GET** /app/rest/users | 
[**SetUserField**](UserApi.md#setuserfield) | **PUT** /app/rest/users/{userLocator}/{field} | 
[**UpdateUser**](UserApi.md#updateuser) | **PUT** /app/rest/users/{userLocator} | 


<a name="addgrouptouser"></a>
# **AddGroupToUser**
> GroupDto AddGroupToUser (string userLocator, GroupDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddGroupToUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new GroupDto(); // GroupDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupDto result = apiInstance.AddGroupToUser(userLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddGroupToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="addroletouser"></a>
# **AddRoleToUser**
> RoleDto AddRoleToUser (string userLocator, RoleDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddRoleToUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new RoleDto(); // RoleDto |  (optional) 

            try
            {
                RoleDto result = apiInstance.AddRoleToUser(userLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddRoleToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **body** | [**RoleDto**](RoleDto.md)|  | [optional] 

### Return type

[**RoleDto**](RoleDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addroletousersimple"></a>
# **AddRoleToUserSimple**
> RoleDto AddRoleToUserSimple (string userLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddRoleToUserSimpleExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                RoleDto result = apiInstance.AddRoleToUserSimple(userLocator, roleId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.AddRoleToUserSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="createtoken"></a>
# **CreateToken**
> TokenDto CreateToken (string userLocator, string name, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateTokenExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var name = name_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TokenDto result = apiInstance.CreateToken(userLocator, name, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **name** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TokenDto**](TokenDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtoken1"></a>
# **CreateToken1**
> TokenDto CreateToken1 (string userLocator, TokenDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateToken1Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new TokenDto(); // TokenDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TokenDto result = apiInstance.CreateToken1(userLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateToken1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **body** | [**TokenDto**](TokenDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**TokenDto**](TokenDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> UserDto CreateUser (UserDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new UserDto(); // UserDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                UserDto result = apiInstance.CreateUser(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserDto**](UserDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterememberme"></a>
# **DeleteRememberMe**
> void DeleteRememberMe (string userLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteRememberMeExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 

            try
            {
                apiInstance.DeleteRememberMe(userLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteRememberMe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterolefromuser"></a>
# **DeleteRoleFromUser**
> void DeleteRoleFromUser (string userLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteRoleFromUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                apiInstance.DeleteRoleFromUser(userLocator, roleId, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteRoleFromUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="deletetoken"></a>
# **DeleteToken**
> void DeleteToken (string userLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteTokenExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                apiInstance.DeleteToken(userLocator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 

            try
            {
                apiInstance.DeleteUser(userLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserfield"></a>
# **DeleteUserField**
> void DeleteUserField (string userLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteUserFieldExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                apiInstance.DeleteUserField(userLocator, field);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUserField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupDto GetGroup (string userLocator, string groupLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetGroupExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var groupLocator = groupLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupDto result = apiInstance.GetGroup(userLocator, groupLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="getgroups"></a>
# **GetGroups**
> GroupsDto GetGroups (string userLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupsDto result = apiInstance.GetGroups(userLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**GroupsDto**](GroupsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissions1"></a>
# **GetPermissions1**
> PermissionAssignmentsDto GetPermissions1 (string userLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPermissions1Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PermissionAssignmentsDto result = apiInstance.GetPermissions1(userLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetPermissions1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**PermissionAssignmentsDto**](PermissionAssignmentsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissions2"></a>
# **GetPermissions2**
> string GetPermissions2 (string userLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetPermissions2Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetPermissions2(userLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetPermissions2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokens"></a>
# **GetTokens**
> TokensDto GetTokens (string userLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTokensExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TokensDto result = apiInstance.GetTokens(userLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TokensDto**](TokensDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listroleforuser"></a>
# **ListRoleForUser**
> RoleDto ListRoleForUser (string userLocator, string roleId, string scope)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ListRoleForUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var roleId = roleId_example;  // string | 
            var scope = scope_example;  // string | 

            try
            {
                RoleDto result = apiInstance.ListRoleForUser(userLocator, roleId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ListRoleForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="listrolesforuser"></a>
# **ListRolesForUser**
> RolesDto ListRolesForUser (string userLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ListRolesForUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 

            try
            {
                RolesDto result = apiInstance.ListRolesForUser(userLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ListRolesForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 

### Return type

[**RolesDto**](RolesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putuserproperty1"></a>
# **PutUserProperty1**
> string PutUserProperty1 (string userLocator, string name, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class PutUserProperty1Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var name = name_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.PutUserProperty1(userLocator, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.PutUserProperty1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="removegroup"></a>
# **RemoveGroup**
> void RemoveGroup (string userLocator, string groupLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveGroupExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var groupLocator = groupLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                apiInstance.RemoveGroup(userLocator, groupLocator, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RemoveGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **groupLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserproperty1"></a>
# **RemoveUserProperty1**
> void RemoveUserProperty1 (string userLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveUserProperty1Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                apiInstance.RemoveUserProperty1(userLocator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RemoveUserProperty1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacegroups"></a>
# **ReplaceGroups**
> GroupsDto ReplaceGroups (string userLocator, GroupsDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceGroupsExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new GroupsDto(); // GroupsDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                GroupsDto result = apiInstance.ReplaceGroups(userLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ReplaceGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="replaceroles"></a>
# **ReplaceRoles**
> RolesDto ReplaceRoles (string userLocator, RolesDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceRolesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new RolesDto(); // RolesDto |  (optional) 

            try
            {
                RolesDto result = apiInstance.ReplaceRoles(userLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ReplaceRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **body** | [**RolesDto**](RolesDto.md)|  | [optional] 

### Return type

[**RolesDto**](RolesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveuser"></a>
# **ServeUser**
> UserDto ServeUser (string userLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                UserDto result = apiInstance.ServeUser(userLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ServeUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveuserfield"></a>
# **ServeUserField**
> string ServeUserField (string userLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUserFieldExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeUserField(userLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ServeUserField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveuserproperties1"></a>
# **ServeUserProperties1**
> PropertiesDto ServeUserProperties1 (string userLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUserProperties1Example
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ServeUserProperties1(userLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ServeUserProperties1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveuserproperty"></a>
# **ServeUserProperty**
> string ServeUserProperty (string userLocator, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUserPropertyExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                string result = apiInstance.ServeUserProperty(userLocator, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ServeUserProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **name** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveusers"></a>
# **ServeUsers**
> UsersDto ServeUsers (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeUsersExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                UsersDto result = apiInstance.ServeUsers(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ServeUsers: " + e.Message );
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

[**UsersDto**](UsersDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserfield"></a>
# **SetUserField**
> string SetUserField (string userLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetUserFieldExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetUserField(userLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SetUserField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
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

<a name="updateuser"></a>
# **UpdateUser**
> UserDto UpdateUser (string userLocator, UserDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userLocator = userLocator_example;  // string | 
            var body = new UserDto(); // UserDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                UserDto result = apiInstance.UpdateUser(userLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userLocator** | **string**|  | 
 **body** | [**UserDto**](UserDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

