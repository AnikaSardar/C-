namespace Assign_08
{
    public partial class frmStudentScoresMain : Form
    {
        public frmStudentScoresMain()
        {
            InitializeComponent();
        }

        private StudentList students = new StudentList();
        private Student student;
        private void frmStudentScoresMain_Load(object sender, EventArgs e)
        {
            students.Fill();
            FillStudentListBox();
        }
        /// <summary>
        /// Fills the student data list in alphabetical order
        /// </summary>
        private void FillStudentListBox()
        {
            lstStudents.Items.Clear();

            //sort names in ascending order
            students.Sort((previous, current) => string.Compare(previous.Name.ToLower(), current.Name.ToLower()));

            foreach (Student s in students)
            {
                lstStudents.Items.Add(s.ToString());
            }
            //event-handler for the selected item info
            lstStudents.SelectedIndexChanged += DisplayStudentScoreSummary;

            //default select the first item
            if (lstStudents.Items.Count > 0)
                lstStudents.SelectedIndex = 0;
        }

        /// <summary>
        /// Displays a student scorse summary in count, sum, average
        /// </summary>
        /// <param name="sender">Selected item that raised the event</param>
        /// <param name="e">Contains click event data</param>
        private void DisplayStudentScoreSummary(object? sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstStudents.SelectedIndex;
                if (selectedIndex != -1)
                {
                    string row = (String)lstStudents.Items[selectedIndex];
                    string[] columns = row.Split('|');
                    List<int> scoresList = new List<int>();

                    for (int i = 1; i < columns.Length; i++)
                    {
                        if (Int32.TryParse(columns[i], out int score))
                        {
                            scoresList.Add(score);
                        }
                    }
                    DisplayStudentStatistics(scoresList);
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
        /// Fills the text field with count, total, and average scores 
        /// </summary>
        /// <param name="scoresList">Contains scores list of a selected student</param>
        private void DisplayStudentStatistics(List<int> scoresList)
        {
            try
            {
                if (scoresList.Count > 0)
                {
                    txtScoreCount.Text = Convert.ToString(scoresList.Count());
                    txtScoreTotal.Text = Convert.ToString(scoresList.Sum());
                    txtAverage.Text = Convert.ToString((int)(scoresList.Average())); //casting int to double
                }
                else
                {
                    ClearControls();
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
        /// Clear fields of score summary
        /// </summary>
        private void ClearControls()
        {
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            txtAverage.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewStudent newForm = new frmAddNewStudent();
            student = newForm.GetNewStudent();
            if (student != null)
            {
                students.Add(student);
                students.Save();
                FillStudentListBox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;
            if (selectedIndex != -1)
            {
                Student selectedStudent = students[selectedIndex];
                //clone selected student
                Student cloneSelectedStudent = (Student)selectedStudent.Clone();

                frmUpdateStudentScores updateStdScoreFrm = new frmUpdateStudentScores
                {
                    Student = cloneSelectedStudent 
                };
                DialogResult result = updateStdScoreFrm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    student = updateStdScoreFrm.Student;
                    students.Save();
                    FillStudentListBox();
                }
            }
            else
            {
                MessageBox.Show("You must select a student to update.", "Invalid Selection");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstStudents.SelectedIndex;
            if (selectedIndex != -1)
            {
                Student student = students[selectedIndex];
                string message = "Are you sure you want to delete " + student.Name + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    students.Remove(student);
                    students.Save();
                    FillStudentListBox();
                }
            }
            else
            {
                MessageBox.Show("You must select a student to delete.", "Invalid Selection");
            }
            //when the list is empty, clear student score summary
            if (lstStudents.SelectedIndex == -1)
            {
                ClearControls();
            }
        }
        private void btnExit_Click(object sender, EventArgs e) => this.Close();   
    }
}
