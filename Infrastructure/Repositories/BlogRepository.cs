using Application.Interfaces;        // ← za IBlogRepository
using Domain.Entities;              // ← za Blog
using Infrastructure.Data;         // ← za AppDbContext
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _context;

        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.ToListAsync();
        }
    }
}
