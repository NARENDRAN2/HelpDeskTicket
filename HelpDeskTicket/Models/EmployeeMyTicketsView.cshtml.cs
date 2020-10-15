using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    public class EmployeeMyTicketsViewModel : PageModel
    {
        //ctor
        public EmployeeMyTicketsViewModel()
        {                
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }

    }
}
