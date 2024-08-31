namespace Assign06
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
            btnSearchDirectory = new Button();
            lblEnterPathSearch = new Label();
            lblDirectory = new Label();
            txtPathSearch = new TextBox();
            txtDirectory = new TextBox();
            txtResultList = new TextBox();
            SuspendLayout();
            // 
            // btnSearchDirectory
            // 
            btnSearchDirectory.Location = new Point(444, 161);
            btnSearchDirectory.Name = "btnSearchDirectory";
            btnSearchDirectory.Size = new Size(165, 29);
            btnSearchDirectory.TabIndex = 2;
            btnSearchDirectory.Text = "SearchDirectory";
            btnSearchDirectory.UseVisualStyleBackColor = true;
            btnSearchDirectory.Click += btnSearchDirectory_Click;
            // 
            // lblEnterPathSearch
            // 
            lblEnterPathSearch.AutoSize = true;
            lblEnterPathSearch.Location = new Point(113, 61);
            lblEnterPathSearch.Name = "lblEnterPathSearch";
            lblEnterPathSearch.Size = new Size(143, 20);
            lblEnterPathSearch.TabIndex = 0;
            lblEnterPathSearch.Text = "Enter path to Search";
            // 
            // lblDirectory
            // 
            lblDirectory.AutoSize = true;
            lblDirectory.Location = new Point(149, 118);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(77, 20);
            lblDirectory.TabIndex = 5;
            lblDirectory.Text = "Directory: ";
            // 
            // txtPathSearch
            // 
            txtPathSearch.Location = new Point(260, 61);
            txtPathSearch.Name = "txtPathSearch";
            txtPathSearch.Size = new Size(349, 27);
            txtPathSearch.TabIndex = 1;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(260, 115);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.ReadOnly = true;
            txtDirectory.Size = new Size(349, 27);
            txtDirectory.TabIndex = 6;
            txtDirectory.TabStop = false;
            // 
            // txtResultList
            // 
            txtResultList.BackColor = SystemColors.ControlLightLight;
            txtResultList.Location = new Point(260, 222);
            txtResultList.Multiline = true;
            txtResultList.Name = "txtResultList";
            txtResultList.ReadOnly = true;
            txtResultList.Size = new Size(349, 181);
            txtResultList.TabIndex = 3;
            // 
            // Form1
            // 
            AcceptButton = btnSearchDirectory;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultList);
            Controls.Add(txtDirectory);
            Controls.Add(txtPathSearch);
            Controls.Add(lblDirectory);
            Controls.Add(lblEnterPathSearch);
            Controls.Add(btnSearchDirectory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchDirectory;
        private Label lblEnterPathSearch;
        private Label lblDirectory;
        private TextBox txtPathSearch;
        private TextBox txtDirectory;
        private TextBox txtResultList;
        private ListBox listBox1;
    }
}
