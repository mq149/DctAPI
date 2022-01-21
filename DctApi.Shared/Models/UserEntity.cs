using DctApi.Shared.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class UserEntity : IdentityUser<int>
    {
        [Key]
        public override int Id { get; set; }

        [Required(ErrorMessage = Config.ErrorMessage.sdtRequired),
            RegularExpression(Config.Regex.sdt, ErrorMessage = Config.ErrorMessage.sdtRegex)]
        public string SDT { get; set; }

        public override string Email { get; set ; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public HinhAnhEntity AvatarId { get; set; }

        //[ForeignKey("DiaChi")]

        //[ForeignKey("DiaChi")]

        public int? DiaChiId { get; set; }
        public DiaChiEntity DiaChi { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
