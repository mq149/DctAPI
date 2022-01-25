using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangEntity
    {

        public CuaHangEntity() {
            HinhChungMinhNhanDan = new HashSet<HinhAnhEntity>();
            CuaHangSanPham = new HashSet<CuaHangSanPhamEntity>();
        }
        [Key]
        public int Id { get; set; }
        public int? ChiTietCuaHangId { get; set; }
        public ChiTietCuaHang ChiTietCuaHang { get; set; }
        public Boolean TrangThaiKichHoat { get; set; }
        public string TenCuaHang { get; set; }

        public string SoDienThoaiLienHe { get; set; }

        public int? LoaiHinhDangKy { get; set; }

        public string TenNguoiDaiDien { get; set; }

        public string Email { get; set; }

        public string SoDienThoaiNguoiDaiDien { get; set; }

        public int? HinhChungMinhNhanDanMatTruocId { get; set; }
        public int? HinhChungMinhNhanDanMatSauId { get; set; }
        public virtual ICollection<HinhAnhEntity> HinhChungMinhNhanDan { get; set; }

        public string MaSoThue { get; set; }

        public int? DiaChiCuaHangId { get; set; }
        public DiaChiEntity DiaChiCuaHang { get; set; }

        [ForeignKey("LoaiCH")]
        public int? LoaiCHId { get; set; }
        public LoaiCuaHangEntity LoaiCH { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public virtual ICollection<CuaHangSanPhamEntity> CuaHangSanPham { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
