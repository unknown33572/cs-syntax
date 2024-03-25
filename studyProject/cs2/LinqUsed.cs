using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class LinqUsed
    {
        static void Main()
        {
            var heavyQuery = Enumerable.Range(0, 10)
                                       .Where(c => { Task.Delay(100).Wait(); return true; });

            var start = DateTime.Now;
            for(int i = 0; i < heavyQuery.Count(); i++)
            {
                Console.WriteLine(heavyQuery.ElementAt(i));
            }
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
