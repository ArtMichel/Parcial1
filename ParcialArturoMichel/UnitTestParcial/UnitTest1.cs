using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialArturoMichel.Controllers;
using ParcialArturoMichel.Models;

namespace UnitTestParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            //arrange
            CountriesController controller = new CountriesController();
            //act
            var result = controller.GetCountry("BOB") as OkNegotiatedContentResult<Country>;
            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual("BOB", result.Content.Name);
        }
    }
}
