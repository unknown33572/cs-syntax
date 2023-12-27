using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace studyProject
{
    class Class24
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 10);
            Console.WriteLine(numbers);

            foreach (var n in numbers)
                Console.WriteLine("{0}\t", n);
        }
    }
}
