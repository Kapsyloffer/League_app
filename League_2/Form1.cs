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
        private DataManager dM = new DataManager();
        public Form1()
        {
            InitializeComponent();
            UpdateAll();
        }

        private void buttonPress(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name);
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
                    return;
                case ("saveFile"):
                    dM.saveFile();
                    return;
                case ("loadFile"):
                    dM.loadFile();
                    return;

            }
        }

        private List<Player> SortList(List<Player> p, int w, Settings s)
        {
            List<Player> x = p;
            x.OrderBy(f => f.calculateScore(w, s));
            for(int i = 0; i<x.Count; i++)
            {
                //x[i].setPlacement(i+1, w);
            }
            return x;
        }
        public void UpdateAll()
        {
            UpdateListBox();
            UpdateComboBox();
            UpdateTextFields();
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            List<Player> sortedList = SortList(dM.getPlayerList(), dM.getCurrentWeek(), dM.getSettings());
            foreach (Player p in dM.getPlayerList())
            {
                listBox1.Items.Add(p.Print(dM.getCurrentWeek(), dM.getSettings()));
            }
        }
        private void UpdateComboBox()
        {
            comboWinner.Items.Clear();
            comboLoser.Items.Clear();
            comboWeek.Items.Clear();
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
            }
            //MessageBox.Show($"{dM.getCurrentWeek()}");
            comboWeek.SelectedIndex = dM.getCurrentWeek();

            //Add all players to the combobox
            foreach(Player p in dM.getPlayerList())
            {
                comboWinner.Items.Add($"(ID:{p.getID()}) {p.getName()}");
                comboLoser.Items.Add($"(ID:{p.getID()}) {p.getName()}");
            }

            if(dM.getPlayerList().Count()>=2)
            {
                comboWinner.Enabled = true;
                comboLoser.Enabled = true;
                addGame.Enabled = true;
            }
            else
            {
                comboWinner.Enabled = false;
                comboLoser.Enabled = false;
                addGame.Enabled = false;
            }
        }
        private void UpdateTextFields()
        {
            nameBox.Clear();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
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
