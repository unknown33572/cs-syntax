using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    internal class VarUesd
    {
        public static void Main(string[] args)
        {
            var dic = new Dictionary<String, Action<TextWriter>>();
            dic.Add("sample1", (writer) => writer.WriteLine("sample1입니다."));
            dic.Add("sample2", (writer) => writer.WriteLine("sample2입니다."));

            foreach (var key in dic.Values)
            {
                key(Console.Out);
                //key.Value(Console.Out);
            }

        }
    }
}
