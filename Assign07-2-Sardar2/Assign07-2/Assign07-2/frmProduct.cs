using Assign07_2.Models;
using Assign07_2.Models.DataLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Assign07_2
{
    public partial class frmProduct : Form
    {
        private ProductList products = new ProductList();
        private Product product;
        public string UserRole { get; set; }
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (UserRole == "customer")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            products.Fill();
            this.GetProductCategory();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();

            lstProducts.Items.Add($"{nameof(product.ProductCode)}\t\t{nameof(product.ProductCategoryID)}\t\t{nameof(product.ProductCategory.ProductCategoryName)}\t\t{nameof(product.ProductName)}\t\t{nameof(product.UnitPrice)}\t\t{nameof(product.Quantity)}");
            foreach (Product p in products)
            {
                lstProducts.Items.Add(p.ToString());
            }
        }

        private void GetProductCategory()
        {
            foreach (Product p in products)
            {
                p.ProductCategory = ProductDB.GetProductCategory(p.ProductCategoryID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmViewAddModifyProduct addModifyForm = new frmViewAddModifyProduct
            {
                AddProduct = true
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                product = addModifyForm.Product;
                if (ValidateUniqueness(addModifyForm, product))
                {
                    products.Add(product);
                    ProductDB.AddProduct(product);
                    FillProductListBox();
                }
            }
        }

        private bool ValidateUniqueness(frmViewAddModifyProduct addModifyForm, Product product)
        {
            var productCategoryNameItem = products.FirstOrDefault(p => p.ProductCategory.ProductCategoryName == product.ProductCategory.ProductCategoryName);
            var productCodeItem = products.FirstOrDefault(p => p.ProductCode == product.ProductCode);

            if (productCategoryNameItem != null)
            {
                MessageBox.Show("A product with the same category name already exists. Please insert a different value.", "Invalid Insertion");
                return false;
            }
            if (productCodeItem != null)
            {
                MessageBox.Show("A product with the same product code already exists. Please insert a different value.", "Invalid Insertion");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProducts.SelectedIndex;
            if (selectedIndex > 0)
            {
                Product selectedProduct = products[selectedIndex];
                Product oldSelectedProduct = (Product)selectedProduct.CloneProduct();
                //clone selected product
                Product cloneSelectedProduct = (Product)selectedProduct.CloneProduct();

                frmViewAddModifyProduct addModifyForm = new frmViewAddModifyProduct
                {
                    AddProduct = false,
                    Product = cloneSelectedProduct

                };
                DialogResult result = addModifyForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    product = addModifyForm.Product;
                    if (ProductDB.UpdateProduct(oldSelectedProduct, product))
                    {
                        var oldListProduct = products.FirstOrDefault(p => p.ProductCategoryID == oldSelectedProduct.ProductCategoryID);
                        if (oldListProduct != null)
                        {
                            products.Remove(oldListProduct); // Remove the old product
                            products.Add(product); // Add the new product
                            FillProductListBox();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Please select a valid row", "Invalid Selection");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProducts.SelectedIndex;
            if (selectedIndex > 0)
            {
                Product selectedProduct = products[selectedIndex];

                DialogResult result =
                MessageBox.Show($"Delete {selectedProduct.ProductName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ProductDB.DeleteProduct(selectedProduct))
                    {
                        var oldListProduct = products.FirstOrDefault(p => p.ProductCategoryID == selectedProduct.ProductCategoryID);
                        if (oldListProduct != null)
                        {
                            // Remove the old product 
                            products.Remove(oldListProduct);
                            FillProductListBox();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Please select a valid row", "Invalid Selection");
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProducts.SelectedIndex;
            if (selectedIndex > 0)
            {
                Product selectedProduct = products[selectedIndex];
                Product cloneSelectedProduct = (Product)selectedProduct.CloneProduct();

                frmViewAddModifyProduct viewAddModifyForm = new frmViewAddModifyProduct
                {
                    AddProduct = false,
                    ViewProduct = true,
                    Product = cloneSelectedProduct

                };
                DialogResult result = viewAddModifyForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Please select a valid row", "Invalid Selection");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
