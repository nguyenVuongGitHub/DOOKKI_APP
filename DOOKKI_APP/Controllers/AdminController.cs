using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    /// <summary>
    /// This class handle admin model
    /// </summary>
    internal class AdminController : AbstractController<Admin>
    {
        private IQueryable<Admin> query;
        public IQueryable<Admin> Query { get => query; set => query = value; }
        public AdminController(DookkiContext context)
        {
           _context = context;
            query = _context.Admins;
        }

        public override void Add(Admin element)
        {
            _context.Admins.Add(element);
        }

        public override DbSet<Admin> GetModel()
        {
            return _context.Admins;
        }

        public override void Remove(Admin element)
        {
            _context.Admins.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Admin element)
        {
            _context.Admins.Update(element);
        }
    }
}
