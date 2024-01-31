using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class11
    {
        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32 : {number}");
        }

        static void GetNumber(string number) // overloading
        {
            Console.WriteLine($"Int64 : {number}");
        }

        static void Main()
        {
            GetNumber(1234);
            GetNumber("1234" + " 이건 string 타입 입니다.");
            GetNumber(5, 5);
            Factorial(10);
            Console.WriteLine(RecursionPower(2, 2));
        }

        static void GetNumber(int number, int number2)
        {
            Console.WriteLine(number + number2);
        }

        static int Factorial(int x)
        {
            int result = 0;
            if (x == 0 || x == 1)
            {
                result = 1;
                return result; // 0, 1이면 그냥 1로 리턴
            }
            result = x * Factorial(x - 1);
            Console.WriteLine(result);
            return result;// 복수의 수이면 재귀
        }

        static int RecursionPower(int num, int cnt)
        {
            if(cnt == 0)
            {
                return 1;
            }
            return num * RecursionPower(num, --cnt); //후위로 두면 카운트를 나중에 해서 결과가 다르게 나옴
        }
    }
}
