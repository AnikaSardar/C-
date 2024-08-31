using Assign07_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assign07_2
{
    public partial class frmViewAddModifyProduct : Form
    {
        public bool AddProduct { get; set; }
        public bool ViewProduct { get; set; }
        public Product Product { get; set; }
        public frmViewAddModifyProduct()
        {
            InitializeComponent();
        }
        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            txtProductCategoryID.Enabled = false;
            lblProductCategoryID.Enabled = false;

            if (this.ViewProduct)
            {
                btnAddModify.Text = "OK";
                this.Text = "View Product Details";
                DisplayProductData();
                ControlDisabled();

            }
            else if (this.AddProduct)
            {
                btnAddModify.Text = "Add";
                this.Text = "Add Product";
            }
            else
            {
                btnAddModify.Text = "Update";
                this.Text = "Update Product";
                DisplayProductData();
            }
        }

        private void ControlDisabled()
        {
            txtProductCategoryName.ReadOnly = true;
            txtProductCode.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtProductName.ReadOnly = true;

        }
        private void DisplayProductData()
        {
            try
            {
                txtProductCode.Text = Product.ProductCode;
                txtProductCategoryID.Text = Convert.ToString(Product.ProductCategory.ProductCategoryID);
                txtProductCategoryName.Text = Product.ProductCategory.ProductCategoryName;
                txtProductName.Text = Product.ProductName;
                txtUnitPrice.Text = Convert.ToString(Product.UnitPrice);
                txtQuantity.Text = Convert.ToString(Product.Quantity);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                if (this.AddProduct)
                    this.Product = new Product();
                this.LoadProductData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoadProductData()
        {
            this.Product.ProductCategory = new ProductCategory();
            try
            {
                if (!this.AddProduct)
                {
                    Product.ProductCategory.ProductCategoryID = Convert.ToInt32(txtProductCategoryID.Text);
                }
                Product.ProductCode = txtProductCode.Text;
                Product.ProductCategory.ProductCategoryName = txtProductCategoryName.Text;
                Product.ProductName = txtProductName.Text;
                Product.Quantity = Convert.ToInt32(txtQuantity.Text);
                Product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
            
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtProductCategoryName.Text, txtProductCategoryName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtProductName.Text, txtProductName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtQuantity.Text, txtQuantity.Tag.ToString());
            errorMessage += Validator.IsInt32(txtQuantity.Text, txtQuantity.Tag.ToString());
            errorMessage += Validator.IsPresent(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtProductCode.Focus();
            }
            return success;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
