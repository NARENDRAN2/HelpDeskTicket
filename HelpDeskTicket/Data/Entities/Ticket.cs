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
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }

        [StringLength(225)]
        public string TicektDescription { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExtension { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        public TicketStatus Status { get; set; } 
    }

    public enum TicketStatus
    {
        Resolved,
        InProgress,
        Unresolved
    }
}
