namespace Assign_08
{
    partial class frmStudentScoresMain
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
            lblStudents = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtAverage = new TextBox();
            lstStudents = new ListBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new Point(22, 19);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(66, 20);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "Students";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(349, 42);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "&Add New...";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(349, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "&Update...";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(349, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.Location = new Point(152, 167);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(84, 20);
            lblScoreTotal.TabIndex = 5;
            lblScoreTotal.Text = "Score total:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.Location = new Point(146, 207);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(90, 20);
            lblScoreCount.TabIndex = 6;
            lblScoreCount.Text = "Score count:";
            // 
            // lblAverage
            // 
            lblAverage.Location = new Point(169, 246);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(67, 20);
            lblAverage.TabIndex = 7;
            lblAverage.Text = "Average:";
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(252, 164);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(69, 27);
            txtScoreTotal.TabIndex = 8;
            txtScoreTotal.TabStop = false;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(252, 200);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(69, 27);
            txtScoreCount.TabIndex = 9;
            txtScoreCount.TabStop = false;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(252, 239);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(69, 27);
            txtAverage.TabIndex = 10;
            txtAverage.TabStop = false;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 20;
            lstStudents.Location = new Point(22, 42);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(299, 104);
            lstStudents.TabIndex = 11;
            lstStudents.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(349, 238);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmStudentScoresMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(465, 282);
            Controls.Add(btnExit);
            Controls.Add(lstStudents);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(lblStudents);
            Name = "frmStudentScoresMain";
            Text = "Student Scores";
            Load += frmStudentScoresMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudents;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
        private ListBox lstStudents;
        private Button btnExit;
    }
}
