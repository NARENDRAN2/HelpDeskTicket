using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskTicket.Models
{
    public class Employee : IdentityUser
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
