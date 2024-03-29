using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    class Code2
    {
        static void Main(string[] args)
        {
            List<List<int>> twoDimensionalList = new List<List<int>>();

            // 2차원 리스트에 데이터 추가
            twoDimensionalList.Add(new List<int> { 1, 2, 3 });
            twoDimensionalList.Add(new List<int> { 4, 5, 6 });
            twoDimensionalList.Add(new List<int> { 7, 2, 3 });

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        if (twoDimensionalList[i][k].Equals(twoDimensionalList[j][k]))
                        {
                            Console.WriteLine(twoDimensionalList[i][k] + "있음");
                        }
                    }
                }
            }

            String[] input;
            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);

            String answer = "";

            for(int i = 0; i < a; i++)
            {
                answer += s1;
            }
            
            Console.WriteLine(answer);
        }
    }
}
