namespace CC_Computer_Programing_Computer_Installer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkedListBox1 = new CheckedListBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Git", "Github Desktop", "Java JDK 21", "Python 3.12.1", "Visual Studio 2019", "Visual Studio 2022", "Vs Code" });
            checkedListBox1.Location = new Point(12, 233);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(171, 246);
            checkedListBox1.Sorted = true;
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 10);
            label1.Size = new Size(518, 93);
            label1.TabIndex = 3;
            label1.Text = "Select Programs to Install";
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(0, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 105);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(782, 753);
            Controls.Add(panel1);
            Controls.Add(checkedListBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CC Computer Programing Computer Installer";
            TopMost = true;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Panel panel1;
    }
}
