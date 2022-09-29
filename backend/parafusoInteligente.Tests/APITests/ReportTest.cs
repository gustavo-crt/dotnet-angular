using System;
using Xunit;
using parafusoInteligente.Domain.Model;
using RequestsTest.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using RestSharp;

namespace APITests
{
    public class ReportTest
    {
        private string baseUrl = "http://localhost:5000";

        [Fact(DisplayName = "Report WebAPI Post")]
        [Trait("Category", "WebAPI")]
        public void PostReportTest()
        {
            string report = "{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}";
            string requestUrl = "Report";

            Requests request = new Requests();
            dynamic result = request.POST<Report>(baseUrl, requestUrl, report);

            Assert.Equal("OK", result[0]);
            Assert.Equal("identifierTest", result[1].Identifier);
        }

        [Fact(DisplayName = "Report WebAPI PostList")]
        [Trait("Category", "WebAPI")]
        public void PostListReportTest()
        {
            string report = "[{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}]";
            string requestUrl = "Report/list";

            Requests request = new Requests();
            dynamic result = request.POSTLIST<Report>(baseUrl, requestUrl, report);

            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "Report WebAPI Delete")]
        [Trait("Category", "WebAPI")]
        public void DeleteReportTest()
        {

            string report = "{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}";
            string requestUrl = "Report";
            string getUrl = "Report/{_id}";
            Requests request = new Requests();
            string id = request.POST<Report>(baseUrl, requestUrl, report)[1].id.ToString();

            dynamic result = request.DELETE<Report>(baseUrl, getUrl, id);
            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "Report WebAPI Get")]
        [Trait("Category", "WebAPI")]
        public void GetReportTest()
        {
            string report = "{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}";
            string requestUrl = "Report";
            string getUrl = "Report/{_id}";
            Requests request = new Requests();
            string id = request.POST<Report>(baseUrl, requestUrl, report)[1].id.ToString();

            dynamic result = request.GET<Report>(baseUrl, getUrl, id);

            Assert.Equal("OK", result[0]);
            Assert.Equal("identifierTest", result[1].Identifier);
        }

        [Fact(DisplayName = "Report WebAPI GetAll")]
        [Trait("Category", "WebAPI")]
        public void GetAllReportTest()
        {
            string getUrl = "Report/allFilter/{_pageNumber}/{_listSize}/{_orderby}/{_way}";
            Requests request = new Requests();

            RestResponse result = request.GETAll<Report>(baseUrl, getUrl, 0, 0, "identifier", "ASC");

            Assert.Equal("OK", result.StatusCode.ToString());
        }

        [Fact(DisplayName = "Report WebAPI Put")]
        [Trait("Category", "WebAPI")]
        public void PutReportTest()
        {
            string report = "{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}";
            string requestUrl = "Report";
            string getUrl = "Report/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<Report>(baseUrl, requestUrl, report)[1].id.ToString();

            dynamic resultGet = request.GET<Report>(baseUrl, getUrl, id);

            if (resultGet[1].Identifier.Equals("identifierTest"))
            {
                resultGet[1].Identifier = "identifierChanged";
                changedValue = resultGet[1].Identifier;
            }
            else
            {
                resultGet[1].Identifier = "identifierTest";
                changedValue = resultGet[1].Identifier;
            }
            string json = new JsonHandler().ToJson<Report>(resultGet[1]);
            dynamic result = request.PUT<Report>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Identifier, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

        [Fact(DisplayName = "Report WebAPI Patch")]
        [Trait("Category", "WebAPI")]
        public void PatchReportTest()
        {
            string report = "{\"identifier\": \"identifierTest\", \"username\": \"usernameTest\", \"dateTimeSync\": \"2022-09-13T03:22:11.060Z\", \"action\": \"actionTest\", \"region\": \"regionTest\"}";
            string requestUrl = "Report";
            string getUrl = "Report/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<Report>(baseUrl, requestUrl, report)[1].id.ToString();

            dynamic resultGet = request.GET<Report>(baseUrl, getUrl, id);

            if (resultGet[1].Identifier.Equals("identifierTest"))
            {
                resultGet[1].Identifier = "IdentifierChanged";
                changedValue = resultGet[1].Identifier;
            }
            else
            {
                resultGet[1].Identifier = "IdentifierTest";
                changedValue = resultGet[1].Identifier;
            }
            string json = new JsonHandler().ToJson<Report>(resultGet[1]);
            dynamic result = request.PATCH<Report>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Identifier, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

    }
}
