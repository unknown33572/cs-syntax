using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Function
    {
        String name = "S";

        static void HelloWorld()
        {
            Console.WriteLine($"Hello World!!");
        }

        static void Log(string message, byte level = 0) // 매개변수 기본값
        {
            Console.WriteLine($"{message}, {level}");
        }

        //static void Main(string[] args)
        //{
        //    HelloWorld();
        //    Function function = new Function();
        //    int result = function.plus(2, 3);
        //    Console.WriteLine(result);

        //    Log("에러");
        //    Log("에러", 22);

        //    minus(second: 5, first: 10); // 매개변수명 쓰면 순서 변경 가능

        //    msgLog("람다식");

        //    Console.WriteLine(Factorial(5));

        //    Console.WriteLine(Factorial(5, 2));
        //}

        int plus(int x, int y) // static 없으면 객체 생성해서 사용해야함
        {
            return x + y;
        }

        static void minus(int first, int second) // 메서드는 위치 상관없이 사용 가능
        {
            Console.WriteLine(first - second);
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
            return result; // 복수의 수이면 재귀
        }

        static int Factorial(int num, int cnt) // 오버로딩
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * Factorial(num, --cnt); //후위로 두면 카운트를 나중에 해서 결과가 다르게 나옴
        }

        static void msgLog(string message) => Console.WriteLine(message); // 람다식

    }

    class VirtualFunction : Function
    {
        int plus(int x, int y) // 오버라이딩
        {
            int result = 0;
            result = x + y;
            return result;
        }

        int calculate(int x, int y, string operation) // 오버로딩
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = Add(x, y);
                    break;
                case "-":
                    result = Subtract(x, y);
                    break;
                case "*":
                    result = Multiply(x, y);
                    break;
                case "/":
                    result = Divide(x, y);
                    break;
                default:
                    Console.WriteLine("보기중에서만 입력해주세요.");
                    break;
            }
            return result;
        }

        int Add(int a, int b) => a + b;
        int Subtract(int a, int b) => a - b;
        int Multiply(int a, int b) => a * b;
        int Divide(int a, int b) => a / b;

        static void Main(string[] args)
        {
            VirtualFunction virtualFunction = new VirtualFunction();

            Console.WriteLine("계산기 프로그램입니다.");
            Console.WriteLine("+, -, *, / 중에 고르세요");
            string operation = Console.ReadLine();
            if(operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.WriteLine("다시 입력하세요.");
                operation = Console.ReadLine();
            }

            Console.WriteLine("첫 번째 숫자를 입력하세요:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("두 번째 숫자를 입력하세요:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = virtualFunction.calculate(num1, num2, operation);
            Console.WriteLine($"결과는 {result}입니다.");
        }

    }
}
