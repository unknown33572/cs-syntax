using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class SecondMemoryReferenceUsed
    {
        public Func<int> GetSum;

        public SecondMemoryReferenceUsed(int max)
        {
            IEnumerable<int> enumAll = Enumerable.Range(0, max);
            GetSum = () => enumAll.Sum();
        }

        public int Sum()
        {
            return GetSum();
        }
    }

    internal class Demo
    {
        static void Main(string[] args)
        {
            var list = new List<SecondMemoryReferenceUsed>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new SecondMemoryReferenceUsed(100));
            }

            foreach(var item in list)
            {
                Console.WriteLine(item.Sum());
            }
        }
    }
}
