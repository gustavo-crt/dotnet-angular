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
    public class StockManagementTest
    {
        private string baseUrl = "http://localhost:5000";

        [Fact(DisplayName = "StockManagement WebAPI Post")]
        [Trait("Category", "WebAPI")]
        public void PostStockManagementTest()
        {
            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";

            Requests request = new Requests();
            dynamic result = request.POST<StockManagement>(baseUrl, requestUrl, stockmanagement);

            Assert.Equal("OK", result[0]);
            Assert.Equal("typeTest", result[1].Type);
        }

        [Fact(DisplayName = "StockManagement WebAPI PostList")]
        [Trait("Category", "WebAPI")]
        public void PostListStockManagementTest()
        {
            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";

            Requests request = new Requests();
            dynamic result = request.POSTLIST<StockManagement>(baseUrl, requestUrl, stockmanagement);

            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "StockManagement WebAPI Delete")]
        [Trait("Category", "WebAPI")]
        public void DeleteStockManagementTest()
        {

            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";
            string getUrl = "StockManagement/{_id}";
            Requests request = new Requests();
            string id = request.POST<StockManagement>(baseUrl, requestUrl, stockmanagement)[1].id.ToString();

            dynamic result = request.DELETE<StockManagement>(baseUrl, getUrl, id);
            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "StockManagement WebAPI Get")]
        [Trait("Category", "WebAPI")]
        public void GetStockManagementTest()
        {
            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";
            string getUrl = "StockManagement/{_id}";
            Requests request = new Requests();
            string id = request.POST<StockManagement>(baseUrl, requestUrl, stockmanagement)[1].id.ToString();

            dynamic result = request.GET<StockManagement>(baseUrl, getUrl, id);

            Assert.Equal("OK", result[0]);
            Assert.Equal("typeTest", result[1].Type);
        }

        [Fact(DisplayName = "StockManagement WebAPI GetAll")]
        [Trait("Category", "WebAPI")]
        public void GetAllStockManagementTest()
        {
            string getUrl = "StockManagement/allFilter/{_pageNumber}/{_listSize}/{_orderby}/{_way}";
            Requests request = new Requests();

            RestResponse result = request.GETAll<StockManagement>(baseUrl, getUrl, 0, 0, "type", "ASC");

            Assert.Equal("OK", result.StatusCode.ToString());
        }

        [Fact(DisplayName = "StockManagement WebAPI Put")]
        [Trait("Category", "WebAPI")]
        public void PutStockManagementTest()
        {
            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";
            string getUrl = "StockManagement/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<StockManagement>(baseUrl, requestUrl, stockmanagement)[1].id.ToString();

            dynamic resultGet = request.GET<StockManagement>(baseUrl, getUrl, id);

            if (resultGet[1].Type.Equals("typeTest"))
            {
                resultGet[1].Type = "typeChanged";
                changedValue = resultGet[1].Type;
            }
            else
            {
                resultGet[1].Type = "typeTest";
                changedValue = resultGet[1].Type;
            }
            string json = new JsonHandler().ToJson<StockManagement>(resultGet[1]);
            dynamic result = request.PUT<StockManagement>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Type, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

        [Fact(DisplayName = "StockManagement WebAPI Patch")]
        [Trait("Category", "WebAPI")]
        public void PatchStockManagementTest()
        {
            string stockmanagement = "{\"type\": \"typeTest\", \"identifier\": \"identifierTest\", \"location\": \"locationTest\", \"lastAccess\": \"lastAccessTest\", \"status\": \"statusTest\", \"stockStatus\": \"stockStatusTest\"}";
            string requestUrl = "StockManagement";
            string getUrl = "StockManagement/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<StockManagement>(baseUrl, requestUrl, stockmanagement)[1].id.ToString();

            dynamic resultGet = request.GET<StockManagement>(baseUrl, getUrl, id);

            if (resultGet[1].Type.Equals("typeTest"))
            {
                resultGet[1].Type = "TypeChanged";
                changedValue = resultGet[1].Type;
            }
            else
            {
                resultGet[1].Type = "TypeTest";
                changedValue = resultGet[1].Type;
            }
            string json = new JsonHandler().ToJson<StockManagement>(resultGet[1]);
            dynamic result = request.PATCH<StockManagement>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Type, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

    }
}
