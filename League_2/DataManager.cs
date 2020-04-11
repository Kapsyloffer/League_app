using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Håll all data här. Läs och skriv allt här.
namespace League_2
{
    [Serializable]
    //Tillåter att klassen sparas och laddas.
    class DataManager
    {
        #region variables
        private List<Player> PlayerList = new List<Player>();
        private Settings LocalSettings = new Settings();
        private int currentWeek = 1;
        private int maxWeeks = 3;
        #endregion

       
        public List<Player> getPlayerList()
        {
            return PlayerList;
        }
        public void setPlayerList(List<Player> pl)
        {
            this.PlayerList = pl;
        }
        public void addPlayer(String n)
        {
            Player p = new Player(n, PlayerList.Count);
            PlayerList.Add(p);
        }
        public void setSettings(Settings s)
        {
            this.LocalSettings = s;
        }

        public Settings getSettings()
        {
            return LocalSettings;
        }

        public int getCurrentWeek()
        {
            return currentWeek;
        }
        public void setCurrentWeek(int w)
        {
            currentWeek = w;
            //System.Windows.Forms.MessageBox.Show($"Changed week to {w}");
        }
        public void setMaxWeeks(int m)
        {
            LocalSettings.setWeeks(m);
        }
        public int getMaxWeeks()
        {
            return LocalSettings.getWeeks();
        }

        public void setDM(DataManager nd)
        {
            this.setPlayerList(nd.getPlayerList());
            this.setSettings(nd.getSettings());
            this.setCurrentWeek(nd.getCurrentWeek());
            this.setMaxWeeks(nd.getMaxWeeks());
        }
    }
}
