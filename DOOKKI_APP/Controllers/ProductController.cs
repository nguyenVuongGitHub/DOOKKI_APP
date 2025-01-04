using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DOOKKI_APP.Controllers
{
    internal class ProductController : AbstractController<Product>
    {
        private IQueryable<Product> _products;
        public IQueryable<Product> Products { get { return _products; } set {_products = value; } }
        private readonly CategoryController _categoryController;
        public ProductController(DookkiContext context)
        {
            _context = context;
            _products = context.Products;
            _categoryController = new CategoryController(context);
        }

        public override DbSet<Product> GetModel()
        {
            return _context.Products;
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        } 
        public override void Add(Product product)
        {
            _context.Products.Add(product);
        }
        public override void Remove(Product product)
        {
            _context.Products.Remove(product); 
        }
        public override void Update(Product product)
        {
            _context.Products.Update(product);
        }
        public void DisplayToGirdView(DataGridView gridView, int pageNumber, int pageSize)
        {
            var productsPaged = _products
                    .Where(p => p.IsActive == true)
                    .OrderBy(p => p.CategoryId)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            var dataSource = productsPaged

                .Select((p, index) => new
                {
                    STT = index + 1 + ((pageNumber - 1) * pageSize), // Calculating the row number
                    Name = p.Name,
                    Mfg = p.Mfg.ToString("dd/MM/yyyy"),
                    Exp = p.Exp.ToString("dd/MM/yyyy"),
                    UnitInStock = p.UnitInStock,
                    CategoryId = _categoryController.GetModel()
                                    .FirstOrDefault(c => c.Id == p.CategoryId)?.Name
                })
                
                .ToList();


            // Bind to the DataGridView
            gridView.DataSource = dataSource;
        }
    }
}
