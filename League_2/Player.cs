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
        private List<int> placement = new List<int>();
        //Ta emot namn och ID, then we let it all begin.
        public Player(String n, int ID)
        {
            this.name = n;
            this.ID = ID;
        }
        private void placementFailSafe(int w)
        {
            if (this.placement.Count <= w)
            {
                for (int i = 0; i <= w + 1; i++)
                {
                    this.placement.Add(0);
                }
            }
        }
        private void noteFailSafe(int w)
        {
            if (notes.Count <= w)
            {
                for (int i = 0; i <= w; i++)
                {
                    Note note = new Note("", i);
                    Boolean exists = false;
                    foreach (Note n in notes)
                    {
                        if (n.week() == i)
                        {
                            exists = true;
                        }
                    }
                    if (!exists)
                    {
                        //Om det inte finns någon note för denna vecka, lägg till en.
                        notes.Add(note);
                    }
                }
            }
        }
        public void setPlacement(int p, int w)
        {
            placementFailSafe(w);
            this.placement[w] = p;
        }
        public int getPlacement(int w)
        {
            placementFailSafe(w);
            return placement[w];
        }
        public String getNote(int w)
        {
            noteFailSafe(w);
            return $"{notes[w].getContent()}";
        }
        public void setNote(String s, int w)
        {
            notes[w].setContent(s);
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
        //Räkna wins för vecka w
        public int getWins(int w)
        {
            int wins = 0;
            foreach (Game g in games)
            {
                if (w == 0)
                {
                    if (g.getWinner() == this)
                    {
                        wins++;
                    }
                }
                else
                {
                    if (g.getWinner() == this && g.getWeek() == w)
                    {
                        wins++;
                    }
                }
            }
            return wins;
        }
        //Räkna losses för vecka w
        public int getLosses(int w)
        {
            int losses = 0;
            foreach (Game g in games)
            {
                if(w == 0)
                {
                    if (g.getWinner() != this)
                    {
                        losses++;
                    }
                }
                else
                {
                    if (g.getWinner() != this && g.getWeek() == w)
                    {
                        losses++;
                    }
                }
            }
            return losses;
        }
        //Räkna ut totalpoängen med alla wins och losses multiplicerat med respektive poäng.
        public int calculateScore(int w, Settings s)
        {
            //return score calculated using current settings & week
            return getWins(w) * s.getWinPoint() + getLosses(w) * s.getLossPoint();
        }
        //Förbereder en print för Listboxen i Form 1
        public String Print(int w, Settings s)
        {
            String printName = name;
            noteFailSafe(w);
            for (int i = printName.Count(); i <= 26; i++)
            {
                printName += " ";
            }
            return $"{getPlacement(w)+1}. {printName}\t(ID:{ID})\t\t{getWins(w)}/{getLosses(w)} \t {calculateScore(w, s)}\t{getNote(w)}";
        }
    }
}
