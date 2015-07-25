using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EFController : Controller
    {
        private FabricsEntities db = new FabricsEntities();
        // GET: EF
        public ActionResult Index()
        {
            var data = db.Product.Where(p => p.ProductId > 1500);

            return View(data);
        }

        public int AddProduct()
        {
            var product = new Product
            {
                ProductName = "Jacket",
                Price = 999,
                Active = true,
                Stock = 10
            };
            db.Product.Add(product);

            db.SaveChanges();

            return product.ProductId;

            return 0;
        }

        public ActionResult BatchUpdateClient()
        {
            var data = db.Client.Take(5);

            foreach (var client in data )
            {
                client.City = "Taipei";
            }

            db.SaveChanges();

            return View(data);
        }

        public ActionResult RemoveClient()
        {
            var data = db.Client.Take(5);

            foreach (var client in data)
            {
                var order = db.Order.Where(p => p.ClientId == client.ClientId);
                foreach (var o in order)
                {
                    var orderline = db.OrderLine.Where(p => p.OrderId == o.OrderId);
                    db.OrderLine.RemoveRange(orderline);
                }

                db.Order.RemoveRange(order);
            }
            db.Client.RemoveRange(data);

            db.SaveChanges();

            return View(data);
        }

        public ActionResult SummaryPrice()
        {
            var data = db.vwSummaryPrice;

            return View(data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}