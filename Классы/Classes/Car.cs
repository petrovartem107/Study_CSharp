using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes
{
    public class Car
    {
        private protected string _model = "Volvo";
        int _price;
        //private int _yearOfMade;


        public int YearOfMade { get; set; }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Info
        {
            get { return $"{_model} стоит {_price}"; }
        }


        //public void ChangePrice(int x)
        //{
        //    _price = x;
        //}




        public Car(string x, int y)
        {
            _model = x;
            Price = y;
            YearOfMade = 3423;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {_model}, стоит: {_price}, год производства {YearOfMade}");
        }


        public static void CalcPlusShow(int x, int y)
        {
            Console.WriteLine($"{x + y}");
        }
    }
}
