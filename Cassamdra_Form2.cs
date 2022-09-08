using System;
using System.Windows.Forms;

namespace Diff
{
    public partial class Cassamdra_Form2 : Form
    {
        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public string Text4 { get; }



        public Cassamdra_Form2(string text1, string text2, string text3, string text4)
        {

            InitializeComponent();
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cassandra_Form1 f1 = new Cassandra_Form1(tables, view, function, Text1, Text2, Text3, Text4, this.progressBar1);
            f1.Show();
            this.Close();

        }

        private void toggle_CheckedChanged(object sender, EventArgs e)
        {
            tables.Checked = toggle.Checked;
            function.Checked = toggle.Checked;
            view.Checked = toggle.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Cassamdra_Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
