using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicHealthcareSystemApp.Models
{
    public class GoogleAuthenticatorViewModel
    {
        public string SecretKey { get; set; }

        public string BarcodeUrl { get; set; }

        public string Code { get; set; }
    }
}