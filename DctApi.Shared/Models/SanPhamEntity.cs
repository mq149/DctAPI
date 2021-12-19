﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class SanPhamEntity
    {
        [Key]
        public int ID { get; set; }
        public string Ten { get; set; }
        public float GiaSP { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string MoTa { get; set; }
        public int HinhAnhID { get; set; }
        public HinhAnhEntity HinhSanPhamID { get; set; }
        public int LoaiSPID { get; set; }
        public LoaiSanPhamEntity LoaiSP { get; set; }
        public int NSXID { get; set; }
        public NhaSanXuatEntity NSX { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }

    }
}
