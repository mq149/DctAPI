using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class LuaChonTracNghiemEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Required]
        public bool Dung { get; set; }
        [Required]
        public CauHoiTracNghiemEntity CauHoi { get; set; }
    }
}
