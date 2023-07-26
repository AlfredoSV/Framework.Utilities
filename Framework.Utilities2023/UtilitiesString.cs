using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        
    }
}
