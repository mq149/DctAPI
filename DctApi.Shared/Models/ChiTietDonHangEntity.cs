using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class ChiTietDonHangEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int DonHangID { get; set; }
        public int SanPhamID { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public float KhoiLuong { get; set; }
    }
}
