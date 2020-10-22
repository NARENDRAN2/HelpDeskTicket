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
        public string Employee_Id { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }

        [StringLength(225)]
        public string TicketDescription { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExtension { get; set; }
        public DateTime CreatedDate { get; set; }
        public TicketStatus Status { get; set; } 
    }

    public enum TicketStatus
    {
        Resolved,
        Unresolved
    }
}
