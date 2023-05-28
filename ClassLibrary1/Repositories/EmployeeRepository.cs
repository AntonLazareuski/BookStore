using BookStore.DAL.Interfaces;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public class EmployeeRepository : IBaseRepository<Employee>
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Employee item)
        {
            _context.Employee.Add(item); 
        }

        public void Delete(Employee item)
        {
            Employee employee = _context.Employee.Find(item.Id);
            if(employee != null)
                _context.Employee.Remove(employee);

        }

        public Employee Get(int id)
        {
            return _context.Employee.Find(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employee;
        }

        public void Update(Employee item)
        {
            _context.Update(item);
        }
    }
}
