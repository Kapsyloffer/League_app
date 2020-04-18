using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace League_2
{
    public partial class Form1 : Form
    {
        //Här inne ligger all data.
        internal DataManager dM = new DataManager();
        //Denna sparar och laddar allt.
        private SaveLoad sL = new SaveLoad();

        //Konstruktorn; används inte förutom on start.
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
                //Add player; players may share name as the list is ID based.
                case ("addPlayer"):
                    if (nameBox.Text.Length >= 2)
                    {
                        dM.addPlayer(nameBox.Text);
                        UpdateAll();
                    }
                    nameBox.Focus();
                    return;

                //Ett game är definierat som en match med en förlorare och en vinnare.
                case ("addGame"):
                    //Checkar att allt är valid, och om de inte har spelat tidigare denna vecka så lägger vi till.
                    if (comboWinner.SelectedIndex== -1 || comboLoser.SelectedIndex == -1 || comboWinner.SelectedIndex == comboLoser.SelectedIndex)
                    {
                        MessageBox.Show("Please select different players.");
                        return;
                    }
                    //Sorterar listan enligt hur den är utskriven i comboboxarna och använder
                    //sig av indexet för att ta spelarna. Funkar flawless hitills.
                    List<Player> sortedList = sortList(dM.getPlayerList());
                    Player Winner = sortedList[comboWinner.SelectedIndex];
                    Player Loser = sortedList[comboLoser.SelectedIndex];

                    //Confirm if you want to register just this game. (safety check)
                    DialogResult dr = MessageBox.Show($"Winner:{Winner.getName()}\nLoser:{Loser.getName()}\nWeek:{dM.getCurrentWeek()}", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        UpdateAll();
                        return;
                    }

                    //Säkerhetskoll för att se om det finns dubletter per vecka.
                    foreach (Game game in Winner.getGames())
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
                //Spara och ladda ligger i SaveLoad klassen.
                case ("saveFile"):
                    if (dM.getHasPath() && sL.thisFileExists())
                    {
                        sL.saveFile(dM);
                    }
                    else
                    {
                        sL.saveAs(dM);
                    }
                    return;
                case ("openFile"):
                        sL.openFile(dM);
                    return;
                case ("openLatest"):
                        sL.openLatest(dM);
                    return;
                case ("saveAs"):
                        sL.saveAs(dM);
                    return;
                case ("viewProfile"):
                    try
                    {
                        Player_Stats curPlayer = new Player_Stats(sortList(dM.getPlayerList())[listBox1.SelectedIndex], dM);
                        curPlayer.ShowDialog();
                        curPlayer.Focus();
                    }
                    catch{}
                    return;

            }
        }

        //Sortera listan med players efter poäng. (calculateScore)
        private List<Player> sortList(List<Player> p)
        {
            int w = dM.getCurrentWeek();
            Settings s = dM.getSettings();
            List<Player> x = p.OrderByDescending(z => z.calculateScore(dM)).ToList();
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
            if(!dM.getHasPath())
            {
                openLatest.Enabled = false;
            }
            else
            {
                openLatest.Enabled = true;
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
                listBox1.Items.Add(p.Print(dM));
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

        private void NameBox_TextChanged(object sender, KeyEventArgs e)
        {
            //Om vi trycker enter i textboxen, lägg till spelare.
            if (e.KeyCode == Keys.Enter)
            {
                addPlayer.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dialog Box
            DialogResult dr = MessageBox.Show("Save before exiting?", "Exit", MessageBoxButtons.YesNoCancel);

            //Ask if you want to save progress
            switch (dr)
            {
                //Yes saves and exits, no exits, cancel does not close.
                case DialogResult.Yes:
                    saveFile.PerformClick();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true ;
                    break;
            }
        }
    }
}
