using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class50
    {
        public string Number { get; set; }
        public string AreaName { get; set; }

        static void Main()
        {
            List<Class50> areas = new List<Class50>();

            Class50 seoul = new Class50();
            seoul.Number = "02";
            seoul.AreaName = "서울";

            Class50 sejong = new Class50() // object initalize
            {
                Number = "03",
                AreaName = "세종"
            };

            areas.Add(seoul);
            areas.Add(sejong);

            foreach(var area in areas)
            {
                Console.WriteLine($"번호 : {area.Number}, 지역 : {area.AreaName}");
            }

            var first = new List<Seoul>()
            {
                new Seoul()
                {
                    Number = "001", Name = "당산"
                },
                new Seoul()
                {
                    Number = "002", Name = "영등포"
                }
            };

            List<Busan> second = new List<Busan>();
            second.Add(new Busan("001", "해운대"));
            second.Add(new Busan("002", "광안리"));

            var merge = new List<Korea>();

            for(int i =0; i < first.Count; i++)
            {
                merge.Add(new Korea() { Number = first[i].Number, Name = first[i].Name });
            }

            Console.WriteLine($"{merge[0].Number}, {merge[0].Name}");
            Console.WriteLine(merge[1].Number.ToString());
            Console.WriteLine(merge[1].Name.ToString());
        }
    }

    class Seoul
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public Seoul()
        {

        }

        public Seoul(string num, string name)
        {
            this.Number = num;
            this.Name = name;
        }
    }

    class Busan
    {
        private string number;
        private string name;

        public Busan()
        {

        }

        public Busan(string num, string name)
        {
            this.number = num;
            this.name = name;
        }

        public void setNumber(string newNum)
        {
            this.number = newNum;
        }

        public string getNumber()
        {
            return this.number;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public string getName()
        {
            return this.name;
        }
    }

    class Korea
    {
        public String Name { get; set; }
        public String Number { get; set; }
    }
}
