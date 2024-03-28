using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<List<int>> twoDimensionalList = new List<List<int>>();

            // 2차원 리스트에 데이터 추가
            twoDimensionalList.Add(new List<int> { 1, 2, 3 });
            twoDimensionalList.Add(new List<int> { 4, 5, 6 });
            twoDimensionalList.Add(new List<int> { 7, 2, 3 });

            //Console.WriteLine(twoDimensionalList[0][0]); // 1

            //if (twoDimensionalList[0][0].Equals(twoDimensionalList[2][0]))
            //{
            //    Console.WriteLine(twoDimensionalList[0][0] + "있음");
            //}

            //int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    //if(twoDimensionalList[i][0].Equals(twoDimensionalList[j][0]))
                    //{
                    //    Console.WriteLine(twoDimensionalList[i][0] + "있음");
                    //}
                    //if (twoDimensionalList[i][1].Equals(twoDimensionalList[j][1]))
                    //{
                    //    Console.WriteLine(twoDimensionalList[i][1] + "있음");
                    //}
                    //if (twoDimensionalList[i][2].Equals(twoDimensionalList[j][2]))
                    //{
                    //    Console.WriteLine(twoDimensionalList[i][2] + "있음");
                    //}

                    for(int k = 0; k < 3; k++)
                    {
                        if (twoDimensionalList[i][k].Equals(twoDimensionalList[j][k]))
                        {
                            Console.WriteLine(twoDimensionalList[i][k] + "있음");
                        }
                    }
                }
            }
        }
    }
}
