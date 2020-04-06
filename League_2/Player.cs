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
            int wins = 0;
            foreach(Game g in games)
            {
                if(g.getWinner() == this && g.getWeek() == w)
                {
                    wins++;
                }
            }
            return wins;
        }
        public int getLosses(int w)
        {
            int losses = 0;
            foreach (Game g in games)
            {
                if (g.getWinner() != this && g.getWeek() == w)
                {
                    losses++;
                }
            }
            return losses;
        }

        public int calculateScore(int w, Settings s)
        {
            //return score calculated using current settings & week
            return getWins(w) * s.getWinPoint() + getLosses(w) * s.getLossPoint();
        }

        public String Print(int w, Settings s)
        {
            String printName = name;
            //Ser till så att det finns Notes för alla veckor.
            if (notes.Count <= w)
            {
                for(int i = 0; i<=w; i++)
                {
                    Note note = new Note("", i);
                    Boolean exists = false;
                    foreach(Note n in notes)
                    {
                        if(n.week() == i)
                        {
                            exists = true;
                        }
                    }
                    if(!exists)
                    {
                        //Om det inte finns någon note för denna vecka, lägg till en.
                        notes.Add(note);
                    }
                }
            }
            for (int i = printName.Count(); i <= 24; i++)
            {
                printName += " ";
            }
            return $"{ID}. {printName}\t\t\t\t {getWins(w)}/{getLosses(w)} \t {calculateScore(w, s)} {notes[w].getNote()}";
        }
    }
}
