using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team t1 = new Team(new Coach("Person One", 45), new List<Football_Player> { new Striker("John", 25, "9", 1.85),
                new Midfield("James", 28, "7", 1.80),
                new Midfield("Andrew", 26, "8", 1.77),
                new Midfield("Michael", 24, "11", 1.79),
                new Midfield("George", 24, "10", 1.86),
                new Defender("Robert", 29, "4", 1.83),
                new Defender("William", 30, "5", 1.85),
                new Defender("Daniel", 27, "3", 1.81),
                new Defender("Joseph", 25, "2", 1.78),
                new Defender("Thomas", 26, "6", 1.84),
                new Goalkeeper("Benjamin", 32, "1", 1.90) }, "Team 1");

            Team t2 = new Team(new Coach("Person Two", 50), new List<Football_Player> { new Striker("Harry", 24, "11", 1.86),
                new Midfield("Matthew", 27, "7", 1.79),
                new Midfield("Christopher", 25, "8", 1.77),
                new Midfield("Andrew", 23, "10", 1.83),
                new Defender("Alexander", 28, "4", 1.85),
                new Defender("Ryan", 30, "5", 1.82),
                new Defender("William", 29, "3", 1.80),
                new Defender("David", 27, "2", 1.77),
                new Defender("Joseph", 25, "6", 1.84),
                new Midfield("Eguene", 24, "9", 1.88),
                new Goalkeeper("Daniel", 33, "1", 1.91) }, "Team 2");

            Game g1 = new Game(t1, t2, new Referee("Ref 1", 37), new List<Referee> { new Referee("Ref 2", 27), new Referee("Ref 3", 41) });

            int command = 0;
            do
            {
                Console.WriteLine("Enter 1 for registering a new goal");
                Console.WriteLine("Enter 2 for results");
                Console.WriteLine("Enter 3 for list of players");
                Console.WriteLine("Enter 0 for exit");
                Console.Write("Your choice: ");
                command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1: g1.NewGoal(); break;
                    case 2: Console.WriteLine(g1.GameResult()); command = 0; break;
                    case 3: g1.ListOfPlayers(); break;
                }
            } while (command != 0);
            Console.ReadLine();
        }
    }
}
