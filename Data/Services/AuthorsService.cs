using Librozone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Librozone.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context) 
        {
            _context = context;
        }
        public async Task AddAsync(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            var result = await _context.Authors.FirstOrDefaultAsync(n =>  n.Id == id);
            return result;
        }

        public Author Update(int id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
