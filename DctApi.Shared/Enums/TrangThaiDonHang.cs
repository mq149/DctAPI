using System;
using System.Collections.Generic;
using System.Text;

namespace DctApi.Shared.Enums
{
    public static class TrangThaiDonHang
    {
        public const string ChoXacNhan = "Chờ xác nhận";
        public const string CuaHangDaXacNhan = "Cửa hàng đã xác nhận";
        public const string DangLayHang = "Đang lấy hàng";
        public const string DangGiaoHang = "Đang giao hàng";
        public const string DaGiaoHang = "Đã giao hàng";
        public const string DaHuy = "Đã huỷ";

        public static Models.TrangThaiDonHangEntity[] ConvertToEntities()
        {
            Models.TrangThaiDonHangEntity[] ttdhEntities = {
                new Models.TrangThaiDonHangEntity { ID = 1, Ten = ChoXacNhan },
                new Models.TrangThaiDonHangEntity { ID = 2, Ten = CuaHangDaXacNhan },
                new Models.TrangThaiDonHangEntity { ID = 3, Ten = DangLayHang },
                new Models.TrangThaiDonHangEntity { ID = 4, Ten = DangGiaoHang },
                new Models.TrangThaiDonHangEntity { ID = 5, Ten = DaGiaoHang },
                new Models.TrangThaiDonHangEntity { ID = 6, Ten = DaHuy }
            };
            return ttdhEntities;
        }
    }
}
