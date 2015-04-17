using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using REST_API.Models;

namespace REST_API.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Carrots", Quantity = 100}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public HttpResponseMessage GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(product);
        }
    }
}
