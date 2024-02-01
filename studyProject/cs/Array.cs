using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Array
    {
        static void Main()
        {
            int[] subject = new int[3];
            //int[] subject2 = { 1, 2, 3 };
            //int[] subject3 = new int[] { 1, 2, 3 };
            //var subject4 = new[] { 1, 2, 3 };
            int sum = 0;
            float avg = 0;

            Console.WriteLine("과목 점수를 차례대로 입력하시오. 국어 -> 수학 -> 영어");
            subject[0] = int.Parse(Console.ReadLine());
            subject[1] = int.Parse(Console.ReadLine());
            subject[2] = int.Parse(Console.ReadLine());

            sum = subject[0] + subject[1] + subject[2];
            avg = sum / (float)subject.Length;

            Console.WriteLine($"총점 : {sum}, 평균 : {avg:.0}");

            string arr = "C#";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);


            int[,] arr = new int[3, 3]; // 2차원 배열
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            int[,] scores = // 다른 방법으로 배열 선언
            {
                {90, 100, 0, 0 },
                {80, 90, 0, 0 },
                {100, 80, 0, 0 }
            };

            for (int i = 0; i < 3; i++)
            {
                scores[i, 2] = scores[i, 0] + scores[i, 1];
                scores[i, 3] = scores[i, 2] / 2;
            }
            Console.WriteLine("국어 영어 합계 평균");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{scores[i, j],4}");
                }
                Console.WriteLine();
            }

            string[][] subjectAndScores = new string[2][]; // 행만 정하고, 열은 가변적임
            subjectAndScores[0] = new string[] { "국어", "영어" };
            subjectAndScores[1] = new string[] { "50", "100" };

            foreach (string[] showSubjectScores in subjectAndScores)
            {
                foreach (string show in showSubjectScores)
                {
                    Console.Write($"{show,5}");
                }
                Console.WriteLine();
            }
        }
    }
}
