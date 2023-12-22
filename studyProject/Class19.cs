using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class19
    {
        static void Main()
        {
            string message = "Hello, World!!";
            Console.WriteLine(message.ToUpper());
            string replaceMessage = message.Replace("Hello", "bye");
            Console.WriteLine(replaceMessage.ToLower());

            string koreanMessage = " 안녕하세요. 반갑습니다. 세상! "; // 공백있음
            Console.WriteLine(koreanMessage);
            Console.WriteLine(koreanMessage.Replace("반갑습니다.", "").Trim());
        }
    }
}
