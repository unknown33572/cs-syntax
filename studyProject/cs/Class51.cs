using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace studyProject
{
    class Class51
    {
        private static void csIDE()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[3] IDE : Visual Studio");
        }

        private static void javaIDE()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[2] IDE : IntelliJ");
        }

        private static void jsIDE()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[1] IDE : Visual Studio Code");
        }

        static void Main()
        {
            ThreadStart js = new ThreadStart(jsIDE);
            ThreadStart java = new ThreadStart(javaIDE);
            ThreadStart cs = new ThreadStart(csIDE);

            Thread t1 = new Thread(jsIDE);
            Thread t2 = new Thread(javaIDE);
            Thread t3 = new Thread(cs);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
