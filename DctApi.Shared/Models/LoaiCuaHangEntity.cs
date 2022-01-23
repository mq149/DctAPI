using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class LoaiCuaHangEntity
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }

        public string DienGiai { get; set; }
        public int? HinhAnhId { get; set; }
        public HinhAnhEntity HinhAnh { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
