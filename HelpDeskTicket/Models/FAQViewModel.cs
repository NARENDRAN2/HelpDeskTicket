using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    public class FAQViewModel
    {
        public int FAQId { get; set; }
        public string FAQTitle { get; set; }
        public string description{ get; set; }


        public void AddFAQ()
        {
            //default code for now
        }
        public void DeleteFAQ(int Id)
        {
            //default code for now
        }
        public void SearchFAQ(int Id)
        {
            //default code for now
        }
        public void EditTicket(int Id)
        {
            //default code for now
        }
    }
}
