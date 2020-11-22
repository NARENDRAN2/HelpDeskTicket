using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelpDeskTicket.Data;
using HelpDeskTicket.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using PagedList;


namespace HelpDeskTicket.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;

        public TicketsController(ApplicationDbContext context, UserManager<Employee> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Tickets
        //[Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var tickets =  _context.Tickets;
            var ticketModels = tickets.Select(ticket => new TicketModel
            {
                Department = ticket.Department,
                Title = ticket.Title,
                TicketDescription = ticket.TicketDescription,
                Id = ticket.Id
            });

             int pageSize = 3;
            return View(await PaginatedList<Ticket>.CreateAsync(tickets.AsNoTracking(), pageNumber ?? 1, pageSize));


            return View(ticketModels);
        }

        // GET: Tickets/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketModel ticketModel)
        {
            //if TicketModel is valid, take all data from the ticektModel and 
            //store it into the DB.
            if (ModelState.IsValid)
            {
                var email = HttpContext.User.Identity.Name;
                var employee = await _userManager.FindByNameAsync(email);

                var ticket = new Ticket
                {
                    Department = ticketModel.Department,
                    Title = ticketModel.Title,
                    TicketDescription = ticketModel.TicketDescription,
                    CreatedDate = DateTime.Now,
                    Status = TicketStatus.Unresolved,
                    EmployeeId = employee.Id,
                    EmployeeName = employee.Name
                }; 
                            
                if (ticketModel.Attachment != null)
                {
                    var attachment = ticketModel.Attachment;
                    using(var ms = new MemoryStream())
                    {
                        attachment.CopyTo(ms);
                        ticket.Attachment = ms.ToArray();
                        ticket.AttachmentName = Path.GetFileNameWithoutExtension(attachment.FileName);
                        ticket.AttachmentExtension = Path.GetExtension(attachment.FileName);
                    }
                }

                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketModel);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TicketModel ticketModel)
        {
            if (id != ticketModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //try
                //{
                //    _context.Update(ticket);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!TicketExists(ticket.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                //return RedirectToAction(nameof(Index));
            }
            return View(ticketModel);
        }

        // GET: Tickets/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }

        public IActionResult MyTickets(Employee employee) => View();
    }
}
