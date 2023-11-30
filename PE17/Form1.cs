using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // pre-populate text boxes with 1 & 100
            lowTextBox.Text = "1";
            highTextBox.Text = "100";

            this.startButton.Click += new EventHandler(this.StartButton__Click);
        
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            lowNumber = Int32.Parse(lowTextBox.Text);
            highNumber = Int32.Parse(highTextBox.Text);

            // if not a valid range
            if (lowNumber < 1 || highNumber > 100 )
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else if (highNumber < lowNumber)
            {
                MessageBox.Show("The high number must be higher than the low number!");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }


    }
}
