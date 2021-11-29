using DctApi.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public RoleUser Role { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public HinhAnhEntity AvatarId { get; set; }
        public DiaChiEntity DiaChiId { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
