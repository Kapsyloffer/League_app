using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_2
{
    public partial class Form1 : Form
    {
        //Här inne ligger all data.
        internal DataManager dM = new DataManager();
        //Denna sparar och laddar allt.
        private SaveLoad s_l = new SaveLoad();
        public Form1()
        {
            InitializeComponent();
            UpdateAll();
        }
        //Switch för varje button på Form1 UI:n
        private void buttonPress(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case ("addPlayer"):
                    if (nameBox.Text.Length >= 2)
                    {
                        dM.addPlayer(nameBox.Text);
                        UpdateAll();
                        nameBox.Focus();
                    }
                    return;
                case ("addGame"):
                    //Checkar att allt är valid, och om de inte har spelat tidigare denna vecka så lägger vi till.
                    if(comboWinner.SelectedIndex== -1 || comboLoser.SelectedIndex == -1 || comboWinner.SelectedIndex == comboLoser.SelectedIndex)
                    {
                        MessageBox.Show("Please select different players.");
                        return;
                    }
                    List<Player> sortedList = sortList(dM.getPlayerList());
                    Player Winner = sortedList[comboWinner.SelectedIndex];
                    Player Loser = sortedList[comboLoser.SelectedIndex];
                    foreach(Game game in Winner.getGames())
                    {
                        if(game.getWinner() == Winner && game.getLoser() == Loser || game.getWinner() == Loser && game.getLoser() == Winner)
                        {
                            if(game.getWeek() == dM.getCurrentWeek())
                            {
                                MessageBox.Show("The game has already been played this week.");
                                return;
                            }
                        }
                    }
                    Game g = new Game(Winner, Loser, dM.getCurrentWeek());
                    UpdateAll();
                    return;
                case ("openSettings"):
                    SettingsUI s = new SettingsUI(dM);
                    s.ShowDialog();
                    s.Focus();
                    return;
                case ("saveFile"):
                    s_l.saveFile(dM);
                    return;
                case ("openFile"):
                    s_l.openFile(dM);
                    return;
                case ("viewProfile"):
                    try
                    {
                    Player_Stats curPlayer = new Player_Stats(sortList(dM.getPlayerList())[listBox1.SelectedIndex], dM);
                    curPlayer.ShowDialog();
                    curPlayer.Focus();
                    }
                    catch
                    {}
                    return;

            }
        }

        //Sortera listan med players efter poäng. (calculateScore)
        private List<Player> sortList(List<Player> p)
        {
            int w = dM.getCurrentWeek();
            Settings s = dM.getSettings();
            List<Player> x = p.OrderByDescending(z => z.calculateScore(w,s)).ToList();
            return x;
        }
        //Updatera all data på UI:n
        internal void UpdateAll()
        {
            UpdateListBox();
            UpdateComboBox();
            UpdateTextFields();

            //Ändrar den lilla texten över Standingsboxen
            if (dM.getCurrentWeek() > 0)
            {
                placementBox.Text = $"Standings (Week {dM.getCurrentWeek()})";
            }
            else
            {
                placementBox.Text = $"Standings (Total)";
            }
        }
        //Updaterar endast listboxes
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            List<Player> sortedList = sortList(dM.getPlayerList());
            int positionCounter = 1;
            foreach (Player p in sortedList)
            {
                p.setPlacement(positionCounter, dM.getCurrentWeek());
                listBox1.Items.Add(p.Print(dM.getCurrentWeek(), dM.getSettings()));
                positionCounter++;
            }
        }
        //Updaterar endast comboboxes
        private void UpdateComboBox()
        {
            comboWinner.Items.Clear();
            comboLoser.Items.Clear();
            comboWeek.Items.Clear();
            //Clear week och gör mer
            for (int i = 0; i <= dM.getMaxWeeks(); i++)
            {
                if (i == 0)
                {
                    comboWeek.Items.Add("Total");
                }
                else
                {
                    comboWeek.Items.Add(i);
                }

                try
                {
                    comboWeek.SelectedIndex = dM.getCurrentWeek();
                }
                catch
                {
                    comboWeek.SelectedIndex = -1;
                }
            }

            //Sort the list by score.
            List<Player> sortedList = sortList(dM.getPlayerList());
            //Add all players to the combobox
            foreach (Player p in sortedList)
            {
                comboWinner.Items.Add($"(ID:{p.getID()}) {p.getName()}");
                comboLoser.Items.Add($"(ID:{p.getID()}) {p.getName()}");
            }
            //Disable scores if checking totals or if too little players.
            if (dM.getPlayerList().Count() < 2 || dM.getCurrentWeek() == 0)
            {
                comboWinner.Enabled = false;
                comboLoser.Enabled = false;
                addGame.Enabled = false;
            }
            else
            {
                comboWinner.Enabled = true;
                comboLoser.Enabled = true;
                addGame.Enabled = true;
            }
        }

        //Updaterar endast textFields
        private void UpdateTextFields()
        {
            nameBox.Clear();
        }

        //Om t.ex. Veckan byter index (vecka, byt på en gång)
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            //Förhindra stackOverflow ifall vivalde samma vecka igen. Triggras även av UpdateAll()
            if(((ComboBox)sender).SelectedIndex == dM.getCurrentWeek())
            {
                return;
            }
            else
            {
                dM.setCurrentWeek(((ComboBox)sender).SelectedIndex);
                UpdateAll();
            }
        }
        //Om vi fokuserar på fönstret, refresha.
        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateAll();
        }
    }
}
