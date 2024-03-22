namespace BookStore.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
