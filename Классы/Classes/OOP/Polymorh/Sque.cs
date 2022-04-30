using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Polymorh
{
    public class Sque : Figure
    {
        //public int C { get; set; }
        public Sque(int A1) : base(A1)
        {

        }


        public int S
        {
            get
            {
                int result = 0;
                result = A*A;
                return result;
            }
        }
        public override void Show()
        {
            Console.WriteLine("Площадь квадрата:" + S);
        }
    }
}
