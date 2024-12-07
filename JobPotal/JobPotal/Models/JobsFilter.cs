using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPotal.Models
{
    public class JobsFilter
    {

        public string SelectCategory { get; set; }      
        public string FullTime { get; set; }
        public string PartTime { get; set; }
        public string Remote { get; set; }
        public string Freelance { get; set; }
        public string JobLocation { get; set; }
        public string Fresher { get; set; }
        public string OneToTwoYear { get; set; }
        public string TwoToThreeYear { get; set; }
        public string ThreeToSixYear { get; set; }
        public string MoreThenSixYear { get; set; }

        public string Any { get; set; }
        public string Today { get; set; }
        public string LastTwoday { get; set; }
        public string Lastthreeday { get; set; }
        public string Lastfourday { get; set; }
        public string Lastfiveday { get; set; }
        public string Lasttenday { get; set; }


    }
}