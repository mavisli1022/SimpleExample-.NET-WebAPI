using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace WebApi.Steps.Spec
{
    [Binding]
    public class GetProductSteps
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response;


        [Given(@"I am at the home page want to see detail of 2")]
        public void GivenIAmAtTheHomePageWantToSeeDetailOf()
        {
            client.BaseAddress = new Uri("http://localhost:49365/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [When(@"I click submit button")]
        public void WhenTheClientMakesAGetRequest()
        {
            response = client.GetAsync("api/product/2").Result;
        }


        [Then(@"the returned status code is success")]
        public void ThenTheStatusCodeIs()
        {
            Assert.AreEqual(response.IsSuccessStatusCode, true);
        }


    /*
        [Then(@"the response contains product details")]
        public void ThenTheProductHasTheValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                var propertyName = row["Name"];
                var expectedValue = row["Value"];
                Assert.AreEqual(expectedValue, Response.Value<string>(propertyName));
            }
        }
    */
    }
}
