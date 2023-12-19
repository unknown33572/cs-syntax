using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class7
    {
        static void Main()
        {
            int[] subject = new int[3];
            int sum = 0;
            float avg = 0;

            Console.WriteLine("과목 점수를 차례대로 입력하시오. 국어 -> 수학 -> 영어");
            subject[0] = int.Parse(Console.ReadLine());
            subject[1] = int.Parse(Console.ReadLine()); ;
            subject[2] = int.Parse(Console.ReadLine()); ;

            sum = subject[0] + subject[1] + subject[2];
            avg = sum / (float)subject.Length;

            Console.WriteLine($"총점 : {sum}, 평균 : {avg:.0}");
        }
    }
}
