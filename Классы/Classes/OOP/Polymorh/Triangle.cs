using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Polymorh
{
    public class Triangle : Figure
    {

        //s = Math. Sqrt (p(p-a)(p-b)(p-c))
        //p = (a+b+c)/2
        public int C { get; set; }
        public int D { get; set; }
        public Triangle(int A1, int b, int c) : base(A1)
        {
            C = c;
            D = b;
        }
        public int C1
        {
            get
            {
                int result = 0;
                int p = (A + D + C) / 2;
                int xxx = p * (p - A) * (p - D) * (p - C);

                double zzz = Math.Sqrt(Convert.ToDouble(xxx));
                result = Convert.ToInt32(zzz);

                return result;
            }
        }
        //public int c1
        //{
        //    get
        //    {
        //        int result = 0;
        //        result = (A+D+C)/2;
        //        return result;
        //    }
        //}

        public override void Show()
        {
            Console.WriteLine("Площать треугольника:" + C1);
        }
    }
}
