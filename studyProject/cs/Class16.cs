using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class16
    {
        static void StaticMethod() => Console.WriteLine("1 : 정적메서드");

        void InstanceMethod() => Console.WriteLine("2 : 인스턴스메서드");

        static void Main()
        {
            StaticMethod();
            Class16 im = new Class16();
            im.InstanceMethod();
            
        }
    }
}
