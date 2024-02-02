using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Reference
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
            List<Reference> GetAll()
            {
                return new List<Reference>
                {
                    new Reference { Name = "Radio", Quantity = 3},
                    new Reference { Name = "TV", Quantity = 1},
                    new Reference { Name = "Radio", Quantity = 2},
                    new Reference { Name = "DVD", Quantity = 4},
                    new Reference { Name = "GameConsole", Quantity = 2},
                    new Reference { Name = "Computer", Quantity = 3},
                    new Reference { Name = "Computer", Quantity = 3},
                    new Reference { Name = "Radio", Quantity = 1},
                    new Reference { Name = "Phone", Quantity = 8},
                    new Reference { Name = "AirConditioner", Quantity = 1}
                };
            }

            void PrintData(String message, List<Reference> data)
            {
                Console.WriteLine(message);
                foreach(var item in data)
                {
                    Console.WriteLine($"{item.Name} -> {item.Quantity}");
                }
            }

            List<Reference> records = GetAll();
            List<Reference> groups = new List<Reference>();
            int N = records.Count;

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

            int subtotal = 0;
            for(int i = 0; i < N; i++)
            {
                subtotal += records[i].Quantity;
                if ((i + 1) == N || (records[i].Name != records[i + 1].Name))
                {
                    groups.Add(new Reference { Name = records[i].Name, Quantity = subtotal });
                    subtotal = 0;
                }
            }

            PrintData("기본 정렬 데이터 : ", records);
            PrintData("이름으로 그룹화된 데이터 : ", groups);
            Console.WriteLine(groups.Count);

            StaticMember();
            //InstanceMember();
            Reference class27InstanceMember = new Reference();
            class27InstanceMember.InstanceMember();
        }

    void InstanceMember() => Console.WriteLine("인스턴스함수"); // 인스턴스 함수는 정적함수와 달리 클래스의 인스턴스를 생성해야만 호출할 수 있음
        
    public static void StaticMember() => Console.WriteLine("정적멤버함수");
    }
}
