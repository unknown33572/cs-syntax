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

        static void Main()
        {
            var nickName = new Class34();

            nickName["홍길동"] = "도적";
            nickName["이순신"] = "장군";

            Console.WriteLine($"{nickName["홍길동"]},{nickName["이순신"]}");
        }
    }
}
