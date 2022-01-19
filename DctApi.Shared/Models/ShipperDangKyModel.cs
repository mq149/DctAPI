using DctApi.Shared.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DctApi.Shared.Models
{
    public class ShipperDangKyModel
    {
        [Required(ErrorMessage = Config.ErrorMessage.sdtRequired),
            RegularExpression(Config.Regex.sdt, ErrorMessage = Config.ErrorMessage.sdtRegex)]
        public string SDT { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required,
            RegularExpression(Config.Regex.email, ErrorMessage = Config.ErrorMessage.emailRegex)]
        public string Email { get; set; }
    }
}
