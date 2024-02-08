using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Indexers
    {
        private string[] week;

        public Indexers()
        {
            Length = 7;
            week = new string[Length];
        }

        public Indexers(int length)
        {
            Length = length;
            week = new string[Length];
        }

        public int Length { get; }

        public string this[int index] // 인덱스는 this 키워드로 정의하고 []로 묶어서 사용함
        {
            get { return week[index]; }
            set { week[index] = value; }
        }

        static void Main()
        {
            Indexers week = new Indexers(3);

            week[0] = "일요일";
            week[1] = "월요일";
            week[2] = "화요일";

            for(int i = 0; i < week.Length; i++)
            {
                Console.WriteLine($"{week[i]}");
            }
        }
    }
}
