/* 
 * TeamCity REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2018.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TeamCity.Client;
using TeamCity.Api;
using TeamCity.Model;

namespace TeamCity.Test
{
    /// <summary>
    ///  Class for testing ProjectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProjectApiTests
    {
        private ProjectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProjectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProjectApi
            //Assert.IsInstanceOfType(typeof(ProjectApi), instance, "instance is a ProjectApi");
        }

        
        /// <summary>
        /// Test Add
        /// </summary>
        [Test]
        public void AddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //ProjectFeatureDto body = null;
            //string fields = null;
            //var response = instance.Add(projectLocator, body, fields);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test CreateBuildType
        /// </summary>
        [Test]
        public void CreateBuildTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //NewBuildTypeDescriptionDto body = null;
            //string fields = null;
            //var response = instance.CreateBuildType(projectLocator, body, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test CreateBuildTypeTemplate
        /// </summary>
        [Test]
        public void CreateBuildTypeTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //NewBuildTypeDescriptionDto body = null;
            //string fields = null;
            //var response = instance.CreateBuildTypeTemplate(projectLocator, body, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test CreateProject
        /// </summary>
        [Test]
        public void CreateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewProjectDescriptionDto body = null;
            //var response = instance.CreateProject(body);
            //Assert.IsInstanceOf<ProjectDto> (response, "response is ProjectDto");
        }
        
        /// <summary>
        /// Test CreateSecureToken
        /// </summary>
        [Test]
        public void CreateSecureTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string body = null;
            //var response = instance.CreateSecureToken(projectLocator, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureLocator = null;
            //string projectLocator = null;
            //instance.Delete(featureLocator, projectLocator);
            
        }
        
        /// <summary>
        /// Test DeleteAllParameters1
        /// </summary>
        [Test]
        public void DeleteAllParameters1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //instance.DeleteAllParameters1(projectLocator);
            
        }
        
        /// <summary>
        /// Test DeleteParameter1
        /// </summary>
        [Test]
        public void DeleteParameter1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //instance.DeleteParameter1(name, projectLocator);
            
        }
        
        /// <summary>
        /// Test DeleteProject
        /// </summary>
        [Test]
        public void DeleteProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //instance.DeleteProject(projectLocator);
            
        }
        
        /// <summary>
        /// Test DeleteProjectAgentPools
        /// </summary>
        [Test]
        public void DeleteProjectAgentPoolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string agentPoolLocator = null;
            //instance.DeleteProjectAgentPools(projectLocator, agentPoolLocator);
            
        }
        
        /// <summary>
        /// Test Get1
        /// </summary>
        [Test]
        public void Get1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string locator = null;
            //string fields = null;
            //var response = instance.Get1(projectLocator, locator, fields);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetBranches
        /// </summary>
        [Test]
        public void GetBranchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string locator = null;
            //string fields = null;
            //var response = instance.GetBranches(projectLocator, locator, fields);
            //Assert.IsInstanceOf<BranchesDto> (response, "response is BranchesDto");
        }
        
        /// <summary>
        /// Test GetBuildTypesOrder
        /// </summary>
        [Test]
        public void GetBuildTypesOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string field = null;
            //var response = instance.GetBuildTypesOrder(projectLocator, field);
            //Assert.IsInstanceOf<BuildTypesDto> (response, "response is BuildTypesDto");
        }
        
        /// <summary>
        /// Test GetDefaultTemplate
        /// </summary>
        [Test]
        public void GetDefaultTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.GetDefaultTemplate(projectLocator, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test GetParameter2
        /// </summary>
        [Test]
        public void GetParameter2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.GetParameter2(name, projectLocator, fields);
            //Assert.IsInstanceOf<PropertyDto> (response, "response is PropertyDto");
        }
        
        /// <summary>
        /// Test GetParameterType1
        /// </summary>
        [Test]
        public void GetParameterType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //var response = instance.GetParameterType1(name, projectLocator);
            //Assert.IsInstanceOf<TypeDto> (response, "response is TypeDto");
        }
        
        /// <summary>
        /// Test GetParameterTypeRawValue1
        /// </summary>
        [Test]
        public void GetParameterTypeRawValue1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //var response = instance.GetParameterTypeRawValue1(name, projectLocator);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetParameterValueLong1
        /// </summary>
        [Test]
        public void GetParameterValueLong1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //var response = instance.GetParameterValueLong1(name, projectLocator);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetParameters1
        /// </summary>
        [Test]
        public void GetParameters1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string locator = null;
            //string fields = null;
            //var response = instance.GetParameters1(projectLocator, locator, fields);
            //Assert.IsInstanceOf<PropertiesDto> (response, "response is PropertiesDto");
        }
        
        /// <summary>
        /// Test GetParentProject
        /// </summary>
        [Test]
        public void GetParentProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.GetParentProject(projectLocator, fields);
            //Assert.IsInstanceOf<ProjectDto> (response, "response is ProjectDto");
        }
        
        /// <summary>
        /// Test GetProjectAgentPools
        /// </summary>
        [Test]
        public void GetProjectAgentPoolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.GetProjectAgentPools(projectLocator, fields);
            //Assert.IsInstanceOf<AgentPoolsDto> (response, "response is AgentPoolsDto");
        }
        
        /// <summary>
        /// Test GetProjectsOrder
        /// </summary>
        [Test]
        public void GetProjectsOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string field = null;
            //var response = instance.GetProjectsOrder(projectLocator, field);
            //Assert.IsInstanceOf<ProjectsDto> (response, "response is ProjectsDto");
        }
        
        /// <summary>
        /// Test GetSecureValue
        /// </summary>
        [Test]
        public void GetSecureValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string token = null;
            //var response = instance.GetSecureValue(projectLocator, token);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetSettingsFile1
        /// </summary>
        [Test]
        public void GetSettingsFile1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //var response = instance.GetSettingsFile1(projectLocator);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetSingle1
        /// </summary>
        [Test]
        public void GetSingle1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureLocator = null;
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.GetSingle1(featureLocator, projectLocator, fields);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ReloadSettingsFile
        /// </summary>
        [Test]
        public void ReloadSettingsFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.ReloadSettingsFile(projectLocator, fields);
            //Assert.IsInstanceOf<ProjectDto> (response, "response is ProjectDto");
        }
        
        /// <summary>
        /// Test RemoveDefaultTemplate
        /// </summary>
        [Test]
        public void RemoveDefaultTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //instance.RemoveDefaultTemplate(projectLocator, fields);
            
        }
        
        /// <summary>
        /// Test Replace
        /// </summary>
        [Test]
        public void ReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureLocator = null;
            //string projectLocator = null;
            //ProjectFeatureDto body = null;
            //string fields = null;
            //var response = instance.Replace(featureLocator, projectLocator, body, fields);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ReplaceAll
        /// </summary>
        [Test]
        public void ReplaceAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //ProjectFeaturesDto body = null;
            //string fields = null;
            //var response = instance.ReplaceAll(projectLocator, body, fields);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ServeBuildFieldWithProject
        /// </summary>
        [Test]
        public void ServeBuildFieldWithProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string buildLocator = null;
            //string field = null;
            //var response = instance.ServeBuildFieldWithProject(projectLocator, btLocator, buildLocator, field);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeBuildType
        /// </summary>
        [Test]
        public void ServeBuildTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string fields = null;
            //var response = instance.ServeBuildType(projectLocator, btLocator, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test ServeBuildTypeFieldWithProject
        /// </summary>
        [Test]
        public void ServeBuildTypeFieldWithProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string field = null;
            //var response = instance.ServeBuildTypeFieldWithProject(projectLocator, btLocator, field);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeBuildTypeTemplates
        /// </summary>
        [Test]
        public void ServeBuildTypeTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string fields = null;
            //var response = instance.ServeBuildTypeTemplates(projectLocator, btLocator, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test ServeBuildTypesInProject
        /// </summary>
        [Test]
        public void ServeBuildTypesInProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.ServeBuildTypesInProject(projectLocator, fields);
            //Assert.IsInstanceOf<BuildTypesDto> (response, "response is BuildTypesDto");
        }
        
        /// <summary>
        /// Test ServeBuildWithProject1
        /// </summary>
        [Test]
        public void ServeBuildWithProject1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string buildLocator = null;
            //string fields = null;
            //var response = instance.ServeBuildWithProject1(projectLocator, btLocator, buildLocator, fields);
            //Assert.IsInstanceOf<BuildDto> (response, "response is BuildDto");
        }
        
        /// <summary>
        /// Test ServeBuilds1
        /// </summary>
        [Test]
        public void ServeBuilds1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string btLocator = null;
            //string fields = null;
            //var response = instance.ServeBuilds1(projectLocator, btLocator, fields);
            //Assert.IsInstanceOf<BuildsDto> (response, "response is BuildsDto");
        }
        
        /// <summary>
        /// Test ServeProject
        /// </summary>
        [Test]
        public void ServeProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.ServeProject(projectLocator, fields);
            //Assert.IsInstanceOf<ProjectDto> (response, "response is ProjectDto");
        }
        
        /// <summary>
        /// Test ServeProjectField
        /// </summary>
        [Test]
        public void ServeProjectFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string field = null;
            //var response = instance.ServeProjectField(projectLocator, field);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeProjects
        /// </summary>
        [Test]
        public void ServeProjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeProjects(locator, fields);
            //Assert.IsInstanceOf<ProjectsDto> (response, "response is ProjectsDto");
        }
        
        /// <summary>
        /// Test ServeTemplatesInProject
        /// </summary>
        [Test]
        public void ServeTemplatesInProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string fields = null;
            //var response = instance.ServeTemplatesInProject(projectLocator, fields);
            //Assert.IsInstanceOf<BuildTypesDto> (response, "response is BuildTypesDto");
        }
        
        /// <summary>
        /// Test SetBuildTypesOrder
        /// </summary>
        [Test]
        public void SetBuildTypesOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //BuildTypesDto body = null;
            //string field = null;
            //var response = instance.SetBuildTypesOrder(projectLocator, body, field);
            //Assert.IsInstanceOf<BuildTypesDto> (response, "response is BuildTypesDto");
        }
        
        /// <summary>
        /// Test SetDefaultTemplate
        /// </summary>
        [Test]
        public void SetDefaultTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //BuildTypeDto body = null;
            //string fields = null;
            //var response = instance.SetDefaultTemplate(projectLocator, body, fields);
            //Assert.IsInstanceOf<BuildTypeDto> (response, "response is BuildTypeDto");
        }
        
        /// <summary>
        /// Test SetParameter2
        /// </summary>
        [Test]
        public void SetParameter2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //PropertyDto body = null;
            //string fields = null;
            //var response = instance.SetParameter2(name, projectLocator, body, fields);
            //Assert.IsInstanceOf<PropertyDto> (response, "response is PropertyDto");
        }
        
        /// <summary>
        /// Test SetParameter3
        /// </summary>
        [Test]
        public void SetParameter3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //PropertyDto body = null;
            //string fields = null;
            //var response = instance.SetParameter3(projectLocator, body, fields);
            //Assert.IsInstanceOf<PropertyDto> (response, "response is PropertyDto");
        }
        
        /// <summary>
        /// Test SetParameterType1
        /// </summary>
        [Test]
        public void SetParameterType1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //TypeDto body = null;
            //var response = instance.SetParameterType1(name, projectLocator, body);
            //Assert.IsInstanceOf<TypeDto> (response, "response is TypeDto");
        }
        
        /// <summary>
        /// Test SetParameterTypeRawValue1
        /// </summary>
        [Test]
        public void SetParameterTypeRawValue1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //string body = null;
            //var response = instance.SetParameterTypeRawValue1(name, projectLocator, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SetParameterValueLong1
        /// </summary>
        [Test]
        public void SetParameterValueLong1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string projectLocator = null;
            //string body = null;
            //var response = instance.SetParameterValueLong1(name, projectLocator, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SetParameters1
        /// </summary>
        [Test]
        public void SetParameters1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //PropertiesDto body = null;
            //string fields = null;
            //var response = instance.SetParameters1(projectLocator, body, fields);
            //Assert.IsInstanceOf<PropertiesDto> (response, "response is PropertiesDto");
        }
        
        /// <summary>
        /// Test SetParentProject
        /// </summary>
        [Test]
        public void SetParentProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //ProjectDto body = null;
            //string fields = null;
            //var response = instance.SetParentProject(projectLocator, body, fields);
            //Assert.IsInstanceOf<ProjectDto> (response, "response is ProjectDto");
        }
        
        /// <summary>
        /// Test SetProjectAgentPools
        /// </summary>
        [Test]
        public void SetProjectAgentPoolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //AgentPoolDto body = null;
            //var response = instance.SetProjectAgentPools(projectLocator, body);
            //Assert.IsInstanceOf<AgentPoolDto> (response, "response is AgentPoolDto");
        }
        
        /// <summary>
        /// Test SetProjectAgentPools1
        /// </summary>
        [Test]
        public void SetProjectAgentPools1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //AgentPoolsDto body = null;
            //string fields = null;
            //var response = instance.SetProjectAgentPools1(projectLocator, body, fields);
            //Assert.IsInstanceOf<AgentPoolsDto> (response, "response is AgentPoolsDto");
        }
        
        /// <summary>
        /// Test SetProjectField
        /// </summary>
        [Test]
        public void SetProjectFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //string field = null;
            //string body = null;
            //var response = instance.SetProjectField(projectLocator, field, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SetProjectsOrder
        /// </summary>
        [Test]
        public void SetProjectsOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectLocator = null;
            //ProjectsDto body = null;
            //string field = null;
            //var response = instance.SetProjectsOrder(projectLocator, body, field);
            //Assert.IsInstanceOf<ProjectsDto> (response, "response is ProjectsDto");
        }
        
    }

}
