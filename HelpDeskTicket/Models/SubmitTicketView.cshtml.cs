using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelpDeskTicket.Models
{
    public class SubmitTicketViewModel : PageModel
    {       
        public string department { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public dynamic Attachment { get; set; }
    }
}