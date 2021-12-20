using System;
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
<<<<<<< HEAD
        public int CuaHangID { get; set; }
        public int? ShipperID { get; set; }
        public int DiaChiGiaoId { get; set; }
       
=======
        public int CuaHangId { get; set; }
        public CuaHangEntity CuaHang { get; set; }
        public int? ShipperId { get; set; }
        public ShipperEntity Shipper { get; set; }
        [Required]
        [ForeignKey("DiaChiGiao")]
        public int DiaChiGiaoId { get; set; }
>>>>>>> master
        public DiaChiEntity DiaChiGiao { get; set; }
        [Required]
        [ForeignKey("TTDH")]
        public int TTDHId { get; set; }
        public TrangThaiDonHangEntity TTDH { get; set; }
<<<<<<< HEAD
        public int PTTTId { get; set; }
      
=======
        [Required]
        [ForeignKey("PTTT")]
        public int PTTTId { get; set; }
>>>>>>> master
        public PhuongThucThanhToanEntity PTTT { get; set; }
        [Required]
        public float TongTien { get; set; }
        [Required]
        public DateTime NgayMuaHang { get; set; }
        public DateTime NgayGiao { get; set; }
        public List<ChiTietDonHangEntity> ChiTietDonHang { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
