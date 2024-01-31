using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class12
    {
        static void Main()
        {
            Console.WriteLine(Calc(5, 5, "*"));
        }

        static void Log(string message) => Console.WriteLine(message);

        static int Calc(int x, int y, string z)
        {
            int result = 0;

            if(z == "+")
            {
                result = x + y;
            }
            else if(z == "-")
            {
                result = x - y;
            }
            else
            {
                Console.WriteLine("더하기 아니면 빼기만 가능합니다.");
            }
            return result;
        }
    }
}
