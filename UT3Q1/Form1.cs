using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace UT3
{
    public partial class PresidentsForm : System.Windows.Forms.Form
    {
        public PresidentsForm()
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

            // Set up initial state
            allRadioButton.Checked = true;
            benjHarrisRadio.Checked = true;
            exitButton.Enabled = false;
            webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            popupLabel.Visible = false;

            // set interval for timer (1000ms) & value for progress bar
            this.timer.Interval = 1000;
            this.progressBar.Value = 100;

            // event handler for timer tick
            this.timer.Tick += new EventHandler(Timer__Tick);

            // Presidents Radio Button Event Handlers:
            this.benjHarrisRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.frankRooseRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.williamClintonRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.jamesBuchRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.franklinPierceRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.georgeBushRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.obamaRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.jfkRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.willMckinleyRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.ronaldReaganRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.dwightEisenRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.martinVanRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.georgeWashRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.johnAdamsRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.theoRooseRadio.Click += new EventHandler(PresidentsRadio__Click);
            this.thomasJeffRadio.Click += new EventHandler(PresidentsRadio__Click);

            // Filter Event Handlers:
            this.allRadioButton.Click += new EventHandler(AllRadioButton__Click);
            this.democratRadioButton.Click += new EventHandler(DemocratRadioButton__Click);
            this.republicanRadioButton.Click += new EventHandler(RepublicanRadioButton__Click);
            this.demRepRadioButton.Click += new EventHandler(DemRepRadioButton__Click);
            this.federalistRadioButton.Click += new EventHandler(FederalistRadioButton__Click);

            // Text box text changed event handlers:
            this.benjHarrisText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.frankRooseText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.williamClintonText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.jamesBuchText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.franklinPierceText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.georgeBushText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.obamaText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.jfkText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.willMckinleyText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.ronaldReaganText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.dwightEisenText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.martinVanText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.georgeWashText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.johnAdamsText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.theoRooseText.TextChanged += new EventHandler(PresidentsText__TextChanged);
            this.thomasJeffText.TextChanged += new EventHandler(PresidentsText__TextChanged);

            // Text box hover 
            this.benjHarrisText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.benjHarrisText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.frankRooseText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.frankRooseText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.williamClintonText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.williamClintonText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.jamesBuchText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.jamesBuchText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.franklinPierceText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.franklinPierceText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.georgeBushText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.georgeBushText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.obamaText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.obamaText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.jfkText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.jfkText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.willMckinleyText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.willMckinleyText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.ronaldReaganText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.ronaldReaganText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.dwightEisenText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.dwightEisenText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.martinVanText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.martinVanText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.georgeWashText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.georgeWashText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.johnAdamsText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.johnAdamsText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.theoRooseText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.theoRooseText.MouseLeave += new EventHandler(Text__MouseLeave);
            this.thomasJeffText.MouseEnter += new EventHandler(Text__MouseEnter);
            this.thomasJeffText.MouseLeave += new EventHandler(Text__MouseLeave);

            // Picture Box Hover
            this.pictureBox.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            // Exit 
            this.exitButton.Click += new EventHandler(ExitButton__Click);

        }
        // "All" event handler
        private void AllRadioButton__Click(object sender, EventArgs e)
        {
            benjHarrisRadio.Visible = true;
            frankRooseRadio.Visible = true;
            williamClintonRadio.Visible = true;
            jamesBuchRadio.Visible = true;
            franklinPierceRadio.Visible = true;
            georgeBushRadio.Visible = true;
            obamaRadio.Visible = true;
            jfkRadio.Visible = true;
            willMckinleyRadio.Visible = true;
            ronaldReaganRadio.Visible = true;
            dwightEisenRadio.Visible = true;
            martinVanRadio.Visible = true;
            georgeWashRadio.Visible = true;
            johnAdamsRadio.Visible = true;
            theoRooseRadio.Visible = true;
            thomasJeffRadio.Visible = true;
            benjHarrisRadio.Checked = true;
        }
        // "Democrat" event handler
        private void DemocratRadioButton__Click(object sender, EventArgs e)
        {
            frankRooseRadio.Visible = true;
            williamClintonRadio.Visible = true;
            jamesBuchRadio.Visible = true;
            franklinPierceRadio.Visible = true;
            obamaRadio.Visible = true;
            jfkRadio.Visible = true;
            martinVanRadio.Visible = true;
            benjHarrisRadio.Visible = false;
            georgeBushRadio.Visible = false;
            willMckinleyRadio.Visible = false;
            ronaldReaganRadio.Visible = false;
            dwightEisenRadio.Visible = false;
            georgeWashRadio.Visible = false;
            johnAdamsRadio.Visible = false;
            theoRooseRadio.Visible = false;
            thomasJeffRadio.Visible = false;
            frankRooseRadio.Checked = true;
        }
        // "Republican" event handler
        private void RepublicanRadioButton__Click(object sender, EventArgs e)
        {
            benjHarrisRadio.Visible = true;
            georgeBushRadio.Visible = true;
            willMckinleyRadio.Visible = true;
            ronaldReaganRadio.Visible = true;
            dwightEisenRadio.Visible = true;
            theoRooseRadio.Visible = true;
            frankRooseRadio.Visible = false;
            williamClintonRadio.Visible = false;
            jamesBuchRadio.Visible = false;
            franklinPierceRadio.Visible = false;
            obamaRadio.Visible = false;
            jfkRadio.Visible = false;
            martinVanRadio.Visible = false;
            georgeWashRadio.Visible = false;
            johnAdamsRadio.Visible = false;
            thomasJeffRadio.Visible = false;
            benjHarrisRadio.Checked = true;
        }
        // "Dem-Rep" event handler
        private void DemRepRadioButton__Click(object sender, EventArgs e)
        {
            thomasJeffRadio.Visible = true;
            benjHarrisRadio.Visible = false;
            frankRooseRadio.Visible = false;
            williamClintonRadio.Visible = false;
            jamesBuchRadio.Visible = false;
            franklinPierceRadio.Visible = false;
            georgeBushRadio.Visible = false;
            obamaRadio.Visible = false;
            jfkRadio.Visible = false;
            willMckinleyRadio.Visible = false;
            ronaldReaganRadio.Visible = false;
            dwightEisenRadio.Visible = false;
            martinVanRadio.Visible = false;
            georgeWashRadio.Visible = false;
            johnAdamsRadio.Visible = false;
            theoRooseRadio.Visible = false;
            thomasJeffRadio.Checked = true;
        }
        // "Federalist" event handler
        private void FederalistRadioButton__Click(object sender, EventArgs e)
        {
            georgeWashRadio.Visible = true;
            johnAdamsRadio.Visible = true;
            thomasJeffRadio.Visible = false;
            benjHarrisRadio.Visible = false;
            frankRooseRadio.Visible = false;
            williamClintonRadio.Visible = false;
            jamesBuchRadio.Visible = false;
            franklinPierceRadio.Visible = false;
            georgeBushRadio.Visible = false;
            obamaRadio.Visible = false;
            jfkRadio.Visible = false;
            willMckinleyRadio.Visible = false;
            ronaldReaganRadio.Visible = false;
            dwightEisenRadio.Visible = false;
            martinVanRadio.Visible = false;
            theoRooseRadio.Visible = false;
            georgeWashRadio.Checked = true;
        }
        // Mouse entering picture box, make image size bigger
        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Height *= 2;
            pb.Width *= 2;
        }
        // Mouse leaving picture box, revert image size 
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Height /= 2;
            pb.Width /= 2;
        }
        // When President radio buttons are clicked, change image, wikipedia page, and link text
        private void PresidentsRadio__Click(object sender, EventArgs e)
        {
            if (benjHarrisRadio.Checked)
            {
               pictureBox.Image = UT3.Properties.Resources.BenjaminHarrison;
               webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
               wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            }
            else if (frankRooseRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.FranklinDRoosevelt;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
            }
            else if (williamClintonRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.WilliamJClinton;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Bill_Clinton");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
            }
            else if (jamesBuchRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.JamesBuchanan;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            }
            else if (franklinPierceRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.FranklinPierce;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            }
            else if (georgeBushRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.GeorgeWBush;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_W._Bush");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            }
            else if (obamaRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.BarackObama;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            }
            else if (jfkRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.JohnFKennedy;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_F._Kennedy");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";
            }
            else if (willMckinleyRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.WilliamMcKinley;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/William_McKinley");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            }
            else if (ronaldReaganRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.RonaldReagan;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            }
            else if (dwightEisenRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.DwightDEisenhower;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
            }
            else if (martinVanRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.MartinVanBuren;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Martin_Van_Buren";
            }
            else if (georgeWashRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.GeorgeWashington;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_Washington");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
            }
            else if (johnAdamsRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.JohnAdams;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Adams");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            }
            else if (theoRooseRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.TheodoreRoosevelt;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            }
            else if (thomasJeffRadio.Checked)
            {
                pictureBox.Image = UT3.Properties.Resources.ThomasJefferson;
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                wikipediaBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            }

        }
        // When the text in any text box is changed, start the timer
        private void PresidentsText__TextChanged(object sender, EventArgs e)
        {
            // start timer
            this.timer.Start();

        }
        // As timer ticks down, remove value from progress bar: if it reaches 0, reset value- stop timer & show fireworks if all #'s correct
        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar.Value;

            if (benjHarrisText.Text == "23" && frankRooseText.Text == "32" && williamClintonText.Text == "42" && jamesBuchText.Text == "15" && franklinPierceText.Text == "14" && georgeBushText.Text == "43" && obamaText.Text == "44"
                && jfkText.Text == "35" && willMckinleyText.Text == "25" && ronaldReaganText.Text == "40" && dwightEisenText.Text == "34" && martinVanText.Text == "8" && georgeWashText.Text == "1" && johnAdamsText.Text == "2"
                && theoRooseText.Text == "26" && thomasJeffText.Text == "3") 
            {
                this.timer.Stop();
                webBrowser.Url = new Uri("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif");
                wikipediaBox.Text = "https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif";
                exitButton.Enabled = true;
            }

            if (this.progressBar.Value == 0)
            {
                this.timer.Stop();
                this.progressBar.Value = 100;
            }
        }
        // When mouse hovers over textbox, make the popup label visible
        private void Text__MouseEnter(object sender, EventArgs e)
        {
            popupLabel.Visible = true;
        }
        // When mouse leaves textbox, remove popup label from visibility
        private void Text__MouseLeave(object sender, EventArgs e)
        {
            popupLabel.Visible = false;
        }
        // Exit Button Click: close the app
        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}