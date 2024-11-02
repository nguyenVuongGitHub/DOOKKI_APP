using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DOOKKI_APP.Controllers
{
    internal class ProductController : AbstractController<Product>
    {
        private BindingList<Product> _bindingList;
        public BindingList<Product> BindingList { get { return _bindingList; } set { _bindingList = value; } }

        private readonly CategoryController _categoryController;
        public ProductController(DookkiContext context)
        {
            _context = context;
            _bindingList = new BindingList<Product>(_context.Products.ToList());
            _categoryController = new CategoryController(context);
        }

        public override DbSet<Product> GetModel()
        {
            return _context.Products;
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
            _bindingList = new BindingList<Product>(_context.Products.ToList());
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
        public void UpdateBinDingList(List<Product> products)
        {
            _bindingList.Clear();
            _bindingList = new BindingList<Product>(products);
        }
        public void DisplayToGirdView(DataGridView gridView, int pageNumber, int pageSize)
        {
            var productsPaged = _bindingList
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            var dataSource = productsPaged
                .Select((p, index) => new
                {
                    STT = index + 1 + ((pageNumber - 1) * pageSize), // Calculating the row number
                    Name = p.ProductName,
                    Mfg = p.Mfg,
                    Exp = p.Exp,
                    UnitInStock = p.UnitInStock,
                    CategoryId = _categoryController.GetModel()
                                    .FirstOrDefault(c => c.CategoryId == p.CategoryId)?.CategoryName
                })
                .ToList();


            // Bind to the DataGridView
            gridView.DataSource = dataSource;
        }
    }
}
