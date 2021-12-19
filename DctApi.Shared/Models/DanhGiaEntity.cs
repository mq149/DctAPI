using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class DanhGiaEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DonHangEntity DonHang { get; set; }
        [Required]
        public LoaiDanhGiaEntity LoaiDG { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public int SoDiem { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
