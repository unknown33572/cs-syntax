using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class35
    {
        static void Hi() => Console.WriteLine("안녕!");

        delegate void SayDelegate();

        static void Main()
        {

            SayDelegate say = Hi;

            say();

            object hi = new SayDelegate(Hi);
            ((SayDelegate)hi)();

          GoForward();
          GoLeft();
          GoRight();

          SayDelegate carDriver = new SayDelegate(GoForward);
          carDriver();
        }

      public static void GoForward() => Console.WriteLine("직진");
      public static void GoLeft() => Console.WriteLine("좌회전");
      public static void GoRight() => Console.WriteLine("우회전");
    }
}
