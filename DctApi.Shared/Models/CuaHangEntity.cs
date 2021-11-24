using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CuaHangEntity
    {
        [Key]
        public int UserID { get; set; }
        public Boolean TrangThaiKichHoat { get; set; }
        public string TenCuaHang { get; set; }
        public LoaiCuaHangEntity LoaiCH { get; set; }
        public UserEntity UserEntity { get; set; }
    }
}
