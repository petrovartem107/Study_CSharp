using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Polymorh
{
    public class Rectangle : Figure
    {
        public int B { get; set; }
        public Rectangle(int A1, int b) : base(A1)
        {
            B = b;
        }

        public int S
        {
            
            get 
            {
                //int B1;
                //int x;
                //int y;
                //return B1 = x*y; 


                int result = 0;
                result = A * B; 
                return result;
            }
        }
        public override void Show()
        {
           
            Console.WriteLine("Площадь прямоугольника:" + S);
        }
    }
}
