using System;
using System.Drawing;
using System.Windows.Forms;

namespace GalixWEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }




        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Update();
        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnATRAS_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnADELANTE_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {



        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }


        }

    }
}
