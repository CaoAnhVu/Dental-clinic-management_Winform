using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PKNK.BUS.Servive
{
    public class CheckValidService
    {
        public static bool IsEmailValid(string emailAddress)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(emailAddress, pattern);
        }

        public static bool IsVietnamesePhoneNumber(string phoneNumber)
        {
            string pattern = @"^(03|05|07|09)[0-9]{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
