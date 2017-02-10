using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDemoWinForms
{
    public partial class Form1 : Form
    {
        int timeLeft = 10;

        public Form1()
        {
            InitializeComponent();
        }

        //Event handler for if they click on the first radio button of question 1 (Wrong answer)
        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A1.Checked) //i.e. Clicked wrong answer
            {
                //Want to display a red cross in label feedback
                labelFeedbackQ1.ForeColor = Color.Red;
                labelFeedbackQ1.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                //Don't display anything in label feedback
                labelFeedbackQ1.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked) //i.e. Clicked CORRECT answer
            {
                //Want to display a green tick in label feedback
                labelFeedbackQ1.ForeColor = Color.Green;
                labelFeedbackQ1.Text = "\u00fc"; //unicode for tick
            }
            else
            {
                labelFeedbackQ1.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked) //i.e. Clicked wrong answer
            {
                labelFeedbackQ1.ForeColor = Color.Red;
                labelFeedbackQ1.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                labelFeedbackQ1.Text = "";
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked) //i.e. Clicked wrong answer
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked) //i.e. Clicked CORRECT answer
            {
                labelFeedbackQ2.ForeColor = Color.Green;
                labelFeedbackQ2.Text = "\u00fc"; //unicode for tick
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked) //i.e. Clicked wrong answer
            {
                labelFeedbackQ2.ForeColor = Color.Red;
                labelFeedbackQ2.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                labelFeedbackQ2.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked) //i.e. Clicked wrong answer
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked) //i.e. Clicked wrong answer
            {
                labelFeedbackQ3.ForeColor = Color.Red;
                labelFeedbackQ3.Text = "\u00fb"; //unicode for cross
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked) //i.e. Clicked CORRECT answer
            {
                labelFeedbackQ3.ForeColor = Color.Green;
                labelFeedbackQ3.Text = "\u00fc"; //unicode for tick
            }
            else
            {
                labelFeedbackQ3.Text = "";
            }
        }

        //Double-click timer to get event handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //Update and display the time left
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";
            }
            else
            {
                //If user runs out of time
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                //Message box
                MessageBox.Show("You ran out of time.", "Sorry");

            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
    }

