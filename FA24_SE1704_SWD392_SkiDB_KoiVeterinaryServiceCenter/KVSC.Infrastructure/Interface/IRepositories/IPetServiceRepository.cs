using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPetServiceRepository
    {
        public Task<PetService> CreateServiceAsync(PetService petService);
        public Task<IEnumerable<PetService>> GetAllServicesAsync();
        public Task<PetService> GetServiceByIdAsync(Guid id);
        public Task<int> UpdateServiceAsync(PetService petService);
        public Task<int> DeleteServiceAsync(Guid id);
        public Task<int> GetServiceByPetServiceCategoryIdAsync(Guid id);
        public Task<List<PetService>> GetByIdsAsync(List<Guid> serviceIds);

    }
}
