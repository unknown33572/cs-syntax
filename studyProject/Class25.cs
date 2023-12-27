using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class25
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            List<int> newNumbers = numbers.Where(n => n > 3).ToList();
            for(int i = 0; i < newNumbers.Count; i++)
            {
                Console.WriteLine(newNumbers[i]);
            }
        }
    }
}
