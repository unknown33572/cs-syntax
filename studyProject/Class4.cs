using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class4
    {
        static void Main()
        {
            /*
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
            }
            */

            int fact = 0;
            for(int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}! -> ");
                fact = 1;
                for(int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                Console.WriteLine($"{fact,2}");
            }
        }
    }
}
