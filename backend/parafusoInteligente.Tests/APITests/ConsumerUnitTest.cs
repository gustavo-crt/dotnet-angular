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
    public class ConsumerUnitTest
    {
        private string baseUrl = "http://localhost:5000";

        [Fact(DisplayName = "ConsumerUnit WebAPI Post")]
        [Trait("Category", "WebAPI")]
        public void PostConsumerUnitTest()
        {
            string consumerunit = "{\"consumerGroup\": \"consumerGroupTest\", \"coordinates\": \"coordinatesTest\", \"address\": \"addressTest\", \"meterCode\": 1, \"screws\": \"screwsTest\", \"region\": \"regionTest\"}";
            string requestUrl = "ConsumerUnit";

            Requests request = new Requests();
            dynamic result = request.POST<ConsumerUnit>(baseUrl, requestUrl, consumerunit);

            Assert.Equal("OK", result[0]);
            Assert.Equal("consumerGroupTest", result[1].ConsumerGroup);
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI PostList")]
        [Trait("Category", "WebAPI")]
        public void PostListConsumerUnitTest()
        {
            string consumerunit = "[{\"consumerGroup\": \"consumerGroupTest\", \"coordinates\": \"coordinatesTest\", \"address\": \"addressTest\", \"meterCode\": 1, \"screws\": \"screwsTest\", \"region\": \"regionTest\"}]";
            string requestUrl = "ConsumerUnit/list";

            Requests request = new Requests();
            dynamic result = request.POSTLIST<ConsumerUnit>(baseUrl, requestUrl, consumerunit);

            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI Delete")]
        [Trait("Category", "WebAPI")]
        public void DeleteConsumerUnitTest()
        {

            string consumerunit = "{\"consumerGroup\": \"consumerGroupTest\", \"coordinates\": \"coordinatesTest\", \"address\": \"addressTest\", \"meterCode\": 1, \"screws\": \"screwsTest\", \"region\": \"regionTest\"}";
            string requestUrl = "ConsumerUnit";
            string getUrl = "ConsumerUnit/{_id}";
            Requests request = new Requests();
            string id = request.POST<ConsumerUnit>(baseUrl, requestUrl, consumerunit)[1].id.ToString();

            dynamic result = request.DELETE<ConsumerUnit>(baseUrl, getUrl, id);
            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI Get")]
        [Trait("Category", "WebAPI")]
        public void GetConsumerUnitTest()
        {
            string consumerunit = "{\"consumerGroup\": \"consumerGroupTest\", \"coordinates\": \"coordinatesTest\", \"address\": \"addressTest\", \"meterCode\": 1, \"screws\": \"screwsTest\", \"region\": \"regionTest\"}";
            string requestUrl = "ConsumerUnit";
            string getUrl = "ConsumerUnit/{_id}";
            Requests request = new Requests();
            string id = request.POST<ConsumerUnit>(baseUrl, requestUrl, consumerunit)[1].id.ToString();

            dynamic result = request.GET<ConsumerUnit>(baseUrl, getUrl, id);

            Assert.Equal("OK", result[0]);
            Assert.Equal("consumerGroupTest", result[1].ConsumerGroup);
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI GetAll")]
        [Trait("Category", "WebAPI")]
        public void GetAllConsumerUnitTest()
        {
            string getUrl = "ConsumerUnit/allFilter/{_pageNumber}/{_listSize}/{_orderby}/{_way}";
            Requests request = new Requests();

            RestResponse result = request.GETAll<ConsumerUnit>(baseUrl, getUrl, 0, 0, "consumerGroup", "ASC");

            Assert.Equal("OK", result.StatusCode.ToString());
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI Put")]
        [Trait("Category", "WebAPI")]
        public void PutConsumerUnitTest()
        {
            string consumerunit = "{\"ConsumerGroup\": \"consumerGroupTest\", \"Coordinates\": \"coordinatesTest\", \"Address\": \"addressTest\", \"MeterCode\": 1, \"Screws\": \"screwsTest\", \"Region\": \"regionTest\"}";
            string requestUrl = "ConsumerUnit";
            string getUrl = "ConsumerUnit/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<ConsumerUnit>(baseUrl, requestUrl, consumerunit)[1].id.ToString();

            dynamic resultGet = request.GET<ConsumerUnit>(baseUrl, getUrl, id);

            if (resultGet[1].ConsumerGroup.Equals("consumerGroupTest"))
            {
                resultGet[1].ConsumerGroup = "consumerGroupChanged";
                changedValue = resultGet[1].ConsumerGroup;
            }
            else
            {
                resultGet[1].ConsumerGroup = "consumerGroupTest";
                changedValue = resultGet[1].ConsumerGroup;
            }
            string json = new JsonHandler().ToJson<ConsumerUnit>(resultGet[1]);
            dynamic result = request.PUT<ConsumerUnit>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].ConsumerGroup, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

        [Fact(DisplayName = "ConsumerUnit WebAPI Patch")]
        [Trait("Category", "WebAPI")]
        public void PatchConsumerUnitTest()
        {
            string consumerunit = "{\"ConsumerGroup\": \"consumerGroupTest\", \"Coordinates\": \"coordinatesTest\", \"Address\": \"addressTest\", \"MeterCode\": 1, \"Screws\": \"screwsTest\", \"Region\": \"regionTest\"}";
            string requestUrl = "ConsumerUnit";
            string getUrl = "ConsumerUnit/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<ConsumerUnit>(baseUrl, requestUrl, consumerunit)[1].id.ToString();

            dynamic resultGet = request.GET<ConsumerUnit>(baseUrl, getUrl, id);

            if (resultGet[1].ConsumerGroup.Equals("consumerGroupTest"))
            {
                resultGet[1].ConsumerGroup = "ConsumerGroupChanged";
                changedValue = resultGet[1].ConsumerGroup;
            }
            else
            {
                resultGet[1].ConsumerGroup = "ConsumerGroupTest";
                changedValue = resultGet[1].ConsumerGroup;
            }
            string json = new JsonHandler().ToJson<ConsumerUnit>(resultGet[1]);
            dynamic result = request.PATCH<ConsumerUnit>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].ConsumerGroup, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

    }
}
