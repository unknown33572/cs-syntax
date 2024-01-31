using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class28
    {
        public static void StaticMember() => Console.WriteLine("정적멤버함수");
        void InstanceMember() => Console.WriteLine("인스턴스함수");

        static void Main()
        {
            StaticMember();
            //InstanceMember();
            Class28 class28InstanceMember = new Class28();
            class28InstanceMember.InstanceMember();
        }
    }
}
