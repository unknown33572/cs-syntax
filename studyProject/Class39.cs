using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class Class39
	{

	}
	public class Car
	{
		private string name;
		public Car(string name)
		{
			this.name = name;
		}

		public void Run() => Console.WriteLine($"{this.name}가 달립니다.");
	}

	public sealed class HyundaiCar : Car
	{
		public HyundaiCar() : this("현대 자동차")
		{

		}
		public HyundaiCar(string name) : base(name)
		{

		}
	}

	public class GenesisCar : HyundaiCar //sealed 키워드로 인해 상속불가
	{

	}

	class BaseKeywordDemo
	{
		static void Main()
		{
			(new HyundaiCar()).Run();
			(new HyundaiCar("제네시스 자동차")).Run();
		}
	}
}
