using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class LoopUsed
    {
        private static void sample(int a)
        {
            do
            {
                Console.WriteLine(a--);
            }
            while (a >= 0);
        }

        private static void Main()
        {
            sample(10);
            sample(-1);
        }
    }
}
