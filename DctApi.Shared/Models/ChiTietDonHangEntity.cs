using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class ChiTietDonHangEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("DonHang")]
        public int DonHangId { get; set; }
        public DonHangEntity DonHang { get; set; }
        [Required]
        public int SanPhamId { get; set; }
        public SanPhamEntity SanPham { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public float KhoiLuong { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
