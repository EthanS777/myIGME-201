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
    public partial class GameForm : Form
    {
        private int lowNum;
        private int highNum;
        int nRandom;

        // GameForm: accepts 2 params, lowNum and highNum, called from Form1 
        public GameForm(int lowNum, int highNum)
        {
            InitializeComponent();
            this.lowNum = lowNum;
            this.highNum = highNum;

            outputText.Visible = false;

            // generate random #
            Random rand = new Random();
            nRandom = rand.Next(lowNum, highNum);

            // set interval for timer (500ms) & value for progress bar
            this.timerTime.Interval = 500;
            this.progressBar.Value = 65;

            // start timer
            this.timerTime.Start();

            // event handlers for timer tick & guessing button
            this.timerTime.Tick += new EventHandler(Timer__Tick);
            this.guessButton.Click += new EventHandler(GuessButton__Click);

        }

        // GuessButton: When button is clicked, prompt user if too low/high/correct
        private void GuessButton__Click(object sender, EventArgs e)
        {
            // convert guessed value into integer, store in guessedNumber
            int guessedNumber = 0;
            guessedNumber = Int32.Parse(guessBox.Text);

            // if too low/high, prompt user their guess was too low/high, make that text visible
            if (guessedNumber < nRandom)
            {
                outputText.Text = "Your guess of " + guessedNumber + " was too low!";
                outputText.ForeColor = Color.Red;
                outputText.Visible = true;
 
            }
            else if (guessedNumber > nRandom)
            {
                outputText.Text = "Your guess of " + guessedNumber + " was too high!";
                outputText.ForeColor = Color.Red;
                outputText.Visible = true;
            }
            // if # guessed is correct, stop timer and prompt user
            else if (guessedNumber == nRandom)
            {
                this.timerTime.Stop();
                outputText.Text = guessedNumber + " is correct!!! Way to go!";
                MessageBox.Show("Good job!! You got it correct!");
            }
        }

        // TimerTick: slowly decrease progress bar value: if it reaches 0, stop timer and prompt user for loss
        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar.Value;

            if (this.progressBar.Value == 0)
            {
                this.timerTime.Stop();
                MessageBox.Show("Sorry.. you ran out of time! The number was " + nRandom);
            }
        }
    }
}
