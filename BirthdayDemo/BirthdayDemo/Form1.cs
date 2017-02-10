using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handler
        private void buttonMessage_Click(object sender, EventArgs e)
        {
            //Want the text of the text box when you click on buttonMessage
            string name = textBoxName.Text;

            //Work out how old person is
            DateTime today = DateTime.Now.Date;
            //Need to work out when birthday
            TimeSpan ageDays = today - dateTimePickerBirthdate.Value;
            //convert totalDays(double) into an integer
            int years = (int)ageDays.TotalDays / 365;

            //get their birthday details to display
            int day = dateTimePickerBirthdate.Value.Day;
            //MMMM formating to display month as word
            string month = dateTimePickerBirthdate.Value.ToString("MMMM");

            labelMessage.Text = "Hello, " + name + "! You will be " +
                (years + 1) + " years old on " + day + " " + month + ".";


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
