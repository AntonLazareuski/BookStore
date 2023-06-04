using BookStore.DAL.Entities.Interfaces;

namespace BookStore.DAL.Entities
{
    public class Employee: IBaseEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string SecondName { get; set; }

    }
}