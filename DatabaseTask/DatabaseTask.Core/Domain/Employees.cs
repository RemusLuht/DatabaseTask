using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employees
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelephoneNr { get; set; }
        public string Address { get; set; }

    }
}

