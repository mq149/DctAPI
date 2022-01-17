using System;
using System.Collections.Generic;
using System.Text;

namespace DctApi.Shared.Common
{
    public static class Config
    {
        public struct Regex
        {
            public const string sdt = @"((09|03|07|08|05)+([0-9]{8})\b)";
            public const string email = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        }

        public struct ErrorMessage
        {
            public const string sdtRegex = "Số điện thoại không hợp lệ";
            public const string sdtRequired = "Yêu cầu cung cấp số điện thoại";
            public const string emailRegex = "Email không hợp lệ";
            public const string comfirmPassword = "Xác nhận mật khẩu không trùng khớp";
        }
        

    }
}
