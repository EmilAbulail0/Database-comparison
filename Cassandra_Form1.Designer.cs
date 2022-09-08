namespace Diff
{
    partial class Cassandra_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cassandra_Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationResult1 = new System.Windows.Forms.TextBox();
            this.sourceResult1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1016, 777);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(779, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(243, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source";
            // 
            // destinationResult1
            // 
            this.destinationResult1.AcceptsReturn = true;
            this.destinationResult1.AcceptsTab = true;
            this.destinationResult1.Location = new System.Drawing.Point(621, 73);
            this.destinationResult1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationResult1.Multiline = true;
            this.destinationResult1.Name = "destinationResult1";
            this.destinationResult1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.destinationResult1.Size = new System.Drawing.Size(468, 669);
            this.destinationResult1.TabIndex = 12;
            // 
            // sourceResult1
            // 
            this.sourceResult1.AcceptsReturn = true;
            this.sourceResult1.AcceptsTab = true;
            this.sourceResult1.Location = new System.Drawing.Point(69, 73);
            this.sourceResult1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sourceResult1.Multiline = true;
            this.sourceResult1.Name = "sourceResult1";
            this.sourceResult1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceResult1.Size = new System.Drawing.Size(472, 669);
            this.sourceResult1.TabIndex = 13;
            // 
            // Cassandra_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diff.Properties.Resources.تصميم_بدون_عنوان__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 825);
            this.Controls.Add(this.sourceResult1);
            this.Controls.Add(this.destinationResult1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cassandra_Form1";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destinationResult1;
        private System.Windows.Forms.TextBox sourceResult1;
    }
}