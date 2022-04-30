using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Inheritance
{
    public class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public Person()
        //{

        //}
        public Person(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine("Имя: " + Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public override /*sealed*/ void Print()
        {
            Console.WriteLine("Имя: " + Name + " Компания: " + Company);
        }


        //public Employee(string name, string company) : base()    // ! Ошибка
        //{
        //    Name = name;
        //    Company = company;
        //}
    }



    class Manager : Employee
    {
        public int Salary { get; set; }
        public Manager(string name, string company, int salary) : base(name, company)
        {
            this.Salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Имя: " + Name + " Компания: " + Company + " ЗП: " + Salary);
        }
    }



    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }

        public override void Print()
        {
            Console.WriteLine("Имя: " + Name + " Банк: " + Bank);
        }
    }


}
