using ConsoleArt;
using ConsoleArt.Classes;
using ConsoleArt.Classes.OOP.Inheritance;
using ConsoleArt.Classes.OOP.Polymorh;
using Meth;
using System;

using System.Collections.Generic;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InvokeRun
            //RunCodeWars();
            //RunPeople();
            //RunCar(); 


            //RunNasledniki1();
            //RunUpCasting();
            //RunUpcastDowncast();
            //RunPolymorh();
            //RunFigures();
            //RunObject();
            #endregion
            Generic<string, string> sa = new Generic<string, string>("sasd", "sa");
            Generic<int, string> ssas = new Generic<int, string>(2222, "sadasda");




        }

        private static void RunObject()
        {
            string x = "Artem";
            string y = "Artem";

            if (x.GetHashCode() == y.GetHashCode())
            {
                Console.WriteLine("Значение одинаковые");
            }

            //Console.WriteLine(x.GetHashCode()) ;
            //Console.WriteLine(x.GetType());
        }

        private static void RunFigures()
        {
            //Figure figure = new Figure(1);
            //figure.Show();

            Rectangle rectangle = new Rectangle(5, 6);
            //rectangle.Show();

            Sque sque = new Sque(5);
            //sque.Show();

            Triangle triangle = new Triangle(3, 3, 3);
            //triangle.Show();
            triangle.GetType();

            //Figure figure = new Figure(22);
            //figure.Show();

            Figure[] figures = new Figure[] { rectangle, sque, triangle };

            foreach (var item in figures)
            {
                item.Show();
            }
        }

        private static void RunPolymorh()
        {
            Person person = new Person("Ваня");
            person.Print();

            Employee employee = new Employee("Игорь", "Яндекс");
            employee.Print();

            //Client client = new Client("Толя", "ВТБ");
            //client.Print();

            Manager manager = new Manager("Dima", "GNIVC", 30000);
            manager.Print();
        }
        private static void RunNasledniki1()
        {

            Person person = new Person("Tom");
            person.Print();   // Tom

            person = new Employee("Sam", "IBM");
            person.Print();   // Sam

        }
        private static void RunUpCasting()
        {
            Employee employee = new Employee("Tom", "Microsoft");
            Person person = employee;   // преобразование от Employee к Person
            person.Print();
            //Console.WriteLine(person.Name);


            Person bob = new Client("Bob", "ContosoBank");   // преобразование от Client к Person
            Console.WriteLine(bob.Name);

            object person1 = new Employee("Tom", "Microsoft");  // от Employee к object
            object person2 = new Client("Bob", "ContosoBank");  // от Client к object
            object person3 = new Person("Sam");
        }
        private static void RunUpcastDowncast()
        {
            Employee employee = new Employee("Tom", "Microsoft");
            Person person = employee;   // преобразование от Employee к Person

            //DownCasting
            //Employee employee2 = person;    // так нельзя, нужно явное преобразование
            Employee employee1 = (Employee)person;


            // Exception try/catch
            try
            {
                Person person21 = new Person("Bob");
                Employee employee2 = (Employee)person21; // ! Ошибка
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine("-----------AS---------------------------");

            // As
            Person person333 = new Person("Tom");
            Employee? employee333 = person333 as Employee;
            if (employee333 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(employee333.Company);
            }

            Console.WriteLine("------------IS--------------------------");
            // Is
            Person person1 = new Person("Bob");
            bool isEmployee = person1 is Employee;


            if (isEmployee)
            {
                Console.WriteLine("Все ок");
            }
            else
            {
                Console.WriteLine("Вернул false");
            }
        }



        #region RunMethods

        private static void RunCar()
        {
            Car bmw = new Car("x6", 5000000);
            Car vw = new Car("Passat", 3000000);

            bmw.YearOfMade = 2015;
            Console.WriteLine(bmw.YearOfMade);

            bmw.ShowInfo();

            //bmw.ShowInfo();
            //vw.ShowInfo();
        }
        private static void RunCodeWars()
        {
            int x = CodeWars.SumMul(5, 20);
            Console.WriteLine(x);
        }
        public static void RunPeople()
        {
            People artem = new People();
            artem.Name = "Dima";
            artem.Sname = "Vor";
            artem.Yers = 33;
            artem.Show();

            People people = new People("Artem");
            // people.Yers = 155; 
            people.Show();

            People people1 = new People("Artem", "Petrov");
            people1.Show();

            People people2 = new People("Artem", "Petrov", 150);
            people2.Show();

            People people3 = new People("Vanya", "Grigorev", 26, 45500);
            people3.Show();

            People[] peoples = new People[] { artem, people1, people2, people3 };
            foreach (People item in peoples)
            {
                Console.WriteLine(item.Name);
            }
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine(peoples[i].Sname);
            }
            List<People> peoples1 = new List<People>() { artem, people1, people2, people3 };
            foreach (People item in peoples1)
            {
                Console.WriteLine(item.SalaRy);
            }
            for (int i = 0; i < peoples1.Count; i++)
            {
                Console.WriteLine(peoples1[i].Yers);
            }


        }

        #endregion

    }
}

