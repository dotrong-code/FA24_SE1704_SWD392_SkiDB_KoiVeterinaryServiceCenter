using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.AddComboService;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.PetService
{
    public class AddPetServiceCategoryValidator : PetServiceCategoryValidator<AddPetServiceCategoryRequest>
    {
        public AddPetServiceCategoryValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddCategoryNameRules(request => request.Name);
            AddDescriptionRules(request => request.Description);
            AddServiceTypeRules(request => request.ServiceType);
            AddApplicableToRules(request => request.ApplicableTo);
        }
    }
}
