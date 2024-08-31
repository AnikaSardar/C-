using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Assign_08
{
    /// <summary>
    /// Student class with student data & clone method
    /// </summary>
    public class Student: ICloneable
    {
        #region Auto-Implemented Properties
        public string Name { get; set; }
        public List<int> Scores { get; set; }
        #endregion

        #region Constructors
        public Student()
        {
            this.Name = string.Empty;
            this.Scores = new List<int>();
        }
        public Student(string name)
        {
            this.Name = name;
            this.Scores = new List<int>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Override object class ToString() Method
        /// </summary>
        /// <returns>String representation of each student object that includes the student name and scores</returns>
        public override string ToString() => Name + string.Join("|", DisplayScores(Scores));

        /// <summary>
        ///  Display student scores using StringBuilder
        /// </summary>
        /// <param name="Scores">List of student scores</param>
        /// <returns>Displays the scores in string</returns>
        public string DisplayScores(List<int> Scores)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int score in Scores)
            {
                sb.Append("|").Append(score);
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Clone a student object
        /// </summary>
        /// <returns>A deep cloned student object</returns>
        public object Clone()
        { 
            Student s = new Student();
            s.Name = this.Name;
            s.Scores = this.Scores;
            return s;
        }
        #endregion 
    }
}
