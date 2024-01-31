using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class6
    {
        static void Main()
        {
            /*
            int goal = 22;
            int sum = 0;

            int i = 1;
            while(i <= 10)
            {
                sum += i;

                if(sum >= goal)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine($"1부터 {i}까지의 합은 {sum}이고, 목표치 {goal} 이상을 달성했습니다.");
            */

            Console.WriteLine("Start");
            Start:
            Console.WriteLine("0,1,2 중 하나 입력 : _\b");
            int chapter = int.Parse(Console.ReadLine());

            if (chapter == 1)
            {
                goto Chapter1;
            }
            else if(chapter == 2)
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
