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
    public partial class Settings : Form
    {
        private int winPoints;
        private int lossPoints;
        private int weeks;
        public Settings()
        {
            InitializeComponent();
            //set default values
            this.winPoints = 3;
            this.lossPoints = 2;
            this.weeks = 3;
        }

        public int getLossPoint()
        {
            return lossPoints;
        }
        public int getWinPoint()
        {
            return lossPoints;
        }
    }
}
