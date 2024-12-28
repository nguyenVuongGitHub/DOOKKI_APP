using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DOOKKI_APP.Controllers
{
    internal class OrderController : AbstractController<Order>
    {
        public OrderController(DookkiContext context)
        {
            _context = context;
        }

        public override void Add(Order element)
        {
            _context.Orders.Add(element);
        }

        public override DbSet<Order> GetModel()
        {
            return _context.Orders;
        }

        public override void Remove(Order element)
        {
            _context.Orders.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Order element)
        {
            _context.Orders.Update(element);
        }
    }
}
