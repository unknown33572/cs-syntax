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

    enum Animal
    {
        Dog = 1,
        Cat = 2,
        Pig = 4,
        Cow = 8
    }

    class Enum
    {
        static void Main()
        {
            Priorty high = Priorty.High;
            Priorty normal = Priorty.Normal;
            Priorty low = Priorty.Low;

            Console.WriteLine($"{high},{normal},{low}");

            Animal dog = Animal.Dog;
            Animal cat = Animal.Cat;
            Animal pig = Animal.Pig;
            Animal cow = Animal.Cow;

            Console.WriteLine($"{dog},{cat},{pig},{cow}");
            Console.WriteLine($"{(int)dog},{(int)cat},{(int)pig},{(int)cow}");
        }
    }
}
