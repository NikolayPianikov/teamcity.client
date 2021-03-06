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
    ///  Class for testing TestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TestApiTests
    {
        private TestApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TestApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TestApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TestApi
            //Assert.IsInstanceOfType(typeof(TestApi), instance, "instance is a TestApi");
        }

        
        /// <summary>
        /// Test GetTests1
        /// </summary>
        [Test]
        public void GetTests1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.GetTests1(locator, fields);
            //Assert.IsInstanceOf<TestsDto> (response, "response is TestsDto");
        }
        
        /// <summary>
        /// Test ServeInstance5
        /// </summary>
        [Test]
        public void ServeInstance5Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string testLocator = null;
            //string fields = null;
            //var response = instance.ServeInstance5(testLocator, fields);
            //Assert.IsInstanceOf<TestDto> (response, "response is TestDto");
        }
        
    }

}
