using BookAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public async Task<Book> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
