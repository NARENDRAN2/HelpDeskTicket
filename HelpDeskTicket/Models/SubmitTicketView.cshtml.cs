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
        public string Name { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //isResolved will be false by default untill set to true
        public bool isResolved { get; set; }
        public dynamic Attachment { get; set; }
        //will need DateTime to post onto mytickets view
        public DateTime DateTime { get; set; }
    }
}