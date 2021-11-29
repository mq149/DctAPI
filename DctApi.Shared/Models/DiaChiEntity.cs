using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class DiaChiEntity
    {
        [Key]
        public int Id { get; set; }
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
