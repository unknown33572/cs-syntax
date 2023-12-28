using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Singleton
    {
        private static Singleton singleton;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Singleton();
                }
                return singleton;
            }
        }

        public void Alert()
        {
            Console.WriteLine("띠링~!");
        }
    }

    public class FakeSingleton
    {
        private int x;
        private int y;

        public int xProperty
        {
            get { return x; }
            set { x = value; }
        }

        public int yProperty
        {
            get { return y; }
            set { y = value; }
        }

        public void calc()
        {
            int sum = this.x + this.y;
            Console.WriteLine(sum);
        }
    }

    class Run
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.Instance;
            singleton1.Alert();

            Singleton singleton2 = Singleton.Instance;
            singleton2.Alert();

            if(singleton1 == singleton2)
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }

            FakeSingleton fs1 = new FakeSingleton();

            fs1.xProperty = 2;
            fs1.yProperty = 3;
            fs1.calc();

            FakeSingleton fs2 = new FakeSingleton();

            if (fs1 == fs2)
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }
        }
    }
}


