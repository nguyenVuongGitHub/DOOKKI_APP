using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class CategoryTicketControllerSingleton
    {
        private static CategoryTicketControllerSingleton instance;

        public static CategoryTicketControllerSingleton Instance
        {
            get { if (instance == null) instance = new CategoryTicketControllerSingleton(); return instance; }
            set { instance = value; }
        }

        private CategoryTicketControllerSingleton() { }

        public List<CategoryTicket> GetListCategoryTicket()
        {
            using (var context = new DookkiContext())
            {
                return context.CategoryTickets.ToList();
            }
        }
    }
}
