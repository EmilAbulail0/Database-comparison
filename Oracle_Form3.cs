//using System.Data.OracleClient;
using Oracle.DataAccess.Client;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diff
{
    public partial class Oracle_Form3 : Form
    {
#pragma warning disable CS0169 // The field 'Oracle_Form3.sequence' is never used
        private CheckBox sequence;
#pragma warning restore CS0169 // The field 'Oracle_Form3.sequence' is never used
#pragma warning disable CS0169 // The field 'Oracle_Form3.tables' is never used
        private CheckBox tables;
#pragma warning restore CS0169 // The field 'Oracle_Form3.tables' is never used
#pragma warning disable CS0169 // The field 'Oracle_Form3.package_spec' is never used
        private CheckBox package_spec;
#pragma warning restore CS0169 // The field 'Oracle_Form3.package_spec' is never used
#pragma warning disable CS0169 // The field 'Oracle_Form3.procedures' is never used
        private CheckBox procedures;
#pragma warning restore CS0169 // The field 'Oracle_Form3.procedures' is never used
#pragma warning disable CS0169 // The field 'Oracle_Form3.functions' is never used
        private CheckBox functions;
#pragma warning restore CS0169 // The field 'Oracle_Form3.functions' is never used
#pragma warning disable CS0169 // The field 'Oracle_Form3.package_body' is never used
        private CheckBox package_body;
#pragma warning restore CS0169 // The field 'Oracle_Form3.package_body' is never used

        public Oracle_Form3(CheckBox sequence, CheckBox tables, CheckBox package_spec, CheckBox procedures, CheckBox functions, CheckBox package_body, ProgressBar p1)
        {
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 
            p1.Minimum = 0;
            p1.Value = 8;
            InitializeComponent();
            p1.Value = 10;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 
            var result = "";
            var result1 = "";
            Oracle_Form.Source_con.Open();
            Oracle_Form.Destination_con.Open();
            var command = " DBMS_METADATA.set_transform_param(DBMS_METADATA.session_transform, 'EMIT_SCHEMA', false)";
            var content = string.Format("BEGIN {0}; END;", command);
            OracleCommand FilterationCommand = new OracleCommand(content, Oracle_Form.Source_con);
            OracleCommand FilterationCommand1 = new OracleCommand(content, Oracle_Form.Destination_con);
            OracleDataReader reader0 = FilterationCommand.ExecuteReader();
            reader0 = FilterationCommand1.ExecuteReader();
            if (functions.Checked)
            {


#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('FUNCTION',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('FUNCTION') order by OBJECT_NAME", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('FUNCTION',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('FUNCTION') order by OBJECT_NAME", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 15;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                    p1.Value = 20;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
                }
                finally
                {
                   /* if (result != result1)
                    {
                        MessageBox.Show("Check functions, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
            p1.Value = 25;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
            if (sequence.Checked)
            {
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('SEQUENCE',u.sequence_name)  FROM USER_SEQUENCES u order by sequence_name", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('SEQUENCE',u.sequence_name)  FROM USER_SEQUENCES u order by sequence_name", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 30;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                }
                finally
                {
                   /* if (result != result1)
                    {
                        MessageBox.Show("Check sequences, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
            p1.Value = 40;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
            if (tables.Checked)
            {
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('TABLE',u.table_name)  FROM USER_TABLES u order by table_name", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('TABLE',u.table_name)  FROM USER_TABLES u order by table_name", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 45;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                    p1.Value = 50;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

                }
                finally
                {
                    /*if (result != result1)
                    {
                        MessageBox.Show("Check tables, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
            p1.Value = 55;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 
            if (package_body.Checked)
            {
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('PACKAGE BODY',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('PACKAGE BODY') order by OBJECT_NAME", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('PACKAGE BODY',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('PACKAGE BODY') order by OBJECT_NAME", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 60;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                    p1.Value = 65;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

                }
                finally
                {
                  /*  if (result != result1)
                    {
                        MessageBox.Show("Check package body, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
            p1.Value = 70;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));

            if (package_spec.Checked)
            {
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('PACKAGE SPECIFICATION',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('PACKAGE SPECIFICATION') order by OBJECT_NAME", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('PACKAGE SPECIFICATION',u.OBJECT_NAME)  FROM USER_OBJECTS u WHERE OBJECT_TYPE IN ('PACKAGE SPECIFICATION') order by OBJECT_NAME", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 75;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                    p1.Value = 80;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));

                }
                finally
                {
                   /* if (result != result1)
                    {
                        MessageBox.Show("Check package specification, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
            p1.Value = 85;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

            if (procedures.Checked)
            {
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd = new OracleCommand("select dbms_metadata.get_ddl('PROCEDURE',u.PROCEDURE_NAME)  FROM USER_PROCEDURES u order by PROCEDURE_NAME", Oracle_Form.Source_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning disable CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
                OracleCommand cmd1 = new OracleCommand("select dbms_metadata.get_ddl('PROCEDURE',u.PROCEDURE_NAME)  FROM USER_PROCEDURES u order by PROCEDURE_NAME", Oracle_Form.Destination_con);
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'
#pragma warning restore CS0618 // 'OracleCommand' is obsolete: 'OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260'

                OracleDataReader reader = cmd.ExecuteReader();
                OracleDataReader reader1 = cmd1.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        result = result + reader.GetString(0) + "\n";
                    }
                    p1.Value = 90;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));

                    while (reader1.Read())
                    {
                        result1 = result1 + reader1.GetString(0) + "\n";
                    }
                    p1.Value = 95;
                    p1.Refresh();
                    p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                             Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 

                }
                finally
                {
                  /*  if (result != result1)
                    {
                        MessageBox.Show("Check procedures, there is a difference");
                    }*/
                    // always call Close when done reading.
                    reader.Close();
                    reader1.Close();
                }
            }
          
            p1.Value = 100;
            p1.Refresh();
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7)); 
            sourceResult.Text = result;
            destinationResult.Text = result1;
            File.WriteAllText("ORACLE_SourceResult", result);
            File.WriteAllText("ORACLE_DestinationResult", result1);
            if (result == result1)
            {
                MessageBox.Show("Identical Schemas");
            }
            Oracle_Form.Source_con.Close();
            Oracle_Form.Destination_con.Close();

        }

        private void Oracle_Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void destinationResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sourceResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
