using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace studyProject
{

    class MyThread
    {
        public delegate void ThreadStart();
        public static void Hi() { Console.WriteLine("Hi"); }

        private static void csIDE()
        {
            Thread.Sleep(1000);
            Console.WriteLine("[3] IDE : Visual Studio");
        }

        private static void javaIDE()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[2] IDE : IntelliJ");
        }

        private static void jsIDE()
        {
            Thread.Sleep(2000);
            Console.WriteLine("[1] IDE : Visual Studio Code");
        }

        static void Main()
        {
            ThreadStart js = new ThreadStart(jsIDE);
            ThreadStart java = new ThreadStart(javaIDE);
            ThreadStart cs = new ThreadStart(csIDE);

            Thread t1 = new Thread(jsIDE);
            Thread t2 = new Thread(javaIDE);
            Thread t3 = new Thread(csIDE);

            t1.Start();
            t2.Start();
            t3.Start();

            var t4 = new Thread(new System.Threading.ThreadStart(Hi));
            t4.Start();
        }
    }
}
