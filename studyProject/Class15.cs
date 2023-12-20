using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    enum Priorty
    {
        High,
        Normal,
        Low
    }

    class Class15
    {
        static void Main()
        {
            Priorty high = Priorty.High;
            Priorty normal = Priorty.Normal;
            Priorty low = Priorty.Low;

            Console.WriteLine($"{high},{normal},{low}");
        }
    }
}
