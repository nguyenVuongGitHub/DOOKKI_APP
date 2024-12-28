using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace DOOKKI_APP.Controllers
{
    internal class EmployeeController : AbstractController<Employee>
    {
        private IQueryable<Employee> query;
        public IQueryable<Employee> Query { get => query; set => query = value; }
        public EmployeeController(DookkiContext context)
        {
            _context = context;
            query = _context.Employees;
        }

        public override void Add(Employee element)
        {
            _context.Employees.Add(element);
        }

        public override DbSet<Employee> GetModel()
        {
            return _context.Employees;
        }

        public override void Remove(Employee element)
        {
            _context.Employees.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Employee element)
        {
            _context.Employees.Update(element);
        }
    }
}
