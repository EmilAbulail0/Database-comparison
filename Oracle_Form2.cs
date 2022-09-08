using System;
using System.Windows.Forms;

namespace Diff
{
    public partial class Oracle_Form2 : Form
    {
        public Oracle_Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sequence.Checked = toggle.Checked;
            tables.Checked = toggle.Checked;
            package_spec.Checked = toggle.Checked;
            procedures.Checked = toggle.Checked;
            functions.Checked = toggle.Checked;
            package_body.Checked = toggle.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oracle_Form3 f1 = new Oracle_Form3(sequence, tables, package_spec, procedures, functions, package_body, progressBar1);
            f1.Show();
        }


    }
}
