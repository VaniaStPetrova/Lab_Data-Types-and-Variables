using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int cycle = 1; cycle <= n; cycle++)
            {
                int newCycle = cycle;
                while (newCycle != 0)
                {
                    sum = sum + newCycle % 10;
                    newCycle = newCycle / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} - > True", cycle);
                }
                else
                {
                    Console.WriteLine("{0} - > False", cycle);
                }
                sum = 0;
            }
        }
    }
}
