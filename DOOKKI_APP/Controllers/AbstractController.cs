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
    /// Abstract base class for managing database operations on a specific model type.
    /// </summary>
    /// <typeparam name="ModelT">The type of the model this controller manages.</typeparam>
    internal abstract class AbstractController<ModelT> where ModelT : class
    {
        /// <summary>
        /// The database context used to interact with the database.
        /// </summary>
        protected DookkiContext _context = null;
        /// <summary>
        /// Retrieves the DbSet for the specific model type from the database context.
        /// </summary>
        /// <returns>A DbSet containing the model of type ModelT.</returns>
        public abstract DbSet<ModelT> GetModel();

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// <br></br>
        /// Carefuly when use.
        /// </summary>
        public abstract void SaveChanges();
    }

}
