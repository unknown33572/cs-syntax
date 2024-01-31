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

            int i = (int)d;

            d = i; // 암시적 형변환

            char c = 'a';

            int i1 = Convert.ToInt32(c);

            Console.WriteLine(i1); // ACSII 코드값 출력 97

            string s = i.ToString();

            string s2 = Convert.ToString(i);

            int i2 = Convert.ToInt32(s);

            int i3 = int.Parse(s);

            Console.WriteLine(i3);

        }
    }
}
