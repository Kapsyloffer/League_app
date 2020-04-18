namespace League_2
{
    partial class SettingsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            this.maxWeeks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lossPoint = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.saveSettings = new System.Windows.Forms.Button();
            this.winPoint = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPoint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maxWeeks
            // 
            this.maxWeeks.Location = new System.Drawing.Point(9, 85);
            this.maxWeeks.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.maxWeeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxWeeks.Name = "maxWeeks";
            this.maxWeeks.Size = new System.Drawing.Size(63, 20);
            this.maxWeeks.TabIndex = 5;
            this.maxWeeks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max weeks:";
            // 
            // lossPoint
            // 
            this.lossPoint.Location = new System.Drawing.Point(88, 32);
            this.lossPoint.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lossPoint.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.lossPoint.Name = "lossPoint";
            this.lossPoint.Size = new System.Drawing.Size(63, 20);
            this.lossPoint.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Points for loss:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points for win:";
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(141, 184);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.buttonPress);
            // 
            // saveSettings
            // 
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Location = new System.Drawing.Point(60, 184);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(75, 23);
            this.saveSettings.TabIndex = 9;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.buttonPress);
            // 
            // winPoint
            // 
            this.winPoint.Location = new System.Drawing.Point(9, 32);
            this.winPoint.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.winPoint.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.winPoint.Name = "winPoint";
            this.winPoint.Size = new System.Drawing.Size(63, 20);
            this.winPoint.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxWeeks);
            this.groupBox1.Controls.Add(this.lossPoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.winPoint);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score settings";
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 219);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsUI";
            this.Text = "Settings UI";
            ((System.ComponentModel.ISupportInitialize)(this.maxWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPoint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown maxWeeks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lossPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.NumericUpDown winPoint;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}