using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Models.Users
{
    public class AuthenticateModel
    {
        [Required]
        public string SDT { get; set; }
        [Required]
        public string MatKhau { get; set; }
    }
}
