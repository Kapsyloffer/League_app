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
            this.playerName = new System.Windows.Forms.Label();
            this.gameHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.lossCount = new System.Windows.Forms.Label();
            this.winCount = new System.Windows.Forms.Label();
            this.statGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.placement = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Consolas", 20F);
            this.playerName.Location = new System.Drawing.Point(16, 35);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(165, 32);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "playerName";
            // 
            // gameHistory
            // 
            this.gameHistory.Font = new System.Drawing.Font("Consolas", 8F);
            this.gameHistory.FormattingEnabled = true;
            this.gameHistory.Location = new System.Drawing.Point(9, 36);
            this.gameHistory.Name = "gameHistory";
            this.gameHistory.Size = new System.Drawing.Size(250, 225);
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
            this.weekLabel.Location = new System.Drawing.Point(389, 35);
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
            this.lossCount.Location = new System.Drawing.Point(376, 127);
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
            this.winCount.Location = new System.Drawing.Point(376, 56);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(70, 49);
            this.winCount.TabIndex = 6;
            this.winCount.Text = "99";
            this.winCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statGroup
            // 
            this.statGroup.Controls.Add(this.label1);
            this.statGroup.Controls.Add(this.addNote);
            this.statGroup.Controls.Add(this.textBox1);
            this.statGroup.Controls.Add(this.totalScore);
            this.statGroup.Controls.Add(this.placement);
            this.statGroup.Controls.Add(this.label9);
            this.statGroup.Controls.Add(this.label10);
            this.statGroup.Controls.Add(this.label8);
            this.statGroup.Controls.Add(this.label7);
            this.statGroup.Controls.Add(this.gameHistory);
            this.statGroup.Controls.Add(this.winCount);
            this.statGroup.Controls.Add(this.lossCount);
            this.statGroup.Controls.Add(this.label2);
            this.statGroup.Location = new System.Drawing.Point(13, 84);
            this.statGroup.Name = "statGroup";
            this.statGroup.Size = new System.Drawing.Size(452, 354);
            this.statGroup.TabIndex = 7;
            this.statGroup.TabStop = false;
            this.statGroup.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note:";
            // 
            // addNote
            // 
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Location = new System.Drawing.Point(144, 307);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(114, 41);
            this.addNote.TabIndex = 14;
            this.addNote.Text = "Add note (week x)";
            this.addNote.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 13;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.Location = new System.Drawing.Point(274, 127);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(70, 49);
            this.totalScore.TabIndex = 12;
            this.totalScore.Text = "99";
            this.totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placement
            // 
            this.placement.AutoSize = true;
            this.placement.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.placement.Location = new System.Drawing.Point(274, 56);
            this.placement.Name = "placement";
            this.placement.Size = new System.Drawing.Size(70, 49);
            this.placement.TabIndex = 11;
            this.placement.Text = "99";
            this.placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Score:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "Placement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Losses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Week:";
            // 
            // Player_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statGroup);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerName);
            this.Name = "Player_Stats";
            this.Text = "Player_Stats";
            this.statGroup.ResumeLayout(false);
            this.statGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.ListBox gameHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label lossCount;
        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.GroupBox statGroup;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label placement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}