using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyProject.winforms.lotto
{
    static class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Rice rice = (new Cooking()).MakeRice();
            Soup soup = (new Cooking()).MakeSoup();
            Egg egg = (new Cooking()).MakeEgg();

            stopwatch.Stop();
            Console.WriteLine("Total time: " + stopwatch.ElapsedMilliseconds + "ms");
            Console.WriteLine("Synchronous Dinner is ready!");
        }
    }
}
