using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class TicketController : AbstractController<Ticket>
    {
        public TicketController(DookkiContext context)
        {
            _context = context;
        }
        public override void Add(Ticket element)
        {
            _context.Tickets.Add(element);
        }

        public override DbSet<Ticket> GetModel()
        {
            return _context.Tickets;
        }

        public override void Remove(Ticket element)
        {
            _context.Tickets.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Ticket element)
        {
            _context.Tickets.Update(element);
        }

        public void DisplayToGirdView(DataGridView gridView)
        {
            var tickets = _context.Tickets
                                 .Select(t => new
                                 {
                                     STT = t.Id,
                                     Name = t.Name,
                                     Price = t.Price
                                 })
                                 .ToList();

            // Bind to the DataGridView
            gridView.DataSource = tickets;
        }
    }
}
