using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Conditional
    {
        static void Main()
        {
            Console.WriteLine("영문 대문자 또는 소문자 하나를 입력하세요.");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z') // A 65 ~ Z 90 나머지는 전부 소문자
            {
                Console.WriteLine($"{ch}는 대문자입니다.");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"{ch}는 소문자입니다.");
            }
            else
            {
                Console.WriteLine("영문자가 아닙니다.");
            }

            Console.WriteLine("숫자 입력: ");
            string answer2 = Console.ReadLine();
            int answer3 = int.Parse(answer2);
            Console.WriteLine(answer3);
            string result = (answer3 % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);


            Console.WriteLine("1 or 2를 입력하세요.");
            int x = int.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine("굿");
                    break;
                case 2:
                    Console.WriteLine("낫굿");
                    break;
            }

            Console.WriteLine("Start");
            Start:
                Console.WriteLine("0,1,2 중 하나 입력 : _\b");
                int chapter = int.Parse(Console.ReadLine());

                if (chapter == 1)
                {
                    goto Chapter1;
                }
                else if (chapter == 2)
                {
                    goto Chapter2;
                }
                else
                {
                    goto End;
                }
            Chapter1:
                Console.WriteLine("1장");
                goto Start;
            Chapter2:
                Console.WriteLine("2장");
                goto Start;
            End:
                Console.WriteLine("종료");
        }
    }
}
