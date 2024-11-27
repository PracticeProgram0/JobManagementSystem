using JobPotal.DataBase_Work;
using JobPotel.Models;
using System;
using System.Collections.Generic;



namespace JobPotal.LogicLayer
{
    public class AddNewJobs
    {
        public bool AddNewJob(PostJobsModel data)
        {
            var educationDetails = string.Empty;
            var skillDetails = string.Empty;
            var currentDate = DateTime.Now.ToString();
            var listOfEducationDetails = new List<string>
            {
                data.EducationBTech,data.EducationMCA,data.EducationBCA,data.EducationBSc,data.EducationOther
            };

            var listOfSkillDetails = new List<string>
            {
                data.SkillJava , data.JavaSpring , data.JavaHibernate,data.SkillCSharp,data.CSharpDotNet,data.SkillPython,data.PythonDjango,data.PythonFlask,data.SkillJavaScript,data.JavaScriptReact,data.javaScriptAngular
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

            var query = $"insert into jobs values('{data.JobTitle}','{data.CompanyName}','{data.Location}','{data.JobType}','{educationDetails}','{skillDetails}','{data.SalaryRange}','{data.JobDescription}','{currentDate}','29-11-2024')";

            var queryExection = new DBWork();
            return queryExection.AddNewJob(query);



        }

        public List<ViewAllJobs> SelectJobs()
        {
            var queryExection = new DBWork();
            return queryExection.SelectJobs("select  JobId, JobTitle,JobDescription,PostDate,FinalDate from Jobs");
        }

        public ViewAllJobs SelectJobByID(string jobID)
        {
            var queryExection = new DBWork();
            return queryExection.SelectJobByID($"select * from Jobs where JobId ={jobID}");
        }
    }
}