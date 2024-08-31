using Assign07_2.Models;
using Assign07_2.Models.DataLayer;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Assign07_2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string userRole;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                try
                {
                    string username = Convert.ToString(txtUsername.Text);
                    string password = Convert.ToString(txtPassword.Text);

                    this.GetUserRole(username, password);

                    if (userRole == null)
                    {
                        MessageBox.Show("No user found with this credential. " +
                            "Please try again.", "Invalid Login");
                    }
                    else
                    {
                        frmProduct frmProduct = new frmProduct
                        {
                            UserRole = userRole
                        };
                        frmProduct.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
                }
            }

        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage  += Validator.IsPresent(txtUsername.Text, txtUsername.Tag.ToString());
            errorMessage += Validator.IsPresent(txtPassword.Text, txtPassword.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtUsername.Focus();
            }
            return success;
        }
        private void GetUserRole(string username, string password)
        {
            CustomerCredential customerCredential = CustomerDB.GetCustomerCredential(username, password);
            AdminCredential adminCredential = AdminDB.GetAdminCredential(username, password);

            if (customerCredential != null)
            {
                userRole = "customer";
            }
            if (adminCredential != null)
            {
                userRole = "admin";
            }
        }

    }
}
