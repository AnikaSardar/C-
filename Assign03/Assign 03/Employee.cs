using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_03
{
    /// <summary>
    /// Employee class with public properties for Name, Id, and Salary
    /// and ToString() method to print the current state of the object
    /// </summary>
    internal class Employee
    {
        public string Name { get; set; }
        public long Id { get; set; }

        private decimal salary;

        #region Constructors

        /// <summary>
        /// No args constructor with default values
        /// </summary>
        public Employee()
        {
            Name = String.Empty; 
            Id = 0;
            Salary = 0;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Employee's Name</param>
        /// <param name="id">Employee's ID</param>
        /// <param name="salary">Employee's Salary</param>
        public Employee(string name, long id, decimal salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        #endregion
        
        /// <summary>
        /// Employee's salary property
        /// </summary>
        public decimal Salary
        {
            get 
            {
                return salary; 
            }
            set 
            {
                if (value > 0) //if salary is neg, leaves salary unchanged
                {
                    salary = value;
                }
            }
        }

        /// <summary>
        /// Overrides default ToString() method and uses StringBuilder class 
        /// </summary>
        /// <returns>Current state of the Employee object</returns>
        public override string ToString()
        {
            StringBuilder employeeInfo = new StringBuilder();
            
            employeeInfo.Append($"Employee Id is {Id}, name is {Name}, and salary is {Salary:c}");
            
            return employeeInfo.ToString();
        }


    }
}
