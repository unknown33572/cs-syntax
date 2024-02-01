using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Struct
    {
        struct BusinessCard
        {
            public string Name;
            public int Age;
            public string PhoneNumber;
        }

        static void Main(string[] args)
        {
            BusinessCard card;
            card.Name = "S";
            card.Age = 30;
            card.PhoneNumber = "010-1234-5678";

            string info = "이름: " + card.Name + " "+ "나이: " + card.Age + " " + "번호: " + card.PhoneNumber;
            Console.WriteLine(info);

            Console.WriteLine();

            BusinessCard[] cards = new BusinessCard[3];
            cards[0].Name = "DD";
            cards[0].Age = 30;
            cards[0].PhoneNumber = "010-1234-5678";

            cards[1].Name = "EE";
            cards[1].Age = 25;
            cards[1].PhoneNumber = "011-1234-5678";

            cards[2].Name = "FF";
            cards[2].Age = 20;
            cards[2].PhoneNumber = "017-1234-5678";

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine("이름: " + cards[i].Name + " " + "나이: " + cards[i].Age + " " + "번호: " + cards[i].PhoneNumber);
            }

            Console.WriteLine();

            showInfo(card);

            Console.WriteLine();

            TimeSpan d_day = /*Convert.ToDateTime("2023-12-25")*/new DateTime(2024,12,25) - DateTime.Now;
            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)d_day.TotalDays}일 남음");
        }

        static void showInfo(BusinessCard card)
        {
            Console.WriteLine("이름: " + card.Name + " " + "나이: " + card.Age + " " + "번호: " + card.PhoneNumber);
        }
    }
}
