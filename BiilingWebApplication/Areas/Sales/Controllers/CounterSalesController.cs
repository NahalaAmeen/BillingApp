using BiilingWebApplication.Areas.Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiilingWebApplication.Areas.Sales.Controllers
{
    public class CounterSalesController : Controller
    {
        // GET: Sales/CounterSales
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            CounterSalesModel model = new CounterSalesModel();
            return View(model);
        }
    }
}