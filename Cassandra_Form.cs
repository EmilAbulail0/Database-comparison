using Cassandra;
using System;
using System.Windows.Forms;

namespace Diff
{
    public partial class Cassandra_Form : Form
    {
        public static ISession session;
        public static ISession session1;

        public Cassandra_Form()
        {
            InitializeComponent();
        }

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        private void button1_Click(object sender, EventArgs e)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            try
            {
                if (S_name.Text == D_name.Text)
                {
                    MessageBox.Show("You are comparing same Keyspaces", "Same Keyspace",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var cluster = Cluster.Builder()
                            .AddContactPoint(S_server.Text).WithPort(9042)
                            .Build();
                //Create connections to the nodes using a keyspace
                session = cluster.Connect(S_name.Text);
                var cluster1 = Cluster.Builder()
                           .AddContactPoint(D_server.Text).WithPort(9042)
                           .Build();
                //Create connections to the nodes using a keyspace
                session1 = cluster.Connect(D_name.Text);
                Cassamdra_Form2 f1 = new Cassamdra_Form2(S_name.Text, D_name.Text, S_server.Text, D_server.Text);
                f1.Show();
                this.Close();
            }
            catch (NoHostAvailableException ex)
            {
                MessageBox.Show("Please check cassandra connection settings");
            }
            catch (Cassandra.InvalidQueryException ex) {
                MessageBox.Show("Please check cassandra connection settings");
            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void S_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
