using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace studyProject
{
    class List
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("C#");
            list.Add("Java");
            list.Add("Python");

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            List<int> newNumbers = numbers.Where(n => n > 3).ToList(); // 3보다 큰 수만 추출
            for (int i = 0; i < newNumbers.Count; i++)
            {
                newNumbers[i] += newNumbers[i]; // 3보다 큰 수에 그 만큼을 더함
                Console.WriteLine(newNumbers[i]);
            }
        }
    }
}
