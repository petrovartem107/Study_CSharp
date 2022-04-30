using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt
{
    abstract class Transport
    {
        public abstract void Move();
    }
    // класс корабля
    class Ship : Transport
    {
        // мы должны реализовать все абстрактные методы и свойства базового класса
        public override void Move()
        {
            Console.WriteLine("Корабль плывет");
        }
    }
    // класс самолета
    class Aircraft : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Самолет летит");
        }
    }
    // класс машины
    class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
