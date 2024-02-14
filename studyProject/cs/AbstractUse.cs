using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    public abstract class Animal
    {
        public abstract string Cry();
    }

    public class Dog : Animal
    {
        public override string Cry()
        {
            return "멍멍";
        }
    }

    public class Cat : Animal
    {
        public override string Cry()
        {
            return "야옹";
        }
    }

    public class Trainer
    {
        public void DoCry(Animal animal) // 상속받은 객체 파라미터로 받음
        {
            Console.WriteLine("{0}", animal.Cry()); // Animal Cry 메서드
        }
    }

    class DemoTest
    {
        static void Main()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Console.WriteLine(dog.Cry());
            Console.WriteLine(cat.Cry());

            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());
        }
    }
}
