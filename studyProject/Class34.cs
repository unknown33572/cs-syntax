using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace studyProject
{
    class Class34
    {
        private Hashtable names = new Hashtable();

        public string this[string key]
        {
            get { return names[key].ToString(); }
            set { names[key] = value; }
        }


        static IEnumerable<int> GreaterOne(int[] numbers, int greater)
        {
            List<int> temp = new List<int>();

            foreach(var n in numbers)
            {
                if(n > greater)
                {
                    temp.Add(n);
                }
            }

            return temp;
        }

        static IEnumerable<int> GreaterTwo(int[] numbers, int greater)
        {
            foreach(var n in numbers)
            {
                if(n > greater)
                {
                    yield return n;
                }
            }
        }


        static void Main()
        {
            var nickName = new Class34();

            nickName["홍길동"] = "도적";
            nickName["이순신"] = "장군";

            Console.WriteLine($"{nickName["홍길동"]},{nickName["이순신"]}");

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach(var n in GreaterOne(numbers, 2))
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            foreach(var n in GreaterTwo(numbers, 3))
            {
                Console.WriteLine(n);
            }
        }
    }
}
