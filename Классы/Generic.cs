using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt
{
    public class Generic<T, S>
    {
        public T Id { get; set; }
        public S Name { get; set; }
        public Generic(T id, S name)
        {
            Id = id;
            Name = name;
        }
    }
}
