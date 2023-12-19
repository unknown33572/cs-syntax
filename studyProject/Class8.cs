using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class8
    {
        static void Main()
        {
            /*
            int[,] intArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{intArray[i, j]}_");
                }
                Console.Write("ㅋ\n");
            }
            */

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"arr[{i},{j}] = {arr[i, j]}");
                }
            }
        }
    }
}
