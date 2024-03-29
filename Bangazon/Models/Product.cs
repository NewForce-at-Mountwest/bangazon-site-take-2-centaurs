using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;



namespace Bangazon.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated {get;set;}

        [Required]
        [StringLength(255, ErrorMessage = "Please enter less than 255 characters")]
        public string Description { get; set; }

        [Required]
        [StringLength(55, ErrorMessage="Please shorten the product title to 55 characters")]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter quantity")]
        public int Quantity { get; set; }

        [Required]
        public string UserId {get; set;}

        public string City {get; set;}

        public byte[] ProductImage  {get; set;}

        public bool Active { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Please choose a product category.")]
        [Display(Name="Product Category")]
        public int ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }
        [Display(Name="Local Delivery Available?")]
        public bool localDeliveryAvailable { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product ()
        {
            Active = true;
        }

    }
}
