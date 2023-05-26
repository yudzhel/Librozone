using Librozone.Data.Base;
using Librozone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Librozone.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsService
    {
        private readonly AppDbContext _context;
        public AuthorsService(AppDbContext context) : base(context) { }
    }
       
}
