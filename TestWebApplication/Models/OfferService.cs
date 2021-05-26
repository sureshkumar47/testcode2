using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class OfferService : IOfferService
    {
        private List<Product> Inventory;

        private void AddProducts()
        {
            
            Product p = new Product("p1", 1000, "P1 desc");
            Product p1 = new Product("p2", 200, "P2 desc");
            Product p2= new Product("p3", 400, "P3 desc");
            Product p3 = new Product("p4", 700, "P4 desc");
            Product p4 = new Product("p5", 600, "P5 desc");
            Product p5 = new Product("p6", 800, "P6 desc");
            Inventory.Add(p);
            Inventory.Add(p1);
            Inventory.Add(p2);
            Inventory.Add(p3);
            Inventory.Add(p4);
            Inventory.Add(p5);


        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> offers = new List<Offer>();
            Offer offer = new Offer("ComboPackage1", createProduct());
            Offer offer1 = new Offer("ComboPackage2", createProduct());
            Offer offer2 = new Offer("ComboPackage3", createProduct());
            Offer offer3 = new Offer("ComboPackage4", createProduct());
            offers.Add(offer);
            offers.Add(offer1);
            offers.Add(offer2);
            offers.Add(offer3);
            return offers;
        }

        public List<Product> createProduct()
        { 

            
            List<Product> p = new List<Product>();
            Product p1 = new Product("p7",4000 , "P1 desc");
            Product p2 = new Product("p8", 2000, "P1 desc");
            Product p3 = new Product("p9", 3000, "P1 desc");
            p.Add(p1);
            p.Add(p2);
            p.Add(p3);
            return p;
        }

       
    }
}