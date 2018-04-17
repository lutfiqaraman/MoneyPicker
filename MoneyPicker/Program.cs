using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount   = (decimal) Math.Round(235.00345, 4);
            string coins = (amount % Decimal.One).ToString().Substring(2);

            Console.WriteLine("Amount : {0}", amount);
            Console.WriteLine("Papers : {0}", (int) amount);
            Console.WriteLine("Coins  : {0}", coins);

            Console.ReadKey();
        }
    }
}