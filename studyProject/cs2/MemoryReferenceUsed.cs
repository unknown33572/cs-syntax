using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class MemoryReferenceUsed
    {
        private int[] array;
        private int sum;

        private void calc()
        {
            sum = array.Sum();
        }

        public MemoryReferenceUsed(int max)
        {
            array = Enumerable.Range(0, max).ToArray();
            calc();
        }

        public override string ToString()
        {
            return sum.ToString();
        }
    }

    internal class Demo
    {
        static void Main()
        {
            var list = new List<MemoryReferenceUsed>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new MemoryReferenceUsed(5));
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
