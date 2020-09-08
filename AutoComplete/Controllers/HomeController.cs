using AutoComplete.DAL;
using AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSearchValues(string search)
        {
            MohamedExperimentEntities db = new MohamedExperimentEntities();
            List<PeopleModel> allsearch = db.PeopleResponses.Where(x => x.Firstname.StartsWith(search)).Select(
                x => new PeopleModel { Firstname = x.Firstname, Id = x.Id }).ToList();

            return new JsonResult { Data = allsearch, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
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