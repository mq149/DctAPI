using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class ShipperEntity
    {
        [Key]
        public int UserId { get; set; }
        public Boolean KichHoat { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string BienSo { get; set; }
        public string DongXe { get; set; }
        public UserEntity UserEntity { get; set; }
    }
}
