using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        public int Id { get; set; }

        public string UserName { get; set; }

 
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public bool IsApproved { get; set; }

        public DateTime? DateCreated { get; set; }

        virtual public List<Product> Products { get; set; }


    }
}
