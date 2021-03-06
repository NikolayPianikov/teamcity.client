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
    ///  Class for testing AuditApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuditApiTests
    {
        private AuditApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuditApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuditApi
            //Assert.IsInstanceOfType(typeof(AuditApi), instance, "instance is a AuditApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.Get(locator, fields);
            //Assert.IsInstanceOf<AuditEventsDto> (response, "response is AuditEventsDto");
        }
        
        /// <summary>
        /// Test GetSingle
        /// </summary>
        [Test]
        public void GetSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string auditEventLocator = null;
            //string fields = null;
            //var response = instance.GetSingle(auditEventLocator, fields);
            //Assert.IsInstanceOf<AuditEventDto> (response, "response is AuditEventDto");
        }
        
    }

}
