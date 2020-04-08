using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        //Spara och läs filer
        //Filnamn
        string file_name = null;
        //Filer att läsa in från.
        private string ser = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Inställningar_Liga.bin");
        private string serializationFile = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Spelare.bin");
        #endregion

        /*void Spara(string savePath)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Spara allt i {savePath}?", "Spara", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (Stream stream = File.Open(savePath, FileMode.Create))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        bformatter.Serialize(stream, spelareList);
                        MessageBox.Show($"Sparad i\n{savePath}");
                    }
                }
                using (Stream stream = File.Open(ser, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, inst);
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            UpdateList();
        }

        //Spara fil som...
        void SaveAs()
        {
            SaveFileDialog fil_save = new SaveFileDialog();
            if (file_name == null)
            {
                fil_save.FileName = "Ligaspelare.bin";
            }
            else
            {
                fil_save.FileName = file_name;
            }

            fil_save.Filter = "Binary file | *.bin";
            if (fil_save.ShowDialog(this) == DialogResult.OK)
            {
                string newpath = fil_save.InitialDirectory + fil_save.FileName;
                inst[0] = newpath;
                Spara(inst[0]);
            }
        }

        //Öppna fil
        void Open()
        {
            OpenFileDialog fil_load = new OpenFileDialog();
            fil_load.Filter = "Binary file | *.bin";
            if (fil_load.ShowDialog(this) == DialogResult.OK)
            {
                string newpath = fil_load.InitialDirectory + fil_load.FileName;
                inst[0] = newpath;
                Ladda(inst[0]);
            }
        }

        //Ladda Fil
        void Ladda(string savePath)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Är du säker på att du vill ladda:\n{savePath}?", "Ladda", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (Stream stream = File.Open(savePath, FileMode.Open))
                    {
                        file_name = savePath.Split('\\').Last();
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        spelareList = (List<Spelare>)bformatter.Deserialize(stream);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingen sparad fil hittad.");
            }
            finally
            {
                //Rensa allt
                listBox1.Items.Clear();
                UpdateList();
                UpdateList();
            }
        }*/
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
