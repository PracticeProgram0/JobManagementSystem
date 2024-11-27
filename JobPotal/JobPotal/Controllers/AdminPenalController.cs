using JobPotal.DataBase_Work;
using JobPotal.LogicLayer;
using JobPotal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPotal.Controllers
{
    [Authorize]
    public class AdminPenalController : Controller
    {
        // GET: AdminPenal
        //Home
        public ActionResult Index()
        {
            return View();
        }
        //Contact Us
        public ActionResult Contactus()
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
            var result = responce.AddOrUpdateNewJob(data);
            return View();
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
        public ActionResult Delete(string id)
        {
            var response = new DBWork();
            var resultOfDelete = response.DeleteJob(id);
            if (resultOfDelete)
            {
                ViewBag.DeletionResult = 1;
                return View("ViewAllJob");
            }
            return RedirectToAction("ViewAllJob");
        }

        public ActionResult Edit(string id)
        {
            var editJob = new AddNewJobs();
            var dataForEdit = editJob.SelectJobByID(id);
            return View(dataForEdit);

        }

        [HttpPost]
        public ActionResult EditJob(ViewAllJobs data)
        {
            var logicLayer = new AddNewJobs();
            var result = logicLayer.EditJob(data);
            return RedirectToAction("ViewAllJob");
        }

        public ActionResult AdminProfile()
        {
            return View();
        }
    }
}