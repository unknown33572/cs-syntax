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

    class Override
    {
        static void Main()
        {
            Me me = new Me();
            Console.WriteLine(me); // ToString() 메서드를 오버라이딩 하지 않았기 때문에 출력값은 참조변수의 주소값임.

            ToStringMethod toStringMethod = new ToStringMethod();
            Console.WriteLine(toStringMethod);
        }
    }

}
