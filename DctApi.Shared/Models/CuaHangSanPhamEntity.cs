using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangSanPhamEntity
    {
        [Key]
        public int Id { get; set; }
        public int CuaHangId { get; set; }
        public int SanPhamId { get; set; }
        public int SoLuong { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
