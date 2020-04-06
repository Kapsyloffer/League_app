using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_2
{
    class DataManager
    {
        //Håll all data här. Läs och skriv allt här.
        private List<Player> PlayerList;
        private Settings LocalSettings;
        public List<Player> getPlayerList()
        {
            return PlayerList;
        }
        public void setPlayerList(List<Player> pl)
        {
            this.PlayerList = pl;
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
