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
    public class ServiceOrderTest
    {
        private string baseUrl = "http://localhost:5000";

        [Fact(DisplayName = "ServiceOrder WebAPI Post")]
        [Trait("Category", "WebAPI")]
        public void PostServiceOrderTest()
        {
            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";

            Requests request = new Requests();
            dynamic result = request.POST<ServiceOrder>(baseUrl, requestUrl, serviceorder);

            Assert.Equal("OK", result[0]);
            Assert.Equal("serviceTest", result[1].Service);
        }

        [Fact(DisplayName = "ServiceOrder WebAPI PostList")]
        [Trait("Category", "WebAPI")]
        public void PostListServiceOrderTest()
        {
            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";

            Requests request = new Requests();
            dynamic result = request.POSTLIST<ServiceOrder>(baseUrl, requestUrl, serviceorder);

            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "ServiceOrder WebAPI Delete")]
        [Trait("Category", "WebAPI")]
        public void DeleteServiceOrderTest()
        {

            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";
            string getUrl = "ServiceOrder/{_id}";
            Requests request = new Requests();
            string id = request.POST<ServiceOrder>(baseUrl, requestUrl, serviceorder)[1].id.ToString();

            dynamic result = request.DELETE<ServiceOrder>(baseUrl, getUrl, id);
            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "ServiceOrder WebAPI Get")]
        [Trait("Category", "WebAPI")]
        public void GetServiceOrderTest()
        {
            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";
            string getUrl = "ServiceOrder/{_id}";
            Requests request = new Requests();
            string id = request.POST<ServiceOrder>(baseUrl, requestUrl, serviceorder)[1].id.ToString();

            dynamic result = request.GET<ServiceOrder>(baseUrl, getUrl, id);

            Assert.Equal("OK", result[0]);
            Assert.Equal("serviceTest", result[1].Service);
        }

        [Fact(DisplayName = "ServiceOrder WebAPI GetAll")]
        [Trait("Category", "WebAPI")]
        public void GetAllServiceOrderTest()
        {
            string getUrl = "ServiceOrder/allFilter/{_pageNumber}/{_listSize}/{_orderby}/{_way}";
            Requests request = new Requests();

            RestResponse result = request.GETAll<ServiceOrder>(baseUrl, getUrl, 0, 0, "service", "ASC");

            Assert.Equal("OK", result.StatusCode.ToString());
        }

        [Fact(DisplayName = "ServiceOrder WebAPI Put")]
        [Trait("Category", "WebAPI")]
        public void PutServiceOrderTest()
        {
            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";
            string getUrl = "ServiceOrder/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<ServiceOrder>(baseUrl, requestUrl, serviceorder)[1].id.ToString();

            dynamic resultGet = request.GET<ServiceOrder>(baseUrl, getUrl, id);

            if (resultGet[1].Service.Equals("serviceTest"))
            {
                resultGet[1].Service = "serviceChanged";
                changedValue = resultGet[1].Service;
            }
            else
            {
                resultGet[1].Service = "serviceTest";
                changedValue = resultGet[1].Service;
            }
            string json = new JsonHandler().ToJson<ServiceOrder>(resultGet[1]);
            dynamic result = request.PUT<ServiceOrder>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Service, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

        [Fact(DisplayName = "ServiceOrder WebAPI Patch")]
        [Trait("Category", "WebAPI")]
        public void PatchServiceOrderTest()
        {
            string serviceorder = "{\"os\": 1, \"service\": \"serviceTest\", \"address\": \"addressTest\", \"meter\": \"meterTest\", \"cdc\": \"cdcTest\"}";
            string requestUrl = "ServiceOrder";
            string getUrl = "ServiceOrder/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<ServiceOrder>(baseUrl, requestUrl, serviceorder)[1].id.ToString();

            dynamic resultGet = request.GET<ServiceOrder>(baseUrl, getUrl, id);

            if (resultGet[1].Service.Equals("serviceTest"))
            {
                resultGet[1].Service = "ServiceChanged";
                changedValue = resultGet[1].Service;
            }
            else
            {
                resultGet[1].Service = "ServiceTest";
                changedValue = resultGet[1].Service;
            }
            string json = new JsonHandler().ToJson<ServiceOrder>(resultGet[1]);
            dynamic result = request.PATCH<ServiceOrder>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Service, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

    }
}
