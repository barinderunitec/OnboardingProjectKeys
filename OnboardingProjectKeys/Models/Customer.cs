using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnboardingProjectKeys.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer Name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Customer Address")]
        public string Address { get; set; }
      public virtual List<ProductSold> ProductSolds { get; set; }
       // public virtual ICollection<ProductSold> ProductSolds { get; set; }
    }
}