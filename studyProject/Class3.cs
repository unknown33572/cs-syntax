using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class3
    {
        static void Main()
        {
            Console.WriteLine("1 or 2를 입력하세요.");
            int x = int.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine("굿");
                    break;
                case 2:
                    Console.WriteLine("낫굿");
                    break;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
