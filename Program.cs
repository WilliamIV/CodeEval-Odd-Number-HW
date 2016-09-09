using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Odd_numbers_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print out odd muns from 1 through 99 inclusive.
            //start at 1, make your condition lt or = 99, add 2 after each loop
            int counter;
            for (counter = 1; counter <= 99; counter += 2)
            {
                System.Console.WriteLine(counter);

            }
        }
    }
}
