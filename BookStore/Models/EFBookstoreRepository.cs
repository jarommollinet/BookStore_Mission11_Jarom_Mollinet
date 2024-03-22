
namespace BookStore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookStoreContext _context;
        public EFBookstoreRepository(BookStoreContext temp) {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
