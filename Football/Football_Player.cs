using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Football_Player : Person
    {
        public string Number { get; private set; }
        public double Height { get; private set; }
        public Football_Player(string name, int age, string number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
