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
        private List<Player> PlayerList;
        private Settings LocalSettings;
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

        public Settings GetSettings()
        {
            return LocalSettings;
        }

        public void LoadFile()
        {

        }

        public void SaveFile()
        {
            
        }
    }
}
