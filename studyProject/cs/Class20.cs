using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class20
    {
        static void Main()
        {
            DateTime start = DateTime.Now;

            string msg = "";
            for(int i = 0; i < 10000; i++)
            {
                msg += "hi";
            }

            DateTime end = DateTime.Now;

            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);

            DateTime start1 = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 10000; i++)
            {
                sb.Append("bye");
            }

            DateTime end1 = DateTime.Now;
            double exec1 = (end1 - start1).TotalMilliseconds;
            Console.WriteLine(exec1);
        }
    }
}
