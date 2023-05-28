using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        public Coach Coach { get; private set; }
        public List<Football_Player> Players { get; private set; }
        public string Name { get; private set; }

        public Team(Coach coach, List<Football_Player> players, string name)
        {
            if (players.Count() < 11 || players.Count() > 22) throw new Exception();

            Coach = coach;
            Players = players;
            Name = name;
        }

        public double AverageAge()
        {
            double averageAge = 0;
            foreach (Football_Player player in Players)
            {
                averageAge += player.Age;
            }
            return averageAge / Players.Count();
        }
    }
}
