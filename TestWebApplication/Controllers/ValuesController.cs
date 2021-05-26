using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TestWebApplication.Models;

namespace TestWebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IOfferService _offerService;
        public ValuesController(IOfferService offerService)
        {
            this._offerService = offerService;
        }
        // GET api/values
        [HttpGet]
     public  Task<List<Offer>> getOffers()
        {
           var response= _offerService.GetTodaysOffers();
            return Task.FromResult(response);
        }

        [HttpGet]
        public  Task<IEnumerable<Product>> getProducts()
        {
            var response = _offerService.GetAllProducts().Take<Product>(3);
            return Task.FromResult(response);
        }

        [HttpGet]
        [ActionName("getProductssecond")]
        public  Task<IEnumerable<Product>> getProductssecond()
        {
            var response = _offerService.GetAllProducts().Take<Product>(3);
            return Task.FromResult(response);
        }

        [HttpPost]
        public void AddProductssecond(Product p)
        {
            
        }

    }
}
