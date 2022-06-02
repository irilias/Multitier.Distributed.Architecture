using Internal.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private IService internalService;

        public HomeController(IService internalService)
        {
            this.internalService = internalService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CallInternalService()
        {
            //TODO Call internal service and get result back
            var result = internalService.ServiceMethod("Hello");
            ViewBag.Message = $"The call to the internal service has been successful. The value returned is {result.MyProperty}";

            return View();
        }

    }
}