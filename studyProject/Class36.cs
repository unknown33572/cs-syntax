using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
  class Class36
  {
    static Action<string> printfCustom = Console.WriteLine;

    static Func<int, int> absCustom() => Math.Abs;

    static void Main()
		{
      int x = 1;
      int y = 2;
      int z = x + y;

      Console.WriteLine(z);

      printfCustom(z.ToString());

      Console.WriteLine(absCustom()(-100));

      int[] arr = { 2, 4, 1, 7, 12, 15 };
      InsertionSort(arr);
      Console.WriteLine(String.Join(", ", arr));
		}

    static void InsertionSort(int[] arr)
		{
      for(int i = 1; i < arr.Length; i++)
			{
        int key = arr[i];
        int j = i - 1;

        while(j >= 0 && arr[j] > key)
				{
          arr[j + 1] = arr[j];
          j = j - 1;
				}

        arr[j + 1] = key;
			}
		}
  }
}