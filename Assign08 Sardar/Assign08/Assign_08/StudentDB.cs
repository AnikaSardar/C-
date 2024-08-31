using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assign_08
{
    /// <summary>
    /// Student database class to retrieve or save student data
    /// </summary>
    internal class StudentDB
    {
        #region Fields
        private const string dir = @"C:\C#\Files\";
        private const string path = dir + "StudentScores.txt";
        #endregion

        #region Methods
        /// <summary>
        /// Gets student data from the directory
        /// </summary>
        /// <returns>List of students with their names and scores (optional)</returns>
        public static List<Student> GetStudents()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<Student> students = new List<Student>();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                string name = columns[0];
                List<int> scoresList = new List<int>();

                for (int i = 1; i < columns.Length; i++)
                {
                    if (Int32.TryParse(columns[i], out int score))
                    {
                        scoresList.Add(score);
                    }
                }
                students.Add(new Student { Name = name, Scores = scoresList });
            }
            textIn.Close();
            return students;
        }

        /// <summary>
        /// Saves student data into the directory
        /// </summary>
        /// <param name="students">List of students with their names and scores (optional)</param>
        public static void SaveStudents(List<Student> students)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                    new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each product
            foreach (Student student in students)
            {
                textOut.Write(student.Name);
                if (student.Scores.Count > 0)
                {
                    foreach (int score in student.Scores)
                    {
                        textOut.Write("|" + score); 
                    }
                }
                textOut.WriteLine();
            }
            // write the end of the document
            textOut.Close();
        }
    }
    #endregion
}
