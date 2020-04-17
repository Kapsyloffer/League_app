using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

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
        //Default path for saving files.
        //TODO: Create a registry key that keeps track of the last location of saved files are.
        private String filePath = "C:\\Users\\User\\Save.save";
        private Boolean hasPath = false;

        public DataManager()
        {
            //Read last save from registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LeagueAppLastSave"); 
            try
            {
                filePath = (string)key.GetValue("filePath");
                if (filePath != null)
                {
                    hasPath = true;
                    System.Windows.Forms.MessageBox.Show("owowowo");
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public Boolean getHasPath()
        {
            return hasPath;
        }

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
            this.setPath(nd.getPath());
            //Print out info about the save for debugging's sake.
            System.Windows.Forms.MessageBox.Show(
                $"PlayerList count: {nd.getPlayerList().Count()}\n" +
                $"Win points: {nd.getSettings().getWinPoint()}\n" +
                $"Loss points: {nd.getSettings().getLossPoint()}\n" +
                $"Current week: {nd.getCurrentWeek()}\n" +
                $"Max weeks: {nd.getMaxWeeks()}\n" +
                $"Path: {nd.getPath()}\n");
        }

        //filePath
        public String getPath()
        {
            return filePath;
        }

        public void setPath(String newPath)
        {
            filePath = newPath;
            //Set last saved key in registry
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\LeagueAppLastSave"); 
            key.SetValue("filePath", filePath);
            hasPath = true;
        }
    }
}
