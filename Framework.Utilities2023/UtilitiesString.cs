using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.UtilitiesString
{
    public static class UtilitiesString
    {

        public static bool Validate_Min_Max_Length_String(this string str, int min, int max)
        => str.Length >= min && str.Length <= max;

        public static bool Validate_Split_Count(this string str, int count, char[] chare)
        {
            string[] result = str.Split(chare);

            return result.Length == count;
        }

        
    }
}
