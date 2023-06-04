using BookStore.DAL.Interfaces;
using BookStore.DAL.Entities;

namespace BookStore.DAL.Repositories
{
    public class BookRepository : IBaseRepository<Book>
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Book item)
        {
            _context.Book.Add(item);
        }

        public void Delete(Book item)
        {
            Book book = _context.Book.Find(item.Id);
            if(book != null)
                _context.Book.Remove(book);
        }

        public Book Get(int id)
        {
            return _context.Book.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Book;
        }

        public void Update(Book item)
        {
           _context.Update(item);
        }
    }
}
