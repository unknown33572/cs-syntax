using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            int[] result = new int[52];

            for(int i = 0; i < my_string.length; i++)
            {
                if (my_string[i] == 'A')
                {
                    result[0]++;
                }
                else if (my_string[i] == 'B')
                {
                    result[1]++;
                }
                else if (my_string[i] == 'C')
                {
                    result[2]++;
                }
                else if (my_string[i] == 'D')
                {
                    result[3]++;
                }
                else if (my_string[i] == 'E')
                {
                    result[4]++;
                }
                else if (my_string[i] == 'F')
                {
                    result[5]++;
                }
                else if (my_string[i] == 'G')
                {
                    result[6]++;
                }
                else if (my_string[i] == 'H')
                {
                    result[7]++;
                }
                else if (my_string[i] == 'I')
                {
                    result[8]++;
                }
                else if (my_string[i] == 'J')
                {
                    result[9]++;
                }
                else if (my_string[i] == 'K')
                {
                    result[10]++;
                }
                else if (my_string[i] == 'L')
                {
                    result[11]++;
                }
                else if (my_string[i] == 'M')
                {
                    result[12]++;
                }
                else if (my_string[i] == 'N')
                {
                    result[13]++;
                }
                else if (my_string[i] == 'O')
                {
                    result[14]++;
                }
                else if (my_string[i] == 'P')
                {
                    result[15]++;
                }
                else if (my_string[i] == 'Q')
                {
                    result[16]++;
                }
                else if (my_string[i] == 'R')
                {
                    result[17]++;
                }
                else if (my_string[i] == 'S')
                {
                    result[18]++;
                }
                else if (my_string[i] == 'T')
                {
                    result[19]++;
                }
                else if (my_string[i] == 'U')
                {
                    result[20]++;
                }
                else if (my_string[i] == 'V')
                {
                    result[21]++;
                }
                else if (my_string[i] == 'W')
                {
                    result[22]++;
                }
                else if (my_string[i] == 'X')
                {
                    result[23]++;
                }
                else if (my_string[i] == 'Y')
                {
                    result[24]++;
                }
                else if (my_string[i] == 'Z')
                {
                    result[25]++;
                }
                else if (my_string[i] == 'a')
                {
                    result[26]++;
                }
                else if (my_string[i] == 'b')
                {
                    result[27]++;
                }
                else if (my_string[i] == 'c')
                {
                    result[28]++;
                }
                else if (my_string[i] == 'd')
                {
                    result[29]++;
                }
                else if (my_string[i] == 'e')
                {
                    result[30]++;
                }
                else if (my_string[i] == 'f')
                {
                    result[31]++;
                }
                else if (my_string[i] == 'g')
                {
                    result[32]++;
                }
                else if (my_string[i] == 'h')
                {
                    result[33]++;
                }
                else if (my_string[i] == 'i')
                {
                    result[34]++;
                }
                else if (my_string[i] == 'j')
                {
                    result[35]++;
                }
                else if (my_string[i] == 'k')
                {
                    result[36]++;
                }
                else if (my_string[i] == 'l')
                {
                    result[37]++;
                }
                else if (my_string[i] == 'm')
                {
                    result[38]++;
                }
                else if (my_string[i] == 'n')
                {
                    result[39]++;
                }
                else if (my_string[i] == 'o')
                {
                    result[40]++;
                }
                else if (my_string[i] == 'p')
                {
                    result[41]++;
                }
                else if (my_string[i] == 'q')
                {
                    result[42]++;
                }
                else if (my_string[i] == 'r')
                {
                    result[43]++;
                }
                else if (my_string[i] == 's')
                {
                    result[44]++;
                }
                else if (my_string[i] == 't')
                {
                    result[45]++;
                }
                else if (my_string[i] == 'u')
                {
                    result[46]++;
                }
                else if (my_string[i] == 'v')
                {
                    result[47]++;
                }
                else if (my_string[i] == 'w')
                {
                    result[48]++;
                }
                else if (my_string[i] == 'x')
                {
                    result[49]++;
                }
                else if (my_string[i] == 'y')
                {
                    result[50]++;
                }
                else if (my_string[i] == 'z')
                {
                    result[51]++;
                }
            }
        }
    }
}
