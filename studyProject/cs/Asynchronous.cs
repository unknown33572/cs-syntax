using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace studyProject
{
    class Asynchronous
    {

        static async Task Main()
        {
            Cooking cooking = new Cooking();

            /// <summary>
            /// 동기식 실행
            /// </summary>
            //Rice riceTask = await cooking.makeRice();
            //Console.WriteLine("밥이 완성되었습니다.");

            //Soup soupTask = await cooking.makeSoup();
            //Console.WriteLine("국이 완성되었습니다.");

            //Egg eggTask = await cooking.makeEgg();
            //Console.WriteLine("후라이가 완성되었습니다.");

            /// <summary>
            /// 비동기식 실행
            /// </summary>
            Task<Rice> rice = cooking.makeRice();
            Console.WriteLine("밥이 완성되었습니다.");

            Task<Soup> soup = cooking.makeSoup();
            Console.WriteLine("국이 완성되었습니다.");

            Task<Egg> egg = cooking.makeEgg();
            Console.WriteLine("후라이가 완성되었습니다.");

            //await Task.WhenAll(rice, soup, egg);

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
            await Task.Delay(2000);
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
            for (int i = 0; i < 10; i++) // 게임중독자라 비동기 함수 안끝남
            {
                gaming();
            }
            await Task.Delay(3000);
            return new Egg();
        }

        void gaming()
        {
            Console.WriteLine("게임중");
        }
    }
}
