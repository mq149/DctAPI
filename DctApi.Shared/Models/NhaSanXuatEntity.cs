using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class NhaSanXuatEntity
    {
        [Key]
        public int ID { get; set; }
        public string Ten { get; set; }

        public DiaChiEntity DiaChi { get; set; }
    }
}
