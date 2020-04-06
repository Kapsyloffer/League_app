namespace League_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.openLatest = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addGame = new System.Windows.Forms.Button();
            this.comboLoser = new System.Windows.Forms.ComboBox();
            this.comboWinner = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addPlayer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboWeek = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openSettings = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openLatest
            // 
            this.openLatest.Location = new System.Drawing.Point(730, 345);
            this.openLatest.Name = "openLatest";
            this.openLatest.Size = new System.Drawing.Size(87, 39);
            this.openLatest.TabIndex = 0;
            this.openLatest.Text = "Open Latest";
            this.openLatest.UseVisualStyleBackColor = true;
            this.openLatest.Click += new System.EventHandler(this.buttonPress);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(626, 345);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(87, 39);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.buttonPress);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(626, 395);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(87, 39);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.buttonPress);
            // 
            // saveAs
            // 
            this.saveAs.Location = new System.Drawing.Point(730, 395);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(87, 39);
            this.saveAs.TabIndex = 2;
            this.saveAs.Text = "Save As...";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.buttonPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addGame);
            this.groupBox1.Controls.Add(this.comboLoser);
            this.groupBox1.Controls.Add(this.comboWinner);
            this.groupBox1.Location = new System.Drawing.Point(626, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add game";
            // 
            // addGame
            // 
            this.addGame.Location = new System.Drawing.Point(104, 102);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(87, 27);
            this.addGame.TabIndex = 8;
            this.addGame.Text = "Add Game";
            this.addGame.UseVisualStyleBackColor = true;
            this.addGame.Click += new System.EventHandler(this.buttonPress);
            // 
            // comboLoser
            // 
            this.comboLoser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLoser.FormattingEnabled = true;
            this.comboLoser.Location = new System.Drawing.Point(6, 75);
            this.comboLoser.Name = "comboLoser";
            this.comboLoser.Size = new System.Drawing.Size(185, 21);
            this.comboLoser.TabIndex = 1;
            // 
            // comboWinner
            // 
            this.comboWinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboWinner.FormattingEnabled = true;
            this.comboWinner.Location = new System.Drawing.Point(6, 35);
            this.comboWinner.Name = "comboWinner";
            this.comboWinner.Size = new System.Drawing.Size(185, 21);
            this.comboWinner.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.addPlayer);
            this.groupBox2.Location = new System.Drawing.Point(626, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Player";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 40);
            this.nameBox.MaxLength = 24;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(185, 20);
            this.nameBox.TabIndex = 10;
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(104, 66);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(87, 27);
            this.addPlayer.TabIndex = 9;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.buttonPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboWeek);
            this.groupBox3.Location = new System.Drawing.Point(632, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 65);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Week";
            // 
            // comboWeek
            // 
            this.comboWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboWeek.FormattingEnabled = true;
            this.comboWeek.Location = new System.Drawing.Point(6, 27);
            this.comboWeek.Name = "comboWeek";
            this.comboWeek.Size = new System.Drawing.Size(104, 21);
            this.comboWeek.TabIndex = 9;
            this.comboWeek.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 422);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Standings (Week x)";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Items.AddRange(new object[] {
            "1. Person #1\t\t\t\t\t\t13/37\t69  A good boi"});
            this.listBox1.Location = new System.Drawing.Point(7, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 368);
            this.listBox1.TabIndex = 0;
            // 
            // openSettings
            // 
            this.openSettings.Location = new System.Drawing.Point(754, 20);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(81, 40);
            this.openSettings.TabIndex = 11;
            this.openSettings.Text = "Settings";
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.buttonPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.deletePlayerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewProfileToolStripMenuItem.Text = "View profile.";
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deletePlayerToolStripMenuItem.Text = "Delete player.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.openLatest);
            this.Name = "Form1";
            this.Text = "League_improved";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openLatest;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addGame;
        private System.Windows.Forms.ComboBox comboLoser;
        private System.Windows.Forms.ComboBox comboWinner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboWeek;
    }
}

