using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//These tickets will be put into the DB

namespace HelpDeskTicket.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int Employee_Name { get; set; }
        public int Employee_Id { get; set; }

        public string Department { get; set; }

        public string Title { get; set; }

        [StringLength(225)]
        public string TicketDescription { get; set; }
        public String CreatedDate { get; set; }
        public string Status { get; set; } 
    }
}
