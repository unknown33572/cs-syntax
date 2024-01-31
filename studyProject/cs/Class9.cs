using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class9
    {
        static void Main()
        {
            
            
            int[,] scores =
            {
                {90, 100, 0, 0 },
                {80, 90, 0, 0 },
                {100, 80, 0, 0 }
            };

            for(int i = 0; i < 3; i++)
            {
                scores[i, 2] = scores[i, 0] + scores[i, 1];
                scores[i, 3] = scores[i, 2] / 2;
            }
            Console.WriteLine("국어 영어 합계 평균");

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write($"{scores[i, j], 4}");
                }
                Console.WriteLine();
            }

            string[][] subjectAndScores = new string[2][]; // 행만 정하고, 열은 가변적임
            subjectAndScores[0] = new string[] { "국어", "영어" };
            subjectAndScores[1] = new string[] { "50", "100" };

            foreach(string[] showSubjectScores in subjectAndScores)
            {
                foreach(string show in showSubjectScores)
                {
                    Console.Write($"{show, 5}");
                }
                Console.WriteLine();
            }

            var anything = new int[] { 1, 2, 3 };
            for(int i = 0; i < anything.Length; i++)
            {
                Console.WriteLine(anything[i]);
            }
            for(int i= 0; i < anything.Length; i++)
            {
                string alphabet = ((char)('a' + i)).ToString();
                anything[i] = int.Parse(alphabet);
                Console.WriteLine(anything[i]);
            }

        }
    }
}
