using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(225)]
        public string TicketDescription { get; set; }
        public IFormFile Attachment { get; set; }
    }
}
