using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DctApi.Shared.Models {
    public class HopDongEntity {
        [Key]
        public int Id { get; set; }

        public string Url { get; set; }
    }
}
