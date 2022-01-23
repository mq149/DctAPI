using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models {
    public class ChiTietCuaHang {

        [Key]
        public int Id { get; set; }
        public int CuaHangId { get; set; }
        public ChiTietCuaHang() {
            AnhQuan = new HashSet<HinhAnhEntity>();
        }

        public int ThoiGianId { get; set; }
        public ThoiGianMoCuaHang ThoiGian { get; set; }
         public string TuKhoaTimKiem { get; set; }
        public string MieuTaQuan { get; set; }
        public int AnhDaiDienId { get; set; }
        public int AnhBiaId { get; set; }
        public virtual ICollection<HinhAnhEntity> AnhQuan { get; set; }
    }
}
