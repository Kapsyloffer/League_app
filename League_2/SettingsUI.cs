using System;
using System.Windows.Forms;

namespace League_2
{
    partial class SettingsUI : Form
    {
        private DataManager dM;
        public SettingsUI(DataManager d)
        {
            InitializeComponent();
            this.dM = d;
            //set all of the values-
            winPoint.Value = dM.getSettings().getWinPoint();
            lossPoint.Value = dM.getSettings().getLossPoint();
            maxWeeks.Value = dM.getSettings().getWeeks();
        }
        private void buttonPress(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case ("saveSettings"):
                    pushSettings();
                    return;
                case ("cancel"):
                    this.Close();
                    return;
            }
        }

        //Apply all settings set by the user.
        public void pushSettings()
        {
            Settings s = dM.getSettings();
            s.setWinPoint((int)winPoint.Value);
            s.setLossPoint((int)lossPoint.Value);
            s.setWeeks((int)maxWeeks.Value);
            MessageBox.Show("Settings saved successfully!");
            this.Close();
        }
    }
}
