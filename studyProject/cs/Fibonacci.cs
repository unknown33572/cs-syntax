using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace studyProject
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            #region for문을 이용한 피보나치 수열
            int fact = 0;

            for(int i = 1; i <= 4; i++)
            {
                fact = 1;
                for(int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                WriteLine($"{i}번째 : {fact, 2}");
            }
            #endregion

            #region while문을 이용한 피보나치 수열
            int first = 0;
            int second = 1;

            while(second <= 20)
            {
                WriteLine(second);
                int temp = first + second;
                first = second;
                second = temp;
            }
            #endregion
        }
    }
}
