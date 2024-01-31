using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class4
    {
        static void Main()
        {

            for(int i = 2; i <= 9; i++)
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
                Console.WriteLine(subject2);
                if (subject2.Contains(difficultSubject))
                {
                    Console.WriteLine($"{subject2} 은 어려운 과목입니다.");
                }
            }
        }
    }
}
