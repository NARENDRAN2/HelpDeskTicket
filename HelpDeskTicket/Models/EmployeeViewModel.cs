using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public int Employee_Id { get; set; }

        [Required]
        public String Employee_Name { get; set; }

        [Required]
        [EmailAddress]
        public string Employee_Email { get; set; }

        [Required]
        public string Employee_DOB { get; set; }

        public int Role_Id { get; set; }
        public string Role { get; set; }

        public void EditEmployee(int Id)
        {
            //default code for now
            
        }
        public void AddEmployee(int Id)
        {
            //default code for now

        }
        public void DeleteEmployee(int Id)
        {
            //default code for now

        }
        public EmployeeViewModel SearchEmployee(int Id)
        {
            //default code for now
            return null;

        }
        public void EditRole(int Id)
        {
            //default code for now

        }
        public void SearchRole(int Id)
        {
            //default code for now

        }
        public void AssignRole(int Id)
        {
            //default code for now

        }
    }
}
