using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace studyProject
{
    class Person
    {
        public string name { get; set; } = "unknown";
        public Address address { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
    }

    class Access
    {
        static void Main()
        {
            var people = new Person[] { new Person { name = "홍길동" },
                                        null};

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach(var person in peopleArray)
                {
                    Console.WriteLine($"{person?.name??"아무개"}은(는)" +
                        $"{person?.address?.Street??"아무곳"}에 삽니다");
                }
            }

            ProcessPeople(people);
        }
    }
}
