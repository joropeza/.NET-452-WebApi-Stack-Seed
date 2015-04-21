using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Layer.Services
{
    public class ProductsService : ICoreService
    {
        public IServiceResponseMessage List(ServiceResponseMessage<int> newRequest)
        {
            newRequest.RequestObject = 5;

            this.request = newRequest;

            return request;

        }

    }
}
