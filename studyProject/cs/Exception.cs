using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Exception
    {
        static void Main()
        {
            int a = 3;
            int b = 0;

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
            catch (Exception e) // 자세한 예외 정보를 알려줌
            {
                Console.WriteLine(e.Message);
            }

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
