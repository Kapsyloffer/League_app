namespace League_2
{
    partial class Player_Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Stats));
            this.gameHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.lossCount = new System.Windows.Forms.Label();
            this.winCount = new System.Windows.Forms.Label();
            this.statGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lookup = new System.Windows.Forms.Button();
            this.removeRare = new System.Windows.Forms.Button();
            this.addRare = new System.Windows.Forms.Button();
            this.rareInput = new System.Windows.Forms.TextBox();
            this.rareList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.noteInput = new System.Windows.Forms.TextBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.placement = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.statGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameHistory
            // 
            this.gameHistory.Font = new System.Drawing.Font("Consolas", 8F);
            this.gameHistory.FormattingEnabled = true;
            this.gameHistory.Location = new System.Drawing.Point(9, 36);
            this.gameHistory.Name = "gameHistory";
            this.gameHistory.Size = new System.Drawing.Size(229, 290);
            this.gameHistory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Match History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Showing stats for:";
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.weekLabel.Location = new System.Drawing.Point(657, 35);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(70, 49);
            this.weekLabel.TabIndex = 4;
            this.weekLabel.Text = "99";
            this.weekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lossCount
            // 
            this.lossCount.AutoSize = true;
            this.lossCount.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lossCount.Location = new System.Drawing.Point(324, 278);
            this.lossCount.Name = "lossCount";
            this.lossCount.Size = new System.Drawing.Size(70, 49);
            this.lossCount.TabIndex = 5;
            this.lossCount.Text = "99";
            this.lossCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winCount
            // 
            this.winCount.AutoSize = true;
            this.winCount.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winCount.ForeColor = System.Drawing.Color.Green;
            this.winCount.Location = new System.Drawing.Point(254, 278);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(70, 49);
            this.winCount.TabIndex = 6;
            this.winCount.Text = "99";
            this.winCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statGroup
            // 
            this.statGroup.Controls.Add(this.label5);
            this.statGroup.Controls.Add(this.lookup);
            this.statGroup.Controls.Add(this.removeRare);
            this.statGroup.Controls.Add(this.addRare);
            this.statGroup.Controls.Add(this.rareInput);
            this.statGroup.Controls.Add(this.rareList);
            this.statGroup.Controls.Add(this.label1);
            this.statGroup.Controls.Add(this.addNote);
            this.statGroup.Controls.Add(this.noteInput);
            this.statGroup.Controls.Add(this.totalScore);
            this.statGroup.Controls.Add(this.label9);
            this.statGroup.Controls.Add(this.label8);
            this.statGroup.Controls.Add(this.label7);
            this.statGroup.Controls.Add(this.gameHistory);
            this.statGroup.Controls.Add(this.winCount);
            this.statGroup.Controls.Add(this.lossCount);
            this.statGroup.Controls.Add(this.label2);
            this.statGroup.Location = new System.Drawing.Point(13, 84);
            this.statGroup.Name = "statGroup";
            this.statGroup.Size = new System.Drawing.Size(425, 425);
            this.statGroup.TabIndex = 7;
            this.statGroup.TabStop = false;
            this.statGroup.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rares";
            // 
            // lookup
            // 
            this.lookup.Enabled = false;
            this.lookup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lookup.Location = new System.Drawing.Point(329, 163);
            this.lookup.Name = "lookup";
            this.lookup.Size = new System.Drawing.Size(80, 39);
            this.lookup.TabIndex = 20;
            this.lookup.Text = "Lookup (scryfall)";
            this.lookup.UseVisualStyleBackColor = true;
            this.lookup.Click += new System.EventHandler(this.buttonPress);
            // 
            // removeRare
            // 
            this.removeRare.Enabled = false;
            this.removeRare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeRare.Location = new System.Drawing.Point(244, 163);
            this.removeRare.Name = "removeRare";
            this.removeRare.Size = new System.Drawing.Size(80, 39);
            this.removeRare.TabIndex = 19;
            this.removeRare.Text = "Remove rare";
            this.removeRare.UseVisualStyleBackColor = true;
            this.removeRare.Click += new System.EventHandler(this.buttonPress);
            // 
            // addRare
            // 
            this.addRare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRare.Location = new System.Drawing.Point(338, 234);
            this.addRare.Name = "addRare";
            this.addRare.Size = new System.Drawing.Size(71, 27);
            this.addRare.TabIndex = 18;
            this.addRare.Text = "Add rare";
            this.addRare.UseVisualStyleBackColor = true;
            this.addRare.Click += new System.EventHandler(this.buttonPress);
            // 
            // rareInput
            // 
            this.rareInput.Location = new System.Drawing.Point(244, 208);
            this.rareInput.MaxLength = 20;
            this.rareInput.Name = "rareInput";
            this.rareInput.Size = new System.Drawing.Size(165, 20);
            this.rareInput.TabIndex = 17;
            this.rareInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameBox_TextChanged);
            // 
            // rareList
            // 
            this.rareList.Font = new System.Drawing.Font("Consolas", 8F);
            this.rareList.FormattingEnabled = true;
            this.rareList.Location = new System.Drawing.Point(244, 36);
            this.rareList.Name = "rareList";
            this.rareList.Size = new System.Drawing.Size(165, 121);
            this.rareList.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note:";
            // 
            // addNote
            // 
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Location = new System.Drawing.Point(133, 370);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(105, 41);
            this.addNote.TabIndex = 14;
            this.addNote.Text = "Add note (week x)";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.buttonPress);
            // 
            // noteInput
            // 
            this.noteInput.Location = new System.Drawing.Point(9, 344);
            this.noteInput.MaxLength = 20;
            this.noteInput.Name = "noteInput";
            this.noteInput.Size = new System.Drawing.Size(230, 20);
            this.noteInput.TabIndex = 13;
            this.noteInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameBox_TextChanged);
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.Location = new System.Drawing.Point(254, 344);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(70, 49);
            this.totalScore.TabIndex = 12;
            this.totalScore.Text = "99";
            this.totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Score:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Losses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Wins";
            // 
            // placement
            // 
            this.placement.AutoSize = true;
            this.placement.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.placement.Location = new System.Drawing.Point(581, 35);
            this.placement.Name = "placement";
            this.placement.Size = new System.Drawing.Size(70, 49);
            this.placement.TabIndex = 11;
            this.placement.Text = "99";
            this.placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(575, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Placement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(663, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Week:";
            // 
            // changeName
            // 
            this.changeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeName.Location = new System.Drawing.Point(156, 16);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(94, 23);
            this.changeName.TabIndex = 16;
            this.changeName.Text = "Change name";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.Click += new System.EventHandler(this.buttonPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerList);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(444, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 422);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Consolas", 8F);
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(6, 42);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(250, 368);
            this.playerList.TabIndex = 1;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.PlayerList_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 14);
            this.label18.TabIndex = 2;
            this.label18.Text = "Player List:";
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("Consolas", 20F);
            this.playerName.Location = new System.Drawing.Point(13, 42);
            this.playerName.MaxLength = 24;
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(425, 39);
            this.playerName.TabIndex = 22;
            this.playerName.Text = "playerName";
            this.playerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameBox_TextChanged);
            // 
            // deletePlayer
            // 
            this.deletePlayer.BackColor = System.Drawing.Color.Red;
            this.deletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlayer.ForeColor = System.Drawing.Color.Gold;
            this.deletePlayer.Location = new System.Drawing.Point(13, 515);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(90, 25);
            this.deletePlayer.TabIndex = 23;
            this.deletePlayer.Text = "Delete player";
            this.deletePlayer.UseVisualStyleBackColor = false;
            this.deletePlayer.Click += new System.EventHandler(this.buttonPress);
            // 
            // Player_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 546);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.changeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.placement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player_Stats";
            this.Text = "Player stats";
            this.statGroup.ResumeLayout(false);
            this.statGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox gameHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label lossCount;
        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.GroupBox statGroup;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.TextBox noteInput;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label placement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lookup;
        private System.Windows.Forms.Button removeRare;
        private System.Windows.Forms.Button addRare;
        private System.Windows.Forms.TextBox rareInput;
        private System.Windows.Forms.ListBox rareList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button deletePlayer;
    }
}