namespace Diff
{
    partial class Oracle_Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggle = new System.Windows.Forms.CheckBox();
            this.tables = new System.Windows.Forms.CheckBox();
            this.package_spec = new System.Windows.Forms.CheckBox();
            this.package_body = new System.Windows.Forms.CheckBox();
            this.procedures = new System.Windows.Forms.CheckBox();
            this.functions = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sequence = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "_______________________________________";
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.BackColor = System.Drawing.Color.Transparent;
            this.toggle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toggle.Location = new System.Drawing.Point(263, 238);
            this.toggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(116, 27);
            this.toggle.TabIndex = 3;
            this.toggle.Text = "Toggle All";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tables
            // 
            this.tables.AutoSize = true;
            this.tables.BackColor = System.Drawing.Color.Transparent;
            this.tables.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tables.Location = new System.Drawing.Point(55, 146);
            this.tables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(86, 27);
            this.tables.TabIndex = 4;
            this.tables.Text = "Tables";
            this.tables.UseVisualStyleBackColor = false;
            // 
            // package_spec
            // 
            this.package_spec.AutoSize = true;
            this.package_spec.BackColor = System.Drawing.Color.Transparent;
            this.package_spec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.package_spec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.package_spec.Location = new System.Drawing.Point(55, 192);
            this.package_spec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.package_spec.Name = "package_spec";
            this.package_spec.Size = new System.Drawing.Size(149, 27);
            this.package_spec.TabIndex = 5;
            this.package_spec.Text = "Package Spec";
            this.package_spec.UseVisualStyleBackColor = false;
            // 
            // package_body
            // 
            this.package_body.AutoSize = true;
            this.package_body.BackColor = System.Drawing.Color.Transparent;
            this.package_body.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.package_body.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.package_body.Location = new System.Drawing.Point(55, 238);
            this.package_body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.package_body.Name = "package_body";
            this.package_body.Size = new System.Drawing.Size(152, 27);
            this.package_body.TabIndex = 6;
            this.package_body.Text = "Package Body";
            this.package_body.UseVisualStyleBackColor = false;
            // 
            // procedures
            // 
            this.procedures.AutoSize = true;
            this.procedures.BackColor = System.Drawing.Color.Transparent;
            this.procedures.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procedures.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procedures.Location = new System.Drawing.Point(55, 282);
            this.procedures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.procedures.Name = "procedures";
            this.procedures.Size = new System.Drawing.Size(127, 27);
            this.procedures.TabIndex = 7;
            this.procedures.Text = "Procedures";
            this.procedures.UseVisualStyleBackColor = false;
            // 
            // functions
            // 
            this.functions.AutoSize = true;
            this.functions.BackColor = System.Drawing.Color.Transparent;
            this.functions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.functions.Location = new System.Drawing.Point(55, 325);
            this.functions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(112, 27);
            this.functions.TabIndex = 8;
            this.functions.Text = "Functions";
            this.functions.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(356, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Next >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sequence
            // 
            this.sequence.AutoSize = true;
            this.sequence.BackColor = System.Drawing.Color.Transparent;
            this.sequence.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sequence.Location = new System.Drawing.Point(55, 370);
            this.sequence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(120, 27);
            this.sequence.TabIndex = 21;
            this.sequence.Text = "Sequences";
            this.sequence.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 428);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 23);
            this.progressBar1.TabIndex = 22;
            this.progressBar1.UseWaitCursor = true;
            // 
            // Oracle_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diff.Properties.Resources.Oracle_Accelerates_Adoption_of_Enterprise_Blockchain_Worldwide;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 518);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sequence);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.procedures);
            this.Controls.Add(this.package_body);
            this.Controls.Add(this.package_spec);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Oracle_Form2";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox toggle;
        private System.Windows.Forms.CheckBox tables;
        private System.Windows.Forms.CheckBox package_spec;
        private System.Windows.Forms.CheckBox package_body;
        private System.Windows.Forms.CheckBox procedures;
        private System.Windows.Forms.CheckBox functions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox sequence;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}