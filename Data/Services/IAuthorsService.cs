using Librozone.Models;

namespace Librozone.Data.Services
{
    public interface IAuthorsService
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Task <Author> UpdateAsync(int id, Author newAuthor);
        void Delete(int id);
    }
}
