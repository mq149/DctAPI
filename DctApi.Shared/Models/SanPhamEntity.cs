using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class SanPhamEntity
    {

        public SanPhamEntity() {
            CuaHangSanPham = new HashSet<CuaHangSanPhamEntity>();
        }
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        public float GiaSP { get; set; }
        public DateTime? NgaySanXuat { get; set; }
        public string MoTa { get; set; }

        public int HinhSanPhamId { get; set; }
        public HinhAnhEntity HinhSanPham { get; set; }
        public int LoaiSPId { get; set; }
        public LoaiSanPhamEntity LoaiSP { get; set; }
        public int NSXId { get; set; }

        public NhaSanXuatEntity NSX { get; set; }

        public virtual ICollection<CuaHangSanPhamEntity> CuaHangSanPham { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
        public virtual int SoLuong { get; set; }

    }
}
