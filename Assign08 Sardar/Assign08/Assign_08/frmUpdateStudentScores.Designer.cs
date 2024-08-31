namespace Assign_08
{
    partial class frmUpdateStudentScores
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
            lblScores = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnOk = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            lstScores = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(33, 84);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(55, 20);
            lblScores.TabIndex = 1;
            lblScores.Text = "Scores:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(248, 84);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 123);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 31);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(248, 161);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(105, 31);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 200);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear Scores";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(142, 267);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 31);
            btnOk.TabIndex = 6;
            btnOk.Text = "&OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(248, 267);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(98, 35);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(235, 27);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            // 
            // lstScores
            // 
            lstScores.FormattingEnabled = true;
            lstScores.ItemHeight = 20;
            lstScores.Location = new Point(98, 84);
            lstScores.Name = "lstScores";
            lstScores.Size = new Size(126, 144);
            lstScores.TabIndex = 10;
            lstScores.TabStop = false;
            // 
            // frmUpdateStudentScores
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(379, 352);
            ControlBox = false;
            Controls.Add(lstScores);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblScores);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateStudentScores";
            Text = "Update Student Scores";
            Load += frmUpdateStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblScores;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClear;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtName;
        private ListBox lstScores;
    }
}