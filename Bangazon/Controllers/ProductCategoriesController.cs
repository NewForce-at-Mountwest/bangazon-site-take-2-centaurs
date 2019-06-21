using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bangazon.Data;
using Bangazon.Models;


namespace Bangazon.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: ProductCategories
        public async Task<IActionResult> Index()
        {
            var model = await _context.ProductType.Include(pt => pt.Products).ToListAsync();
            foreach (ProductType productType in model)
            {
                productType.Quantity = productType.Products.Count();
                ICollection<Product> updatedProductList = productType.Products.Take(3).ToList();
                productType.Products = updatedProductList;
            }
            return View(model);
        }

        // GET: ProductCategories/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = await _context.ProductType
                .FirstOrDefaultAsync(m => m.ProductTypeId == id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }


        // GET: ProductCategories/Create
        public IActionResult Create()
        {
            return View();
        }
        private bool ProductTypeExists(int id)
        {
            return _context.ProductType.Any(e => e.ProductTypeId == id);
        }
    }
}