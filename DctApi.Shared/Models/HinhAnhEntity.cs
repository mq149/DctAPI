using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class HinhAnhEntity
    {
        [Key]
        public int Id { get; set; }
        public string MoTa { get; set; }
        [NotMapped]
        public IFormFile Anh { get; set; }
        public string Url { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
