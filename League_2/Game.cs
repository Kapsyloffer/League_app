using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_2
{
    [Serializable]
    class Game
    {
        private Player winner;
        private Player loser;
        private int week;

        //Skapar ett objekt Game som innehåller vinnare, förlorare, och veckan matchen spelades.
        public Game(Player W, Player L, int week)
        {
            this.winner = W;
            this.loser = L;
            this.week = week;
            winner.addGame(this);
            loser.addGame(this);
        }
        //Printar om win eller loss i Player_Stats.cs
        public String print(Player p)
        {
            if(p == winner)
            {
                return $"[W][ {week} ]: {loser.getName()}";
            }
            else
            {
                return $"[L][ {week} ]: {winner.getName()}";
            }
        }
        public Player getWinner()
        {
            return winner;
        }
        public Player getLoser()
        {
            return loser;
        }
        public int getWeek()
        {
            return week;
        }
    }
}
