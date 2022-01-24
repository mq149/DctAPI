using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models
{
    public class ShipperHuyDonHangModel
    {
        [Required]
        public int DonHangId { get; set; }
        [Required]
        public int ShipperId { get; set; }
        [Required]
        public string LyDoHuy { get; set; }
    }
}
