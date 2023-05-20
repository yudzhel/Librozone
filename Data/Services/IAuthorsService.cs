using Librozone.Models;

namespace Librozone.Data.Services
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Author Update(int id, Author newAuthor);
        void Delete(int id);
    }
}
