using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Loop
    {
        static void Main()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                if(i == 7)
                {
                    break;
                }
                    
                if(i == 9)
                {
                    goto Point; // goto문은 사용하지 않는 것이 좋음 7번째 줄에서 break라 실행안됨
                }

                Console.WriteLine(i);
            }

            Point: // for문 끝나고 절차적 프로그래밍으로 인해 실행됨
            Console.WriteLine("Point");

            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"{i}단");
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            string difficultSubject = "c#";

            string[] subject1 = { "java", "c#", "python", "js" };

            foreach (string subject2 in subject1)
            {
                if (subject2.Contains(difficultSubject))
                {
                    Console.WriteLine($"{subject2} 은 어려운 과목입니다.");
                }
                Console.WriteLine(subject2);
            }

            while (true)
            {
                Console.WriteLine("계속할까요? (예/아니오)");
                string answer = Console.ReadLine();
                if (answer == "아니오")
                {
                    break;
                }
            }

            int x = 0;
            bool flag = true;
            do
            {
                x++;
                Console.WriteLine(x);
                if(x >= 10)
                {
                    flag = false;
                }
            }
            while (flag);
        }
    }
}
