using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace JobPotal.Models
{
    public class ViewAllJobs
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string jobCategory { get; set; }
        public string Experience { get; set; }
        
        public string Education { get; set; }
        public string Skills { get; set; }
        public string SalaryRange { get; set; }
        public string JobDescription { get; set; }
        public string PostDate { get; set; }
        public string FinalDate { get; set; }
    }
}