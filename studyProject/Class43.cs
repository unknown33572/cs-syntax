using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	interface IDog
	{
		void Eat();
	}

	interface ICat
	{
		void Eat();
	}

	class Pet : IDog, ICat
	{
		void IDog.Eat() => Console.WriteLine("개가 먹는다.");
		void ICat.Eat() => Console.WriteLine("고양이가 먹는다.");
	}

	class DemoTest
	{
		static void Main()
		{
			Pet pet = new Pet();
			((IDog)pet).Eat();
			((ICat)pet).Eat();

			IDog dog = new Pet();
			ICat cat = new Pet();

			dog.Eat();
			cat.Eat();
		}
	}
}
