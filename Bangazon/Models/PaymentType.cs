using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bangazon.Models
{
  public class PaymentType
  {
    [Key]
    public int PaymentTypeId { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated { get; set; }

    [Display(Name = "Inactive?")]
    public bool Inactive { get; set; }

    [Required]
    [StringLength(55, ErrorMessage = "Please enter less than 55 characters")]
    public string Description { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Please enter less than 20 characters")]
        public string AccountNumber { get; set; }

    [Required]
    public string UserId {get; set;}

    [Required]
    public ApplicationUser User { get; set; }

    public ICollection<Order> Orders { get; set; }
        //public object ApplicationUser { get; internal set; }
    }
}
