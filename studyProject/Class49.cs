using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class49
    {
        public string name { get; set; }

        static void Main()
        {
            List<Class49> people = new List<Class49>
            {
                new Class49 { name = "홍길동" },
                new Class49 { name = "이순신" },
                new Class49 { name = "유관순" }
            };

            foreach(var person in people)
            {
                Console.WriteLine(person.name);
            }
        }
    }
}
