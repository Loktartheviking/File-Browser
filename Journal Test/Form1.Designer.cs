namespace Journal_Test
{
    partial class Form1
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
            this.openFile = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.ListBox();
            this.fileName = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseDir = new System.Windows.Forms.Button();
            this.UpdateDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(368, 199);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.FormattingEnabled = true;
            this.filePath.Location = new System.Drawing.Point(12, 20);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(329, 342);
            this.filePath.TabIndex = 1;
            this.filePath.SelectedIndexChanged += new System.EventHandler(this.filePath_SelectedIndexChanged);
            // 
            // fileName
            // 
            this.fileName.FormattingEnabled = true;
            this.fileName.Location = new System.Drawing.Point(497, 12);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(291, 407);
            this.fileName.TabIndex = 2;
            this.fileName.SelectedIndexChanged += new System.EventHandler(this.fileName_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Directory";
            // 
            // browseDir
            // 
            this.browseDir.Location = new System.Drawing.Point(348, 399);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(75, 23);
            this.browseDir.TabIndex = 5;
            this.browseDir.Text = "Browse";
            this.browseDir.UseVisualStyleBackColor = true;
            this.browseDir.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateDir
            // 
            this.UpdateDir.Location = new System.Drawing.Point(266, -1);
            this.UpdateDir.Name = "UpdateDir";
            this.UpdateDir.Size = new System.Drawing.Size(75, 23);
            this.UpdateDir.TabIndex = 6;
            this.UpdateDir.Text = "Update";
            this.UpdateDir.UseVisualStyleBackColor = true;
            this.UpdateDir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recent Files";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateDir);
            this.Controls.Add(this.browseDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.ListBox filePath;
        private System.Windows.Forms.ListBox fileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseDir;
        private System.Windows.Forms.Button UpdateDir;
        private System.Windows.Forms.Label label2;
    }
}

