using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class Class41
	{
		public virtual void Hi1() => Console.WriteLine("기본 : 안녕");
		public void Hi2() => Console.WriteLine("기본 : 반가워");
		public void Hi3() => Console.WriteLine("기본 : 또 만나");
	}

	class Class41_Child : Class41
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
			Class41_Child class41_Child = new Class41_Child();

			class41_Child.Hi1();
			class41_Child.Hi2();
			class41_Child.Hi3();
		}
	}
}
