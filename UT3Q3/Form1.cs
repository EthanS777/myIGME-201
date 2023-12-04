using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT3Q3
{
    public partial class Form1 : Form
    {
        // n and k for counter
        int n = 0;
        int k = 0;
        public Form1()
        {
            InitializeComponent();

            // using the WebBrowser control with Internet Explorer
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            // set initial state, make Q2/Q3 hidden
            q2Text.Visible = false;
            q2Box.Visible = false;
            q3Text.Visible = false;
            q3Radio1.Visible = false;
            q3Radio2.Visible = false;
            q3Radio3.Visible = false;
            submitButton.Enabled = true;
            webBrowser1.Visible = false;
            
            // event handlers
            this.q1Box.TextChanged += new EventHandler(Q1Box__TextChanged);
            this.q2Box.MouseEnter += new EventHandler(Q2Box__MouseEnter);
            this.q2Box.MouseLeave += new EventHandler(Q2Box__MouseLeave);
            this.q3Radio1.CheckedChanged += new EventHandler(Q3Radio1__CheckedChanged);
            this.q3Radio2.CheckedChanged += new EventHandler(Q3Radio2__CheckedChanged);
            this.q3Radio3.CheckedChanged += new EventHandler(Q3Radio3__CheckedChanged);
            this.submitButton.Click += new EventHandler(SubmitButton__Click);
            this.submitButton.MouseEnter += new EventHandler(SubmitButton__MouseEnter);
            this.submitButton.MouseLeave += new EventHandler(SubmitButton__MouseLeave);
        }

        // if text changed in Q1 box, update location - every other key typed, show error/reset text
        private void Q1Box__TextChanged(object sender, EventArgs e)
        {
            
            n++;

            q1Box.Location = new Point(n * 100, n * 50);

               if (q1Box.Location.X > 600)
            {
                q1Box.Location = new Point();

            }
            
            
            
            
            q1Box.RightToLeft = RightToLeft.Yes;

            // show error & reset text 
            if (n % 2 == 0)
            {
                MessageBox.Show("That letter doesn't exist. ERROR");
                MessageBox.Show("INVALID LETTER");

                q1Box.ResetText();
                q2Box.Visible = true;
                q2Text.Visible = true;
                q1Box.Location = new Point(261, 109);
            }
            // after 2 letters typed, show question 2 
            else
            {
                q2Box.Visible = false;
                q2Text.Visible = false;
            }
            
        }

        // when mouse enters Q2 box, change to new point and remove visibility - if mouse enters more than 3 times, show Q3
        private void Q2Box__MouseEnter(object sender, EventArgs e)
        {
            n++;
            k++;

            q2Box.Location = new Point(n, n * 30);
            q2Box.Visible = false;

            if (k > 3)
            {
                q3Text.Visible = true;
                q3Radio1.Visible = true;
                q3Radio2.Visible = true;
                q3Radio3.Visible = true;
                q2Box.Location = new Point(261, 184);
            }
       
        }

        // when mouse leaves Q2 box, change visibility to true
        private void Q2Box__MouseLeave(object sender, EventArgs e)
        {
            n++;

            q2Box.Visible = true;
           // q2Box.Location = new Point(n* 50, n);
        }

        // when Q3 first radio button is changed
        private void Q3Radio1__CheckedChanged(object sender, EventArgs e)
        {
            q3Radio1.Visible = false;
            q3Radio2.Visible = true;
            q3Radio3.Visible = true;
        }

        // when Q3 second radio button is changed
        private void Q3Radio2__CheckedChanged(object sender, EventArgs e)
        {
            q3Radio1.Visible = true;
            q3Radio2.Visible = false;
            q3Radio3.Visible = true;
        }

        // when Q3 third radio button is changed, make ALL visible, including Web Browser, change URL to show GIF
        private void Q3Radio3__CheckedChanged(object sender, EventArgs e)
        {
            q3Radio1.Visible = true;
            q3Radio2.Visible = true;
            q3Radio3.Visible = true;

            webBrowser1.Visible = true;
            webBrowser1.Url = new Uri("https://media.giphy.com/media/mcH0upG1TeEak/giphy.gif");
        }

        // when submit button clicked, show error
        private void SubmitButton__Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("'Submit' not found. ERROR");
            }

        }

        // when mouse enters submit button, disable it
        private void SubmitButton__MouseEnter(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }
        
        // when mouse leaves exit button, enable it
        private void SubmitButton__MouseLeave(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
        }
    }
}
