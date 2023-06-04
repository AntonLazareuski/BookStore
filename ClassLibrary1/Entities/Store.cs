using BookStore.DAL.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Entities
{
    public class Store: IBaseEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public IEnumerable<Employee> EmployeeName { get; set; }
        public IEnumerable<Book> Book { get; set; }

    }
}
