using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class PaymentController : AbstractController<Payment>
    {
        public PaymentController(DookkiContext context)
        {
            _context = context;
        }
        public override void Add(Payment element)
        {
            _context.Payments.Add(element);
        }

        public override DbSet<Payment> GetModel()
        {
            return _context.Payments;
        }

        public override void Remove(Payment element)
        {
            _context.Payments.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Payment element)
        {
            _context.Payments.Update(element);
        }
    }
}
