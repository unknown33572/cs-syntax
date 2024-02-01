using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Implied
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

            String str = "Welcome ";

            int stringMeddleNum = message.Length / 2;

            String temp = message.Substring(stringMeddleNum);
            String resultStr = String.Concat(str, temp);
            Console.WriteLine(resultStr);

            string userName = "BlueDog";
            Console.WriteLine("이름을 입력해주세요.");
            string inputName = Console.ReadLine();

            if(String.Equals(userName, inputName, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"{userName}과 {inputName}은 같습니다.");
            }
            else
            {
                Console.WriteLine("이름이 같지 않습니다.");
            }
        }
    }
}
