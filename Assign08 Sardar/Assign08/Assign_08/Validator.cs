using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assign_08
{
    /// <summary>
    /// Validator class to validate student data
    /// </summary>
    public static class Validator
    {
        #region Field
        private static string lineEnd = "\n";
        #endregion

        #region Property
        public static string LineEnd
        {
            get
            {
                return lineEnd;
            }
            set
            {
                lineEnd = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks to see if the named field is present
        /// </summary>
        /// <param name="value">Value of the field</param>
        /// <param name="name">Name of the field</param>
        /// <returns>Returns a string message</returns>
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Checks to see whether the value is a valid integers within a range
        /// </summary>
        /// <param name="value">Value of the field</param>
        /// <param name="name">Name of the field</param>
        /// <param name="min">Min value of the integer range</param>
        /// <param name="max">Max Value of the integer range</param>
        /// <returns></returns>
        public static string IsInt32(string value, string name, int min, int max)
        {
            string msg = "";
            if (string.IsNullOrEmpty(value) || !Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            if (!IsWithinRange(value, min, max))
            {
                msg += name + " must be between " + min + " and " + max + "." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Validate the entered score is within the entered range
        /// </summary>
        /// <param name="value">Integer value (score)</param>
        /// <param name="min">Minimum score allowed</param>
        /// <param name="max">Maximum score allowed</param>
        /// <returns></returns>
        public static bool IsWithinRange(string value, int min, int max)
        {
            if (Int32.TryParse(value, out int number))
            {
                if (number < min || number > max)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
