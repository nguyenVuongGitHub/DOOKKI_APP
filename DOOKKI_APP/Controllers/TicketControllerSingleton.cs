using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class TicketControllerSingleton
    {
        private static TicketControllerSingleton instance;

        public static TicketControllerSingleton Instance
        {
            get { if (instance == null) instance = new TicketControllerSingleton(); return instance; }
            set { instance = value; }
        }

        private TicketControllerSingleton() { }

        public List<Ticket> GetTicketByCategoryTicketID(int id)
        {
            using (var context = new DookkiContext())
            {
                var ticketList = context.Tickets
                    .Where(p => p.IdCategory == id)
                    .ToList();
                return ticketList;
            }
        }

        public int GetTicketIdByName(string itemName)
        {
            using (var context = new DookkiContext())
            {
                var ticket = context.Tickets.FirstOrDefault(t => t.Name == itemName);
                return ticket?.Id ?? 0;
            }
        }
    }
}
