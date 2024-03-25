using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
	class IEnumerator
	{
		static void Main()
		{
			string[] names = { ".Net", "Spring" };

			//foreach(string name in names)
			//{
			//	Console.WriteLine(name);
			//}

			System.Collections.IEnumerator list = names.GetEnumerator();
			while(list.MoveNext()) // MoveNext()는 다음 요소가 있으면 true 반환, 더 이상 요소가 없으면 false를 반환
			{
				Console.WriteLine(list.Current);
			}
		}
	}
}
