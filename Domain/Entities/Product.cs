using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")] // user input
        [MaxLength(50)] // property in database
        public string Name { get; set; }


        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Range(0, int.MaxValue)] // a positive integer
        public int Quantity { get;  set; }
        
       public string ImageName { get; set; }


        [Display(Name = "Production Date")]  // displayed as 'production date'
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }

        //foreign Key properties
        public int? CategoryId { get; set; }  /** cant put a nullable entity so I use the Id for 0..* relation !! **/

        public virtual Category Category { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }


    }
}
