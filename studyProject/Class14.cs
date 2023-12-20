using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class14
    {
        struct Point
        {
            public int X;
            public int Y;
        }

        static void Main(string[] args)
        {
            Point p;
            p.X = 100;
            p.Y = 200;
            Console.WriteLine(p.X + p.Y);

            TimeSpan d_day = /*Convert.ToDateTime("2023-12-25")*/new DateTime(2023,12,25) - DateTime.Now;
            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)d_day.TotalDays}일 남음");
        }
    }
}
