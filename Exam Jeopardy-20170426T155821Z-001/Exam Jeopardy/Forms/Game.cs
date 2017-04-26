using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Jeopardy
{
    public partial class Game : Form
    {
        private int[] scores;
        private int playing;
        private int turn;

        public int[] Scores
        {
            get { return scores; }
            set { scores = value; }
        }
    

        public Game()
        {
            InitializeComponent();
        }

        public void GameSetup(int[] scoresIn)
        {
            int[]Scores = scoresIn;
        }

        private void category1_Click(object sender, EventArgs e)
        {
           this.SetStyle(ControlStyles.UserPaint, true);
       
        }


        private void GameBoard_Load(object sender, EventArgs e)
        {
            if (Scores.Length < 3)
            {
                teamLabel3.Visible = false;
            }
        }

        //private void openQuestion()
        //{
        //    //Opens a question
        //}
        //private void closeQuestion()
        //{
        //    //Closes the question
        //}

        //public int getNextTeam()
        //{
        //    //Get the next team to play based on whether the answer given was correct or not.
        //}

 
    }
}
