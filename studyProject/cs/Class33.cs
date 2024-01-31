using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class33
    {
        private string[] week;

        public Class33()
        {
            Length = 7;
            week = new string[Length];
        }

        public Class33(int length)
        {
            Length = length;
            week = new string[Length];
        }

        public int Length { get; }

        public string this[int index]
        {
            get { return week[index]; }
            set { week[index] = value; }
        }

        static void Main()
        {
            Class33 week = new Class33(3);

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
