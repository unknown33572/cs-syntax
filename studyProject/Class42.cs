using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	interface ICar
	{
		void go();
	}

	class Car : ICar
	{
		public void go() => Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현함.");
	}

	class DemoTest
	{
		static void Main()
		{
			var car = new Car(); // 인터페이스는 인스턴스화 할 수 없으니 구현한 클래스로 인스턴스 객체 생성
			car.go();
		}
	}
}
