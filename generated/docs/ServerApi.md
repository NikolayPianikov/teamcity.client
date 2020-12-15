# TeamCity.Api.ServerApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLicenseKeys**](ServerApi.md#addlicensekeys) | **POST** /app/rest/server/licensingData/licenseKeys | 
[**DeleteLicenseKey**](ServerApi.md#deletelicensekey) | **DELETE** /app/rest/server/licensingData/licenseKeys/{licenseKey} | 
[**GetBackupStatus**](ServerApi.md#getbackupstatus) | **GET** /app/rest/server/backup | 
[**GetChildren3**](ServerApi.md#getchildren3) | **GET** /app/rest/server/files/{areaId}/children{path} | 
[**GetChildrenAlias3**](ServerApi.md#getchildrenalias3) | **GET** /app/rest/server/files/{areaId}/{path} | 
[**GetContent3**](ServerApi.md#getcontent3) | **GET** /app/rest/server/files/{areaId}/content{path} | 
[**GetContentAlias3**](ServerApi.md#getcontentalias3) | **GET** /app/rest/server/files/{areaId}/files{path} | 
[**GetLicenseKey**](ServerApi.md#getlicensekey) | **GET** /app/rest/server/licensingData/licenseKeys/{licenseKey} | 
[**GetLicenseKeys**](ServerApi.md#getlicensekeys) | **GET** /app/rest/server/licensingData/licenseKeys | 
[**GetLicensingData**](ServerApi.md#getlicensingdata) | **GET** /app/rest/server/licensingData | 
[**GetMetadata3**](ServerApi.md#getmetadata3) | **GET** /app/rest/server/files/{areaId}/metadata{path} | 
[**GetRoot3**](ServerApi.md#getroot3) | **GET** /app/rest/server/files/{areaId} | 
[**GetZipped3**](ServerApi.md#getzipped3) | **GET** /app/rest/server/files/{areaId}/archived{path} | 
[**ServeMetrics**](ServerApi.md#servemetrics) | **GET** /app/rest/server/metrics | 
[**ServePlugins**](ServerApi.md#serveplugins) | **GET** /app/rest/server/plugins | 
[**ServeServerInfo**](ServerApi.md#serveserverinfo) | **GET** /app/rest/server | 
[**ServeServerVersion**](ServerApi.md#serveserverversion) | **GET** /app/rest/server/{field} | 
[**StartBackup**](ServerApi.md#startbackup) | **POST** /app/rest/server/backup | 


<a name="addlicensekeys"></a>
# **AddLicenseKeys**
> LicenseKeysDto AddLicenseKeys (string body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddLicenseKeysExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var body = body_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                LicenseKeysDto result = apiInstance.AddLicenseKeys(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.AddLicenseKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**LicenseKeysDto**](LicenseKeysDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelicensekey"></a>
# **DeleteLicenseKey**
> void DeleteLicenseKey (string licenseKey)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteLicenseKeyExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var licenseKey = licenseKey_example;  // string | 

            try
            {
                apiInstance.DeleteLicenseKey(licenseKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.DeleteLicenseKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **licenseKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbackupstatus"></a>
# **GetBackupStatus**
> string GetBackupStatus (BackupProcessManagerDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBackupStatusExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var body = new BackupProcessManagerDto(); // BackupProcessManagerDto |  (optional) 

            try
            {
                string result = apiInstance.GetBackupStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetBackupStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupProcessManagerDto**](BackupProcessManagerDto.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren3"></a>
# **GetChildren3**
> FilesDto GetChildren3 (string path, string areaId, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildren3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildren3(path, areaId, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetChildren3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 
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

<a name="getchildrenalias3"></a>
# **GetChildrenAlias3**
> FilesDto GetChildrenAlias3 (string path, string areaId, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenAlias3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildrenAlias3(path, areaId, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetChildrenAlias3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 
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

<a name="getcontent3"></a>
# **GetContent3**
> void GetContent3 (string path, string areaId, string responseBuilder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContent3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 
            var responseBuilder = responseBuilder_example;  // string |  (optional) 

            try
            {
                apiInstance.GetContent3(path, areaId, responseBuilder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetContent3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 
 **responseBuilder** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentalias3"></a>
# **GetContentAlias3**
> void GetContentAlias3 (string path, string areaId)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentAlias3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 

            try
            {
                apiInstance.GetContentAlias3(path, areaId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetContentAlias3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicensekey"></a>
# **GetLicenseKey**
> LicenseKeyDto GetLicenseKey (string licenseKey, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetLicenseKeyExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var licenseKey = licenseKey_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                LicenseKeyDto result = apiInstance.GetLicenseKey(licenseKey, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetLicenseKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **licenseKey** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**LicenseKeyDto**](LicenseKeyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicensekeys"></a>
# **GetLicenseKeys**
> LicenseKeysDto GetLicenseKeys (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetLicenseKeysExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                LicenseKeysDto result = apiInstance.GetLicenseKeys(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetLicenseKeys: " + e.Message );
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

[**LicenseKeysDto**](LicenseKeysDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicensingdata"></a>
# **GetLicensingData**
> LicensingDataDto GetLicensingData (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetLicensingDataExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                LicensingDataDto result = apiInstance.GetLicensingData(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetLicensingData: " + e.Message );
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

[**LicensingDataDto**](LicensingDataDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata3"></a>
# **GetMetadata3**
> FileDto GetMetadata3 (string path, string areaId, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMetadata3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FileDto result = apiInstance.GetMetadata3(path, areaId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetMetadata3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**FileDto**](FileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroot3"></a>
# **GetRoot3**
> FilesDto GetRoot3 (string areaId, string basePath = null, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRoot3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var areaId = areaId_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetRoot3(areaId, basePath, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetRoot3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **areaId** | **string**|  | 
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

<a name="getzipped3"></a>
# **GetZipped3**
> void GetZipped3 (string path, string areaId, string basePath = null, string locator = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetZipped3Example
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var path = path_example;  // string | 
            var areaId = areaId_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.GetZipped3(path, areaId, basePath, locator, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetZipped3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **areaId** | **string**|  | 
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

<a name="servemetrics"></a>
# **ServeMetrics**
> MetricsDto ServeMetrics (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeMetricsExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                MetricsDto result = apiInstance.ServeMetrics(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServeMetrics: " + e.Message );
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

[**MetricsDto**](MetricsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveplugins"></a>
# **ServePlugins**
> PluginsDto ServePlugins (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServePluginsExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PluginsDto result = apiInstance.ServePlugins(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServePlugins: " + e.Message );
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

[**PluginsDto**](PluginsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveserverinfo"></a>
# **ServeServerInfo**
> ServerDto ServeServerInfo (string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeServerInfoExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ServerDto result = apiInstance.ServeServerInfo(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServeServerInfo: " + e.Message );
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

[**ServerDto**](ServerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serveserverversion"></a>
# **ServeServerVersion**
> string ServeServerVersion (string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeServerVersionExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeServerVersion(field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServeServerVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **field** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startbackup"></a>
# **StartBackup**
> string StartBackup (string fileName = null, bool? addTimestamp = null, bool? includeConfigs = null, bool? includeDatabase = null, bool? includeBuildLogs = null, bool? includePersonalChanges = null, bool? includeRunningBuilds = null, bool? includeSupplimentaryData = null, BackupProcessManagerDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class StartBackupExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var fileName = fileName_example;  // string |  (optional) 
            var addTimestamp = true;  // bool? |  (optional) 
            var includeConfigs = true;  // bool? |  (optional) 
            var includeDatabase = true;  // bool? |  (optional) 
            var includeBuildLogs = true;  // bool? |  (optional) 
            var includePersonalChanges = true;  // bool? |  (optional) 
            var includeRunningBuilds = true;  // bool? |  (optional) 
            var includeSupplimentaryData = true;  // bool? |  (optional) 
            var body = new BackupProcessManagerDto(); // BackupProcessManagerDto |  (optional) 

            try
            {
                string result = apiInstance.StartBackup(fileName, addTimestamp, includeConfigs, includeDatabase, includeBuildLogs, includePersonalChanges, includeRunningBuilds, includeSupplimentaryData, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.StartBackup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**|  | [optional] 
 **addTimestamp** | **bool?**|  | [optional] 
 **includeConfigs** | **bool?**|  | [optional] 
 **includeDatabase** | **bool?**|  | [optional] 
 **includeBuildLogs** | **bool?**|  | [optional] 
 **includePersonalChanges** | **bool?**|  | [optional] 
 **includeRunningBuilds** | **bool?**|  | [optional] 
 **includeSupplimentaryData** | **bool?**|  | [optional] 
 **body** | [**BackupProcessManagerDto**](BackupProcessManagerDto.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

