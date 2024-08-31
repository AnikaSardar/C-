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

namespace Assign_08
{
    public partial class frmAddOrUpdateScore : Form
    {
        public frmAddOrUpdateScore()
        {
            InitializeComponent();
        }
        #region Auto-Implemented Property
        public bool AddScore { get; set; }
        public object SelectedItemObj { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Form caption and button text changes depending on the selected option in frmUpdateStudentScores
        /// </summary>
        /// <param name="sender">References the button that raised the click event</param>
        /// <param name="e">Contains the click event data</param>
        private void frmAddOrUpdateScore_Load(object sender, EventArgs e)
        {
            if (this.AddScore)
            {
                btnAddOrUpdate.Text = "Add";
                this.Text = "Add Score";
            }
            else
            {
                btnAddOrUpdate.Text = "Update";
                this.Text = "Update Score";
                DisplaySelectedScore();
            }
        }
        /// <summary>
        /// Displays the selected score from frmUpdateScores
        /// </summary>
        private void DisplaySelectedScore() => txtScore.Text = SelectedItemObj.ToString();

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    SelectedItemObj = txtScore.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    txtScore.Clear();
                    txtScore.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }
        /// <summary>
        /// Validates the entered score is within a certain integer range
        /// </summary>
        /// <returns>true if it meets the criteria otherwise returns false</returns>
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage = Validator.IsInt32(txtScore.Text, txtScore.Tag.ToString(), 0, 100);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        #endregion
    }
}
