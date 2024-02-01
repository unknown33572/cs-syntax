using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class TimeAndSB
    {
        static void Main()
        {
            DateTime start = DateTime.Now;

            string msg = "";
            for(int i = 0; i < 100; i++)
            {
                msg += "hi"; // string은 불변이기 때문에 메모리에 새로운 공간을 할당하고 기존의 공간을 버리는 과정을 반복함 (메모리 낭비)
            }

            DateTime end = DateTime.Now;
            Console.WriteLine(msg);

            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);

            DateTime start1 = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 100; i++)
            {
                sb.Append("bye"); // StringBuilder는 가변이기 때문에 메모리에 새로운 공간을 할당하지 않고 기존의 공간을 재사용함 (메모리 절약)
            }

            DateTime end1 = DateTime.Now;
            Console.WriteLine(sb.ToString());

            double exec1 = (end1 - start1).TotalMilliseconds;
            Console.WriteLine(exec1);

            var log = new StringBuilder().AppendFormat("{0} Log : ", nameof(TimeAndSB)).Append("메서드 체이닝으로 ").Append("로그 확인").ToString();
            Console.WriteLine(log);
        }
    }
}
