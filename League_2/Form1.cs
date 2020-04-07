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
        private DataManager dM = new DataManager();
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
                    }
                    return;
                case ("addGame"):
                    //Checkar att allt är valid, och om de inte har spelat tidigare denna vecka så lägger vi till.
                    if(comboWinner.SelectedIndex== -1 || comboLoser.SelectedIndex == -1 || comboWinner.SelectedIndex == comboLoser.SelectedIndex)
                    {
                        MessageBox.Show("Please select different players.");
                        return;
                    }
                    Player Winner = dM.getPlayerList()[comboWinner.SelectedIndex];
                    Player Loser = dM.getPlayerList()[comboLoser.SelectedIndex];
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
                    dM.getSettings().Show();
                    dM.getSettings().Focus();
                    return;
                case ("saveFile"):
                    dM.saveFile();
                    return;
                case ("loadFile"):
                    dM.loadFile();
                    return;

            }
        }

        //Sortera listan med players efter poäng. (calculateScore)
        private List<Player> sortList(List<Player> p, int w, Settings s)
        {
            List<Player> x = p.OrderByDescending(z => z.calculateScore(w,s)).ToList();
            for(int i = 1; i<x.Count; i++)
            {
                x[i].setPlacement(i, w);
            }
            return x;
        }
        //Updatera all data på UI:n
        public void UpdateAll()
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
            List<Player> sortedList = sortList(dM.getPlayerList(), dM.getCurrentWeek(), dM.getSettings());
            foreach (Player p in sortedList)
            {
                listBox1.Items.Add(p.Print(dM.getCurrentWeek(), dM.getSettings()));
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
            List<Player> sortedList = sortList(dM.getPlayerList(), dM.getCurrentWeek(), dM.getSettings());
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
    }
}
