using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class2
    {
        static void Main(string[] args)
        {
            int a, b, c ,d, e;
        
            a = 2;
            b = 3;
            c = 4;
            d = a + b * c; // 우선순위 연산자 때문에 값이 다름
            e = (a + b) * c;

            Console.WriteLine(d);
            Console.WriteLine(e);

            string subject = "c#";

            if(subject == "c#")
            {
                Console.WriteLine($"{subject}" + "입니다.");
                subject = "java";
                if(subject == "java")
                {
                    Console.WriteLine($"{subject}" + "입니다.");
                }
            }

            Console.WriteLine("영문 대문자 또는 소문자 하나를 입력하세요.");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch >= 'A' && ch <= 'Z') // A 65 ~ Z 90 나머지는 전부 소문자
            {
                Console.WriteLine($"{ch}는 대문자입니다.");
            }
            else
            {
                Console.WriteLine($"{ch}는 소문자입니다.");
            }

            Console.Write("문자를 입력하세요. (y/n/c) : ");
            char input = Convert.ToChar(Console.ReadLine());
            if(input == 'y')
            {
                Console.WriteLine("Yes");
            }
            else if(input == 'n')
            {
                Console.WriteLine("No");
            }
            else if(input == 'c')
            {
                Console.WriteLine("Cancel");
            }
            else
            {
                Console.WriteLine("옵션이 아닙니다.");
            }
        }
    }
}
