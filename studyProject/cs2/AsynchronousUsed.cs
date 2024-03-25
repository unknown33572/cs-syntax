using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class AsynchronousUsed
    {
        private static async Task countDown()
        {
            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
            }
        }

        private static async Task countDown(int x)
        {
            for(int i = x; i <= x + 10; i++)
            {
                char ascii = (char)i;
                Console.WriteLine(ascii);
                await Task.Delay(100);
            }
        }

        static void Main(string[] args)
        {
            var a = countDown();
            var b = countDown(65);

            Task.WaitAll(a, b);
        }
    }
}
