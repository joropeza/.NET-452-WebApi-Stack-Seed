using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using REST_API.Models.Abstracts;

namespace REST_API.Models
{
    public class Product : Thing
    {
        public int Quantity { get; set; }
    }
}