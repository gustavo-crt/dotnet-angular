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
    public class BusinessRulesTest
    {
        private string baseUrl = "http://localhost:5000";

        [Fact(DisplayName = "BusinessRules WebAPI Post")]
        [Trait("Category", "WebAPI")]
        public void PostBusinessRulesTest()
        {
            string businessrules = "{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}";
            string requestUrl = "BusinessRules";

            Requests request = new Requests();
            dynamic result = request.POST<BusinessRules>(baseUrl, requestUrl, businessrules);

            Assert.Equal("OK", result[0]);
            Assert.Equal("ruleTest", result[1].Rule);
        }

        [Fact(DisplayName = "BusinessRules WebAPI PostList")]
        [Trait("Category", "WebAPI")]
        public void PostListBusinessRulesTest()
        {
            string businessrules = "[{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}]";
            string requestUrl = "BusinessRules/list";

            Requests request = new Requests();
            dynamic result = request.POSTLIST<BusinessRules>(baseUrl, requestUrl, businessrules);

            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "BusinessRules WebAPI Delete")]
        [Trait("Category", "WebAPI")]
        public void DeleteBusinessRulesTest()
        {

            string businessrules = "{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}";
            string requestUrl = "BusinessRules";
            string getUrl = "BusinessRules/{_id}";
            Requests request = new Requests();
            string id = request.POST<BusinessRules>(baseUrl, requestUrl, businessrules)[1].id.ToString();

            dynamic result = request.DELETE<BusinessRules>(baseUrl, getUrl, id);
            Assert.Equal("OK", result[0]);
        }

        [Fact(DisplayName = "BusinessRules WebAPI Get")]
        [Trait("Category", "WebAPI")]
        public void GetBusinessRulesTest()
        {
            string businessrules = "{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}";
            string requestUrl = "BusinessRules";
            string getUrl = "BusinessRules/{_id}";
            Requests request = new Requests();
            string id = request.POST<BusinessRules>(baseUrl, requestUrl, businessrules)[1].id.ToString();

            dynamic result = request.GET<BusinessRules>(baseUrl, getUrl, id);

            Assert.Equal("OK", result[0]);
            Assert.Equal("ruleTest", result[1].Rule);
        }

        [Fact(DisplayName = "BusinessRules WebAPI GetAll")]
        [Trait("Category", "WebAPI")]
        public void GetAllBusinessRulesTest()
        {
            string getUrl = "BusinessRules/allFilter/{_pageNumber}/{_listSize}/{_orderby}/{_way}";
            Requests request = new Requests();

            RestResponse result = request.GETAll<BusinessRules>(baseUrl, getUrl, 0, 0, "rule", "ASC");

            Assert.Equal("OK", result.StatusCode.ToString());
        }

        [Fact(DisplayName = "BusinessRules WebAPI Put")]
        [Trait("Category", "WebAPI")]
        public void PutBusinessRulesTest()
        {
            string businessrules = "{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}";
            string requestUrl = "BusinessRules";
            string getUrl = "BusinessRules/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<BusinessRules>(baseUrl, requestUrl, businessrules)[1].id.ToString();

            dynamic resultGet = request.GET<BusinessRules>(baseUrl, getUrl, id);

            if (resultGet[1].Rule.Equals("ruleTest"))
            {
                resultGet[1].Rule = "ruleChanged";
                changedValue = resultGet[1].Rule;
            }
            else
            {
                resultGet[1].Rule = "ruleTest";
                changedValue = resultGet[1].Rule;
            }
            string json = new JsonHandler().ToJson<BusinessRules>(resultGet[1]);
            dynamic result = request.PUT<BusinessRules>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Rule, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

        [Fact(DisplayName = "BusinessRules WebAPI Patch")]
        [Trait("Category", "WebAPI")]
        public void PatchBusinessRulesTest()
        {
            string businessrules = "{\"rule\": \"ruleTest\", \"groupsToApply\": \"groupsToApplyTest\", \"permissions\": \"permissionsTest\", \"hourToApply\": \"hourToApplyTest\", \"region\": \"regionTest\", \"keysToApply\": \"keysToApplyTest\", \"screwsToApply\": \"screwsToApplyTest\"}";
            string requestUrl = "BusinessRules";
            string getUrl = "BusinessRules/{_id}";
            string changedValue = "";

            Requests request = new Requests();
            string id = request.POST<BusinessRules>(baseUrl, requestUrl, businessrules)[1].id.ToString();

            dynamic resultGet = request.GET<BusinessRules>(baseUrl, getUrl, id);

            if (resultGet[1].Rule.Equals("ruleTest"))
            {
                resultGet[1].Rule = "RuleChanged";
                changedValue = resultGet[1].Rule;
            }
            else
            {
                resultGet[1].Rule = "RuleTest";
                changedValue = resultGet[1].Rule;
            }
            string json = new JsonHandler().ToJson<BusinessRules>(resultGet[1]);
            dynamic result = request.PATCH<BusinessRules>(baseUrl, getUrl, id, json);
            string statusCode = result[0];
            if (!statusCode.Equals("NoContent"))
            {
                Assert.Equal(statusCode, "OK");
                Assert.Equal(result[1].Rule, changedValue);
            }
            else
            {
                Assert.Equal(true, false);
            }
        }

    }
}
