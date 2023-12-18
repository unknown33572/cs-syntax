using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int a = 5;
            int b = 5;
            a = 10;
            int sum = a + b;
            Console.WriteLine(sum);
            
            int x, y, z;
            x = 2;
            y = 2;
            z = 2;
            int mul = x * y * z;
            Console.WriteLine(mul);
            Console.WriteLine("{0},{1},{2}", x, y, z);

            Console.WriteLine("암호는?");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);

            Console.WriteLine(sum + 5);

            int bit = 2;

            Console.WriteLine(bit << 2); // 이진수로 변환 2^3 자리로 가서 8 나옴

            Console.WriteLine("숫자 입력: ");
            string answer2 = Console.ReadLine();
            int answer3 = int.Parse(answer2);
            Console.WriteLine(answer3);
            string result = (answer3 % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
