using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class Inheritance // 지정하지않으면 object 클래스 상속됨
	{
		public void Foo() => Console.WriteLine("Parent Class Called");

		public override string ToString()
		{
			return "개발자";
		}
	}

	class Inheritance_Child : Inheritance
  {
		public void Bar() => Console.WriteLine("Child Class Called");
	}

	class InheritanceDemo
	{
		static void Main()
		{
      Inheritance_Child child = new Inheritance_Child();

			child.Foo(); // 부모 클래스 메서드 사용가능
			child.Bar();

			WebDeveloper webDeveloper = new WebDeveloper();
			MobileDeveloper mobileDeveloper = new MobileDeveloper();
			ApplicationDeveloper applicationDeveloper = new ApplicationDeveloper();

			Console.WriteLine(webDeveloper.ToString());
			Console.WriteLine(mobileDeveloper.ToString());
			Console.WriteLine(applicationDeveloper.ToString());
		}
	}

	class WebDeveloper : Inheritance
  {
		public override string ToString()
		{
			return "웹개발자";
		}
	}

	class MobileDeveloper : Inheritance
  {
		public override string ToString()
		{
			return "모바일개발자";
		}
	}

	class ApplicationDeveloper : Inheritance
	{
		public override string ToString()
		{
			return "응용프로그램개발자";
		}
	}
}
