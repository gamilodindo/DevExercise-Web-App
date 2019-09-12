using APOWeb.Data;
using APOWeb.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APOWeb.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAPORepository _APORepository;
        public HomeController(IAPORepository aPORepository)
        {
            _APORepository = aPORepository;
        }

        public ActionResult Index()
        {
        
            return View();
        }

        public PartialViewResult APOList()
        {
            var list = _APORepository.FindAll();
            return PartialView("_APOList", list);
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
    }
}