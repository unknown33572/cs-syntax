using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace studyProject
{
    class Generic
    {
        static void Main()
        {
            List<Generic> people = new List<Generic>
            {
                new Generic { name = "홍길동" },
                new Generic { name = "이순신" },
                new Generic { name = "유관순" }
            };

            foreach (var person in people)
            {
              Console.WriteLine(person.name);
            }

            Stack stack = new Stack();
            stack.Push(1234);
            stack.Push(5678);

            int num = (int)stack.Pop();

            Console.WriteLine(num);

            Queue queue = new Queue();
            queue.Enqueue("1234");
            queue.Enqueue("5678");

            string num2 = queue.Dequeue().ToString();

            Console.WriteLine(num2);

            int num3 = int.Parse((string)queue.Dequeue());

            Console.WriteLine(num3);

            List<int> numList = new List<int>();

            numList.Add(100);
            numList.Add(200);
            numList.Add(300);

            foreach (int item in numList)
                Console.WriteLine(item);

            /*
            foreach (string item in numList) // 제네릭 타입이기 때문에 컴파일 에러가 발생함
                Console.WriteLine(item);
            */

            var numbers = Enumerable.Range(1, 10);

            foreach (var n in numbers)
                Console.WriteLine("{0}\t", n); // \t는 탭을 의미 \n은 줄바꿈을 의미

            var numbers2 = Enumerable.Repeat(100, 10);

            foreach (var n in numbers2)
                Console.WriteLine("{0}\t", n);
        }
    }
}
