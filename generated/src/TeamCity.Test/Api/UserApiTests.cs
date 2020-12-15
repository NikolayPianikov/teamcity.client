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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test AddGroupToUser
        /// </summary>
        [Test]
        public void AddGroupToUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //GroupDto body = null;
            //string fields = null;
            //var response = instance.AddGroupToUser(userLocator, body, fields);
            //Assert.IsInstanceOf<GroupDto> (response, "response is GroupDto");
        }
        
        /// <summary>
        /// Test AddRoleToUser
        /// </summary>
        [Test]
        public void AddRoleToUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //RoleDto body = null;
            //var response = instance.AddRoleToUser(userLocator, body);
            //Assert.IsInstanceOf<RoleDto> (response, "response is RoleDto");
        }
        
        /// <summary>
        /// Test AddRoleToUserSimple
        /// </summary>
        [Test]
        public void AddRoleToUserSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string roleId = null;
            //string scope = null;
            //var response = instance.AddRoleToUserSimple(userLocator, roleId, scope);
            //Assert.IsInstanceOf<RoleDto> (response, "response is RoleDto");
        }
        
        /// <summary>
        /// Test CreateToken
        /// </summary>
        [Test]
        public void CreateTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string name = null;
            //string fields = null;
            //var response = instance.CreateToken(userLocator, name, fields);
            //Assert.IsInstanceOf<TokenDto> (response, "response is TokenDto");
        }
        
        /// <summary>
        /// Test CreateToken1
        /// </summary>
        [Test]
        public void CreateToken1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //TokenDto body = null;
            //string fields = null;
            //var response = instance.CreateToken1(userLocator, body, fields);
            //Assert.IsInstanceOf<TokenDto> (response, "response is TokenDto");
        }
        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserDto body = null;
            //string fields = null;
            //var response = instance.CreateUser(body, fields);
            //Assert.IsInstanceOf<UserDto> (response, "response is UserDto");
        }
        
        /// <summary>
        /// Test DeleteRememberMe
        /// </summary>
        [Test]
        public void DeleteRememberMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //instance.DeleteRememberMe(userLocator);
            
        }
        
        /// <summary>
        /// Test DeleteRoleFromUser
        /// </summary>
        [Test]
        public void DeleteRoleFromUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string roleId = null;
            //string scope = null;
            //instance.DeleteRoleFromUser(userLocator, roleId, scope);
            
        }
        
        /// <summary>
        /// Test DeleteToken
        /// </summary>
        [Test]
        public void DeleteTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string name = null;
            //instance.DeleteToken(userLocator, name);
            
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //instance.DeleteUser(userLocator);
            
        }
        
        /// <summary>
        /// Test DeleteUserField
        /// </summary>
        [Test]
        public void DeleteUserFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string field = null;
            //instance.DeleteUserField(userLocator, field);
            
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Test]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string groupLocator = null;
            //string fields = null;
            //var response = instance.GetGroup(userLocator, groupLocator, fields);
            //Assert.IsInstanceOf<GroupDto> (response, "response is GroupDto");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string fields = null;
            //var response = instance.GetGroups(userLocator, fields);
            //Assert.IsInstanceOf<GroupsDto> (response, "response is GroupsDto");
        }
        
        /// <summary>
        /// Test GetPermissions1
        /// </summary>
        [Test]
        public void GetPermissions1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string locator = null;
            //string fields = null;
            //var response = instance.GetPermissions1(userLocator, locator, fields);
            //Assert.IsInstanceOf<PermissionAssignmentsDto> (response, "response is PermissionAssignmentsDto");
        }
        
        /// <summary>
        /// Test GetPermissions2
        /// </summary>
        [Test]
        public void GetPermissions2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //var response = instance.GetPermissions2(userLocator);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetTokens
        /// </summary>
        [Test]
        public void GetTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string fields = null;
            //var response = instance.GetTokens(userLocator, fields);
            //Assert.IsInstanceOf<TokensDto> (response, "response is TokensDto");
        }
        
        /// <summary>
        /// Test ListRoleForUser
        /// </summary>
        [Test]
        public void ListRoleForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string roleId = null;
            //string scope = null;
            //var response = instance.ListRoleForUser(userLocator, roleId, scope);
            //Assert.IsInstanceOf<RoleDto> (response, "response is RoleDto");
        }
        
        /// <summary>
        /// Test ListRolesForUser
        /// </summary>
        [Test]
        public void ListRolesForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //var response = instance.ListRolesForUser(userLocator);
            //Assert.IsInstanceOf<RolesDto> (response, "response is RolesDto");
        }
        
        /// <summary>
        /// Test PutUserProperty1
        /// </summary>
        [Test]
        public void PutUserProperty1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string name = null;
            //string body = null;
            //var response = instance.PutUserProperty1(userLocator, name, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test RemoveGroup
        /// </summary>
        [Test]
        public void RemoveGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string groupLocator = null;
            //string fields = null;
            //instance.RemoveGroup(userLocator, groupLocator, fields);
            
        }
        
        /// <summary>
        /// Test RemoveUserProperty1
        /// </summary>
        [Test]
        public void RemoveUserProperty1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string name = null;
            //instance.RemoveUserProperty1(userLocator, name);
            
        }
        
        /// <summary>
        /// Test ReplaceGroups
        /// </summary>
        [Test]
        public void ReplaceGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //GroupsDto body = null;
            //string fields = null;
            //var response = instance.ReplaceGroups(userLocator, body, fields);
            //Assert.IsInstanceOf<GroupsDto> (response, "response is GroupsDto");
        }
        
        /// <summary>
        /// Test ReplaceRoles
        /// </summary>
        [Test]
        public void ReplaceRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //RolesDto body = null;
            //var response = instance.ReplaceRoles(userLocator, body);
            //Assert.IsInstanceOf<RolesDto> (response, "response is RolesDto");
        }
        
        /// <summary>
        /// Test ServeUser
        /// </summary>
        [Test]
        public void ServeUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string fields = null;
            //var response = instance.ServeUser(userLocator, fields);
            //Assert.IsInstanceOf<UserDto> (response, "response is UserDto");
        }
        
        /// <summary>
        /// Test ServeUserField
        /// </summary>
        [Test]
        public void ServeUserFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string field = null;
            //var response = instance.ServeUserField(userLocator, field);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeUserProperties1
        /// </summary>
        [Test]
        public void ServeUserProperties1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string fields = null;
            //var response = instance.ServeUserProperties1(userLocator, fields);
            //Assert.IsInstanceOf<PropertiesDto> (response, "response is PropertiesDto");
        }
        
        /// <summary>
        /// Test ServeUserProperty
        /// </summary>
        [Test]
        public void ServeUserPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string name = null;
            //var response = instance.ServeUserProperty(userLocator, name);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServeUsers
        /// </summary>
        [Test]
        public void ServeUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locator = null;
            //string fields = null;
            //var response = instance.ServeUsers(locator, fields);
            //Assert.IsInstanceOf<UsersDto> (response, "response is UsersDto");
        }
        
        /// <summary>
        /// Test SetUserField
        /// </summary>
        [Test]
        public void SetUserFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //string field = null;
            //string body = null;
            //var response = instance.SetUserField(userLocator, field, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userLocator = null;
            //UserDto body = null;
            //string fields = null;
            //var response = instance.UpdateUser(userLocator, body, fields);
            //Assert.IsInstanceOf<UserDto> (response, "response is UserDto");
        }
        
    }

}
