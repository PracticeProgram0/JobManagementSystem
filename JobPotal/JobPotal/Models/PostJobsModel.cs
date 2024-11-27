using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPotal.Models
{
    public class PostJobsModel
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string EducationBTech { get; set; }

        public string EducationMCA { get; set; }
        public string EducationBCA { get; set; }
        public string EducationBSc { get; set; }
        public string EducationOther { get; set; }
        public string SkillJava { get; set; }
        public string JavaSpring { get; set; }
        public string JavaHibernate { get; set; }
        public string SkillCSharp { get; set; }
        public string CSharpDotNet { get; set; }
        public string ASPDotNet { get; set; }
        public string ASPDotNetmvc { get; set; }
        public string SkillPython { get; set; }
        public string PythonDjango { get; set; }
        public string PythonFlask { get; set; }
        public string SkillJavaScript { get; set; }
        public string JavaScriptReact { get; set; }
        public string javaScriptAngular { get; set; }
        public string SalaryRange { get; set; }

        public string JobDescription { get; set; }
        public string PostDate { get; set; }
        public string FinalDate { get; set; }
        public string Experience { get; set; }
        public string jobCategory { get; set; }
        public string ApplyLink { get; set; }

    }
}