using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class TypeConvert
    {
        static void Main()
        {

            double d = 12.34;

            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            int i = (int)d;

            Console.WriteLine(i);
            Console.WriteLine(i.GetType());

            double d1 = i; // 암시적 형변환

            Console.WriteLine(d1);
            Console.WriteLine(d1.GetType());

            char c = 'a';

            Console.WriteLine(c); // a
            Console.WriteLine(c.GetType()); // System.Char

            int i1 = Convert.ToInt32(c);

            Console.WriteLine(i1); // ACSII 코드값 출력 97
            Console.WriteLine(i1.GetType());

            string s = i.ToString();

            string s2 = Convert.ToString(i);

            int i2 = Convert.ToInt32(s);

            int i3 = int.Parse(s);

            Console.WriteLine(i3);
            Console.WriteLine(i3.GetType());


            var v = 123; // 가변형 변수
            var v2 = "abc";
            var v3 = 12.34;
            var v4 = 'a';
            var v5 = true; // bool
            var v6 = new int[] { 1, 2, 3 }; // array

            Console.WriteLine(v.GetType());
            Console.WriteLine(v2.GetType());
            Console.WriteLine(v3.GetType());
            Console.WriteLine(v4.GetType());
            Console.WriteLine(v5.GetType());
            Console.WriteLine(v6.GetType());
        }
    }
}
