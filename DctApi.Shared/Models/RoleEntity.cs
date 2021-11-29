﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class RoleEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ten { get; set; }
    }
}