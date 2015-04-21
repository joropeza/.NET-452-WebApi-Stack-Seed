using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Services_Layer.Data;

namespace Services_Layer.Services
{
    public class ProductsService : ICoreService
    {
        public IServiceResponseMessage List(ServiceResponseMessage<List<Product>> newRequest)
        {
           
            LocalDatabaseEntities ldb = new LocalDatabaseEntities();
            newRequest.RequestObject = ldb.Products.ToList();

            this.request = newRequest;
            return request;

        }


    }
}
