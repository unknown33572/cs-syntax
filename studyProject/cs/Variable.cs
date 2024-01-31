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

            string msg = string.Format("{0}님, {1}", "S", "안녕하세요");
            Console.WriteLine(msg);

            string name = "S";
            string greeting = $"Hello {name}";
            Console.WriteLine(greeting);

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

            int bit = 2;

            Console.WriteLine(bit << 2); // 이진수로 변환 2^3 자리로 가서 8 나옴

            int q, w, e, r, f;

            q = 2;
            w = 3;
            e = 4;
            r = q + w * e; // 우선순위 연산자 때문에 값이 다름
            f = (q + w) * e;

            Console.WriteLine(r);
            Console.WriteLine(f);

            string subject = "c#";

            if (subject == "c#")
            {
                Console.WriteLine($"{subject}" + "입니다.");
                subject = "java";
                if (subject == "java")
                {
                    Console.WriteLine($"{subject}" + "입니다.");
                }
            }

            Console.WriteLine("암호는?");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            
        }
    }
}
