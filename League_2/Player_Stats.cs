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
    [Serializable]
    internal partial class Player_Stats : Form
    {
        private Player player;
        private int week;
        private DataManager dM_new;
        //Öppna med en spelare
        public Player_Stats(Player p, DataManager d)
        {
            InitializeComponent();
            this.player = p;
            this.dM_new = d;
            refreshList();
            switchPlayer(player);
        }
        private void switchPlayer(Player p)
        {
            this.player = p;
            this.week = dM_new.getCurrentWeek();
            weekLabel.Text = $"{week}      ";
            playerName.Text = player.getName();
            winCount.Text = $"{player.getWins(dM_new.getCurrentWeek())}";
            lossCount.Text = $"{player.getLosses(dM_new.getCurrentWeek())}";
            totalScore.Text = $"{player.calculateScore(dM_new.getCurrentWeek(), dM_new.getSettings())}";
            placement.Text = $"{player.getPlacement(dM_new.getCurrentWeek())}";
            addNote.Text = $"Add note (week {dM_new.getCurrentWeek()})";
            textBox1.Text = player.getNote(week);
            playerList.Items.Clear();
            foreach (Player pp in dM_new.getPlayerList())
            {
                playerList.Items.Add(pp.Print(dM_new.getCurrentWeek(), dM_new.getSettings()));
            }
        }
        private void buttonPress(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case ("addNote"):
                    player.setNote(textBox1.Text, week);
                    MessageBox.Show("Note added.");
                    return;
                case ("addRare"):
                    player.addRare(rareInput.Text);
                    rareInput.Clear();
                    rareInput.Focus();
                    refreshList();
                    return;
                case ("changeName"):
                    if (playerName.Text.Length >= 2)
                    { 
                        player.setName(playerName.Text);
                        refreshList();
                        MessageBox.Show($"The name for ID:{player.getID()} has been changed to {player.getName()}!");
                    }
                    else
                    {
                        MessageBox.Show("The name you have selected is too short.");
                    }
                    return;
            }
        }

        private void PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switchPlayer(dM_new.getPlayerList()[playerList.SelectedIndex]);
                refreshList();
            }
            catch
            {
                //MessageBox.Show("Something went wrong. (switchPlayer(dM_new.getPlayerList()[playerList.SelectedIndex]);)");
            }
        }

        private void refreshList()
        {
            playerList.Items.Clear();
            rareList.Items.Clear();
            gameHistory.Items.Clear();
            foreach (Player pp in dM_new.getPlayerList())
            {
                playerList.Items.Add(pp.Print(dM_new.getCurrentWeek(), dM_new.getSettings()));
            }
            foreach(String rare in player.getRares())
            {
                rareList.Items.Add(rare);
            }
            foreach (Game g in player.getGames())
            {
                gameHistory.Items.Add(g.print(player));
            }
        }
    }
}
