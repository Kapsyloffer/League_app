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
            winCount.Text = $"{player.getWins(dM_new)}";
            lossCount.Text = $"{player.getLosses(dM_new)}";
            totalScore.Text = $"{player.calculateScore(dM_new)}";
            placement.Text = $"{player.getPlacement(dM_new)}";
            addNote.Text = $"Add note (week {dM_new.getCurrentWeek()})";
            noteInput.Text = player.getNote(week);
            playerList.Items.Clear();
            foreach (Player pp in dM_new.getPlayerList())
            {
                playerList.Items.Add(pp.Print(dM_new));
            }
        }
        private void buttonPress(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                //If a note is added on that week.
                case ("addNote"):
                    player.setNote(noteInput.Text, week);
                    MessageBox.Show("Note added.");
                    return;
                //If a rare (Magic the gathering) is added.
                case ("addRare"):
                    player.addRare(rareInput.Text);
                    rareInput.Clear();
                    rareInput.Focus();
                    refreshList();
                    return;
                //Change the name on the selected player.
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
            catch{}
        }

        //Refresh everything on screen.
        private void refreshList()
        {
            if(player.getRares().Count>0)
            {
                removeRare.Enabled = true;
                lookup.Enabled = true;
            }
            else
            {
                removeRare.Enabled = false;
                lookup.Enabled = false;
            }
            //Clear all
            playerList.Items.Clear();
            rareList.Items.Clear();
            gameHistory.Items.Clear();
            //Set all
            foreach (Player pp in dM_new.getPlayerList())
            {
                playerList.Items.Add(pp.Print(dM_new));
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

        //Jag vet att detta är hella fult, but what can you do?
        private void NameBox_TextChanged(object sender, KeyEventArgs e)
        {
            //Om vi trycker enter i textboxen, lägg till spelare.
            if (e.KeyCode == Keys.Enter)
            {
                switch (((TextBox)sender).Name)
                {
                    case ("playerName"):
                        changeName.PerformClick();
                        e.SuppressKeyPress = true;
                        return;
                    case ("rareInput"):
                        addRare.PerformClick();
                        e.SuppressKeyPress = true;
                        return;
                    case ("noteInput"):
                        addNote.PerformClick();
                        e.SuppressKeyPress = true;
                        return;
            }
            }
        }
    }
}
