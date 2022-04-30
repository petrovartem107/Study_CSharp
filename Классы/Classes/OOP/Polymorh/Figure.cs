using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Polymorh
{
    public abstract class Figure
    {
        private int _a ;
        public int A
        {
            get { return _a; }
            set { _a = value; }
        }
        public Figure (int A1)
        {
            A = A1;
        }
        public virtual void Show()
        {
            Console.WriteLine("Вызов метода из базового класса");
        }
    }
}
