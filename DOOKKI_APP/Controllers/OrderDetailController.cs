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
    internal class OrderDetailController : AbstractController<OrderDetail>
    {
        public OrderDetailController(DookkiContext context)
        {
            _context = context;
        }

        public override void Add(OrderDetail element)
        {
            _context.OrderDetails.Add(element);
        }

        public override DbSet<OrderDetail> GetModel()
        {
            return _context.OrderDetails;
        }

        public override void Remove(OrderDetail element)
        {
            _context.OrderDetails.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(OrderDetail element)
        {
            _context.OrderDetails.Update(element);
        }
    }
}
