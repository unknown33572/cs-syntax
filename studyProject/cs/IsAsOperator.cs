using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class IsAsOperator
    {
        static void Main()
        {
            object obj = 123;
            object obj2 = "일이삼";

            if(obj is int)
            {
                Console.WriteLine("obj는 int형");
            }
            else
            {
                Console.WriteLine("obj는 int형이 아님");
            }

            if(obj2 is int)
            {
                Console.WriteLine("obj2는 int형");
            }
            else
            {
                Console.WriteLine("obj2는 int형이 아님");
            }

            if(obj is int)
            {
                int a = (int)obj;
                Console.WriteLine(a is int); // 변환된 a는 int형이므로 true
            }
            else
            {
                Console.WriteLine("obj는 int형이 아님");
            }
                

            if(obj2 is string)
            {
                string a = obj2 as string; // as 연산자는 형변환 연산자와 비슷하지만, 형변환 연산자는 변환할 수 없는 경우 예외를 발생시키지만 as 연산자는 null을 반환
                Console.WriteLine(a is string);
            }
            else
            {
                Console.WriteLine("obj2는 int형이 아님");
            }
        }
    }
}
