using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangSanPhamEntity
    {
        [Key]
        public int ID { get; set; }
        public int CuaHangID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
    }
}
