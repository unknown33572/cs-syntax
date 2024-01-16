using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    interface IStandard
    {
        void run();
    }

    class Car : IStandard
    {
        // Car Member Variables or field
        private string name;
        private string[] names;
        private readonly int length; // 읽기전용 필드

        public Car()
        {
            this.name = "Benz";
        }

        public Car(string name)
        {
            this.name = name;
        }

        public Car(int lengthParm)
        {
            this.Name = "BMW";
            length = lengthParm; // this 안붙여도 됨
            names = new string[length]; // 읽기전용 필드를 가리킴
        }

        public void run() => Console.WriteLine("{0} 차가 움직입니다.", name);

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Length
        {
            get { return length; }
        }

        ~Car()
        {
            Console.WriteLine("{0} 차가 멈췄습니다.", name);
        }

        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        public IEnumerator getEnumerator()
        {
            for(int i = 0; i < length; i++)
            {
                yield return names[i];
            }
        }

        public delegate void eventHandler();

        public event eventHandler click;

        public void onClick()
        {
            if(click != null)
            {
                click();
            }
        }
    }



    class Circuit
    {
        static void Main()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.run();

            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.run();
        }
    }
}
