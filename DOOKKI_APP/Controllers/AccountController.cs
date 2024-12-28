using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DOOKKI_APP.Controllers
{
    internal class AccountController : AbstractController<Models.Entities.Account>
    {
        private IQueryable<Account> query;
        public IQueryable<Account> Query { get => query; set => query = value; }
        public AccountController(DookkiContext context)
        {
            _context = context;
            query = _context.Accounts;
        }
        public override void Add(Account element)
        {
            _context.Accounts.Add(element);
        }

        public override DbSet<Account> GetModel()
        {
            return _context.Accounts;
        }

        public override void Remove(Account element)
        {
            _context.Accounts.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Account element)
        {
            _context.Accounts.Update(element);
        }
    }

}
