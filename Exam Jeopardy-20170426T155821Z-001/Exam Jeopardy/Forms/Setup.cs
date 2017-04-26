using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Jeopardy
{
    public partial class Setup : Form
    {
        Game game = new Game();
        public Setup()
        {
            InitializeComponent();
            numberOfTeams.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void GameStart_Click(object sender, EventArgs e)
        {
                game.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberOfTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = numberOfTeams.SelectedIndex;
            if (selectedValue == 2)
            {
               List<int> Scores = new List<int>();
               Scores.Add(0);
               Scores.Add(0);
                game.Scores = Scores.ToArray();
            }

            if (selectedValue == 3)
            {
                List<int> Scores = new List<int>();
                Scores.Add(0);
                Scores.Add(0);
                Scores.Add(0);
                game.Scores = Scores.ToArray();

            }
            else if (selectedValue == 4)
            {
                List<int> Scores = new List<int>();
                Scores.Add(0);
                Scores.Add(0);
                Scores.Add(0);
                Scores.Add(0);
                game.Scores = Scores.ToArray();
                game.GameSetup(game.Scores);

            }
            else
            {
                return;
            }
        }
    }
        }
    
