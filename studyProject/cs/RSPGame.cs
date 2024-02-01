using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class RSPGame
    {
        static void Main()
        {
            int com = 0;
            int user = 0;
            string[] choice = new string[3];
            choice[0] = "가위";
            choice[1] = "바위";
            choice[2] = "보";

            com = new Random().Next(1, 4);

            Start:
            Console.Write("1.가위 2.바위 3.보\n 입력 : ");
            user = Convert.ToInt32(Console.ReadLine());
            if(user >= 0 && 3 >= user)
            {
                Console.WriteLine("\n 사용자 : {0}", choice[user - 1]);
                Console.WriteLine("\n 컴퓨터 : {0}", choice[com - 1]);
            }
            else
            {
                Console.WriteLine("보기에 옵션에서만 선택해주세요.");
                goto Start;
            }

            if (user == com)
            {
                Console.WriteLine("draw~");
            }
            else if ((user == 0 && com == 2) || (user == 1 && com == 0) || (user == 2 && com == 1))
            {
                Console.WriteLine("사용자 승!");
            }
            else
            {
                Console.WriteLine("컴퓨터 승!");
            }
        }
    }
}
