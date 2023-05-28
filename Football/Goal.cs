using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Goal
    {
        public string Minute { get;private set; }
        public Football_Player Player { get;private set;}

        public Goal(string minute, Football_Player player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
