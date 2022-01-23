using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class HoSoShipperEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Shipper")]
        public int ShipperId { get; set; }
        public ShipperEntity Shipper { get; set; }
        public string NgheNghiep { get; set; }
        public HinhAnhEntity CMNDMatTruoc { get; set; }
        public HinhAnhEntity CMNDMatSau { get; set; }
        public DateTime? CMNDNgayCap { get; set; }
        public string CMNDNoiCap { get; set; }
        public string BLXSo { get; set; }
        public string BLXHang { get; set; }
        public HinhAnhEntity BLXMatTruoc { get; set; }
        public HinhAnhEntity BLXMatSau { get; set; }
        public HinhAnhEntity PhuongTienHinhDau { get; set; }
        public HinhAnhEntity PhuongTienHinhDuoi { get; set; }
        public HinhAnhEntity GiayKiemTraXe { get; set; }
        public HinhAnhEntity GiayDKXMatTruoc { get; set; }
        public HinhAnhEntity GiayDKXMatSau { get; set; }
        public int? NamSXXe { get; set; }
        public HinhAnhEntity BHXMatTruoc { get; set; }
        public HinhAnhEntity BHXMatSau { get; set; }
        public bool? HoanThanh { get; set; }
        public bool? DaDuyet { get; set; }
        public decimal? DiemBaiKiemTra { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
