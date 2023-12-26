using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class21
    {
        static void Main()
        {
            try
            {
                int[] arr = new int[3];
                arr[4] = 1234; // exception
            }
            catch
            {
                Console.WriteLine("에러가 발생했습니다.");
            }

            try
            {
                int[] arr = new int[5];
                arr[6] = 1234;
            }
            catch(Exception e) // 자세한 예외 정보를 알려줌
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
