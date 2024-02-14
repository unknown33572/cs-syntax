using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs
{
  class IDisposableDemo
  {
    static void Main()
    {
      Console.WriteLine("화장실이 어디지?");
      using (Toilet toilet = new Toilet())
      {
        Console.WriteLine("화장실 찾기");
      }
    }
  }

    public class  Toilet : IDisposable
    {
        public void Dispose()
        {
          Console.WriteLine("화장실 사용");
        }
    }
}
