using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Goalkeeper : Football_Player
    {
        public Goalkeeper(string name, int age, string number, double height) : base(name, age, number, height)
        {
        }
    }
}
