using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class KhachhangEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int KhachHangID { get; set; }
        [Required]
        public int CuaHangID { get; set; }
        public int ShipperID { get; set; }
        [Required]
        public DiaChiEntity DiaChiGiao { get; set; }
        public TrangThaiDonHangEntity TTDH { get; set; }
        [Required]
        public PhuongThucThanhToanEntity PTTT { get; set; }
        public List<SanPhamEntity> listSp { get; set; }
        public float TongTien { get; set; }
        [Required]
        public DateTime NgayMuaHang { get; set; }
        public DateTime NgayGiao { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
