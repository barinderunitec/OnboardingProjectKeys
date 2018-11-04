using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnboardingProjectKeys.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }
         public virtual List<ProductSold> ProductSolds { get; set; }
       // public virtual ICollection<ProductSold> ProductSolds { get; set; }
    }
}