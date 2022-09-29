using System.Net;
using RestSharp;
using RequestsTest.Utils;
using System.Collections.Generic;
using System.Collections;
using System;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection;
using System.Net.Mail;

namespace RequestsTest.Utils
{
    public class Requests : ControllerBase
    {
        public dynamic GET<T>(string baseUrl, string requestUrl, string attributeId)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);

            var request = new RestRequest(requestUrl, Method.Get);
            if (attributeId != null)
            {

                request.AddUrlSegment("_id", attributeId);
            }

            RestResponse response = client.Execute(request);

            if (!(response.Content.Equals("")))
            {
                var resultObj = new JsonHandler().ToObj<T>(response.Content);
                result[0] = response.StatusCode.ToString();
                result[1] = resultObj;
            }
            return result;
        }

        public dynamic GETAll<T>(string baseUrl, string requestUrl, int atributePageNumber, int atributeListSize, string atributeOrderby, string atributeWay)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);

            var request = new RestRequest(requestUrl, Method.Get);

            request.AddUrlSegment("_pageNumber", atributePageNumber);
            request.AddUrlSegment("_listSize", atributeListSize);
            request.AddUrlSegment("_orderby", atributeOrderby);
            request.AddUrlSegment("_way", atributeWay);

            RestResponse response = client.Execute(request);

            return response;
        }

        public dynamic PUT<T>(string baseUrl, string requestUrl, string attributeId, string updatedJson)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var request = new RestRequest(requestUrl, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("text/json", updatedJson, ParameterType.RequestBody);
            request.AddUrlSegment("_id", attributeId);

            RestResponse response = client.Execute(request);

            if (!(response.Content.Equals("")))
            {
                var resultObj = new JsonHandler().ToObj<T>(response.Content);
                result[0] = response.StatusCode.ToString();
                result[1] = resultObj;
            }
            return result;
        }

        public dynamic PATCH<T>(string baseUrl, string requestUrl, string attributeId, string updatedJson)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var request = new RestRequest(requestUrl, Method.Patch);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("text/json", updatedJson, ParameterType.RequestBody);
            request.AddUrlSegment("_id", attributeId);

            RestResponse response = client.Execute(request);

            if (!(response.Content.Equals("")))
            {
                var resultObj = new JsonHandler().ToObj<T>(response.Content);
                result[0] = response.StatusCode.ToString();
                result[1] = resultObj;
            }
            return result;
        }

        public dynamic POST<T>(string baseUrl, string requestUrl, string registerJson)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest(requestUrl, Method.Post);

            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", registerJson, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);

            if (!(response.Content.Equals("")))
            {
                var resultObj = new JsonHandler().ToObj<T>(response.Content);
                result[0] = response.StatusCode.ToString();
                result[1] = resultObj;
            }
            return result;
        }

        public dynamic POSTLIST<T>(string baseUrl, string requestUrl, string registerJson)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest(requestUrl, Method.Post);

            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", registerJson, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);

            result[0] = response.StatusCode.ToString();

            return result;
        }

        public dynamic POSTSAVE<T>(string baseUrl, string requestUrl, string[,] parameters, string registerJson)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest(requestUrl, Method.Post);

            for (int i = 0; i < parameters.Length / 2; i++)
            {
                request.AddParameter(parameters[i, 0], parameters[i, 1]);
            }

            if (requestUrl != "InspectionChecklist/save" && requestUrl != "InspectionCustomerInformation/save")
            {
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string[] path = outPutDirectory.Split("RequestsTest\\");
                var logoimage = Path.Combine(path[0], "RequestsTest\\Utils\\teste.jpg");
                string relLogo = new Uri(logoimage).LocalPath;
                request.AddFile("filename", relLogo, "image/jpeg");
                request.AlwaysMultipartFormData = true;
            }
            else
            {
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", registerJson, ParameterType.RequestBody);
            }

            RestResponse response = client.Execute(request);

            if (requestUrl != "InspectionChecklist/save" && requestUrl != "InspectionCustomerInformation/save")
            {
                bool delete = DeleteItem();
                result[1] = delete;
            }

            result[0] = response.StatusCode.ToString();

            return result;
        }

        public bool DeleteItem()
        {
            string bucketName = "pnt-s3";
            var accessKeyId = "";
            var secretAccessKey = "";
            using (var client = new AmazonS3Client(accessKeyId, secretAccessKey, RegionEndpoint.USEast2))
            {
                try
                {
                    var deleteObjectRequest = new DeleteObjectRequest { BucketName = bucketName, Key = "Images/Inspection/teste.jpg" };
                    client.DeleteObjectAsync(deleteObjectRequest).Wait();
                }
                catch
                {
                    return false;
                }
            }

            return true;

        }

        public dynamic DELETE<T>(string baseUrl, string requestUrl, string attributeId)
        {

            dynamic[] result = new dynamic[2];

            var client = new RestClient(baseUrl);
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest(requestUrl, Method.Delete);

            request.AddUrlSegment("_id", attributeId);

            RestResponse response = client.Execute(request);

            result[0] = response.StatusCode.ToString();

            return result;

        }

    }
}
