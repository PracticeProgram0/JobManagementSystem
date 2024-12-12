using JobPotal.DataBase_Work;
using JobPotal.LogicLayer;
using JobPotal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
bv5
namespace JobPotal.Controllers
{
    public class UserPenalController : Controller
    {
        // GET: UserPenal
        //Home
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        // GET: About
        public ActionResult About()
        {
            return View("~/Views/Home/About.cshtml");
        }
        // GET: Contactus
        public ActionResult Contactus()
        {
            return View();
        }
        [Route("FindJobs")]
        public ActionResult FindJobs()
        {
            var responce = new AddNewJobs();
            var result = responce.SelectJobs();
            return View(result);
        }
        [Route("JobDetails")]        
        public ActionResult JobDetails(string id)
        {
            ViewBag.LayOut = "UserPannal";
            var responce = new AddNewJobs();
            var result = responce.SelectJobByID(id);
            return View(result);
        }
        [Route("ApplyFilter")]
        [HttpPost]
        public ActionResult ApplyFilter(JobsFilter filter)
        {
             var filterData = new AddNewJobs().ApplyFilter(filter);
             return View("FindAJob", filterData);
            
        }


    }
}