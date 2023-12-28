using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class26
    {
        static void Main()
        {
            int[] scores = { 1, 3, 4, 3, 5 };
            int[] indexes = new int[5 + 1];
            int max = int.MinValue;
            int mode = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                indexes[scores[i]]++;
            }
            for(int i = 0; i < indexes.Length; i++)
            {
                if(indexes[i] > max)
                {
                    max = indexes[i];
                    mode = i;
                }
            }
            Console.WriteLine($"{mode} -> {max}");
        }
    }
}
