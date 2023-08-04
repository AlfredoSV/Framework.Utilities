using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Framework.Utilities2023.UtilitiesString
{
    public static class UtilitiesString
    {

        public static bool ValidateMinMaxLengthString(this string str, int min, int max)
        => str.Length >= min && str.Length <= max;

        public static bool ValidateSplitCount(this string str, int count, char[] chare)
        {
            string[] result = str.Split(chare);

            return result.Length == count;
        }

        public static string ReverseString(this string str)
        {
            char[] convert = str.ToCharArray();

            Array.Reverse(convert);

            return new string(convert);
        }

        public static bool StringIsBase64(this string str)
        {
            str = str.Trim();
            return (str.Length % 4 == 0) && Regex.IsMatch(str, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        public static bool OnlyNumbers(this string str)
        {
            return Regex.IsMatch(str, @"^\d+$");
        }

    }
}
