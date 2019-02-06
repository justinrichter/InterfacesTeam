using InterfacesTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfacesTeam.Data
{
    public class EmployeeRepository
    {
        private static Employee[] _employees = new Employee[]
        {
        new Employee()
            {
                Id = 1,
                EmployeeFullName = "Omprakash Sharma",
                LastName = "Sharma",
                FirstName = "Omprakash",
                Title = "Citius Tech Developer",
                Team = "Interfaces Dev 911",
                Description = "<p>Om is one of the most promising Citius Tech Contractors with a wide range of skills.</strong></p>",
                AverageRating = 9,
                Skills = new Skill[]
                {
                    new Skill() {Name = "SQL"},
                    new Skill() {Name = "Cache ObjectScript"}
                }
            },
            new Employee()
            {
                Id = 2,
                EmployeeFullName = "Satin Mandlik",
                LastName = "Mandlik",
                FirstName = "Satin",
                Title = "Citius Tech Developer",
                Team = "Interfaces Dev 911",
                Description = "<p>Satin is a dependable developer that you want on your team.</p>",
                AverageRating = 8,
                Skills = new Skill[]
                {
                    new Skill() {Name = "SQL"},
                    new Skill() {Name = "Cache ObjectScript"}
                }
            },
            new Employee()
            {
                Id = 3,
                EmployeeFullName = "Deepali Pai",
                LastName = "Pai",
                FirstName = "Deepali",
                Title = "Software Engineer II - Interfaces",
                Team = "Interfaces Dev 911",
                Description = "<p>Deepali has a wide-range of development expertise and tackles some of the highest priority items on the team.</p>",
                AverageRating = 10,
                Skills = new Skill[]
                {
                    new Skill() {Name = "SQL"},
                    new Skill() {Name = "Cache ObjectScript"}
                }
            },
            new Employee()
            {
                Id = 4,
                EmployeeFullName = "Ramesh Ramachandran",
                LastName = "Ramachandran",
                FirstName = "Ramesh",
                Title = "Sr. Systems Developer - Interfaces",
                Team = "Olympians",
                Description = "<p>Ramesh's in-depth understanding of InterSystems and our most complicated interfaces is key to the team's success!</p>",
                AverageRating = 10,
                Skills = new Skill[]
                {
                    new Skill() {Name = "SQL"},
                    new Skill() {Name = "Cache ObjectScript"}
                }
            },
            new Employee()
            {
                Id = 5,
                EmployeeFullName = "Warren Hornsby",
                LastName = "Hornsby",
                FirstName = "Warren",
                Title = "Senior Software Engineer - Interfaces",
                Team = "Clinically Clouded Madness",
                Description = "<p>Warren's experience and ability to create internal tools such as IAM has allowed the Interfaces Team to reach new heights.</p>",
                AverageRating = 10,
                Skills = new Skill[]
                {
                    new Skill() {Name = "SQL"},
                    new Skill() {Name = "Cache ObjectScript"},
                    new Skill() {Name = "JavaScript"}
                }
            }
        };

        public Employee[] GetEmployees()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            Employee EmployeeToReturn = null;

            foreach (var Employee in _employees)
            {
                if (Employee.Id == id)
                {
                    EmployeeToReturn = Employee;

                    break;
                }
            }

            return EmployeeToReturn;
        }
    };
}
