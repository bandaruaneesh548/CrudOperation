using Codepulse.Models.Domain;

namespace Codepulse.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
