using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    class People
    {
        private string _name;
        string _sname;
        public int yers;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }
        public int Yers
        {
            get { return yers; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Столько люди не живут!");
                }
                else
                {
                    yers = value;
                }
            }
        }
        public int SalaRy { get; set; }
        public People(string a = "неизвестно", string b = "неизвестно", int c = 0, int d = 0)
        {
            Name = a;
            Sname = b;
            Yers = c;
            SalaRy = d;
        }

        public void Show()
        {
            Console.WriteLine($"Имя:{_name} Фамилия:{_sname} Возраст:{yers} Ваша зп:{SalaRy}");
        }
    }
}