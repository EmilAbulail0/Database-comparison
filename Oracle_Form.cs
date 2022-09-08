using Cassandra;
using Oracle.DataAccess.Client;
using System;
//using System.Data.OracleClient;
using System.Windows.Forms;

namespace Diff
{
    public partial class Oracle_Form : Form
    {
#pragma warning disable CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
        public static OracleConnection Source_con = new OracleConnection();
#pragma warning restore CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
        public static OracleConnection Destination_con = new OracleConnection();
#pragma warning restore CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleConnection' is obsolete: 'OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
        public Oracle_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source_schema = S_name.Text;
            var source_password = S_pass.Text;
            var source_server = S_server.Text;
            var source_sid = S_sid.Text;

            var destination_schema = D_name.Text;
            var destination_password = D_pass.Text;
            var destination_server = D_server.Text;
            var destination_sid = D_sid.Text;
            if (source_schema == destination_schema)
            {
                MessageBox.Show("You are comparing same schemas", "Same Schema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            
                string source_connection_string = "Data Source=  (DESCRIPTION ="
                   + $"(ADDRESS = (PROTOCOL = TCP)(HOST = {source_server})(PORT = 1521))" +
                    "(CONNECT_DATA =" +
                      "(SERVER = DEDICATED)" +
                      $"(SERVICE_NAME = {source_sid})" +
                    ")" +
                  $");User Id={source_schema};password={source_password};";
                Source_con.ConnectionString = source_connection_string;
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                try
                {
                    Source_con.Open();
                    Source_con.Close();
                }
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    MessageBox.Show("Invalid source connection  settings");
                return;

            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used


            string destination_connection_string = "Data Source=  (DESCRIPTION ="
      + $"(ADDRESS = (PROTOCOL = TCP)(HOST = {destination_server})(PORT = 1521))" +
       "(CONNECT_DATA =" +
         "(SERVER = DEDICATED)" +
         $"(SERVICE_NAME = {destination_sid})" +
       ")" +
     $");User Id={destination_schema};password={destination_password};"; 
                Destination_con.ConnectionString = destination_connection_string;
                // 
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                try
                {
                    Destination_con.Open();
                    Destination_con.Close();
                    Oracle_Form2 f1 = new Oracle_Form2();
                    f1.Show();  

            }
                catch (Oracle.DataAccess.Client.OracleException ex)
                {
                    MessageBox.Show("Invalid destination connection connection settings");
                return;

                }
            
#pragma warning restore CS0168 // The variable 'ex' is declared but never used



#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void S_pass_TextChanged(object sender, EventArgs e)
        {
            S_pass.PasswordChar = '\u25CF';
        }

        private void D_pass_TextChanged(object sender, EventArgs e)
        {
            D_pass.PasswordChar = '\u25CF';
        }


    }
}
