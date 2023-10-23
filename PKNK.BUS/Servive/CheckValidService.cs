using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public static class CheckValidService
    {
        // Kiểm tra email
        public static bool IsEmailValid(string emailAddress)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(emailAddress, pattern);
        }

        // Kiểm tra số điện thoại việt nam
        public static bool IsVietnamesePhoneNumber(string phoneNumber)
        {
            string pattern = @"^(03|05|07|09|08)[0-9]{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
