using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductViewModel
    {
        public Product product { get; set; }

        
        [Required(ErrorMessage = "You must select a product type.")]
        public SelectList productTypes { get; set; }
    }

}