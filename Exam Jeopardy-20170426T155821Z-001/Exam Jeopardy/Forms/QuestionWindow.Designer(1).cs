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
            this.questionArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionArea
            // 
            this.questionArea.AutoSize = true;
            this.questionArea.Location = new System.Drawing.Point(46, 63);
            this.questionArea.Name = "questionArea";
            this.questionArea.Size = new System.Drawing.Size(54, 13);
            this.questionArea.TabIndex = 0;
            this.questionArea.Text = "Questions";
            // 
            // QuestionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.questionArea);
            this.Name = "QuestionWindow";
            this.Text = "QuestionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionArea;
    }
}