using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class HoSoShipperEntity
    {
        [Key]
        public int Id { get; set; }
        public string NgheNghiep { get; set; }
        [Required]
        public HinhAnhEntity CMNDMatTruoc { get; set; }
        [Required]
        public HinhAnhEntity CMNDMatSau { get; set; }
        [Required]
        public DateTime CMNDNgayCap { get; set; }
        [Required]
        public string CMNDNoiCap { get; set; }
        [Required]
        public string BLXSo { get; set; }
        [Required]
        public string BLXHang { get; set; }
        [Required]
        public HinhAnhEntity BLXMatTruoc { get; set; }
        [Required]
        public HinhAnhEntity BLXMatSau { get; set; }
        [Required]
        public HinhAnhEntity PhuongTienHinhDau { get; set; }
        [Required]
        public HinhAnhEntity PhuongTienHinhDuoi { get; set; }
        [Required]
        public HinhAnhEntity GiayKiemTraXe { get; set; }
        [Required]
        public HinhAnhEntity GiayDKXMatTruoc { get; set; }
        [Required]
        public HinhAnhEntity GiayDKXMatSau { get; set; }
        [Required]
        public int NamSXXe { get; set; }
        [Required]
        public HinhAnhEntity BHXMatTruoc { get; set; }
        [Required]
        public HinhAnhEntity BHXMatSau { get; set; }
        public decimal? DiemBaiKiemTra { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
