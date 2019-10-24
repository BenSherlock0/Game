using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    class Player : IComparable
    {
        public static int Count = 1;
        public static int Highest { get; private set; }
        public int PlayerID { get;}
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Player (int playerid, string playername,int score)
        {
            PlayerID = playerid;
            Count++;
            PlayerName = playername;
            Score = score;
        }

        public Player(int playerid, string playername) : this(playerid, playername, 0)
        {

        }
        public Player(int playerid) : this(playerid, "Unknown", 0)
        {

        }
        public Player() : this(Count, "Unknown", 0)
        {

        }

        public void IncreaseScore(int score)
        {
            Score += score;

            if (Score > Highest)
                Highest = Score;
        }

        public override string ToString()
        {
            return $"{PlayerID}\t{PlayerName}\t{Score}";
        }

        public int CompareTo(object obj)
        {
            Player compare = obj as Player;

            int returnvalue = this.Score.CompareTo(compare.Score);

            return returnvalue;
        }
    }
}
