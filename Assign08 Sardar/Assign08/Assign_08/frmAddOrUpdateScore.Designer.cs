namespace Assign_08
{
    partial class frmAddOrUpdateScore
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
            lblScore = new Label();
            txtScore = new TextBox();
            btnAddOrUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(53, 27);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(53, 20);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score: ";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(108, 23);
            txtScore.Margin = new Padding(3, 4, 3, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(90, 27);
            txtScore.TabIndex = 1;
            txtScore.Tag = "Score";
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Location = new Point(53, 71);
            btnAddOrUpdate.Margin = new Padding(3, 4, 3, 4);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(73, 31);
            btnAddOrUpdate.TabIndex = 2;
            btnAddOrUpdate.Tag = "Score";
            btnAddOrUpdate.Text = "&Add";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(149, 71);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddOrUpdateScore
            // 
            AcceptButton = btnAddOrUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 135);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAddOrUpdate);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddOrUpdateScore";
            Text = "Add Score";
            Load += frmAddOrUpdateScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private TextBox txtScore;
        private Button btnAddOrUpdate;
        private Button btnCancel;
    }
}