using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;


using REST_API.Controllers;
using REST_API.Models;

namespace REST_API.Tests
{
    [TestClass]
    public class Test_ProductsController
    {
        [TestMethod]
        public void ProductsControllerMethod1()
        {
            //Arrange
            var controller = new ProductsController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            
            //Act
            var response = controller.GetProduct(1);

            //Assert
            Product product;

            Assert.IsTrue(response.TryGetContentValue<Product>(out product));
            Assert.AreEqual(1, product.Id);
        }
    }
}
