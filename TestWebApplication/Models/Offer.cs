using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer(string OfferName,List<Product> products)
        {
            this.OfferName = OfferName;
            this.Products = products;
        }
    }
}