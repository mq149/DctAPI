using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DctApi.Shared.Models
{
    public class DiaChiDatHangModel
    {
        public int Id { get; set; }
        public string SDT { get; set; }
        public string NguoiNhan { get; set; }

        public string SoNhaTo { get; set; }
        public string Duong { get; set; }
        public string XaPhuong { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhTP { get; set; }
        [Timestamp]
        public byte[] CreatedAt { get; set; }
        [Timestamp]
        public byte[] UpdatedAt { get; set; }
    }
}
