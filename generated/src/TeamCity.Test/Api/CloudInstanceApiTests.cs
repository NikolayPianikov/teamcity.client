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
    ///  Class for testing CloudInstanceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CloudInstanceApiTests
    {
        private CloudInstanceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CloudInstanceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CloudInstanceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CloudInstanceApi
            //Assert.IsInstanceOfType(typeof(CloudInstanceApi), instance, "instance is a CloudInstanceApi");
        }

        
        /// <summary>
        /// Test ServeImage
        /// </summary>
        [Test]
        public void ServeImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string imageLocator = null;
            //string fields = null;
            //var response = instance.ServeImage(imageLocator, fields);
            //Assert.IsInstanceOf<CloudImageDto> (response, "response is CloudImageDto");
        }
        
        /// <summary>
        /// Test ServeImages
        /// </summary>
        [Test]
        public void ServeImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeImages(locator, fields);
            //Assert.IsInstanceOf<CloudImagesDto> (response, "response is CloudImagesDto");
        }
        
        /// <summary>
        /// Test ServeInstance
        /// </summary>
        [Test]
        public void ServeInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceLocator = null;
            //string fields = null;
            //var response = instance.ServeInstance(instanceLocator, fields);
            //Assert.IsInstanceOf<CloudInstanceDto> (response, "response is CloudInstanceDto");
        }
        
        /// <summary>
        /// Test ServeInstances
        /// </summary>
        [Test]
        public void ServeInstancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeInstances(locator, fields);
            //Assert.IsInstanceOf<CloudInstancesDto> (response, "response is CloudInstancesDto");
        }
        
        /// <summary>
        /// Test ServeProfile
        /// </summary>
        [Test]
        public void ServeProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileLocator = null;
            //string fields = null;
            //var response = instance.ServeProfile(profileLocator, fields);
            //Assert.IsInstanceOf<CloudProfileDto> (response, "response is CloudProfileDto");
        }
        
        /// <summary>
        /// Test ServeProfiles
        /// </summary>
        [Test]
        public void ServeProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeProfiles(locator, fields);
            //Assert.IsInstanceOf<CloudProfilesDto> (response, "response is CloudProfilesDto");
        }
        
        /// <summary>
        /// Test StartInstance
        /// </summary>
        [Test]
        public void StartInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CloudInstanceDto body = null;
            //string fields = null;
            //instance.StartInstance(body, fields);
            
        }
        
        /// <summary>
        /// Test StopInstance
        /// </summary>
        [Test]
        public void StopInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceLocator = null;
            //instance.StopInstance(instanceLocator);
            
        }
        
    }

}