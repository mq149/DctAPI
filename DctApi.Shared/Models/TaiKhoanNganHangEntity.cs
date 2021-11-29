using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class TaiKhoanNganHangEntity
    {
        [Key]
        public int Id { get; set; }
        public string TenChuTk { get; set; }
        public string SoTK { get; set; }
        public string TenNganHang { get; set; }
        public string MaNganHang { get; set; }
        public Boolean LienKet { get; set; }
        public UserEntity UserEntity { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
