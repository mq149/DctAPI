using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class HinhAnhEntity
    {
        [Key]
        public string Id { get; set; }
        public string MoTa { get; set; }
        public string Url { get; set; }
    }
}
