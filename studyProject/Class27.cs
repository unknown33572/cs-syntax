using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class27
    {
        public string Name
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        static void Main()
        {
            List<Class27> GetAll()
            {
                return new List<Class27>
                {
                    new Class27 { Name = "Radio", Quantity = 3},
                    new Class27 { Name = "TV", Quantity = 1},
                    new Class27 { Name = "Radio", Quantity = 2},
                    new Class27 { Name = "DVD", Quantity = 4}
                };
            }

            void PrintData(String message, List<Class27> data)
            {
                Console.WriteLine(message);
                foreach(var item in data)
                {
                    Console.WriteLine($"{item.Name} -> {item.Quantity}");
                }
            }

            List<Class27> records = GetAll();
            List<Class27> groups = new List<Class27>();
            int N = records.Count;

            /*
            for(int i =0; i < records.Count; i++)
            {
                Console.WriteLine($"{records[i].Name} -> {records[i].Quantity}");
            }

            PrintData("값은 : ", records);
            */

            for(int i = 0; i < N - 1; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    if(String.Compare(records[i].Name, records[j].Name) > 0)
                    {
                        var temp = records[i];
                        records[i] = records[j];
                        records[j] = temp;
                    }
                }
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (records[i].Quantity < records[j].Quantity) // 내림차순 정렬 조건
                    {
                        var temp = records[i];
                        records[i] = records[j];
                        records[j] = temp;
                    }
                }
            }

            //PrintData("값은 : ", records);

            int subtotal = 0;
            for(int i = 0; i < N; i++)
            {
                subtotal += records[i].Quantity;
                if ((i + 1) == N || (records[i].Name != records[i + 1].Name))
                {
                    groups.Add(new Class27 { Name = records[i].Name, Quantity = subtotal });
                    subtotal = 0;
                }
            }

            PrintData("기본 정렬 데이터 : ", records);
            PrintData("이름으로 그룹화된 데이터 : ", groups);
            Console.WriteLine(groups.Count);
        }
    }
}
