using System;
using System.Collections.Generic;
using System.Text;

namespace DctApi.Shared.Common
{
    public static class Config
    {
        public struct Regex
        {
            public const string sdt = @"/((09|03|07|08|05)+([0-9]{8})\b)/g";
            public const string email = "/^(([^<>()[\\]\\.,;:\\s@\"]+(\\.[^<>()[\\]\\.,;:\\s@\"]+)*)|(\".+\"))@(([^<>()[\\]\\.,;:\\s@\"]+\\.)+[^<>()[\\]\\.,;:\\s@\"]{2,})$/i";
        }

        public struct ErrorMessage
        {
            public const string sdtRegex = "So dien thoai khong hop le";
            public const string sdtRequired = "Yeu cau so dien thoai";
            public const string emailRegex = "So dien thoai khong hop le";
        }
        

    }
}
