using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class31
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
                new { Name = "이순신", Skill = "Java"}
            };

            foreach(var engineer in developers)
            {
                Console.WriteLine($"{engineer.Name}: {engineer.Skill}");
            }

        }
    }
}
