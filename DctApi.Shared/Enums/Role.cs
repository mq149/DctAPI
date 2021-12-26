using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DctApi.Shared.Enums {
    public enum Role {
        Admin = 1,
        CuaHang = 2,
        Shipper = 3,
        KhachHang = 4,
    }

    public class RoleName {
        public const string Admin = "Admin";
        public const string Store = "Store";
        public const string Shipper= "Shipper";
        public const string Customer = "Customer";
    }
}
