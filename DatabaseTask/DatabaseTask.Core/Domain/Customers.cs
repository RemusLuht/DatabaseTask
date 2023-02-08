using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Customers
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
