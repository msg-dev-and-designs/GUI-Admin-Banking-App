using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BankOfPrometheus
{
    public partial class Splashscreen : Form
    {
        //initialize and declaration of counter variable
        private int counter = 5;

        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            //start the timer component
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //update the progres bar with counter variable, every 100 milliseconds
            progressBar1.Value = counter;
            //increment the counter by 5 every 100 milliseconds
            counter += 5;

            //if counter is 100 then we are good to open login Form
            if (counter == 100)
            {
                //Stop the timer
                timer.Stop();

                //Hide this form first
                this.Hide();
                //Display the new form
                new LoginForm().ShowDialog();
                //close the current form
                this.Close();
            }
        }
    }
}
