using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much change with a max of 99");
            int change = Convert.ToInt32(Console.ReadLine());

            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            int penny = 1;

            int anQuarter = change / quarter;
            int anDime = ((change % quarter) / dime);
            int anNickel = ((( change % quarter) % dime) / nickel);
            int anPenny = ((((change % quarter) % dime) % nickel) / penny);

            if (anQuarter != 0) Console.WriteLine("The amount quarters are {0}", anQuarter);
            if (anDime != 0) Console.WriteLine("The amount dimes are {0}", anDime);
            if (anNickel != 0) Console.WriteLine("The amount nickels are {0}", anNickel);
            if (anPenny != 0) Console.WriteLine("The amount pennies are {0}", anPenny);
            Console.ReadLine();
        }
    }
}
