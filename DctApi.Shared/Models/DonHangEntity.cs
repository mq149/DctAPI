using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class DonHangEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int KhachHangID { get; set; }
        [Required]
        public int CuaHangID { get; set; }
        public int? ShipperID { get; set; }
        public int DiaChiGiaoId { get; set; }
       
        public DiaChiEntity DiaChiGiao { get; set; }
        public int TTDHId { get; set; }
        public TrangThaiDonHangEntity TTDH { get; set; }
        public int PTTTId { get; set; }
      
        public PhuongThucThanhToanEntity PTTT { get; set; }
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
