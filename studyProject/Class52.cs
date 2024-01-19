using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class52
    {
        static void Sum(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
        static void Multiple(int a, int b) => Console.WriteLine($"{a} x {b} = {a * b}");

        /*
        static void Main()
        {
            //Sum(3, 5);
            //Multiple(3, 3);
        }
        */

        static async Task Main()
        {
            Cooking cooking = new Cooking();

            //Rice rice = await cooking.makeRice();
            //Console.WriteLine("밥이 완성되었습니다.");

            //Soup soup = await cooking.makeSoup();
            //Console.WriteLine("국이 완성되었습니다.");

            //Egg egg = await cooking.makeEgg();
            //Console.WriteLine("후라이가 완성되었습니다.");

            Task<Rice> rice = cooking.makeRice();
            Task<Soup> soup = cooking.makeSoup();
            Task<Egg> egg = cooking.makeEgg();

            await Task.WhenAll(rice, soup, egg);

            Console.WriteLine("밥, 국, 계란후라이 모두 완성되었습니다.");
        }
    }

    public class Rice { }
    public class Soup { }
    public class Egg { }

    class Cooking
    {
        public async Task<Rice> makeRice()
        {
            Console.WriteLine("밥 짓는 중");
            await Task.Delay(3000);
            return new Rice();
        }

        public async Task<Soup> makeSoup()
        {
            Console.WriteLine("국 끓이는 중");
            await Task.Delay(1000);
            return new Soup();
        }

        public async Task<Egg> makeEgg()
        {
            Console.WriteLine("후라이 튀기는 중");
            for(int i = 0; i < 1_000; i++) // 게임중독자라 비동기 함수 안끝남
            {
                gaming();
            }
            await Task.Delay(5000);
            return new Egg();
        }

        void gaming()
        {
            Console.WriteLine("게임중");
        }
    }
}
