using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products


       
        public ActionResult ProductList()
        {
             List<ElectronicProducts> plist = new List<ElectronicProducts>();
            plist.Add(new ElectronicProducts {Productid=1,ProductName="charger",Price=1000 });
            plist.Add(new ElectronicProducts { Productid = 2, ProductName = "power bank", Price = 4000 });
            plist.Add(new ElectronicProducts { Productid = 3, ProductName = "keyboard", Price = 2000 });
            plist.Add(new ElectronicProducts { Productid = 4, ProductName = "mouse", Price = 1000 });


            //ViewModel
            return View(plist);
        
        
        }
    }
}