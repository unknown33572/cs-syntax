using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class22
    {
        static void Main()
        {
            int a = 3;
            int b = 0;

            try
            {
                a = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외 : {e.Message}");
            }
            finally
            {
                Console.WriteLine("정상 종료");
            }

            try
            {
                throw new Exception("내가 만든 에러");
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외 발생 : {e.Message}");
            }
            finally
            {
                Console.WriteLine("정상 종료!");
            }
        }
    }
}
