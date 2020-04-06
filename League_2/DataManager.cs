using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Håll all data här. Läs och skriv allt här.
namespace League_2
{
    //Tillåter att klassen sparas och laddas.
    [Serializable]
    class DataManager
    {
        #region variables
        private List<Player> PlayerList = new List<Player>();
        private Settings LocalSettings = new Settings();
        private int currentWeek = 1;
        private int maxWeeks = 3;
        private Form1 f;
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
            System.Windows.Forms.MessageBox.Show(PlayerList.ToString());
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

        public int getMaxWeeks()
        {
            return maxWeeks;
        }

        public void loadFile()
        {

        }

        public void saveFile()
        {
            
        }
    }
}
