using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public List<Referee> AssistantReferee { get; private set; }
        public List<Goal> GoalsT1 { get; private set; }
        public List<Goal> GoalsT2 { get; private set; }
        public Team Winner { get; private set; }

        public Game(Team team1, Team team2, Referee referee, List<Referee> assistantRef)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee = assistantRef;
            GoalsT1 = new List<Goal>();
            GoalsT2 = new List<Goal>();
            Winner = null;
        }
        public void AddGoalT1(string Number, string Minute)
        {
            GoalsT1.Add(new Goal(Minute, Team1.Players.Find(x => x.Number.Equals(Number))));
        }
        public void AddGoalT2(string Number, string Minute)
        {
            GoalsT2.Add(new Goal(Minute, Team2.Players.Find(x => x.Number.Equals(Number))));
        }

        public string GameResult()
        {
            if (GoalsT1.Count() == GoalsT2.Count())
            {
                return "Its a draw!!!!";
            }
            if (GoalsT1.Count() < GoalsT2.Count())
            {
                Winner = Team2;
                return $"The winners is {Winner.Name} with {GoalsT2.Count()} goal/s!!!";
            }
            Winner = Team1;

            return $"The winners is {Winner.Name} with {GoalsT1.Count()} goal/s!!!";
        }

        internal void NewGoal()
        {
            Console.WriteLine("Choose a team");
            Console.WriteLine("Enter 1 for " + Team1.Name);
            Console.WriteLine("Enter 2 for " + Team2.Name);
            int choice = Convert.ToInt32(Console.ReadLine());
            string minute;
            string num;
            switch (choice)
            {
                case 1:
                    Console.Write("Enter minute: ");
                    minute = Console.ReadLine();
                    Console.Write("Emter number of player: ");
                    num = Console.ReadLine();
                    AddGoalT1(num, minute);
                    break;
                case 2:
                    Console.Write("Enter minute: ");
                    minute = Console.ReadLine();
                    Console.Write("Emter number of player: ");
                    num = Console.ReadLine();
                    AddGoalT2(num, minute);
                    break;
                default: Console.WriteLine("error"); break;
            }
        }

        internal void ListOfPlayers()
        {
            Console.WriteLine("Choose a team");
            Console.WriteLine("Enter 1 for " + Team1.Name);
            Console.WriteLine("Enter 2 for " + Team2.Name);
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Team {0} players:", Team1.Name);
                    foreach (Football_Player player in Team1.Players)
                    {
                        Console.WriteLine($"Player No:{player.Number} is {player.Name}, age: {player.Age}, height: {player.Height}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Team {0} players:", Team2.Name);
                    foreach (Football_Player player in Team2.Players)
                    {
                        Console.WriteLine($"Player No:{player.Number} is {player.Name}, age: {player.Age}, height: {player.Height}");
                    }
                    break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
