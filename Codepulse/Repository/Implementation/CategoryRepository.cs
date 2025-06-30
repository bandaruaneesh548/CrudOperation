using Codepulse.Data;
using Codepulse.Models.Domain;
using Codepulse.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Codepulse.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public CategoryRepository(ApplicationDbcontext dbcontext) 
        { 
            _dbcontext = dbcontext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _dbcontext.Categories.AddAsync(category);
            await _dbcontext.SaveChangesAsync();

            return category;
        }
        
    }
}
