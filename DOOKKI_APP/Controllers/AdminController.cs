﻿using DOOKKI_APP.Models.Entities;
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

        public AdminController(DookkiContext context)
        {
           _context = context;
        }

        public override void Add(Admin element)
        {
            throw new NotImplementedException();
        }

        public override DbSet<Admin> GetModel()
        {
            return _context.Admins;
        }

        public override void Remove(Admin element)
        {
            throw new NotImplementedException();
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Admin element)
        {
            throw new NotImplementedException();
        }
    }
}
