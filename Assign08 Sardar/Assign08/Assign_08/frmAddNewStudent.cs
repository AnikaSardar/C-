using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_08
{
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private Student student;

        /// <summary>
        /// Get new student data
        /// </summary>
        /// <returns>Returns student object</returns>
        public Student GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }
       
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    txtScores.Text += txtScore.Text + " ";
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

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScores.Text))
            {
                string message = "Are you sure you want to clear all the scores for " + txtName.Text + "?";
                DialogResult button =
                       MessageBox.Show(message, "Confirm Clear All Scores",
                       MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    txtScores.Clear();
                }
            }
            else
            {
                MessageBox.Show("The score list is already empty.", "Invalid Selection");
            }
        }
        /// <summary>
        /// Validate student name and score 
        /// </summary>
        /// <returns>true if name is present and entered score is within an integer rang<e, otherwise returns false/returns>
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            errorMessage += Validator.IsInt32(txtScore.Text, txtScore.Tag.ToString(), 0, 100); //min int val=0 and max int val=100

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    student = new Student(txtName.Text);
                    //checks scores list to send data to frmStudentScoresMain
                    if (!string.IsNullOrEmpty(txtScores.Text))
                    {
                        string row = txtScores.Text;
                        string[] columns = row.Split(' ');

                        foreach (string col in columns)
                        {
                            if (!string.IsNullOrEmpty(col))
                                student.Scores.Add(Convert.ToInt32(col));
                        }
                    }
                }
                this.Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }
    }
}

