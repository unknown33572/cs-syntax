using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class EventHandler
	{
		public delegate void eventHandlerDelegate();

		public event eventHandlerDelegate Click;

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
			EventHandler btn = new EventHandler();

			btn.Click += Hi1;
			btn.Click += Hi2;

			btn.OnClick();
		}

		static void Hi1() => Console.WriteLine("C#");
		static void Hi2() => Console.WriteLine("JAVA");
	}
}
