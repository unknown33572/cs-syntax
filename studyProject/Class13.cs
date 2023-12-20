using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class13
    {
        static void Main()
        {
            int Add(int a, int b) => a + b;
            int Subtract(int a, int b) => a - b;
            int Multiply(int a, int b) => a * b;
            int Divide(int a, int b) => a / b;

            Console.WriteLine("+, -, *, / 중에 고르세요");
            string operation = Console.ReadLine();

            Console.WriteLine("첫 번째 숫자를 입력하세요:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력하세요:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine(Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(Subtract(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Multiply(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(Divide(num1, num2));
                    break;
                default:
                    Console.WriteLine("보기중에서만 입력해주세요.");
                    break;
            }

        }
    }
}
