using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class PetServiceCategoryRepository : GenericRepository<PetServiceCategory>, IPetServiceCategoryRepository
    {
        public PetServiceCategoryRepository(KVSCContext context) : base(context) { }

        // Kiểm tra xem danh mục dịch vụ có tồn tại không
        public async Task<PetServiceCategory> GetByIdAsync(Guid id)
        {
            return await _context.PetServiceCategories.FindAsync(id);
        }
        public async Task<PetServiceCategory> CreateAsync(PetServiceCategory category)
        {
            await _context.PetServiceCategories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<PetServiceCategory>> GetAllAsync()
        {
            return await _context.PetServiceCategories.ToListAsync();
        }
        public async Task<int> UpdateAsync(PetServiceCategory category)
        {
            _context.PetServiceCategories.Update(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var category = await _context.PetServiceCategories.FindAsync(id);
            if (category != null)
            {
                _context.PetServiceCategories.Remove(category);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
