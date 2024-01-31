using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace studyProject
{
    class Class23
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("C#");
            list.Add("Java");
            list.Add("Python");

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
