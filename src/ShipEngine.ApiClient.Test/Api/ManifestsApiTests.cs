/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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

using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Test
{
    /// <summary>
    ///  Class for testing ManifestsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ManifestsApiTests
    {
        private ManifestsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManifestsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ManifestsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ManifestsApi
            //Assert.IsInstanceOfType(typeof(ManifestsApi), instance, "instance is a ManifestsApi");
        }

        
        /// <summary>
        /// Test ManifestsCreate
        /// </summary>
        [Test]
        public void ManifestsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateManifestRequest request = null;
            //string apiKey = null;
            //var response = instance.ManifestsCreate(request, apiKey);
            //Assert.IsInstanceOf<ManifestResponse> (response, "response is ManifestResponse");
        }
        
        /// <summary>
        /// Test ManifestsGet
        /// </summary>
        [Test]
        public void ManifestsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string manifestId = null;
            //string apiKey = null;
            //var response = instance.ManifestsGet(manifestId, apiKey);
            //Assert.IsInstanceOf<ManifestResponse> (response, "response is ManifestResponse");
        }
        
        /// <summary>
        /// Test ManifestsList
        /// </summary>
        [Test]
        public void ManifestsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string warehouseId = null;
            //DateTime? shipDateStart = null;
            //DateTime? shipDateEnd = null;
            //DateTime? createdAtStart = null;
            //DateTime? createdAtEnd = null;
            //string carrierId = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.ManifestsList(apiKey, warehouseId, shipDateStart, shipDateEnd, createdAtStart, createdAtEnd, carrierId, page, pageSize);
            //Assert.IsInstanceOf<ListManifestsResponse> (response, "response is ListManifestsResponse");
        }
        
    }

}
