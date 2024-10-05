using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddComboService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IComboServiceService
    {
        public Task<Result> CreateComboServiceAsync(AddComboServiceRequest addComboService);
        public Task<Result> GetComboServiceByIdAsync(Guid id);
        public Task<Result> GetAllComboServicesAsync();
        public Task<Result> UpdateComboServiceAsync(Guid id, AddComboServiceRequest addComboService);
        public Task<Result> DeleteComboServiceAsync(Guid id);
    }
}
