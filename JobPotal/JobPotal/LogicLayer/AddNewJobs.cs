using JobPotal.DataBase_Work;
using JobPotal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JobPotal.LogicLayer
{
    public class AddNewJobs
    {
        public bool AddOrUpdateNewJob(PostJobsModel data)
        {
            var educationDetails = string.Empty;
            var skillDetails = string.Empty;
            var currentDate = DateTime.Now.ToString();
            var finaldate = data.FinalDate.ToString();

            var listOfEducationDetails = new List<string>
            {
                data.EducationBTech,data.EducationMCA,data.EducationBCA,data.EducationBSc,data.EducationOther
            };

            var listOfSkillDetails = new List<string>
            {
                data.SkillJava , data.JavaSpring , data.JavaHibernate,data.SkillCSharp,data.CSharpDotNet,data.ASPDotNet,data.ASPDotNetmvc,data.SkillPython,data.PythonDjango,data.PythonFlask,data.SkillJavaScript,data.JavaScriptReact,data.javaScriptAngular
            };

            foreach (var item in listOfEducationDetails)
            {
                if (!string.IsNullOrEmpty(item))
                    educationDetails += item + " ,";
            }


            foreach (var item in listOfSkillDetails)
            {
                if (!string.IsNullOrEmpty(item)) skillDetails += item + " ,";
            }

            var query = $"insert into jobs values('{data.JobTitle}','{data.CompanyName}','{data.Location}','{data.JobType}','{data.jobCategory}','{data.Experience}','{educationDetails}','{skillDetails}','{data.SalaryRange}','{data.JobDescription}','{currentDate}','{finaldate}')";

            var queryExection = new DBWork();
            return queryExection.AddOrUpdateNewJob(query);



        }

        public List<ViewAllJobs> SelectJobs()
        {
            var queryExection = new DBWork();
            return queryExection.SelectJobs("select  JobId, JobTitle,CompanyName,Location,JobType,SalaryRange,JobDescription,PostDate,FinalDate from Jobs");
        }

        public ViewAllJobs SelectJobByID(string jobID)
        {
            var queryExection = new DBWork();
           return queryExection.SelectJobByID($"select * from Jobs where JobId ={jobID}");
        }
        public bool EditJob(ViewAllJobs data)
        {
            var query = $"update jobs set JobTitle= '{data.JobTitle}' , CompanyName = '{data.CompanyName}' , Location = '{data.Location}' , JobType = '{data.JobType}',Education = '{data.Education}', skills = '{data.Skills}' , SalaryRange = '{data.SalaryRange}',JobDescription = '{data.JobDescription}' , PostDate = '{data.PostDate}' , FinalDate = '{data.FinalDate}' where jobid = {data.JobId}";
            return new DBWork().AddOrUpdateNewJob(query);
        }
        public List<ViewAllJobs> ApplyFilter(JobsFilter filter)
        {
            var jobLocation = filter.JobLocation;
            var jobCategory = filter.SelectCategory;
            var jobtype = string.Empty;
            var jobexperience = string.Empty;

            var jobType = new List<string>()
            {
               filter.Fresher, filter.PartTime,filter.FullTime,filter.Remote,filter.Freelance
            };

            var jobExperience = new List<string>()
            {
                filter.OneToTwoYear,filter.TwoToThreeYear,filter.ThreeToSixYear,filter.MoreThenSixYear
            };

            foreach (var item in jobType)
            {
                if (!string.IsNullOrEmpty(item))
                    jobtype += item + ",";
            }

            foreach (var item in jobExperience)
            {
                if (!string.IsNullOrEmpty(item))
                    jobexperience += item + ",";
            }


            var query = $"select * from jobs where jobCategory = '{jobCategory}' and jobLocation = '{jobLocation}' and jobType = '{jobtype}' and experience = '{jobexperience}'";

            return new DBWork().SelectJobs(query);

        }

    }
}