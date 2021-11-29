using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class KhachHangEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CMND { get; set; }

        public UserEntity UserEntity { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
