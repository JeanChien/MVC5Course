using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;

namespace MVC5Course.Controllers
{
    public class EFController : Controller
    {
        //db 為 object services 
        FabricsEntities db = new FabricsEntities();

        // GET: EF
        public ActionResult Index()
        {
            //p 為 集合物件
            var data = db.Product.Where( p => p.ProductName.Contains("White"));

            return View(data);
        }

        public ActionResult Create()
        {
            var product = new Product() {
                ProductName = "White Cat",
                Price = 1000,
                Active = true,
                Stock = 5
            };

            db.Product.Add(product);

            db.SaveChanges();

            return RedirectToAction("index");
        }

        public ActionResult Delete(int ID)
        {
            var product = db.Product.Find(ID);
            db.Product.Remove(product);
            db.SaveChanges();

            return RedirectToAction("index");            
        }

        public ActionResult Details(int ID)
        {
            var product = db.Product.Find(ID);

            return View(product);

        }

        public ActionResult Update(int ID)
        {
            var product = db.Product.Find(ID);
            product.ProductName += "!";

            db.SaveChanges();

            return RedirectToAction("index");            
            
        }

        public ActionResult Add20Percent()
        {
            //p 為 集合物件
            var data = db.Product.Where(p => p.ProductName.Contains("White"));

            foreach (var item in data) { 
                
                if (item.Price.HasValue)
                {
                    item.Price = item.Price.Value * 1.2m;
                }
            
            }

            db.SaveChanges();

            return RedirectToAction("index");            

        }

    }
}