namespace Exam_Jeopardy
{
    partial class Setup
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
            this.GameStart = new System.Windows.Forms.Button();
            this.numberOfTeams = new System.Windows.Forms.ComboBox();
            this.numberOfPLayersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.finalJeopardyCheckbox = new System.Windows.Forms.CheckBox();
            this.finalJeaopardyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GameStart
            // 
            this.GameStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GameStart.Location = new System.Drawing.Point(48, 194);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(75, 25);
            this.GameStart.TabIndex = 0;
            this.GameStart.Text = "Start game !";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // numberOfTeams
            // 
            this.numberOfTeams.Cursor = System.Windows.Forms.Cursors.Cross;
            this.numberOfTeams.FormattingEnabled = true;
            this.numberOfTeams.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.numberOfTeams.Location = new System.Drawing.Point(110, 26);
            this.numberOfTeams.Name = "numberOfTeams";
            this.numberOfTeams.Size = new System.Drawing.Size(55, 21);
            this.numberOfTeams.TabIndex = 1;
            this.numberOfTeams.SelectedIndexChanged += new System.EventHandler(this.numberOfTeams_SelectedIndexChanged);
            // 
            // numberOfPLayersLabel
            // 
            this.numberOfPLayersLabel.AutoSize = true;
            this.numberOfPLayersLabel.Location = new System.Drawing.Point(11, 29);
            this.numberOfPLayersLabel.Name = "numberOfPLayersLabel";
            this.numberOfPLayersLabel.Size = new System.Drawing.Size(91, 13);
            this.numberOfPLayersLabel.TabIndex = 2;
            this.numberOfPLayersLabel.Text = "Number of Teams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Rounds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox2.Location = new System.Drawing.Point(110, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // finalJeopardyCheckbox
            // 
            this.finalJeopardyCheckbox.AutoSize = true;
            this.finalJeopardyCheckbox.Location = new System.Drawing.Point(129, 98);
            this.finalJeopardyCheckbox.Name = "finalJeopardyCheckbox";
            this.finalJeopardyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.finalJeopardyCheckbox.TabIndex = 5;
            this.finalJeopardyCheckbox.UseVisualStyleBackColor = true;
            // 
            // finalJeaopardyLabel
            // 
            this.finalJeaopardyLabel.AutoSize = true;
            this.finalJeaopardyLabel.Location = new System.Drawing.Point(23, 98);
            this.finalJeaopardyLabel.Name = "finalJeaopardyLabel";
            this.finalJeaopardyLabel.Size = new System.Drawing.Size(81, 13);
            this.finalJeaopardyLabel.TabIndex = 6;
            this.finalJeaopardyLabel.Text = "Final Jeopardy?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Game Type:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Default",
            "Custom Game"});
            this.comboBox3.Location = new System.Drawing.Point(88, 136);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(77, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 263);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalJeaopardyLabel);
            this.Controls.Add(this.finalJeopardyCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numberOfPLayersLabel);
            this.Controls.Add(this.numberOfTeams);
            this.Controls.Add(this.GameStart);
            this.Name = "Setup";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.ComboBox numberOfTeams;
        private System.Windows.Forms.Label numberOfPLayersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox finalJeopardyCheckbox;
        private System.Windows.Forms.Label finalJeaopardyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

