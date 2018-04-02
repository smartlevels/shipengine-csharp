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
    ///  Class for testing BatchesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BatchesApiTests
    {
        private BatchesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BatchesApi
            //Assert.IsInstanceOfType(typeof(BatchesApi), instance, "instance is a BatchesApi");
        }

        
        /// <summary>
        /// Test BatchesAddToBatch
        /// </summary>
        [Test]
        public void BatchesAddToBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //ModifyBatchRequest request = null;
            //string apiKey = null;
            //instance.BatchesAddToBatch(batchId, request, apiKey);
            
        }
        
        /// <summary>
        /// Test BatchesCreate
        /// </summary>
        [Test]
        public void BatchesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBatchRequest request = null;
            //string apiKey = null;
            //var response = instance.BatchesCreate(request, apiKey);
            //Assert.IsInstanceOf<Batch> (response, "response is Batch");
        }
        
        /// <summary>
        /// Test BatchesGet
        /// </summary>
        [Test]
        public void BatchesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //string apiKey = null;
            //var response = instance.BatchesGet(batchId, apiKey);
            //Assert.IsInstanceOf<Batch> (response, "response is Batch");
        }
        
        /// <summary>
        /// Test BatchesGetByExternalId
        /// </summary>
        [Test]
        public void BatchesGetByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalBatchId = null;
            //string apiKey = null;
            //var response = instance.BatchesGetByExternalId(externalBatchId, apiKey);
            //Assert.IsInstanceOf<Batch> (response, "response is Batch");
        }
        
        /// <summary>
        /// Test BatchesList
        /// </summary>
        [Test]
        public void BatchesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string status = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortDir = null;
            //string sortBy = null;
            //var response = instance.BatchesList(apiKey, status, page, pageSize, sortDir, sortBy);
            //Assert.IsInstanceOf<ListBatchResponse> (response, "response is ListBatchResponse");
        }
        
        /// <summary>
        /// Test BatchesListErrors
        /// </summary>
        [Test]
        public void BatchesListErrorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //string apiKey = null;
            //int? page = null;
            //int? pagesize = null;
            //var response = instance.BatchesListErrors(batchId, apiKey, page, pagesize);
            //Assert.IsInstanceOf<BatchResponseErrors> (response, "response is BatchResponseErrors");
        }
        
        /// <summary>
        /// Test BatchesProcess
        /// </summary>
        [Test]
        public void BatchesProcessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //ProcessBatchRequest processBatchRequest = null;
            //string apiKey = null;
            //instance.BatchesProcess(batchId, processBatchRequest, apiKey);
            
        }
        
        /// <summary>
        /// Test BatchesRemoveFromBatch
        /// </summary>
        [Test]
        public void BatchesRemoveFromBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string batchId = null;
            //ModifyBatchRequest request = null;
            //string apiKey = null;
            //instance.BatchesRemoveFromBatch(batchId, request, apiKey);
            
        }
        
    }

}
