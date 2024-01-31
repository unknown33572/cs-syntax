using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class Class37
	{
		public delegate void EventHandler();

		public event EventHandler Click;

		public void OnClick()
		{
			if(Click != null)
			{
				Click();
			}
		}
	}

	class EventDemo
	{
		static void Main()
		{
			Class37 btn = new Class37();

			btn.Click += Hi1;
			btn.Click += Hi2;

			btn.OnClick();
		}

		static void Hi1() => Console.WriteLine("C#");
		static void Hi2() => Console.WriteLine("JAVA");
	}
}
