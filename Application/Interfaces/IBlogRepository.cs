using Domain.Entities;

namespace Application.Interfaces
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetAllAsync();
    }
}
