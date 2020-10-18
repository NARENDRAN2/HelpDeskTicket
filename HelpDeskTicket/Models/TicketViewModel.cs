using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    //take this and use it as a template for finishing Ticket.cs
    public class TicketViewModel
    {
        public int Ticket_Id { get; set; }
        public String CreatedDate { get; set; }
        public string Ticket_Description { get; set; }
        public int Employee_Name { get; set; }
        public int Employee_Id { get; set; }
        public string Status { get; set; }

        public int SearchTicket(int Id)
        {
            //default code for now
            return Id;
        }
        public int DeleteTicket(int Id)
        {
            //default code for now
            return Id;
        }
        public int AddTicket(int Id)
        {
            //default code for now
            return Id;
        }
        public int EditTicket(int Id)
        {
            //default code for now
            return Id;
        }
        public int ResolveTicket(int Id)
        {
            //default code for now
            return Id;
        }
    }
}
