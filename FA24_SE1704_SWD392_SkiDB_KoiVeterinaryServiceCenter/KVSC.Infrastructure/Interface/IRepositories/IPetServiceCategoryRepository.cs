using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPetServiceCategoryRepository
    {
        public Task<PetServiceCategory> GetByIdAsync(Guid id);
        public Task<PetServiceCategory> CreateAsync(PetServiceCategory category);
        public Task<IEnumerable<PetServiceCategory>> GetAllAsync();
        public Task<int> UpdateAsync(PetServiceCategory category);
        public Task<int> DeleteAsync(Guid id);
      
    }
}
