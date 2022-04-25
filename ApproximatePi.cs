using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class ApproximatePi : Form
    {
        public ApproximatePi()
        {
            InitializeComponent();
        }

        // utilizes a loop to display the approximate value of pi with a given number of terms

        private void button1_Click(object sender, EventArgs e)
        {
            // try catch for exception handling
            try
            {
                // declare variables and parse input
                int terms = int.Parse(textBox1.Text);
                double pi = 0;

                // for loop that iterates through the number of terms
                for (int i = 0; i < terms; i++)
                {
                    if (i % 2 == 0) // even i values
                    {
                        pi += 1.0 / (2 * i + 1); // positive odd denominators 
                    }
                    else // odd i values for alternating signs
                    {
                        pi -= 1.0 / (2 * i + 1); // negative odd denominators
                    }
                    
                }
                label1.Text = "The approximate value of pi is " + (pi * 4).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number of terms");
            }
        }

    }
}
