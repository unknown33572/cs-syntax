using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner.Common
{
    public class Rice { }
    public class Soup { }
    public class Egg { }

    public class Cooking
    {
        /// <summary>
        /// 동기식
        /// </summary>
        public Rice MakeRice()
        {
            Console.WriteLine("Making rice...");
            Thread.Sleep(3000);
            return new Rice();
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("Making soup...");
            Thread.Sleep(3000);
            return new Soup();
        }

        public Egg MakeEgg()
        {
            Console.WriteLine("Making egg...");
            Thread.Sleep(3000);
            return new Egg();
        }


        /// <summary>
        /// 동기식
        /// </summary>
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("Making rice...");
            await Task.Delay(3000);
            return new Rice();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("Making soup...");
            await Task.Delay(3000);
            return new Soup();
        }

        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("Making egg...");
            await Task.Delay(3000);
            return new Egg();
        }
    }
}
