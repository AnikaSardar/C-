namespace Assign_08
{
    partial class frmAddNewStudent
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
            lblName = new Label();
            lblScore = new Label();
            lblScores = new Label();
            txtName = new TextBox();
            txtScores = new TextBox();
            txtScore = new TextBox();
            btnAddScore = new Button();
            btnClearScores = new Button();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(23, 62);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(42, 15);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score: ";
            // 
            // lblScores
            // 
            lblScores.Location = new Point(23, 95);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(48, 15);
            lblScores.TabIndex = 2;
            lblScores.Text = "Scores:";
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 3;
            txtName.Tag = "Name";
            // 
            // txtScores
            // 
            txtScores.BackColor = SystemColors.Control;
            txtScores.Location = new Point(88, 92);
            txtScores.Name = "txtScores";
            txtScores.ReadOnly = true;
            txtScores.Size = new Size(239, 23);
            txtScores.TabIndex = 4;
            txtScores.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(88, 58);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 5;
            txtScore.Tag = "Score";
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(252, 58);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(75, 23);
            btnAddScore.TabIndex = 6;
            btnAddScore.Text = "&Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(230, 137);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(97, 23);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "&Clear Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(157, 175);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 8;
            btnOk.Text = "&OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(252, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddNewStudent
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(352, 218);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnClearScores);
            Controls.Add(btnAddScore);
            Controls.Add(txtScore);
            Controls.Add(txtScores);
            Controls.Add(txtName);
            Controls.Add(lblScores);
            Controls.Add(lblScore);
            Controls.Add(lblName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewStudent";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblScore;
        private Label lblScores;
        private TextBox txtName;
        private TextBox txtScores;
        private TextBox txtScore;
        private Button btnAddScore;
        private Button btnClearScores;
        private Button btnOk;
        private Button btnCancel;
    }
}