using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Me { }

    class ToStringMethod
    {
        public override string ToString()
        {
            return "새로운 반환 문자열";
        }
    }

    class Class29
    {
        static void Main()
        {
            Me me = new Me();
            Console.WriteLine(me);

            ToStringMethod toStringMethod = new ToStringMethod();
            Console.WriteLine(toStringMethod);
        }
    }

}
