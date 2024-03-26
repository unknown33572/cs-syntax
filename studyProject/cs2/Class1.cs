using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.cs2
{
    struct TenNum
    {
        public double t0, t1, t2, t3, t4, t5, t6, t7, t8, t9;
    }

    class Class1
    {
        private static double calc(TenNum tenNum)
        {
            return tenNum.t0 + tenNum.t1 + tenNum.t2 + tenNum.t3 + tenNum.t4 + tenNum.t5 + tenNum.t6 + tenNum.t7 + tenNum.t8 + tenNum.t9;
        }
    }
}
