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
        public Form1()
        {
            InitializeComponent();

            this.q1Box.TextChanged += new EventHandler(Q1Box__TextChanged);

           
        }

        private void Q1Box__TextChanged(object sender, EventArgs e)
        {

            q1Box.Location = new Point();
            
            
            q1Box.RightToLeft = RightToLeft.Yes;

            if (q1Box.Text.Contains("a") || q1Box.Text.Contains("e") || q1Box.Text.Contains("i"))
            {
                MessageBox.Show("That letter doesn't exist. ERROR");
            }
        }
    }
}
