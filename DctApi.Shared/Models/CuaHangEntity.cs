using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangEntity
    {
        [Key]
        public int Id { get; set; }
        public Boolean TrangThaiKichHoat { get; set; }
        public string TenCuaHang { get; set; }
        [ForeignKey("LoaiCH")]
        public int? LoaiCHId { get; set; }
        public LoaiCuaHangEntity LoaiCH { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
