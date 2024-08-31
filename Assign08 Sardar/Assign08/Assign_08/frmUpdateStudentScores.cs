using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.AxHost;

namespace Assign_08
{
    public partial class frmUpdateStudentScores : Form
    {
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }
        public Student Student { get; set; }
        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            DisplayStudentData();
        }

        /// <summary>
        /// Displays the selected cloned student data
        /// </summary>
        private void DisplayStudentData()
        {
            //get cloned student name
            txtName.Text = Student.Name;

            lstScores.Items.Clear();
            foreach (int score in Student.Scores)
            {
                lstScores.Items.Add(score); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstScores.SelectedIndex;
            try
            {
                if (selectedIndex != -1)
                {
                    var selectedScore = lstScores.SelectedItem; //old selected score
                    frmAddOrUpdateScore addOrUpdateScoreFrm = new frmAddOrUpdateScore()
                    {
                        AddScore = false,
                        SelectedItemObj = selectedScore
                    };
                    DialogResult result = addOrUpdateScoreFrm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Student.Scores[selectedIndex] = Convert.ToInt32(addOrUpdateScoreFrm.SelectedItemObj);
                        DisplayStudentData();
                    }
                }
                else
                {
                    MessageBox.Show("You must select a score to be updated.", "Invalid Selection");
                }
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
            try
            {
                frmAddOrUpdateScore addOrUpdateScoreFrm = new frmAddOrUpdateScore()
                {
                    AddScore = true, //add score is set to true
                };
                DialogResult result = addOrUpdateScoreFrm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Student.Scores.Add(Convert.ToInt32(addOrUpdateScoreFrm.SelectedItemObj));
                    DisplayStudentData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private void btnOk_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstScores.SelectedIndex;
            if (selectedIndex != -1)
            {
                var score = Student.Scores[selectedIndex];
                string message = "Are you sure you want to remove score "
                    + score + " from the score list?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Remove",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    Student.Scores.Remove(score);
                    DisplayStudentData();
                }
            }
            else
            {
                MessageBox.Show("You must select a score to be removed.", "Invalid Selection");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lstScores.Items.Count > 0)
            {
                string message = "Are you sure you want to delete all scores for " + Student.Name + "?";
                DialogResult button =
                       MessageBox.Show(message, "Confirm Clear Scores",
                       MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    Student.Scores.Clear();
                    DisplayStudentData();
                }
            }
            else
            {
                MessageBox.Show("The score list is already empty.", "Invalid Selection");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
