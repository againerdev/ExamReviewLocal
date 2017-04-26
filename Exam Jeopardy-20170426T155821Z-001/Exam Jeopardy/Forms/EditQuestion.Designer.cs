namespace Exam_Jeopardy
{
    partial class EditQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(29, 36);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(59, 13);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question #";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(15, 263);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(71, 17);
            this.chkC.TabIndex = 6;
            this.chkC.Text = "Answer C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(15, 321);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(72, 17);
            this.chkD.TabIndex = 8;
            this.chkD.Text = "Answer D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(12, 98);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(364, 40);
            this.txtQuestion.TabIndex = 9;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(292, 32);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(104, 23);
            this.btnRetrieve.TabIndex = 10;
            this.btnRetrieve.Text = "Retrive Question";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Question text";
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Location = new System.Drawing.Point(12, 175);
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(361, 20);
            this.txtAnswerA.TabIndex = 13;
            this.txtAnswerA.TextChanged += new System.EventHandler(this.txtAnswerA_TextChanged);
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Location = new System.Drawing.Point(12, 286);
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(361, 20);
            this.txtAnswerC.TabIndex = 14;
            this.txtAnswerC.TextChanged += new System.EventHandler(this.txtAnswerC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Answer A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Answer B";
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Location = new System.Drawing.Point(12, 227);
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(361, 20);
            this.txtAnswerB.TabIndex = 16;
            this.txtAnswerB.TextChanged += new System.EventHandler(this.txtAnswerB_TextChanged);
            // 
            // txtAnswerD
            // 
            this.txtAnswerD.Location = new System.Drawing.Point(12, 344);
            this.txtAnswerD.Name = "txtAnswerD";
            this.txtAnswerD.Size = new System.Drawing.Size(361, 20);
            this.txtAnswerD.TabIndex = 18;
            this.txtAnswerD.TextChanged += new System.EventHandler(this.txtAnswerD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Input questions ";
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnswerD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.lblQuestion);
            this.Name = "EditQuestion";
            this.Text = "EditQuestion";
            this.Load += new System.EventHandler(this.EditQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerD;
        private System.Windows.Forms.Label label4;
    }
}