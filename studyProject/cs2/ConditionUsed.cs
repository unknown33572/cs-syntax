using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class ConditionUsed
    {
        static void convert(ref string color)
        {
            switch(color)
            {
                case "red": color = "빨간색"; break;
                case "blue": color = "파란색"; break;
                case "green": color = "초록색"; break;
                default: color = "알 수 없음"; break;
            }
        }

        static void Main(string[] args)
        {
            string r = "red";
            string g = "green";
            string b = "blue";

            convert(ref g);

            Console.WriteLine(g);
        }
    }
}
