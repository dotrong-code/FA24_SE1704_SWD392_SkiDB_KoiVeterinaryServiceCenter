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
    public class PetServiceRepository : GenericRepository<PetService>, IPetServiceRepository
    {
        public PetServiceRepository(KVSCContext context) : base(context) { }

        // CREATE
        public async Task<PetService> CreateServiceAsync(PetService petService)
        {
            _context.PetServices.Add(petService);
            await _context.SaveChangesAsync();
            return petService;
        }

        // READ
        public async Task<IEnumerable<PetService>> GetAllServicesAsync()
        {
            return await _context.PetServices.Where(s => !s.IsDeleted).ToListAsync();
        }

        public async Task<PetService> GetServiceByIdAsync(Guid id)
        {
            return await _context.PetServices.FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }
        //get by list id
        public async Task<List<PetService>> GetByIdsAsync(List<Guid> serviceIds)
        {
            return await _context.PetServices
                                 .Where(ps => serviceIds.Contains(ps.Id))
                                 .ToListAsync();
        }
        public async Task<int> GetServiceByPetServiceCategoryIdAsync(Guid id)
        {
            return await _context.PetServices.CountAsync(s=> s.PetServiceCategoryId == id && !s.IsDeleted);
        }
        // UPDATE
        public async Task<int> UpdateServiceAsync(PetService petService)
        {
            _context.PetServices.Update(petService);
            return await _context.SaveChangesAsync();
        }

        // DELETE (soft delete)
        public async Task<int> DeleteServiceAsync(Guid id)
        {
            var service = await _context.PetServices.FindAsync(id);
            if (service != null)
            {
                service.IsDeleted = true;
                _context.PetServices.Update(service);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
