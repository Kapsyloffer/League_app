using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Håll all data här. Läs och skriv allt här.
namespace League_2
{
    //Tillåter att klassen sparas och laddas.
    [Serializable]
    //DataManager håller i all viktig data. Till skillnad från det tidigare programmet som-
    //Hade saves all over the place. Lättare att hålla koll på.
    class DataManager
    {
        private List<Player> PlayerList = new List<Player>();
        private Settings LocalSettings = new Settings();
        //Sparar nuvarande vecka för att förhindra förvirring on load. (feedback)
        private int currentWeek = 1;

        //Lägg till en ny spelare i listan
        public void addPlayer(String n)
        {
            Player p = new Player(n, PlayerList.Count);
            PlayerList.Add(p);
        }
       
        //Getters och setters nedan
        //Listan med spelare
        public List<Player> getPlayerList()
        {
            return PlayerList;
        }
        public void setPlayerList(List<Player> pl)
        {
            this.PlayerList = pl;
        }
        
        //Inställningar
        public Settings getSettings()
        {
            return LocalSettings;
        }
        public void setSettings(Settings s)
        {
            this.LocalSettings = s;
        }

        //Veckor
        public int getCurrentWeek()
        {
            return currentWeek;
        }
        public void setCurrentWeek(int w)
        {
            currentWeek = w;
        }
        public int getMaxWeeks()
        {
            return LocalSettings.getWeeks();
        }
        public void setMaxWeeks(int m)
        {
            LocalSettings.setWeeks(m);
        }
         
        //Om en ny DataManager laddas in, sätt alla viktiga värden.
        public void setDM(DataManager nd)
        {
            this.setPlayerList(nd.getPlayerList());
            this.setSettings(nd.getSettings());
            this.setCurrentWeek(nd.getCurrentWeek());
            this.setMaxWeeks(nd.getMaxWeeks());
        }
    }
}
