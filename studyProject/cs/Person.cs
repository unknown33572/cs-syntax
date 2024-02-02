using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Person
    {
        private string name = "홍길동"; // 기본 필드 값

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
            return $"{ name }이(가) 걷습니다.";
        }
    }

    class Demo
    {
        static void Main()
        {
            Person p1 = new Person("이순신"); // 인스턴스 생성하면서 필드 값 변경
            Person p2 = new Person(); // 인스턴스 생성하면서 필드 값 변경 안함
            Console.WriteLine(p1.walk());
            Console.WriteLine(p2.walk());
            Console.WriteLine(p1.getName);
            Console.WriteLine(p2.getName);
        }
    }
}
