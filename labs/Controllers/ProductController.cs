using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using labs.Models;
using labs.ModelView;
using labs.Dal;
using System.Threading;

namespace labs.Controllers

{

    public class ProductController : Controller
    {

        public ActionResult ShowSearch()
        {
            ProductViewModel cvm = new ProductViewModel();
            cvm.Products = new List<Product>();
            return View("SearchPerfume", cvm);//pass model cvm to SearhProduct cshtml 
        }

        public ActionResult SearchPerfume()
        {
            DataLayers dal = new DataLayers();
            string searchValue = Request.Form["txtPerfumeName"].ToString();
            List<Product> objProducts = (from x in dal.Products
                                           where x.ProductName.Contains(searchValue)
                                           select x).ToList<Product>();
            ProductViewModel cvm = new ProductViewModel();
            cvm.Products = objProducts;

            return View(cvm);


        }


    }
}


