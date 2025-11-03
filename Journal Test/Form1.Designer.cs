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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(526, 221);
            this.openFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(100, 28);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.FormattingEnabled = true;
            this.filePath.ItemHeight = 16;
            this.filePath.Location = new System.Drawing.Point(16, 25);
            this.filePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(502, 420);
            this.filePath.TabIndex = 1;
            this.filePath.SelectedIndexChanged += new System.EventHandler(this.filePath_SelectedIndexChanged);
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileName.FormattingEnabled = true;
            this.fileName.ItemHeight = 16;
            this.fileName.Location = new System.Drawing.Point(634, 31);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(416, 484);
            this.fileName.TabIndex = 2;
            this.fileName.SelectedIndexChanged += new System.EventHandler(this.fileName_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 491);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Directory";
            // 
            // browseDir
            // 
            this.browseDir.Location = new System.Drawing.Point(464, 491);
            this.browseDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(100, 28);
            this.browseDir.TabIndex = 5;
            this.browseDir.Text = "Browse";
            this.browseDir.UseVisualStyleBackColor = true;
            this.browseDir.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateDir
            // 
            this.UpdateDir.Location = new System.Drawing.Point(355, -1);
            this.UpdateDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateDir.Name = "UpdateDir";
            this.UpdateDir.Size = new System.Drawing.Size(100, 28);
            this.UpdateDir.TabIndex = 6;
            this.UpdateDir.Text = "Update";
            this.UpdateDir.UseVisualStyleBackColor = true;
            this.UpdateDir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recent Files";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateDir);
            this.Controls.Add(this.browseDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.openFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

