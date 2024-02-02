using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class ArrayConstructor
    {
        static void Multi(params string[] messages)
        {
            foreach(string message in messages)
            {
                Console.Write(message);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Multi("A");
            Multi("A", "B");

            var developers = new[]
            {
                new { Name = "홍길동", Skill = "C#"},
                new { Name = "이순신", Skill = "Java"},
                new { Name = "강감찬", Skill = "Python"},
                new { Name = "을지문덕", Skill = "JavaScript"},
            };

            foreach(var engineer in developers)
            {
                Console.WriteLine($"{engineer.Name}: {engineer.Skill}");
            }

            Console.WriteLine();

            int N = developers.Length;
            string search = "이순신";
            bool flag = false;
            int index = -1;

            int low = 0;
            int high = N - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;

                if (developers[mid].Name == search)
                {
                    flag = true;
                    index = mid;
                    break;
                }
                else if (developers[mid].Name.CompareTo(search) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (flag)
            {
                Console.WriteLine($"{search}의 스킬은 {developers[index].Skill}입니다.");
            }
            else
            {
                Console.WriteLine($"{search}은(는) 없습니다.");
            }
        }
    }
}
