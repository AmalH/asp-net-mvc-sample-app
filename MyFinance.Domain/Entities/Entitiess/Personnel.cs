using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities.Entitiess
{
    public class Personnel
    {
        [Key]
        public int CodePersonnel { get; set; }
        public int Age { get; set; }
        public FullName NomComplet { get; set; }
        public Address Address { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }

    }
}
