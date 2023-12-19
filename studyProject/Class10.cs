using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class10
    {
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!!");
        }

        static int sumCalc(int x, int y)
        {
            int z = 10;
            return x + y + z;
        }

        static void Main()
        {
            HelloWorld();
            int result = sumCalc(2, 3);
            Console.WriteLine(result);

            Log("에러");

        }

        static void Log(string message, byte level = 0)
        {
            Console.WriteLine($"{message}, {level}");
        }
    }
}
