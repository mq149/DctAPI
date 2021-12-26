using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models {
   public  class LoginModel {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
