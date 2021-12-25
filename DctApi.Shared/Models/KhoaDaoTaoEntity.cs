using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class KhoaDaoTaoEntity
    {
        [Key]
        public int Id { get; set; }
        public string NoiDung { get; set; }
        public string HuongDan { get; set; }
        public string URL { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
