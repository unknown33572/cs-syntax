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
            Log("에러", 22);

            Minus(second: 5, first: 10); // 매개변수명 쓰면 순서 변경 가능
        }

        static void Log(string message, byte level = 0) // 매개변수 기본값
        {
            Console.WriteLine($"{message}, {level}");
        }

        static void Minus(int first, int second)
        {
            Console.WriteLine(first - second);
        }
    }
}
