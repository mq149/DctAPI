using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class CauHoiTracNghiemEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
        public virtual ICollection<LuaChonTracNghiemEntity> DanhSachLuaChon { get; set; }
    }
}
