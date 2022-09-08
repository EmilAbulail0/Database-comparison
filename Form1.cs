using System;
using System.Windows.Forms;

namespace Diff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oracle_Form f1 = new Oracle_Form();
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cassandra_Form f1 = new Cassandra_Form();
            f1.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://susant.medium.com/simple-way-to-install-cassandra-in-windows-10-6497e93989e6");
        }
    }
}
