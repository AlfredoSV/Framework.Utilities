using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities.UtilitiesInt
{
    public static class UtilitiesInt
    {
        public static bool ValidateRange(this int number,int max, int min)
        {
            return number >= min && number <= max;
        }

        public static bool ValidateDiferentToZero(this int number)
        {
            return number != 0;
        }
    }
}
