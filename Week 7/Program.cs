using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            player1.IncreaseScore(1);
            player2.IncreaseScore(10);

            Display(players);

            AddScores(players);


            players.Sort();
            players.Reverse();
            DisplayPlayerDetails(players);

            Console.WriteLine($"The highest score is: {Player.Highest}");

        }

        private static void AddScores(List<Player> players)
        {
            Console.WriteLine("Please enter number of player you wish to add score for");
            string response = Console.ReadLine();
            int playernumber = int.Parse(response);

            while (playernumber != 0)
            {
                Player selectedPlayer = players.ElementAt(playernumber - 1);

                selectedPlayer.IncreaseScore(1);

                Display(players);

                Console.WriteLine("Please enter number of player you wish to add score for");
                response = Console.ReadLine();
                playernumber = int.Parse(response);
            }
        }

        public static void Display(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            foreach(Player player in players)
            {
                Console.Write("{0,-10}", player.Score);
            }
            Console.WriteLine();
        }

        public static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
