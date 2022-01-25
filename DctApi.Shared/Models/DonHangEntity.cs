using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class DonHangEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int KhachHangId { get; set; }
        public KhachHangEntity KhachHang { get; set; }
        [Required]
        public int CuaHangId { get; set; }
        public CuaHangEntity CuaHang { get; set; }
        public int? ShipperId { get; set; }
        public ShipperEntity Shipper { get; set; }
        [Required]
        [ForeignKey("DiaChiGiao")]
        public int DiaChiGiaoId { get; set; }
        public DiaChiEntity DiaChiGiao { get; set; }
        [Required]
        [ForeignKey("TTDH")]
        public int TTDHId { get; set; }
        public TrangThaiDonHangEntity TTDH { get; set; }
        public string SDT { get; set; }
        public string NguoiNhan { get; set; }
        public string LyDoHuy { get; set; }
        [Required]
        [ForeignKey("PTTT")]
        public int PTTTId { get; set; }
        public PhuongThucThanhToanEntity PTTT { get; set; }
        [Required]
        public float TongTien { get; set; }
        [Required]
        public DateTime NgayMuaHang { get; set; }
        public DateTime NgayGiao { get; set; }
        public virtual List<SanPhamEntity> ListSanPham { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
