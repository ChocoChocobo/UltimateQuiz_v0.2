using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateQuiz_v0._2
{
    public partial class VideoGamesForm : Form
    {
        public int score = 0;

        public VideoGamesForm()
        {
            InitializeComponent();            
            pictureBox1.BackColor = Color.Transparent;
        }

        public VideoGamesForm(MainForm mainForm)
        {
            InitializeComponent();           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }       

        private void VideoGamesForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxG1_TextChanged(object sender, EventArgs e)
        {
            string correctAnswer = "Final Fantasy";
            string userAnswer = textBoxG1.Text;

            if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblAnswerStatus1.Text = "Correct!";
                lblAnswerStatus1.BackColor = Color.Lime;
                score++;
                textBoxG1.ReadOnly = true;
            }
            else
            {
                lblAnswerStatus1.Text = "Incorrect!";
                lblAnswerStatus1.BackColor = Color.Red;
            }
            
        }

        private void textBoxG2_TextChanged(object sender, EventArgs e)
        {
            string correctAnswer = "Hollow Knight";
            string userAnswer = textBoxG2.Text;

            if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblAnswerStatus2.Text = "Correct!";
                lblAnswerStatus2.BackColor = Color.Lime;
                score++;
                textBoxG2.ReadOnly = true;
            }
            else
            {
                lblAnswerStatus2.Text = "Incorrect!";
                lblAnswerStatus2.BackColor = Color.Red;
            }
            
        }

        private void textBoxG3_TextChanged(object sender, EventArgs e)
        {
            string correctAnswer = "Max";
            string userAnswer = textBoxG3.Text;

            if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblAnswerStatus3.Text = "Correct!";
                lblAnswerStatus3.BackColor = Color.Lime;
                score++;
                textBoxG3.ReadOnly = true;
            }
            else
            {
                lblAnswerStatus3.Text = "Incorrect!";
                lblAnswerStatus3.BackColor = Color.Red;
            }
            
        }

        private void comboBoxG4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int correctOption = 2;

            if (comboBoxG4.SelectedIndex == correctOption)
            {
                lblAnswerStatus4.Text = "Correct!";
                lblAnswerStatus4.BackColor = Color.Lime;
                score++;
                comboBoxG4.Enabled = false;
            }
            else
            {
                lblAnswerStatus4.Text = "Incorrect!";
                lblAnswerStatus4.BackColor = Color.Red;
            }
            
        }

        private void textBoxG5_TextChanged(object sender, EventArgs e)
        {
            string correctAnswer = "Cyberpunk 2077";
            string userAnswer = textBoxG5.Text;

            if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblAnswerStatus5.Text = "Correct!";
                lblAnswerStatus5.BackColor = Color.Lime;
                score++;
                textBoxG5.ReadOnly = true;
            }
            else
            {
                lblAnswerStatus5.Text = "Incorrect!";
                lblAnswerStatus5.BackColor = Color.Red;
            }
            
        }

        private void buttonCheckAnswers_Click(object sender, EventArgs e)
        {
            if(score == 5)
            {
                labelCookie.Text = "Congratulations! You deserve it!";
                labelCookie.BackColor = Color.Lime;
                labelCookie.Font = new Font(labelCookie.Font.FontFamily, 12);
                labelCookie.Show();
                pictureBox1.Show();
            }
            else
            {
                labelCookie.Text = $"You made it only {score}/5 through. No cookie for you >:(";
                labelCookie.Show();
            }
        }
    }
}
