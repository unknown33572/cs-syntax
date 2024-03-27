using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    class Code
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;
            for(int i = 0; i < myString.Length - pat.Length; i++)
            {
                if (myString[i] == pat[0])
                {
                    var temp = myString.Substring(i, pat.Length);
                    if (temp == pat)
                    {
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
