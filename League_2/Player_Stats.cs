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
        public Player_Stats()
        {
            InitializeComponent();
        }
        public Player_Stats(Player p, int w, Settings s)
        {
            this.p = p;
            this.week = w;
            playerName.Text = p.getName();
            winCount.Text = $"{p.getWins(w)}";
            lossCount.Text = $"{p.getLosses(w)}";
            totalScore.Text = $"{p.calculateScore(w, s)}";
            //placement.Text = $"{p.getPlacement(w)}";

        }
        private void buttonPress(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case (""):
                    return;
            }
        }
    }
}
