using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPotal.Models
{
    public class UserRegister
    {
     
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }
        public string Natonality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string LinkedinLink { get; set; }
        public string GitHubLink { get; set; }
        public HttpFileCollectionBase ImageName { get; set; }

    }
}