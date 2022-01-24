using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangSanPhamEntity
    {
        public int CuaHangId { get; set; }
        public int SanPhamId { get; set; }
        public int? SoLuong { get; set; }

        public virtual CuaHangEntity CuaHang { get; set; }
        public virtual SanPhamEntity SanPham { get; set; }

        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
