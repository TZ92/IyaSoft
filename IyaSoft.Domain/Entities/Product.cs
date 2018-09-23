using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IyaSoft.Domain.Entities
{
    public class Product
    {

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(50, ErrorMessage = "Must be less than 50 characters")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Range(0, int.MaxValue)]
        [Required(ErrorMessage = "Quantity Required")]
        public int Quantity { get; set; }
        public string Tag { get; set; }

        [Required(ErrorMessage = "Available Date Required")]
        [Display(Name = "Available on")]
        public DateTime AvailableOn { get; set; }
       
        
    }
}
