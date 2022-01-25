using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class KhachHangEntity
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        public string CMND { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? AvatarId { get; set; }
        public HinhAnhEntity Avatar { get; set; }

        public string SDT { get; set; }
        public string HoTen { get; set; }

        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
