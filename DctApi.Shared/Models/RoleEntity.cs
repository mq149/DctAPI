using DctApi.Shared.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models {
    public class RoleEntity : IdentityRole<int> {

        [Required]
        public  string Ten { get; set; }
    }
}
