using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class5
    {
        static void Main()
        {
            /*
            int count = 0;
            Boolean flag = false;
            while(!flag)
            {
                Console.WriteLine($"{count}");
                count++;
                if(count == 3)
                {
                    flag = true;
                }
            }
            */

            string difficultSubject = "c#";
            string[] subject1 = { "java", "c#", "python", "js" };

            foreach(string subject2 in subject1)
            {
                Console.WriteLine(subject2);
                if(subject2.Contains(difficultSubject))
                {
                    Console.WriteLine($"{subject2} 은 어려운 과목입니다.");
                }
            }
        }
    }
}
