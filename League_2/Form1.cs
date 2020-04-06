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
        }

        private void buttonPress(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case ("addPlayer"):
                    if (nameBox.Text.Length > 2)
                    {
                        dM.addPlayer(nameBox.Text);
                        nameBox.Clear();
                        UpdateListBox();
                    }
                    return;
            }
        }

        private void UpdateAll()
        {
            UpdateListBox();
            UpdateComboBox();
            UpdateTextFields();
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Player p in dM.getPlayerList())
            {
                listBox1.Items.Add(p.Print(dM.getCurrentWeek(), dM.getSettings()));
            }
        }
        private void UpdateComboBox()
        {

        }
        private void UpdateTextFields()
        {

        }
    }
}
