using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_2
{
    class Player
    {
        private String name;
        private int ID;
        private List<String> rares = new List<String>();
        private List<Game> games = new List<Game>();
        private List<Note> notes = new List<Note>();
        
        public Player(String n, int ID)
        {
            this.name = n;
            this.ID = ID;
        }
        public void setName(String n)
        {
            this.name = n;
        }
        public String getName()
        {
            return name;
        }

        public int getID()
        {
            return ID;
        }

        public void addRare(String s)
        {
            rares.Add(s);
        }

        public void addGame(Game g)
        {
            games.Add(g);
        }

        public List<Game> getGames()
        {
            return games;
        }

        //TODO: if w = 0, show for all games.
        public int getWins(int w)
        {
            //TODO: foreach game where week is w and winner is you, add setting.scorewinner
            return 3;
        }
        public int getLosses(int w)
        {
            //TODO: foreach game where week is w and loser is you, add setting.scoreloser
            return 2;
        }

        public int calculateScore(int w)
        {
            //return score;
            return this.getWins(w) + this.getLosses(w);
        }
    }
}
