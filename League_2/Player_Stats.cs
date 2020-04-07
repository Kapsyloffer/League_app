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
    internal partial class Player_Stats : Form
    {
        private Player p;
        private int week;
        public Player_Stats(Player p)
        {
            InitializeComponent();
            this.p = p;
            foreach (Game g in p.getGames())
            {
                gameHistory.Items.Add(g.print(p));
            }
            try
            {
                Form1 f = new Form1();
                this.week = f.dM.getCurrentWeek();
                weekLabel.Text = $"{week}      ";
                playerName.Text = p.getName();
                winCount.Text = $"{p.getWins(f.dM.getCurrentWeek())}";
                lossCount.Text = $"{p.getLosses(f.dM.getCurrentWeek())}";
                totalScore.Text = $"{p.calculateScore(f.dM.getCurrentWeek(), f.dM.getSettings())}";
                placement.Text = $"{p.getPlacement(f.dM.getCurrentWeek()) + 1}";
                addNote.Text = $"Add note (week {f.dM.getCurrentWeek()})";
                f.Close();
            }
            catch
            {
                MessageBox.Show("There was an error loading this form. :(");
            }
        }
        private void buttonPress(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case ("addNote"):
                    
                    return;
            }
        }
    }
}
