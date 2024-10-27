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
            throw new NotImplementedException();
        }

        public override DbSet<Ticket> GetModel()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Ticket element)
        {
            throw new NotImplementedException();
        }

        public override void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public override void Update(Ticket element)
        {
            throw new NotImplementedException();
        }

        public void DisplayToGirdView(DataGridView gridView)
        {
            var tickets = _context.Tickets
                                 .Select(t => new
                                 {
                                     STT = t.TicketId,
                                     Name = t.TicketName,
                                     Price = t.TicketPrice
                                 })
                                 .ToList();

            // Bind to the DataGridView
            gridView.DataSource = tickets;
        }
    }
}
