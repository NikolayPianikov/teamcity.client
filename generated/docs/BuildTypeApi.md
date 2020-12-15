# TeamCity.Api.BuildTypeApi

All URIs are relative to *https://teamcity.jetbrains.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAgentRequirement**](BuildTypeApi.md#addagentrequirement) | **POST** /app/rest/buildTypes/{btLocator}/agent-requirements | 
[**AddArtifactDep**](BuildTypeApi.md#addartifactdep) | **POST** /app/rest/buildTypes/{btLocator}/artifact-dependencies | 
[**AddBuildType**](BuildTypeApi.md#addbuildtype) | **POST** /app/rest/buildTypes | 
[**AddFeature**](BuildTypeApi.md#addfeature) | **POST** /app/rest/buildTypes/{btLocator}/features | 
[**AddFeatureParameter**](BuildTypeApi.md#addfeatureparameter) | **PUT** /app/rest/buildTypes/{btLocator}/features/{featureId}/parameters/{parameterName} | 
[**AddSnapshotDep**](BuildTypeApi.md#addsnapshotdep) | **POST** /app/rest/buildTypes/{btLocator}/snapshot-dependencies | 
[**AddStep**](BuildTypeApi.md#addstep) | **POST** /app/rest/buildTypes/{btLocator}/steps | 
[**AddStepParameter**](BuildTypeApi.md#addstepparameter) | **PUT** /app/rest/buildTypes/{btLocator}/steps/{stepId}/parameters/{parameterName} | 
[**AddTemplate**](BuildTypeApi.md#addtemplate) | **POST** /app/rest/buildTypes/{btLocator}/templates | 
[**AddTrigger**](BuildTypeApi.md#addtrigger) | **POST** /app/rest/buildTypes/{btLocator}/triggers | 
[**AddVcsRootEntry**](BuildTypeApi.md#addvcsrootentry) | **POST** /app/rest/buildTypes/{btLocator}/vcs-root-entries | 
[**ChangeArtifactDepSetting**](BuildTypeApi.md#changeartifactdepsetting) | **PUT** /app/rest/buildTypes/{btLocator}/artifact-dependencies/{artifactDepLocator}/{fieldName} | 
[**ChangeFeatureSetting**](BuildTypeApi.md#changefeaturesetting) | **PUT** /app/rest/buildTypes/{btLocator}/features/{featureId}/{name} | 
[**ChangeRequirementSetting**](BuildTypeApi.md#changerequirementsetting) | **PUT** /app/rest/buildTypes/{btLocator}/agent-requirements/{agentRequirementLocator}/{fieldName} | 
[**ChangeStepSetting**](BuildTypeApi.md#changestepsetting) | **PUT** /app/rest/buildTypes/{btLocator}/steps/{stepId}/{fieldName} | 
[**ChangeTriggerSetting**](BuildTypeApi.md#changetriggersetting) | **PUT** /app/rest/buildTypes/{btLocator}/triggers/{triggerLocator}/{fieldName} | 
[**DeleteAgentRequirement**](BuildTypeApi.md#deleteagentrequirement) | **DELETE** /app/rest/buildTypes/{btLocator}/agent-requirements/{agentRequirementLocator} | 
[**DeleteAllParameters**](BuildTypeApi.md#deleteallparameters) | **DELETE** /app/rest/buildTypes/{btLocator}/parameters | 
[**DeleteArtifactDep**](BuildTypeApi.md#deleteartifactdep) | **DELETE** /app/rest/buildTypes/{btLocator}/artifact-dependencies/{artifactDepLocator} | 
[**DeleteBuildType**](BuildTypeApi.md#deletebuildtype) | **DELETE** /app/rest/buildTypes/{btLocator} | 
[**DeleteFeature**](BuildTypeApi.md#deletefeature) | **DELETE** /app/rest/buildTypes/{btLocator}/features/{featureId} | 
[**DeleteParameter**](BuildTypeApi.md#deleteparameter) | **DELETE** /app/rest/buildTypes/{btLocator}/parameters/{name} | 
[**DeleteSnapshotDep**](BuildTypeApi.md#deletesnapshotdep) | **DELETE** /app/rest/buildTypes/{btLocator}/snapshot-dependencies/{snapshotDepLocator} | 
[**DeleteStep**](BuildTypeApi.md#deletestep) | **DELETE** /app/rest/buildTypes/{btLocator}/steps/{stepId} | 
[**DeleteTrigger**](BuildTypeApi.md#deletetrigger) | **DELETE** /app/rest/buildTypes/{btLocator}/triggers/{triggerLocator} | 
[**DeleteVcsRootEntry**](BuildTypeApi.md#deletevcsrootentry) | **DELETE** /app/rest/buildTypes/{btLocator}/vcs-root-entries/{vcsRootLocator} | 
[**GetAgentRequirement**](BuildTypeApi.md#getagentrequirement) | **GET** /app/rest/buildTypes/{btLocator}/agent-requirements/{agentRequirementLocator} | 
[**GetAgentRequirements**](BuildTypeApi.md#getagentrequirements) | **GET** /app/rest/buildTypes/{btLocator}/agent-requirements | 
[**GetAliases**](BuildTypeApi.md#getaliases) | **GET** /app/rest/buildTypes/{btLocator}/aliases | 
[**GetArtifactDep**](BuildTypeApi.md#getartifactdep) | **GET** /app/rest/buildTypes/{btLocator}/artifact-dependencies/{artifactDepLocator} | 
[**GetArtifactDepSetting**](BuildTypeApi.md#getartifactdepsetting) | **GET** /app/rest/buildTypes/{btLocator}/artifact-dependencies/{artifactDepLocator}/{fieldName} | 
[**GetArtifactDeps**](BuildTypeApi.md#getartifactdeps) | **GET** /app/rest/buildTypes/{btLocator}/artifact-dependencies | 
[**GetBuildTypes**](BuildTypeApi.md#getbuildtypes) | **GET** /app/rest/buildTypes | 
[**GetChildren2**](BuildTypeApi.md#getchildren2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/children{path} | 
[**GetChildrenAlias2**](BuildTypeApi.md#getchildrenalias2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/{path} | 
[**GetContent2**](BuildTypeApi.md#getcontent2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/content{path} | 
[**GetContentAlias2**](BuildTypeApi.md#getcontentalias2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/files{path} | 
[**GetCurrentVcsInstances**](BuildTypeApi.md#getcurrentvcsinstances) | **GET** /app/rest/buildTypes/{btLocator}/vcsRootInstances | 
[**GetCurrentVcsInstancesObsolete**](BuildTypeApi.md#getcurrentvcsinstancesobsolete) | **GET** /app/rest/buildTypes/{btLocator}/vcs-root-instances | 
[**GetFeature**](BuildTypeApi.md#getfeature) | **GET** /app/rest/buildTypes/{btLocator}/features/{featureId} | 
[**GetFeatureParameter**](BuildTypeApi.md#getfeatureparameter) | **GET** /app/rest/buildTypes/{btLocator}/features/{featureId}/parameters/{parameterName} | 
[**GetFeatureParameters**](BuildTypeApi.md#getfeatureparameters) | **GET** /app/rest/buildTypes/{btLocator}/features/{featureId}/parameters | 
[**GetFeatureSetting**](BuildTypeApi.md#getfeaturesetting) | **GET** /app/rest/buildTypes/{btLocator}/features/{featureId}/{name} | 
[**GetFeatures**](BuildTypeApi.md#getfeatures) | **GET** /app/rest/buildTypes/{btLocator}/features | 
[**GetInvestigations**](BuildTypeApi.md#getinvestigations) | **GET** /app/rest/buildTypes/{btLocator}/investigations | 
[**GetMetadata2**](BuildTypeApi.md#getmetadata2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/metadata{path} | 
[**GetParameter1**](BuildTypeApi.md#getparameter1) | **GET** /app/rest/buildTypes/{btLocator}/parameters/{name} | 
[**GetParameterType**](BuildTypeApi.md#getparametertype) | **GET** /app/rest/buildTypes/{btLocator}/parameters/{name}/type | 
[**GetParameterTypeRawValue**](BuildTypeApi.md#getparametertyperawvalue) | **GET** /app/rest/buildTypes/{btLocator}/parameters/{name}/type/rawValue | 
[**GetParameterValueLong**](BuildTypeApi.md#getparametervaluelong) | **GET** /app/rest/buildTypes/{btLocator}/parameters/{name}/value | 
[**GetParameters**](BuildTypeApi.md#getparameters) | **GET** /app/rest/buildTypes/{btLocator}/parameters | 
[**GetRequirementSetting**](BuildTypeApi.md#getrequirementsetting) | **GET** /app/rest/buildTypes/{btLocator}/agent-requirements/{agentRequirementLocator}/{fieldName} | 
[**GetRoot2**](BuildTypeApi.md#getroot2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest | 
[**GetSettingsFile**](BuildTypeApi.md#getsettingsfile) | **GET** /app/rest/buildTypes/{btLocator}/settingsFile | 
[**GetSnapshotDep**](BuildTypeApi.md#getsnapshotdep) | **GET** /app/rest/buildTypes/{btLocator}/snapshot-dependencies/{snapshotDepLocator} | 
[**GetSnapshotDeps**](BuildTypeApi.md#getsnapshotdeps) | **GET** /app/rest/buildTypes/{btLocator}/snapshot-dependencies | 
[**GetStep**](BuildTypeApi.md#getstep) | **GET** /app/rest/buildTypes/{btLocator}/steps/{stepId} | 
[**GetStepParameter**](BuildTypeApi.md#getstepparameter) | **GET** /app/rest/buildTypes/{btLocator}/steps/{stepId}/parameters/{parameterName} | 
[**GetStepParameters**](BuildTypeApi.md#getstepparameters) | **GET** /app/rest/buildTypes/{btLocator}/steps/{stepId}/parameters | 
[**GetStepSetting**](BuildTypeApi.md#getstepsetting) | **GET** /app/rest/buildTypes/{btLocator}/steps/{stepId}/{fieldName} | 
[**GetSteps**](BuildTypeApi.md#getsteps) | **GET** /app/rest/buildTypes/{btLocator}/steps | 
[**GetTemplate**](BuildTypeApi.md#gettemplate) | **GET** /app/rest/buildTypes/{btLocator}/templates/{templateLocator} | 
[**GetTemplates**](BuildTypeApi.md#gettemplates) | **GET** /app/rest/buildTypes/{btLocator}/templates | 
[**GetTrigger**](BuildTypeApi.md#gettrigger) | **GET** /app/rest/buildTypes/{btLocator}/triggers/{triggerLocator} | 
[**GetTriggerSetting**](BuildTypeApi.md#gettriggersetting) | **GET** /app/rest/buildTypes/{btLocator}/triggers/{triggerLocator}/{fieldName} | 
[**GetTriggers**](BuildTypeApi.md#gettriggers) | **GET** /app/rest/buildTypes/{btLocator}/triggers | 
[**GetVcsRootEntries**](BuildTypeApi.md#getvcsrootentries) | **GET** /app/rest/buildTypes/{btLocator}/vcs-root-entries | 
[**GetVcsRootEntry**](BuildTypeApi.md#getvcsrootentry) | **GET** /app/rest/buildTypes/{btLocator}/vcs-root-entries/{vcsRootLocator} | 
[**GetVcsRootEntryCheckoutRules**](BuildTypeApi.md#getvcsrootentrycheckoutrules) | **GET** /app/rest/buildTypes/{btLocator}/vcs-root-entries/{vcsRootLocator}/checkout-rules | 
[**GetZipped2**](BuildTypeApi.md#getzipped2) | **GET** /app/rest/buildTypes/{btLocator}/vcs/files/latest/archived{path} | 
[**RemoveAllTemplates**](BuildTypeApi.md#removealltemplates) | **DELETE** /app/rest/buildTypes/{btLocator}/templates | 
[**RemoveTemplate**](BuildTypeApi.md#removetemplate) | **DELETE** /app/rest/buildTypes/{btLocator}/templates/{templateLocator} | 
[**ReplaceAgentRequirement**](BuildTypeApi.md#replaceagentrequirement) | **PUT** /app/rest/buildTypes/{btLocator}/agent-requirements/{agentRequirementLocator} | 
[**ReplaceAgentRequirements**](BuildTypeApi.md#replaceagentrequirements) | **PUT** /app/rest/buildTypes/{btLocator}/agent-requirements | 
[**ReplaceArtifactDep**](BuildTypeApi.md#replaceartifactdep) | **PUT** /app/rest/buildTypes/{btLocator}/artifact-dependencies/{artifactDepLocator} | 
[**ReplaceArtifactDeps**](BuildTypeApi.md#replaceartifactdeps) | **PUT** /app/rest/buildTypes/{btLocator}/artifact-dependencies | 
[**ReplaceFeature**](BuildTypeApi.md#replacefeature) | **PUT** /app/rest/buildTypes/{btLocator}/features/{featureId} | 
[**ReplaceFeatureParameters**](BuildTypeApi.md#replacefeatureparameters) | **PUT** /app/rest/buildTypes/{btLocator}/features/{featureId}/parameters | 
[**ReplaceFeatures**](BuildTypeApi.md#replacefeatures) | **PUT** /app/rest/buildTypes/{btLocator}/features | 
[**ReplaceSnapshotDep**](BuildTypeApi.md#replacesnapshotdep) | **PUT** /app/rest/buildTypes/{btLocator}/snapshot-dependencies/{snapshotDepLocator} | 
[**ReplaceSnapshotDeps**](BuildTypeApi.md#replacesnapshotdeps) | **PUT** /app/rest/buildTypes/{btLocator}/snapshot-dependencies | 
[**ReplaceStep**](BuildTypeApi.md#replacestep) | **PUT** /app/rest/buildTypes/{btLocator}/steps/{stepId} | 
[**ReplaceStepParameters**](BuildTypeApi.md#replacestepparameters) | **PUT** /app/rest/buildTypes/{btLocator}/steps/{stepId}/parameters | 
[**ReplaceSteps**](BuildTypeApi.md#replacesteps) | **PUT** /app/rest/buildTypes/{btLocator}/steps | 
[**ReplaceTrigger**](BuildTypeApi.md#replacetrigger) | **PUT** /app/rest/buildTypes/{btLocator}/triggers/{triggerLocator} | 
[**ReplaceTriggers**](BuildTypeApi.md#replacetriggers) | **PUT** /app/rest/buildTypes/{btLocator}/triggers | 
[**ReplaceVcsRootEntries**](BuildTypeApi.md#replacevcsrootentries) | **PUT** /app/rest/buildTypes/{btLocator}/vcs-root-entries | 
[**ServeBranches**](BuildTypeApi.md#servebranches) | **GET** /app/rest/buildTypes/{btLocator}/branches | 
[**ServeBuildField**](BuildTypeApi.md#servebuildfield) | **GET** /app/rest/buildTypes/{btLocator}/builds/{buildLocator}/{field} | 
[**ServeBuildTypeBuildsTags**](BuildTypeApi.md#servebuildtypebuildstags) | **GET** /app/rest/buildTypes/{btLocator}/buildTags | 
[**ServeBuildTypeField**](BuildTypeApi.md#servebuildtypefield) | **GET** /app/rest/buildTypes/{btLocator}/{field} | 
[**ServeBuildTypeXML**](BuildTypeApi.md#servebuildtypexml) | **GET** /app/rest/buildTypes/{btLocator} | 
[**ServeBuildWithProject**](BuildTypeApi.md#servebuildwithproject) | **GET** /app/rest/buildTypes/{btLocator}/builds/{buildLocator} | 
[**ServeBuilds**](BuildTypeApi.md#servebuilds) | **GET** /app/rest/buildTypes/{btLocator}/builds | 
[**SetBuildTypeField**](BuildTypeApi.md#setbuildtypefield) | **PUT** /app/rest/buildTypes/{btLocator}/{field} | 
[**SetParameter**](BuildTypeApi.md#setparameter) | **PUT** /app/rest/buildTypes/{btLocator}/parameters/{name} | 
[**SetParameter1**](BuildTypeApi.md#setparameter1) | **POST** /app/rest/buildTypes/{btLocator}/parameters | 
[**SetParameterType**](BuildTypeApi.md#setparametertype) | **PUT** /app/rest/buildTypes/{btLocator}/parameters/{name}/type | 
[**SetParameterTypeRawValue**](BuildTypeApi.md#setparametertyperawvalue) | **PUT** /app/rest/buildTypes/{btLocator}/parameters/{name}/type/rawValue | 
[**SetParameterValueLong**](BuildTypeApi.md#setparametervaluelong) | **PUT** /app/rest/buildTypes/{btLocator}/parameters/{name}/value | 
[**SetParameters**](BuildTypeApi.md#setparameters) | **PUT** /app/rest/buildTypes/{btLocator}/parameters | 
[**SetTemplates**](BuildTypeApi.md#settemplates) | **PUT** /app/rest/buildTypes/{btLocator}/templates | 
[**UpdateVcsRootEntry**](BuildTypeApi.md#updatevcsrootentry) | **PUT** /app/rest/buildTypes/{btLocator}/vcs-root-entries/{vcsRootLocator} | 
[**UpdateVcsRootEntryCheckoutRules**](BuildTypeApi.md#updatevcsrootentrycheckoutrules) | **PUT** /app/rest/buildTypes/{btLocator}/vcs-root-entries/{vcsRootLocator}/checkout-rules | 


<a name="addagentrequirement"></a>
# **AddAgentRequirement**
> AgentRequirementDto AddAgentRequirement (string btLocator, string fields = null, AgentRequirementDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddAgentRequirementExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new AgentRequirementDto(); // AgentRequirementDto |  (optional) 

            try
            {
                AgentRequirementDto result = apiInstance.AddAgentRequirement(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddAgentRequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**AgentRequirementDto**](AgentRequirementDto.md)|  | [optional] 

### Return type

[**AgentRequirementDto**](AgentRequirementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addartifactdep"></a>
# **AddArtifactDep**
> ArtifactDependencyDto AddArtifactDep (string btLocator, string fields = null, ArtifactDependencyDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddArtifactDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new ArtifactDependencyDto(); // ArtifactDependencyDto |  (optional) 

            try
            {
                ArtifactDependencyDto result = apiInstance.AddArtifactDep(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddArtifactDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**ArtifactDependencyDto**](ArtifactDependencyDto.md)|  | [optional] 

### Return type

[**ArtifactDependencyDto**](ArtifactDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbuildtype"></a>
# **AddBuildType**
> BuildTypeDto AddBuildType (BuildTypeDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddBuildTypeExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var body = new BuildTypeDto(); // BuildTypeDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.AddBuildType(body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddBuildType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="addfeature"></a>
# **AddFeature**
> FeatureDto AddFeature (string btLocator, string fields = null, FeatureDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddFeatureExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new FeatureDto(); // FeatureDto |  (optional) 

            try
            {
                FeatureDto result = apiInstance.AddFeature(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**FeatureDto**](FeatureDto.md)|  | [optional] 

### Return type

[**FeatureDto**](FeatureDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfeatureparameter"></a>
# **AddFeatureParameter**
> string AddFeatureParameter (string btLocator, string featureId, string parameterName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddFeatureParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var parameterName = parameterName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.AddFeatureParameter(btLocator, featureId, parameterName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddFeatureParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **parameterName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsnapshotdep"></a>
# **AddSnapshotDep**
> SnapshotDependencyDto AddSnapshotDep (string btLocator, string fields = null, SnapshotDependencyDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddSnapshotDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new SnapshotDependencyDto(); // SnapshotDependencyDto |  (optional) 

            try
            {
                SnapshotDependencyDto result = apiInstance.AddSnapshotDep(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddSnapshotDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**SnapshotDependencyDto**](SnapshotDependencyDto.md)|  | [optional] 

### Return type

[**SnapshotDependencyDto**](SnapshotDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstep"></a>
# **AddStep**
> StepDto AddStep (string btLocator, string fields = null, StepDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddStepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new StepDto(); // StepDto |  (optional) 

            try
            {
                StepDto result = apiInstance.AddStep(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**StepDto**](StepDto.md)|  | [optional] 

### Return type

[**StepDto**](StepDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstepparameter"></a>
# **AddStepParameter**
> string AddStepParameter (string btLocator, string stepId, string parameterName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddStepParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var parameterName = parameterName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.AddStepParameter(btLocator, stepId, parameterName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddStepParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **parameterName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtemplate"></a>
# **AddTemplate**
> BuildTypeDto AddTemplate (string btLocator, BuildTypeDto body = null, bool? optimizeSettings = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddTemplateExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new BuildTypeDto(); // BuildTypeDto |  (optional) 
            var optimizeSettings = true;  // bool? |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.AddTemplate(btLocator, body, optimizeSettings, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **body** | [**BuildTypeDto**](BuildTypeDto.md)|  | [optional] 
 **optimizeSettings** | **bool?**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtrigger"></a>
# **AddTrigger**
> TriggerDto AddTrigger (string btLocator, string fields = null, TriggerDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddTriggerExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new TriggerDto(); // TriggerDto |  (optional) 

            try
            {
                TriggerDto result = apiInstance.AddTrigger(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**TriggerDto**](TriggerDto.md)|  | [optional] 

### Return type

[**TriggerDto**](TriggerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvcsrootentry"></a>
# **AddVcsRootEntry**
> VcsRootEntryDto AddVcsRootEntry (string btLocator, VcsRootEntryDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class AddVcsRootEntryExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new VcsRootEntryDto(); // VcsRootEntryDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootEntryDto result = apiInstance.AddVcsRootEntry(btLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.AddVcsRootEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **body** | [**VcsRootEntryDto**](VcsRootEntryDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootEntryDto**](VcsRootEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeartifactdepsetting"></a>
# **ChangeArtifactDepSetting**
> string ChangeArtifactDepSetting (string btLocator, string artifactDepLocator, string fieldName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangeArtifactDepSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var artifactDepLocator = artifactDepLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ChangeArtifactDepSetting(btLocator, artifactDepLocator, fieldName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ChangeArtifactDepSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **artifactDepLocator** | **string**|  | 
 **fieldName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changefeaturesetting"></a>
# **ChangeFeatureSetting**
> string ChangeFeatureSetting (string btLocator, string featureId, string name, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangeFeatureSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var name = name_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ChangeFeatureSetting(btLocator, featureId, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ChangeFeatureSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
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

<a name="changerequirementsetting"></a>
# **ChangeRequirementSetting**
> string ChangeRequirementSetting (string btLocator, string agentRequirementLocator, string fieldName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangeRequirementSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var agentRequirementLocator = agentRequirementLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ChangeRequirementSetting(btLocator, agentRequirementLocator, fieldName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ChangeRequirementSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **agentRequirementLocator** | **string**|  | 
 **fieldName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changestepsetting"></a>
# **ChangeStepSetting**
> string ChangeStepSetting (string btLocator, string stepId, string fieldName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangeStepSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var fieldName = fieldName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ChangeStepSetting(btLocator, stepId, fieldName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ChangeStepSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **fieldName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changetriggersetting"></a>
# **ChangeTriggerSetting**
> string ChangeTriggerSetting (string btLocator, string triggerLocator, string fieldName, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ChangeTriggerSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var triggerLocator = triggerLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ChangeTriggerSetting(btLocator, triggerLocator, fieldName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ChangeTriggerSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **triggerLocator** | **string**|  | 
 **fieldName** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteagentrequirement"></a>
# **DeleteAgentRequirement**
> void DeleteAgentRequirement (string btLocator, string agentRequirementLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteAgentRequirementExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var agentRequirementLocator = agentRequirementLocator_example;  // string | 

            try
            {
                apiInstance.DeleteAgentRequirement(btLocator, agentRequirementLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteAgentRequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **agentRequirementLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallparameters"></a>
# **DeleteAllParameters**
> void DeleteAllParameters (string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteAllParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 

            try
            {
                apiInstance.DeleteAllParameters(btLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteAllParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteartifactdep"></a>
# **DeleteArtifactDep**
> void DeleteArtifactDep (string btLocator, string artifactDepLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteArtifactDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var artifactDepLocator = artifactDepLocator_example;  // string | 

            try
            {
                apiInstance.DeleteArtifactDep(btLocator, artifactDepLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteArtifactDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **artifactDepLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebuildtype"></a>
# **DeleteBuildType**
> void DeleteBuildType (string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteBuildTypeExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 

            try
            {
                apiInstance.DeleteBuildType(btLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteBuildType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefeature"></a>
# **DeleteFeature**
> void DeleteFeature (string btLocator, string featureId)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteFeatureExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 

            try
            {
                apiInstance.DeleteFeature(btLocator, featureId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparameter"></a>
# **DeleteParameter**
> void DeleteParameter (string name, string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 

            try
            {
                apiInstance.DeleteParameter(name, btLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesnapshotdep"></a>
# **DeleteSnapshotDep**
> void DeleteSnapshotDep (string btLocator, string snapshotDepLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteSnapshotDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var snapshotDepLocator = snapshotDepLocator_example;  // string | 

            try
            {
                apiInstance.DeleteSnapshotDep(btLocator, snapshotDepLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteSnapshotDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **snapshotDepLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestep"></a>
# **DeleteStep**
> void DeleteStep (string btLocator, string stepId)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteStepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 

            try
            {
                apiInstance.DeleteStep(btLocator, stepId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetrigger"></a>
# **DeleteTrigger**
> void DeleteTrigger (string btLocator, string triggerLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteTriggerExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var triggerLocator = triggerLocator_example;  // string | 

            try
            {
                apiInstance.DeleteTrigger(btLocator, triggerLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **triggerLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevcsrootentry"></a>
# **DeleteVcsRootEntry**
> void DeleteVcsRootEntry (string btLocator, string vcsRootLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class DeleteVcsRootEntryExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var vcsRootLocator = vcsRootLocator_example;  // string | 

            try
            {
                apiInstance.DeleteVcsRootEntry(btLocator, vcsRootLocator);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.DeleteVcsRootEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **vcsRootLocator** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentrequirement"></a>
# **GetAgentRequirement**
> AgentRequirementDto GetAgentRequirement (string btLocator, string agentRequirementLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAgentRequirementExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var agentRequirementLocator = agentRequirementLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentRequirementDto result = apiInstance.GetAgentRequirement(btLocator, agentRequirementLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetAgentRequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **agentRequirementLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentRequirementDto**](AgentRequirementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentrequirements"></a>
# **GetAgentRequirements**
> AgentRequirementsDto GetAgentRequirements (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAgentRequirementsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                AgentRequirementsDto result = apiInstance.GetAgentRequirements(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetAgentRequirements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**AgentRequirementsDto**](AgentRequirementsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaliases"></a>
# **GetAliases**
> ItemsDto GetAliases (string btLocator, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetAliasesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var field = field_example;  // string |  (optional) 

            try
            {
                ItemsDto result = apiInstance.GetAliases(btLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetAliases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **field** | **string**|  | [optional] 

### Return type

[**ItemsDto**](ItemsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartifactdep"></a>
# **GetArtifactDep**
> ArtifactDependencyDto GetArtifactDep (string btLocator, string artifactDepLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetArtifactDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var artifactDepLocator = artifactDepLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ArtifactDependencyDto result = apiInstance.GetArtifactDep(btLocator, artifactDepLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetArtifactDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **artifactDepLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ArtifactDependencyDto**](ArtifactDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartifactdepsetting"></a>
# **GetArtifactDepSetting**
> string GetArtifactDepSetting (string btLocator, string artifactDepLocator, string fieldName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetArtifactDepSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var artifactDepLocator = artifactDepLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 

            try
            {
                string result = apiInstance.GetArtifactDepSetting(btLocator, artifactDepLocator, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetArtifactDepSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **artifactDepLocator** | **string**|  | 
 **fieldName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartifactdeps"></a>
# **GetArtifactDeps**
> ArtifactDependenciesDto GetArtifactDeps (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetArtifactDepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                ArtifactDependenciesDto result = apiInstance.GetArtifactDeps(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetArtifactDeps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**ArtifactDependenciesDto**](ArtifactDependenciesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbuildtypes"></a>
# **GetBuildTypes**
> BuildTypesDto GetBuildTypes (string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetBuildTypesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.GetBuildTypes(locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetBuildTypes: " + e.Message );
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

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren2"></a>
# **GetChildren2**
> FilesDto GetChildren2 (string path, string btLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildren2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildren2(path, btLocator, basePath, locator, fields, resolveParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetChildren2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildrenalias2"></a>
# **GetChildrenAlias2**
> FilesDto GetChildrenAlias2 (string path, string btLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetChildrenAlias2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetChildrenAlias2(path, btLocator, basePath, locator, fields, resolveParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetChildrenAlias2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontent2"></a>
# **GetContent2**
> void GetContent2 (string path, string btLocator, string responseBuilder = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContent2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var responseBuilder = responseBuilder_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContent2(path, btLocator, responseBuilder, resolveParameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetContent2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **responseBuilder** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentalias2"></a>
# **GetContentAlias2**
> void GetContentAlias2 (string path, string btLocator, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetContentAlias2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetContentAlias2(path, btLocator, resolveParameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetContentAlias2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentvcsinstances"></a>
# **GetCurrentVcsInstances**
> VcsRootInstancesDto GetCurrentVcsInstances (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetCurrentVcsInstancesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstancesDto result = apiInstance.GetCurrentVcsInstances(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetCurrentVcsInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstancesDto**](VcsRootInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentvcsinstancesobsolete"></a>
# **GetCurrentVcsInstancesObsolete**
> VcsRootInstancesDto GetCurrentVcsInstancesObsolete (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetCurrentVcsInstancesObsoleteExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootInstancesDto result = apiInstance.GetCurrentVcsInstancesObsolete(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetCurrentVcsInstancesObsolete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootInstancesDto**](VcsRootInstancesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeature"></a>
# **GetFeature**
> FeatureDto GetFeature (string btLocator, string featureId, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFeatureExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FeatureDto result = apiInstance.GetFeature(btLocator, featureId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**FeatureDto**](FeatureDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureparameter"></a>
# **GetFeatureParameter**
> string GetFeatureParameter (string btLocator, string featureId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFeatureParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                string result = apiInstance.GetFeatureParameter(btLocator, featureId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetFeatureParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureparameters"></a>
# **GetFeatureParameters**
> PropertiesDto GetFeatureParameters (string btLocator, string featureId, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFeatureParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.GetFeatureParameters(btLocator, featureId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetFeatureParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturesetting"></a>
# **GetFeatureSetting**
> string GetFeatureSetting (string btLocator, string featureId, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFeatureSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var name = name_example;  // string | 

            try
            {
                string result = apiInstance.GetFeatureSetting(btLocator, featureId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetFeatureSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **name** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatures"></a>
# **GetFeatures**
> FeaturesDto GetFeatures (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetFeaturesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                FeaturesDto result = apiInstance.GetFeatures(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**FeaturesDto**](FeaturesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvestigations"></a>
# **GetInvestigations**
> InvestigationsDto GetInvestigations (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetInvestigationsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                InvestigationsDto result = apiInstance.GetInvestigations(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetInvestigations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**InvestigationsDto**](InvestigationsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata2"></a>
# **GetMetadata2**
> FileDto GetMetadata2 (string path, string btLocator, string fields = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetMetadata2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                FileDto result = apiInstance.GetMetadata2(path, btLocator, fields, resolveParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetMetadata2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

[**FileDto**](FileDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparameter1"></a>
# **GetParameter1**
> PropertyDto GetParameter1 (string name, string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameter1Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.GetParameter1(name, btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetParameter1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertyDto**](PropertyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametertype"></a>
# **GetParameterType**
> TypeDto GetParameterType (string name, string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterTypeExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 

            try
            {
                TypeDto result = apiInstance.GetParameterType(name, btLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetParameterType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 

### Return type

[**TypeDto**](TypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametertyperawvalue"></a>
# **GetParameterTypeRawValue**
> string GetParameterTypeRawValue (string name, string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterTypeRawValueExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetParameterTypeRawValue(name, btLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetParameterTypeRawValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametervaluelong"></a>
# **GetParameterValueLong**
> string GetParameterValueLong (string name, string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParameterValueLongExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetParameterValueLong(name, btLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetParameterValueLong: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparameters"></a>
# **GetParameters**
> PropertiesDto GetParameters (string btLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.GetParameters(btLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
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

<a name="getrequirementsetting"></a>
# **GetRequirementSetting**
> string GetRequirementSetting (string btLocator, string agentRequirementLocator, string fieldName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRequirementSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var agentRequirementLocator = agentRequirementLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 

            try
            {
                string result = apiInstance.GetRequirementSetting(btLocator, agentRequirementLocator, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetRequirementSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **agentRequirementLocator** | **string**|  | 
 **fieldName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroot2"></a>
# **GetRoot2**
> FilesDto GetRoot2 (string btLocator, string basePath = null, string locator = null, string fields = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetRoot2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                FilesDto result = apiInstance.GetRoot2(btLocator, basePath, locator, fields, resolveParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetRoot2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **fields** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

[**FilesDto**](FilesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettingsfile"></a>
# **GetSettingsFile**
> string GetSettingsFile (string btLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSettingsFileExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetSettingsFile(btLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetSettingsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsnapshotdep"></a>
# **GetSnapshotDep**
> SnapshotDependencyDto GetSnapshotDep (string btLocator, string snapshotDepLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSnapshotDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var snapshotDepLocator = snapshotDepLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                SnapshotDependencyDto result = apiInstance.GetSnapshotDep(btLocator, snapshotDepLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetSnapshotDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **snapshotDepLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**SnapshotDependencyDto**](SnapshotDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsnapshotdeps"></a>
# **GetSnapshotDeps**
> SnapshotDependenciesDto GetSnapshotDeps (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetSnapshotDepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                SnapshotDependenciesDto result = apiInstance.GetSnapshotDeps(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetSnapshotDeps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**SnapshotDependenciesDto**](SnapshotDependenciesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstep"></a>
# **GetStep**
> StepDto GetStep (string btLocator, string stepId, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetStepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                StepDto result = apiInstance.GetStep(btLocator, stepId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**StepDto**](StepDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstepparameter"></a>
# **GetStepParameter**
> string GetStepParameter (string btLocator, string stepId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetStepParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                string result = apiInstance.GetStepParameter(btLocator, stepId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetStepParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstepparameters"></a>
# **GetStepParameters**
> PropertiesDto GetStepParameters (string btLocator, string stepId, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetStepParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.GetStepParameters(btLocator, stepId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetStepParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**PropertiesDto**](PropertiesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstepsetting"></a>
# **GetStepSetting**
> string GetStepSetting (string btLocator, string stepId, string fieldName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetStepSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var fieldName = fieldName_example;  // string | 

            try
            {
                string result = apiInstance.GetStepSetting(btLocator, stepId, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetStepSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **fieldName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsteps"></a>
# **GetSteps**
> StepsDto GetSteps (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetStepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                StepsDto result = apiInstance.GetSteps(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetSteps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**StepsDto**](StepsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplate"></a>
# **GetTemplate**
> BuildTypeDto GetTemplate (string btLocator, string templateLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var templateLocator = templateLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.GetTemplate(btLocator, templateLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **templateLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypeDto**](BuildTypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplates"></a>
# **GetTemplates**
> BuildTypesDto GetTemplates (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTemplatesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.GetTemplates(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrigger"></a>
# **GetTrigger**
> TriggerDto GetTrigger (string btLocator, string triggerLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTriggerExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var triggerLocator = triggerLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TriggerDto result = apiInstance.GetTrigger(btLocator, triggerLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **triggerLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TriggerDto**](TriggerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettriggersetting"></a>
# **GetTriggerSetting**
> string GetTriggerSetting (string btLocator, string triggerLocator, string fieldName)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTriggerSettingExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var triggerLocator = triggerLocator_example;  // string | 
            var fieldName = fieldName_example;  // string | 

            try
            {
                string result = apiInstance.GetTriggerSetting(btLocator, triggerLocator, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetTriggerSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **triggerLocator** | **string**|  | 
 **fieldName** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettriggers"></a>
# **GetTriggers**
> TriggersDto GetTriggers (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetTriggersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                TriggersDto result = apiInstance.GetTriggers(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**TriggersDto**](TriggersDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvcsrootentries"></a>
# **GetVcsRootEntries**
> VcsRootEntriesDto GetVcsRootEntries (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetVcsRootEntriesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootEntriesDto result = apiInstance.GetVcsRootEntries(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetVcsRootEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootEntriesDto**](VcsRootEntriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvcsrootentry"></a>
# **GetVcsRootEntry**
> VcsRootEntryDto GetVcsRootEntry (string btLocator, string vcsRootLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetVcsRootEntryExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootEntryDto result = apiInstance.GetVcsRootEntry(btLocator, vcsRootLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetVcsRootEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **vcsRootLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootEntryDto**](VcsRootEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvcsrootentrycheckoutrules"></a>
# **GetVcsRootEntryCheckoutRules**
> string GetVcsRootEntryCheckoutRules (string btLocator, string vcsRootLocator)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetVcsRootEntryCheckoutRulesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var vcsRootLocator = vcsRootLocator_example;  // string | 

            try
            {
                string result = apiInstance.GetVcsRootEntryCheckoutRules(btLocator, vcsRootLocator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetVcsRootEntryCheckoutRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **vcsRootLocator** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getzipped2"></a>
# **GetZipped2**
> void GetZipped2 (string path, string btLocator, string basePath = null, string locator = null, string name = null, bool? resolveParameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class GetZipped2Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var path = path_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var basePath = basePath_example;  // string |  (optional) 
            var locator = locator_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var resolveParameters = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetZipped2(path, btLocator, basePath, locator, name, resolveParameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.GetZipped2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **btLocator** | **string**|  | 
 **basePath** | **string**|  | [optional] 
 **locator** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **resolveParameters** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removealltemplates"></a>
# **RemoveAllTemplates**
> void RemoveAllTemplates (string btLocator, bool? inlineSettings = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveAllTemplatesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var inlineSettings = true;  // bool? |  (optional) 

            try
            {
                apiInstance.RemoveAllTemplates(btLocator, inlineSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.RemoveAllTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **inlineSettings** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetemplate"></a>
# **RemoveTemplate**
> void RemoveTemplate (string btLocator, string templateLocator, bool? inlineSettings = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class RemoveTemplateExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var templateLocator = templateLocator_example;  // string | 
            var inlineSettings = true;  // bool? |  (optional) 

            try
            {
                apiInstance.RemoveTemplate(btLocator, templateLocator, inlineSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.RemoveTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **templateLocator** | **string**|  | 
 **inlineSettings** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceagentrequirement"></a>
# **ReplaceAgentRequirement**
> AgentRequirementDto ReplaceAgentRequirement (string btLocator, string agentRequirementLocator, string fields = null, AgentRequirementDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceAgentRequirementExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var agentRequirementLocator = agentRequirementLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new AgentRequirementDto(); // AgentRequirementDto |  (optional) 

            try
            {
                AgentRequirementDto result = apiInstance.ReplaceAgentRequirement(btLocator, agentRequirementLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceAgentRequirement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **agentRequirementLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**AgentRequirementDto**](AgentRequirementDto.md)|  | [optional] 

### Return type

[**AgentRequirementDto**](AgentRequirementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceagentrequirements"></a>
# **ReplaceAgentRequirements**
> AgentRequirementsDto ReplaceAgentRequirements (string btLocator, string fields = null, AgentRequirementsDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceAgentRequirementsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new AgentRequirementsDto(); // AgentRequirementsDto |  (optional) 

            try
            {
                AgentRequirementsDto result = apiInstance.ReplaceAgentRequirements(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceAgentRequirements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**AgentRequirementsDto**](AgentRequirementsDto.md)|  | [optional] 

### Return type

[**AgentRequirementsDto**](AgentRequirementsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceartifactdep"></a>
# **ReplaceArtifactDep**
> ArtifactDependencyDto ReplaceArtifactDep (string btLocator, string artifactDepLocator, string fields = null, ArtifactDependencyDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceArtifactDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var artifactDepLocator = artifactDepLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new ArtifactDependencyDto(); // ArtifactDependencyDto |  (optional) 

            try
            {
                ArtifactDependencyDto result = apiInstance.ReplaceArtifactDep(btLocator, artifactDepLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceArtifactDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **artifactDepLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**ArtifactDependencyDto**](ArtifactDependencyDto.md)|  | [optional] 

### Return type

[**ArtifactDependencyDto**](ArtifactDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceartifactdeps"></a>
# **ReplaceArtifactDeps**
> ArtifactDependenciesDto ReplaceArtifactDeps (string btLocator, string fields = null, ArtifactDependenciesDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceArtifactDepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new ArtifactDependenciesDto(); // ArtifactDependenciesDto |  (optional) 

            try
            {
                ArtifactDependenciesDto result = apiInstance.ReplaceArtifactDeps(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceArtifactDeps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**ArtifactDependenciesDto**](ArtifactDependenciesDto.md)|  | [optional] 

### Return type

[**ArtifactDependenciesDto**](ArtifactDependenciesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacefeature"></a>
# **ReplaceFeature**
> FeatureDto ReplaceFeature (string btLocator, string featureId, string fields = null, FeatureDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceFeatureExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new FeatureDto(); // FeatureDto |  (optional) 

            try
            {
                FeatureDto result = apiInstance.ReplaceFeature(btLocator, featureId, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**FeatureDto**](FeatureDto.md)|  | [optional] 

### Return type

[**FeatureDto**](FeatureDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacefeatureparameters"></a>
# **ReplaceFeatureParameters**
> PropertiesDto ReplaceFeatureParameters (string btLocator, string featureId, PropertiesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceFeatureParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var featureId = featureId_example;  // string | 
            var body = new PropertiesDto(); // PropertiesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ReplaceFeatureParameters(btLocator, featureId, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceFeatureParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **featureId** | **string**|  | 
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

<a name="replacefeatures"></a>
# **ReplaceFeatures**
> FeaturesDto ReplaceFeatures (string btLocator, string fields = null, FeaturesDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceFeaturesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new FeaturesDto(); // FeaturesDto |  (optional) 

            try
            {
                FeaturesDto result = apiInstance.ReplaceFeatures(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**FeaturesDto**](FeaturesDto.md)|  | [optional] 

### Return type

[**FeaturesDto**](FeaturesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacesnapshotdep"></a>
# **ReplaceSnapshotDep**
> SnapshotDependencyDto ReplaceSnapshotDep (string btLocator, string snapshotDepLocator, string fields = null, SnapshotDependencyDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceSnapshotDepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var snapshotDepLocator = snapshotDepLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new SnapshotDependencyDto(); // SnapshotDependencyDto |  (optional) 

            try
            {
                SnapshotDependencyDto result = apiInstance.ReplaceSnapshotDep(btLocator, snapshotDepLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceSnapshotDep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **snapshotDepLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**SnapshotDependencyDto**](SnapshotDependencyDto.md)|  | [optional] 

### Return type

[**SnapshotDependencyDto**](SnapshotDependencyDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacesnapshotdeps"></a>
# **ReplaceSnapshotDeps**
> SnapshotDependenciesDto ReplaceSnapshotDeps (string btLocator, string fields = null, SnapshotDependenciesDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceSnapshotDepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new SnapshotDependenciesDto(); // SnapshotDependenciesDto |  (optional) 

            try
            {
                SnapshotDependenciesDto result = apiInstance.ReplaceSnapshotDeps(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceSnapshotDeps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**SnapshotDependenciesDto**](SnapshotDependenciesDto.md)|  | [optional] 

### Return type

[**SnapshotDependenciesDto**](SnapshotDependenciesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacestep"></a>
# **ReplaceStep**
> StepDto ReplaceStep (string btLocator, string stepId, string fields = null, StepDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceStepExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new StepDto(); // StepDto |  (optional) 

            try
            {
                StepDto result = apiInstance.ReplaceStep(btLocator, stepId, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**StepDto**](StepDto.md)|  | [optional] 

### Return type

[**StepDto**](StepDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacestepparameters"></a>
# **ReplaceStepParameters**
> PropertiesDto ReplaceStepParameters (string btLocator, string stepId, PropertiesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceStepParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var stepId = stepId_example;  // string | 
            var body = new PropertiesDto(); // PropertiesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.ReplaceStepParameters(btLocator, stepId, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceStepParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **stepId** | **string**|  | 
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

<a name="replacesteps"></a>
# **ReplaceSteps**
> StepsDto ReplaceSteps (string btLocator, string fields = null, StepsDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceStepsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new StepsDto(); // StepsDto |  (optional) 

            try
            {
                StepsDto result = apiInstance.ReplaceSteps(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceSteps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**StepsDto**](StepsDto.md)|  | [optional] 

### Return type

[**StepsDto**](StepsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacetrigger"></a>
# **ReplaceTrigger**
> TriggerDto ReplaceTrigger (string btLocator, string triggerLocator, string fields = null, TriggerDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceTriggerExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var triggerLocator = triggerLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new TriggerDto(); // TriggerDto |  (optional) 

            try
            {
                TriggerDto result = apiInstance.ReplaceTrigger(btLocator, triggerLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **triggerLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**TriggerDto**](TriggerDto.md)|  | [optional] 

### Return type

[**TriggerDto**](TriggerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacetriggers"></a>
# **ReplaceTriggers**
> TriggersDto ReplaceTriggers (string btLocator, string fields = null, TriggersDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceTriggersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 
            var body = new TriggersDto(); // TriggersDto |  (optional) 

            try
            {
                TriggersDto result = apiInstance.ReplaceTriggers(btLocator, fields, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **fields** | **string**|  | [optional] 
 **body** | [**TriggersDto**](TriggersDto.md)|  | [optional] 

### Return type

[**TriggersDto**](TriggersDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacevcsrootentries"></a>
# **ReplaceVcsRootEntries**
> VcsRootEntriesDto ReplaceVcsRootEntries (string btLocator, VcsRootEntriesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ReplaceVcsRootEntriesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new VcsRootEntriesDto(); // VcsRootEntriesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootEntriesDto result = apiInstance.ReplaceVcsRootEntries(btLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ReplaceVcsRootEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **body** | [**VcsRootEntriesDto**](VcsRootEntriesDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootEntriesDto**](VcsRootEntriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebranches"></a>
# **ServeBranches**
> BranchesDto ServeBranches (string btLocator, string locator = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBranchesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var locator = locator_example;  // string |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BranchesDto result = apiInstance.ServeBranches(btLocator, locator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBranches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
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

<a name="servebuildfield"></a>
# **ServeBuildField**
> string ServeBuildField (string btLocator, string buildLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildFieldExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildField(btLocator, buildLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuildField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="servebuildtypebuildstags"></a>
# **ServeBuildTypeBuildsTags**
> TagsDto ServeBuildTypeBuildsTags (string btLocator, string field = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeBuildsTagsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var field = field_example;  // string |  (optional) 

            try
            {
                TagsDto result = apiInstance.ServeBuildTypeBuildsTags(btLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuildTypeBuildsTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **field** | **string**|  | [optional] 

### Return type

[**TagsDto**](TagsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servebuildtypefield"></a>
# **ServeBuildTypeField**
> string ServeBuildTypeField (string btLocator, string field)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeFieldExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var field = field_example;  // string | 

            try
            {
                string result = apiInstance.ServeBuildTypeField(btLocator, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuildTypeField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="servebuildtypexml"></a>
# **ServeBuildTypeXML**
> BuildTypeDto ServeBuildTypeXML (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildTypeXMLExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypeDto result = apiInstance.ServeBuildTypeXML(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuildTypeXML: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="servebuildwithproject"></a>
# **ServeBuildWithProject**
> BuildDto ServeBuildWithProject (string btLocator, string buildLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildWithProjectExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var buildLocator = buildLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildDto result = apiInstance.ServeBuildWithProject(btLocator, buildLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuildWithProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="servebuilds"></a>
# **ServeBuilds**
> BuildsDto ServeBuilds (string btLocator, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class ServeBuildsExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildsDto result = apiInstance.ServeBuilds(btLocator, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.ServeBuilds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="setbuildtypefield"></a>
# **SetBuildTypeField**
> string SetBuildTypeField (string btLocator, string field, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetBuildTypeFieldExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var field = field_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetBuildTypeField(btLocator, field, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetBuildTypeField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
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

<a name="setparameter"></a>
# **SetParameter**
> PropertyDto SetParameter (string name, string btLocator, PropertyDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var body = new PropertyDto(); // PropertyDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.SetParameter(name, btLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 
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

<a name="setparameter1"></a>
# **SetParameter1**
> PropertyDto SetParameter1 (string btLocator, PropertyDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameter1Example
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new PropertyDto(); // PropertyDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertyDto result = apiInstance.SetParameter1(btLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameter1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
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

<a name="setparametertype"></a>
# **SetParameterType**
> TypeDto SetParameterType (string name, string btLocator, TypeDto body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterTypeExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var body = new TypeDto(); // TypeDto |  (optional) 

            try
            {
                TypeDto result = apiInstance.SetParameterType(name, btLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameterType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 
 **body** | [**TypeDto**](TypeDto.md)|  | [optional] 

### Return type

[**TypeDto**](TypeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparametertyperawvalue"></a>
# **SetParameterTypeRawValue**
> string SetParameterTypeRawValue (string name, string btLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterTypeRawValueExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetParameterTypeRawValue(name, btLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameterTypeRawValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparametervaluelong"></a>
# **SetParameterValueLong**
> string SetParameterValueLong (string name, string btLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParameterValueLongExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var name = name_example;  // string | 
            var btLocator = btLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.SetParameterValueLong(name, btLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameterValueLong: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **btLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setparameters"></a>
# **SetParameters**
> PropertiesDto SetParameters (string btLocator, PropertiesDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetParametersExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new PropertiesDto(); // PropertiesDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                PropertiesDto result = apiInstance.SetParameters(btLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
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

<a name="settemplates"></a>
# **SetTemplates**
> BuildTypesDto SetTemplates (string btLocator, BuildTypesDto body = null, bool? optimizeSettings = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class SetTemplatesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var body = new BuildTypesDto(); // BuildTypesDto |  (optional) 
            var optimizeSettings = true;  // bool? |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                BuildTypesDto result = apiInstance.SetTemplates(btLocator, body, optimizeSettings, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.SetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **body** | [**BuildTypesDto**](BuildTypesDto.md)|  | [optional] 
 **optimizeSettings** | **bool?**|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**BuildTypesDto**](BuildTypesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevcsrootentry"></a>
# **UpdateVcsRootEntry**
> VcsRootEntryDto UpdateVcsRootEntry (string btLocator, string vcsRootLocator, VcsRootEntryDto body = null, string fields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class UpdateVcsRootEntryExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var body = new VcsRootEntryDto(); // VcsRootEntryDto |  (optional) 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                VcsRootEntryDto result = apiInstance.UpdateVcsRootEntry(btLocator, vcsRootLocator, body, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.UpdateVcsRootEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **vcsRootLocator** | **string**|  | 
 **body** | [**VcsRootEntryDto**](VcsRootEntryDto.md)|  | [optional] 
 **fields** | **string**|  | [optional] 

### Return type

[**VcsRootEntryDto**](VcsRootEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevcsrootentrycheckoutrules"></a>
# **UpdateVcsRootEntryCheckoutRules**
> string UpdateVcsRootEntryCheckoutRules (string btLocator, string vcsRootLocator, string body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace Example
{
    public class UpdateVcsRootEntryCheckoutRulesExample
    {
        public void main()
        {
            var apiInstance = new BuildTypeApi();
            var btLocator = btLocator_example;  // string | 
            var vcsRootLocator = vcsRootLocator_example;  // string | 
            var body = body_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.UpdateVcsRootEntryCheckoutRules(btLocator, vcsRootLocator, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildTypeApi.UpdateVcsRootEntryCheckoutRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **btLocator** | **string**|  | 
 **vcsRootLocator** | **string**|  | 
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

