
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities
{
    public class Store
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public Employee EmployeeName { get; set; }
        public Book Book { get; set; }

    }
}
