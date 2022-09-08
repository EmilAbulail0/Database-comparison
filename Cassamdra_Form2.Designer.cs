using System.Drawing;

namespace Diff
{
    partial class Cassamdra_Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.function = new System.Windows.Forms.CheckBox();
            this.view = new System.Windows.Forms.CheckBox();
            this.tables = new System.Windows.Forms.CheckBox();
            this.toggle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(355, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Next >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.BackColor = System.Drawing.Color.Transparent;
            this.function.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function.ForeColor = System.Drawing.SystemColors.ControlText;
            this.function.Location = new System.Drawing.Point(51, 246);
            this.function.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(197, 27);
            this.function.TabIndex = 27;
            this.function.Text = "Function/Procedure";
            this.function.UseVisualStyleBackColor = false;
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.view.Location = new System.Drawing.Point(51, 190);
            this.view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(74, 27);
            this.view.TabIndex = 26;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            // 
            // tables
            // 
            this.tables.AutoSize = true;
            this.tables.BackColor = System.Drawing.Color.Transparent;
            this.tables.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tables.Location = new System.Drawing.Point(51, 132);
            this.tables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(86, 27);
            this.tables.TabIndex = 25;
            this.tables.Text = "Tables";
            this.tables.UseVisualStyleBackColor = false;
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.BackColor = System.Drawing.Color.Transparent;
            this.toggle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toggle.Location = new System.Drawing.Point(307, 190);
            this.toggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(116, 27);
            this.toggle.TabIndex = 24;
            this.toggle.Text = "Toggle All";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.CheckedChanged += new System.EventHandler(this.toggle_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "_____________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Types";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 345);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 25);
            this.progressBar1.TabIndex = 22;
            this.progressBar1.UseWaitCursor = true;
            // 
            // Cassamdra_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diff.Properties.Resources.تصميم_بدون_عنوان__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.view);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cassamdra_Form2";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Cassamdra_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox function;
        private System.Windows.Forms.CheckBox view;
        private System.Windows.Forms.CheckBox tables;
        private System.Windows.Forms.CheckBox toggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}