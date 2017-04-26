namespace Exam_Jeopardy
{
    partial class QuestionWindow
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
            this.lblQuestion_Number = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion_Number
            // 
            this.lblQuestion_Number.AutoSize = true;
            this.lblQuestion_Number.Location = new System.Drawing.Point(46, 63);
            this.lblQuestion_Number.Name = "lblQuestion_Number";
            this.lblQuestion_Number.Size = new System.Drawing.Size(54, 13);
            this.lblQuestion_Number.TabIndex = 0;
            this.lblQuestion_Number.Text = "Questions";
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.AutoSize = true;
            this.lblAnswerD.Location = new System.Drawing.Point(547, 292);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(56, 13);
            this.lblAnswerD.TabIndex = 16;
            this.lblAnswerD.Text = "Answer: D";
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.AutoSize = true;
            this.lblAnswerC.Location = new System.Drawing.Point(380, 292);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(55, 13);
            this.lblAnswerC.TabIndex = 15;
            this.lblAnswerC.Text = "Answer: C";
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.AutoSize = true;
            this.lblAnswerA.Location = new System.Drawing.Point(46, 292);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(55, 13);
            this.lblAnswerA.TabIndex = 14;
            this.lblAnswerA.Text = "Answer: A";
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.AutoSize = true;
            this.lblAnswerB.Location = new System.Drawing.Point(213, 292);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(55, 13);
            this.lblAnswerB.TabIndex = 13;
            this.lblAnswerB.Text = "Answer: B";
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(550, 346);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 12;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(383, 346);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(216, 346);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 10;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(49, 346);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(70, 115);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(54, 13);
            this.lblQuestion.TabIndex = 17;
            this.lblQuestion.Text = "Questions";
            // 
            // QuestionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 421);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblAnswerD);
            this.Controls.Add(this.lblAnswerC);
            this.Controls.Add(this.lblAnswerA);
            this.Controls.Add(this.lblAnswerB);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestion_Number);
            this.Name = "QuestionWindow";
            this.Text = "QuestionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion_Number;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblQuestion;
    }
}