using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assign_08
{
    /// <summary>
    /// StudentList methods to fill and save student data from and into the form list field
    /// </summary>
    public class StudentList : List<Student>
    {
        #region Methods
        /// <summary>
        /// Gets student data from the StudentDB and adds it into the students list
        /// </summary>
        public void Fill()
        {
            List<Student> students = StudentDB.GetStudents();
            foreach (Student student in students)
                base.Add(student);
        }
        /// <summary>
        /// Saves the updated student data into the directory
        /// </summary>
        public void Save() => StudentDB.SaveStudents(this);
        #endregion
    }

}


