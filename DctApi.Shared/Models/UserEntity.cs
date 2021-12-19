using DctApi.Shared.Common;
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
        public int RoleId { get; set; }
        public RoleEntity Role { get; set; }
        [Required(ErrorMessage = Config.ErrorMessage.sdtRequired),
            RegularExpression(Config.Regex.sdt, ErrorMessage = Config.ErrorMessage.sdtRegex)]
        public string SDT { get; set; }
        [RegularExpression(Config.Regex.email,
            ErrorMessage = Config.ErrorMessage.emailRegex)]
        public string Email { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public HinhAnhEntity Avatar { get; set; }
        public DiaChiEntity DiaChi { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
