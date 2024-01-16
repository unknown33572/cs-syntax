using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class46
    {
        private string name;

        public void setName(string n) => name = n;
        public string GetName() => this.name;
    }

    class ReflectionGetProperty
    {
        static void Main()
        {
            Class46 cs46 = new Class46();
            cs46.setName("C#");
            Console.WriteLine(cs46.GetName());
        }
    }
}
