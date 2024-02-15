using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Aggregate
    {
        static void Main()
        {
            int[] numbers = { 10, 2, 3, 4, 5, };

            int max = numbers.Aggregate((f, s) => f > s ? f : s);

            Console.WriteLine(max);

            int min = numbers.Aggregate((f, s) => f < s ? f : s);

            Console.WriteLine(min);
        }
    }
}
