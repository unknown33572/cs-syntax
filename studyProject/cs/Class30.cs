using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Person
    {
        private string name = "홍길동";

        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }

        public string getName
        {
            get
            {
                return name;
            }
        }

        public string walk()
        {
            return name + "이(가) 걷습니다.";
        }
    }

    class Class30
    {
        static void Main()
        {
            Person p1 = new Person("이순신");
            p1.walk();
            Console.WriteLine(p1.getName);
        }
    }
}
