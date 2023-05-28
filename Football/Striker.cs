using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Striker : Football_Player
    {
        public Striker(string name, int age, string number, double height) : base(name, age, number, height)
        {
        }
    }
}
