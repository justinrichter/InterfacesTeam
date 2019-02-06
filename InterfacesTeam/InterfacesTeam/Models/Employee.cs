using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InterfacesTeam.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmployeeFullName { get; set; }
        public string Title { get; set; }

        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Description { get; set; }

        public Skill[] Skills { get; set; }
        public DateTime HiredDate { get; set; }
        public double AverageRating { get; set; }
        public string Team { get; set; }


        public string DisplayText
        {
            get
            {
                return EmployeeFullName;
            }
        }

        // Team-Member.png
        public string CoverImageFileName
        {
            get
            {
                return EmployeeFullName + ".png";
            }
        }
    }
}