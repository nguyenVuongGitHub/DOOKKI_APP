using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class CategoryController : AbstractController<Category>
    {
        public CategoryController(DookkiContext context)
        {
            _context = context;
        }

        public override void Add(Category element)
        {
            throw new NotImplementedException();
        }

        public override DbSet<Category> GetModel()
        {
            return _context.Categories;
        }

        public override void Remove(Category element)
        {
            throw new NotImplementedException();
        }

        public override void SaveChanges()
        {
            //_context.SaveChanges();
        }

        public override void Update(Category element)
        {
            throw new NotImplementedException();
        }
    }
}
