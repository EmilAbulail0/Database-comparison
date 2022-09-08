using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diff
{
    public partial class Cassandra_Form1 : Form
    {
        string source;
        string destination;
        bool finish = false;

        public Cassandra_Form1(CheckBox tables, CheckBox view, CheckBox function, string text1, string text2, string text3, string text4, ProgressBar p1)
        {

            p1.Minimum = 0;
            p1.Value = 2;
            updateProgress(5, p1);

            InitializeComponent();
            updateProgress(12, p1);
            Tables = tables;
            View = view;
            Function = function;
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;

            updateProgress(15, p1);
            if (Function.Checked)
            {
                source = source + listFunction(text1, text3,"source");
                source = source.Replace(text1 + ".", "");

                File.WriteAllText("SourceResult_Cassandra", source);

                updateProgress(20, p1);
                if (Function.Checked)
                    destination = destination + listFunction(text2, text4,"destination");
                    destination = destination.Replace(text2 + ".", "");

                File.WriteAllText("DestinationResult_Cassandra", destination);
                updateProgress(25, p1);

            }
            updateProgress(33, p1);
            if (View.Checked)
            {
                source = source + listView(text1, text3, "source");
                source = source.Replace(text1 + ".", "");

                File.WriteAllText("SourceResult_Cassandra", source);

                updateProgress(45,p1);
                
                destination = destination + listView(text2, text4, "destination");
                destination = destination.Replace(text2 + ".", "");

                File.WriteAllText("DestinationResult_Cassandra", destination);
                updateProgress(55, p1);
            }
            updateProgress(65, p1);
            if (Tables.Checked)
            {
                source = source + listTable(text1, text3, "source");
                source = source.Replace(text1 + ".", "");
                File.WriteAllText("SourceResult_Cassandra", source);

                updateProgress(75, p1);
                destination = destination + listTable(text2, text4,"destination");
                destination = destination.Replace(text2 + ".", "");

                File.WriteAllText("DestinationResult_Cassandra", destination);
                updateProgress(85, p1);
            }

            updateProgress(99, p1);
            finish = true;
            sourceResult1.Text = source;
            destinationResult1.Text = destination;

            if (source == destination)
            {
                MessageBox.Show("Identical Schemas");
            }
            else if (source != destination)
            {
                MessageBox.Show("Different Schemas");
            }

        }

        private void updateProgress(int v, ProgressBar p1)
        {
            p1.Value = v;
            p1.CreateGraphics().DrawString(p1.Value + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                                     Brushes.Red, new PointF(p1.Width / 2 - 10, p1.Height / 2 - 7));
        }

        private string listFunction(string text, string text1, string x)
        {
            var strCmdText_functionslist = $"cqlsh {text1} -e \"use {text}; describe functions\" > {x}_{text}_functions.txt";

            ProcessStartInfo proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + strCmdText_functionslist;
           
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            var running = Process.Start(proc1);
            running.WaitForExit();
            Thread.Sleep(20);
            var functionList_FilePath = proc1.WorkingDirectory + $"\\{x}_{text}_functions.txt";


            string functionlist_result = System.IO.File.ReadAllText(functionList_FilePath);

            //File.Delete(functionList_FilePath);

            List<string> list = new List<string>();
            list = functionlist_result.Split(new[] { "  " }, StringSplitOptions.None).ToList();
            var strCmdText_functionsshow = "";
            var functionsDescription = "";
            int i = 0;
            foreach (var l in list)
            {
                string[] functionName = l.ToString().Replace("\r\n", string.Empty).Split('(');
                strCmdText_functionsshow = $"cqlsh {text1} -e \"use {text}; describe function {functionName[0]}\" > {x}_{text}_function{i}.txt";
                proc1.UseShellExecute = true;
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + strCmdText_functionsshow;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                var running1 = Process.Start(proc1);
                running1.WaitForExit();

                var filePath1 = proc1.WorkingDirectory + $"\\{x}_{text}_function{i}.txt";
                functionsDescription = functionsDescription + System.IO.File.ReadAllText(filePath1);
               //File.Delete(filePath1);

                i++;
            }
            return functionsDescription;
        }

        private string listView(string text, string text1, string x)
        {
            var strCmdText_viewslist = $"cqlsh {text1} -e \"select view_name from system_schema.views where keyspace_name = '{text}'\" > {x}_{text}_views.txt";

            ProcessStartInfo proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + strCmdText_viewslist;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            var running = Process.Start(proc1);
            running.WaitForExit();
            Thread.Sleep(20);
            var tableList_FilePath = proc1.WorkingDirectory + $"\\{x}_{text}_views.txt";


            string viewslist_result = System.IO.File.ReadAllText(tableList_FilePath);
            // File.Delete(tableList_FilePath);

            List<string> list = new List<string>();
            list = viewslist_result.Split(new[] { "\n" }, StringSplitOptions.None).ToList();
            list = list.Skip(3).ToList();
            list = list.Take(list.Count - 3).ToList();
            var strCmdText_tablesshow = "";
            var viewsDescription = "";
            int i = 0;
            foreach (var l in list)
            {
                string viewName = l.ToString().Replace("\n", string.Empty).Replace(" ", string.Empty).Replace("\r", string.Empty);

                strCmdText_tablesshow = $"cqlsh {text1} -e \"use {text}; describe {viewName}\" > {x}_{text}_view{i}.txt";
                proc1.UseShellExecute = true;
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + strCmdText_tablesshow;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                var running1 = Process.Start(proc1);
                running1.WaitForExit();

                var filePath1 = proc1.WorkingDirectory + $"\\{x}_{text}_view{i}.txt";
                viewsDescription = viewsDescription + System.IO.File.ReadAllText(filePath1);
                //    File.Delete(filePath1);

                i++;
            }
            return viewsDescription;

        }

        private string listTable(string text, string text1, string x)
        {
            var strCmdText_tableslist = $"cqlsh {text1} -e \"use {text}; describe tables\" > {x}_{text}_tables.txt";

            ProcessStartInfo proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + strCmdText_tableslist;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            var running = Process.Start(proc1);
            running.WaitForExit();
            Thread.Sleep(20);
            var tableList_FilePath = proc1.WorkingDirectory + $"\\{x}_{text}_tables.txt";


            string tablelist_result = System.IO.File.ReadAllText(tableList_FilePath);
            //  File.Delete(tableList_FilePath);


            List<string> list = new List<string>();
            list = tablelist_result.Split(new[] { "  " }, StringSplitOptions.None).ToList();
            var strCmdText_tablesshow = "";
            var tablesDescription = "";
            int i = 0;
            foreach (var l in list)
            {
                string tableName = l.ToString().Replace("\r\n", string.Empty);

                strCmdText_tablesshow = $"cqlsh {text1} -e \"use {text}; describe {tableName}\" > {x}_{text}_table{i}.txt";
                proc1.UseShellExecute = true;
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + strCmdText_tablesshow;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                var running1 = Process.Start(proc1);
                running1.WaitForExit();

                var filePath1 = proc1.WorkingDirectory + $"\\{x}_{text}_table{i}.txt";
                var temp = System.IO.File.ReadAllText(filePath1);
                tablesDescription = tablesDescription + temp;
                // File.Delete(filePath1);

                i++;
            }
            return tablesDescription;

        }

        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public string Text4 { get; }
        public CheckBox Tables { get; }
        public CheckBox View { get; }
        public CheckBox Materialized_view { get; }
        public CheckBox Function { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Do you want to delete the generated files?", "Path", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32");
            }
            Application.Exit();
        }
    }
}
