using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApplication.Models;

namespace TestWebApplication
{
   public interface IOfferService
    {
       
        List<Product> GetAllProducts();
        List<Offer> GetTodaysOffers();
    }
}
