using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	public abstract class Class40
	{
		public abstract double GetArea();
	}

	public class Square : Class40
	{
		private int size;

		public int Size
		{
			get { return this.size; }
			set { this.size = value; }
		}

		public Square() { }
		public Square(int size)
		{
			this.size = size;
		}

		public override double GetArea()
		{
			return size * size;
		}
	}
	public class Demo
	{
		public static void Main()
		{
			Square square = new Square();
			square.Size = 10;
			double area = square.GetArea();
			Console.WriteLine(area);
		}
	}
}
