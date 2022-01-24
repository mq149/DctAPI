using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models {
    public class ThoiGianMoCuaHang {
        [Key]
        public int Id { get; set; }
        public int? CuaHangId { get; set; }
        public Boolean ChuNhat { get; set; }
        public TimeSpan GioMoCuaCN { get; set; }
        public TimeSpan GioDongCuaCN { get; set; }
        public Boolean ThuHai { get; set; }
        public TimeSpan GioMoCuaT2 { get; set; }
        public TimeSpan GioDongCuaT2 { get; set; }
        public Boolean ThuBa { get; set; }
        public TimeSpan GioMoCuaT3 { get; set; }
        public TimeSpan GioDongCuaT3 { get; set; }
        public Boolean ThuTu { get; set; }
        public TimeSpan GioMoCuaT4 { get; set; }
        public TimeSpan GioDongCuaT4 { get; set; }
        public Boolean ThuNam { get; set; }
        public TimeSpan GioMoCuaT5 { get; set; }
        public TimeSpan GioDongCuaT5 { get; set; }
        public Boolean ThuSau { get; set; }
        public TimeSpan GioMoCuaT6 { get; set; }
        public TimeSpan GioDongCuaT6 { get; set; }
        public Boolean ThuBay { get; set; }
        public TimeSpan GioMoCuaT7 { get; set; }
        public TimeSpan GioDongCuaT7 { get; set; }
    }
}
