using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGen
    {
        private static readonly RNGCryptoServiceProvider _generate = new RNGCryptoServiceProvider();

        public static int RandomNumber(int minValue, int maxValue)
        {
            byte[] randomNum = new byte[1];

            _generate.GetBytes(randomNum);

            double valueOfRanCharacter = Convert.ToDouble(randomNum[0]);

            // Using Math.Max to return the larger of two double precision floating point numbers
            double multi = Math.Max(0, (valueOfRanCharacter / 255d) - 0.00000000001d);

            // Adding one to the range so Math.Floor can work
            int range = maxValue - minValue + 1;

            double ranValueRange = Math.Floor(multi * range);

            return (int)(minValue + ranValueRange);
        }
    }
}
