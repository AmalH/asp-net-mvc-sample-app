using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities.Entitiess
{
    public class Patient
    {

        [Key]
        public int Cin { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        public String Adress { get; set; }

        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        public FullName NomComplet { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }

    }


}
