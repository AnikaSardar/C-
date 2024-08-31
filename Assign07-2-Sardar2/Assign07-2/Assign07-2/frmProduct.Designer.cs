namespace Assign07_2
{
    partial class frmProduct
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
            label1 = new Label();
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            Exit = new Button();
            btnViewProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Product List";
            // 
            // lstProducts
            // 
            lstProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 20;
            lstProducts.Location = new Point(12, 49);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(1141, 224);
            lstProducts.TabIndex = 2;
            lstProducts.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(278, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 316);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1059, 316);
            Exit.Name = "Exit";
            Exit.Size = new Size(72, 30);
            Exit.TabIndex = 3;
            Exit.Text = "E&xit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // btnViewProduct
            // 
            btnViewProduct.Location = new Point(21, 316);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new Size(126, 29);
            btnViewProduct.TabIndex = 1;
            btnViewProduct.Text = "View &Product";
            btnViewProduct.UseVisualStyleBackColor = true;
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Exit;
            ClientSize = new Size(1165, 380);
            ControlBox = false;
            Controls.Add(btnViewProduct);
            Controls.Add(Exit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstProducts);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProduct";
            Text = "Products List";
            Load += frmProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ColumnHeader Code;
        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button Exit;
        private Button btnViewProduct;
    }
}