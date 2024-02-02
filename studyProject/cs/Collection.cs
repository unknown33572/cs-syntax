using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Collection
    {

        static void Main()
        {
            IDictionary<int, string> data = new Dictionary<int, string>();

            data.Add(1, "C#");
            data.Add(2, "Java");
            data.Add(3, "Javascript");

                Here:
                data.Remove(2);
            foreach(KeyValuePair<int, string> item in data)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }


            try
            {
                data.Add(2, "Python");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                goto Here;
            }

            //data.Add(2, "Python");

            foreach(KeyValuePair<int, string> item in data)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
