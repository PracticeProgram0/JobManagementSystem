using JobPotal.LogicLayer;
using JobPotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JobPotel.Controllers
{
    [Authorize]
    public class AdminPenalController : Controller
    {
        // GET: AdminPenal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Postjobs()
        {
            return View();
        }
        [Route("PostNewJob")]
        [HttpPost]
        public ActionResult AddNewJob(PostJobsModel data)
        {
            AddNewJobs responce = new AddNewJobs();
            var result = responce.AddNewJob(data);
            return View("Index");
        }


        public ActionResult ViewAllJob()
        {
            var responce = new AddNewJobs();
            var result = responce.SelectJobs();
            return View(result);
        }

        public ActionResult JobDetails(string id)
        {
            var responce = new AddNewJobs();
            var result = responce.SelectJobByID(id);
            return View(result);
        }
    }
}