using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class LamdaOverride
	{
		public virtual void Hi1() => Console.WriteLine("기본 : 안녕");
		public void Hi2() => Console.WriteLine("기본 : 반가워");
		public void Hi3() => Console.WriteLine("기본 : 또 만나");
	}

	class LamdaOverride_Child : LamdaOverride
	{
		public override void Hi1()
		{
			Console.WriteLine("파생 : 다시 한 번 안녕");
		}

		public new void Hi2()
		{
			Console.WriteLine("파생 : 다시 한 번 반가워");
		}

		public new void Hi3() => Console.WriteLine("파생 : 다시 한 번 또 만나");
	}

	class DemoTest
	{
		static void Main()
		{
      LamdaOverride_Child _Child = new LamdaOverride_Child();
			LamdaOverride _Parent = new LamdaOverride();

			_Child.Hi1();
			_Child.Hi2();
			_Child.Hi3();

			_Parent.Hi1();
			_Parent.Hi2();
			_Parent.Hi3();
		}
	}
}
