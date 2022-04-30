using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meth

{
    public static class StaticMethods
    {
        public static void CalcPlusShow(int x, int y)
        {
            //Console.WriteLine($"{x+y}");
            Console.WriteLine($"{x + y}");
        }

        public static void CalcMinusShow(int x, int y)
        {
            //Console.WriteLine($"{x+y}");
            Console.WriteLine($"{x - y}");
        }
        public static void CalcMultiplayShow(int x, int y)
        {
            //Console.WriteLine($"{x+y}");
            Console.WriteLine($"{x * y}");
        }

    }
}
