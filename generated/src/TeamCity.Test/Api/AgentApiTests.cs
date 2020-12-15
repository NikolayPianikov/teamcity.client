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
    ///  Class for testing AgentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AgentApiTests
    {
        private AgentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AgentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AgentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AgentApi
            //Assert.IsInstanceOfType(typeof(AgentApi), instance, "instance is a AgentApi");
        }

        
        /// <summary>
        /// Test DeleteAgent
        /// </summary>
        [Test]
        public void DeleteAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //instance.DeleteAgent(agentLocator);
            
        }
        
        /// <summary>
        /// Test GeIncompatibleBuildTypes
        /// </summary>
        [Test]
        public void GeIncompatibleBuildTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GeIncompatibleBuildTypes(agentLocator, fields);
            //Assert.IsInstanceOf<CompatibilitiesDto> (response, "response is CompatibilitiesDto");
        }
        
        /// <summary>
        /// Test GetAgentPool
        /// </summary>
        [Test]
        public void GetAgentPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GetAgentPool(agentLocator, fields);
            //Assert.IsInstanceOf<AgentPoolDto> (response, "response is AgentPoolDto");
        }
        
        /// <summary>
        /// Test GetAllowedRunConfigurations
        /// </summary>
        [Test]
        public void GetAllowedRunConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GetAllowedRunConfigurations(agentLocator, fields);
            //Assert.IsInstanceOf<CompatibilityPolicyDto> (response, "response is CompatibilityPolicyDto");
        }
        
        /// <summary>
        /// Test GetAuthorizedInfo
        /// </summary>
        [Test]
        public void GetAuthorizedInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GetAuthorizedInfo(agentLocator, fields);
            //Assert.IsInstanceOf<AuthorizedInfoDto> (response, "response is AuthorizedInfoDto");
        }
        
        /// <summary>
        /// Test GetCompatibleBuildTypes
        /// </summary>
        [Test]
        public void GetCompatibleBuildTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GetCompatibleBuildTypes(agentLocator, fields);
            //Assert.IsInstanceOf<BuildTypesDto> (response, "response is BuildTypesDto");
        }
        
        /// <summary>
        /// Test GetEnabledInfo
        /// </summary>
        [Test]
        public void GetEnabledInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.GetEnabledInfo(agentLocator, fields);
            //Assert.IsInstanceOf<EnabledInfoDto> (response, "response is EnabledInfoDto");
        }
        
        /// <summary>
        /// Test ServeAgent
        /// </summary>
        [Test]
        public void ServeAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string fields = null;
            //var response = instance.ServeAgent(agentLocator, fields);
            //Assert.IsInstanceOf<AgentDto> (response, "response is AgentDto");
        }
        
        /// <summary>
        /// Test ServeAgentField
        /// </summary>
        [Test]
        public void ServeAgentFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string field = null;
            //var response = instance.ServeAgentField(agentLocator, field);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeAgents
        /// </summary>
        [Test]
        public void ServeAgentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeAgents(locator, fields);
            //Assert.IsInstanceOf<AgentsDto> (response, "response is AgentsDto");
        }
        
        /// <summary>
        /// Test SetAgentField
        /// </summary>
        [Test]
        public void SetAgentFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //string field = null;
            //string body = null;
            //var response = instance.SetAgentField(agentLocator, field, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SetAgentPool
        /// </summary>
        [Test]
        public void SetAgentPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //AgentPoolDto body = null;
            //string fields = null;
            //var response = instance.SetAgentPool(agentLocator, body, fields);
            //Assert.IsInstanceOf<AgentPoolDto> (response, "response is AgentPoolDto");
        }
        
        /// <summary>
        /// Test SetAllowedRunConfigurations
        /// </summary>
        [Test]
        public void SetAllowedRunConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //CompatibilityPolicyDto body = null;
            //string fields = null;
            //var response = instance.SetAllowedRunConfigurations(agentLocator, body, fields);
            //Assert.IsInstanceOf<CompatibilityPolicyDto> (response, "response is CompatibilityPolicyDto");
        }
        
        /// <summary>
        /// Test SetAuthorizedInfo
        /// </summary>
        [Test]
        public void SetAuthorizedInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //AuthorizedInfoDto body = null;
            //string fields = null;
            //var response = instance.SetAuthorizedInfo(agentLocator, body, fields);
            //Assert.IsInstanceOf<AuthorizedInfoDto> (response, "response is AuthorizedInfoDto");
        }
        
        /// <summary>
        /// Test SetEnabledInfo
        /// </summary>
        [Test]
        public void SetEnabledInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentLocator = null;
            //EnabledInfoDto body = null;
            //string fields = null;
            //var response = instance.SetEnabledInfo(agentLocator, body, fields);
            //Assert.IsInstanceOf<EnabledInfoDto> (response, "response is EnabledInfoDto");
        }
        
    }

}
