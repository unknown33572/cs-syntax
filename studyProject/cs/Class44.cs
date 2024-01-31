using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class Class44
	{
		static void Main()
		{
			string[] names = { ".Net", "Spring" };

			foreach(string name in names)
			{
				Console.WriteLine(name);
			}

			IEnumerator list = names.GetEnumerator();
			while(list.MoveNext())
			{
				Console.WriteLine(list.Current);
			}
		}
	}
}
