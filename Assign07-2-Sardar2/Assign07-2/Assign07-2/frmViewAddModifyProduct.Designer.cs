namespace Assign07_2
{
    partial class frmViewAddModifyProduct
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
            lblProductCode = new Label();
            lblProductCategoryID = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            txtProductCode = new TextBox();
            txtProductCategoryID = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAddModify = new Button();
            lblProductCategoryName = new Label();
            txtProductCategoryName = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(24, 31);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(99, 20);
            lblProductCode.TabIndex = 0;
            lblProductCode.Text = "Product Code";
            // 
            // lblProductCategoryID
            // 
            lblProductCategoryID.AutoSize = true;
            lblProductCategoryID.Location = new Point(24, 68);
            lblProductCategoryID.Name = "lblProductCategoryID";
            lblProductCategoryID.Size = new Size(143, 20);
            lblProductCategoryID.TabIndex = 1;
            lblProductCategoryID.Text = "Product Category ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(24, 145);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(24, 183);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(72, 20);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 222);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(214, 24);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(180, 27);
            txtProductCode.TabIndex = 1;
            txtProductCode.Tag = "Product Code";
            // 
            // txtProductCategoryID
            // 
            txtProductCategoryID.Location = new Point(214, 61);
            txtProductCategoryID.Name = "txtProductCategoryID";
            txtProductCategoryID.Size = new Size(180, 27);
            txtProductCategoryID.TabIndex = 2;
            txtProductCategoryID.TabStop = false;
            txtProductCategoryID.Tag = "Product Category ID";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(214, 145);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(180, 27);
            txtProductName.TabIndex = 4;
            txtProductName.Tag = "Product Name";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(214, 183);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(180, 27);
            txtUnitPrice.TabIndex = 5;
            txtUnitPrice.Tag = "Unit Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(214, 222);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 27);
            txtQuantity.TabIndex = 6;
            txtQuantity.Tag = "Quantity";
            // 
            // btnAddModify
            // 
            btnAddModify.Location = new Point(24, 278);
            btnAddModify.Name = "btnAddModify";
            btnAddModify.Size = new Size(94, 29);
            btnAddModify.TabIndex = 7;
            btnAddModify.Text = "&Add";
            btnAddModify.UseVisualStyleBackColor = true;
            btnAddModify.Click += btnAdd_Click;
            // 
            // lblProductCategoryName
            // 
            lblProductCategoryName.AutoSize = true;
            lblProductCategoryName.Location = new Point(24, 106);
            lblProductCategoryName.Name = "lblProductCategoryName";
            lblProductCategoryName.Size = new Size(168, 20);
            lblProductCategoryName.TabIndex = 13;
            lblProductCategoryName.Text = "Product Category Name";
            // 
            // txtProductCategoryName
            // 
            txtProductCategoryName.Location = new Point(214, 103);
            txtProductCategoryName.Name = "txtProductCategoryName";
            txtProductCategoryName.Size = new Size(180, 27);
            txtProductCategoryName.TabIndex = 3;
            txtProductCategoryName.Tag = "Product Category ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmViewAddModifyProduct
            // 
            AcceptButton = btnAddModify;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(420, 336);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(txtProductCategoryName);
            Controls.Add(lblProductCategoryName);
            Controls.Add(btnAddModify);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCategoryID);
            Controls.Add(txtProductCode);
            Controls.Add(lblQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblProductName);
            Controls.Add(lblProductCategoryID);
            Controls.Add(lblProductCode);
            Name = "frmViewAddModifyProduct";
            Text = "Add Product";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductCode;
        private Label lblProductCategoryID;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private TextBox txtProductCode;
        private TextBox txtProductCategoryID;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Button btnAddModify;
        private Label lblProductCategoryName;
        private TextBox txtProductCategoryName;
        private Button btnCancel;
    }
}