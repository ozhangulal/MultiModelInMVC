using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiModelInMVC.Models;

namespace MultiModelInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NorthwindEntities _db = new NorthwindEntities();
            ViewModel viewModel = new ViewModel();
            viewModel.Categories = _db.Categories.ToList();
            viewModel.Suppliers = _db.Suppliers.ToList();

            return View(viewModel);
        }
    }
}