using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace WebApi.Spec.Steps
{
    [Binding]
    public class DeleteOneItemSteps
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        [Given(@"I am at the home page want to delete item of id (.*)")]
        public void GivenIAmAtTheHomePageWantToDeleteItemOfId(int p0)
        {
            client.BaseAddress = new Uri("http://localhost:49365/");
        }
        
        [When(@"I click delete button")]
        public void WhenIClickDeleteButton()
        {
            var id = 3;
            var url = "api/product/" + id;
            response = client.DeleteAsync(url).Result;
        }

        [Then(@"the returned status code is deleted")]
        public void ThenTheReturnedStatusCodeIsDeleted()
        {
            Assert.AreEqual(response.IsSuccessStatusCode, true);
        }
    }
}
