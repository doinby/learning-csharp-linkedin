using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            // The Parse function attempts to parse a string into a number
            // but it might throw an exception, so we need to catch that
            int targetNum=0;
            try {
                // TODO: Use Parse to try a simple integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine($"parse int: {targetNum}");

                // TODO: Use Parse to try a floating point number
                // This only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"parse int from float: {targetNum}");

                // TODO: Use Parse to try a number with thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine($"parse int from comma thousand: {targetNum}");

                // TODO: Use Parse to try a number with thousands marker AND decimal
                targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine($"parse int from float w/ comma thousand: {targetNum}");

                // TODO: This works with other types too, like bool
                

                // TODO: Or floating point numbers

            }
            catch {
                Console.Write("Conversion failed");
            }

            // TODO: The TryParse function is similar but handles the exceptions for us
            bool succeeded = false;

            if (succeeded) {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
