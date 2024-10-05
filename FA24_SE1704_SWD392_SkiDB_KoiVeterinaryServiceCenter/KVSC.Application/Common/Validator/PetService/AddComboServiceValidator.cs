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
    public class AddComboServiceValidator : ComboServiceValidator<AddComboServiceRequest>
    {
        public AddComboServiceValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddComboServiceNameRules(request => request.Name);
            AddDiscountPercentageRules(request => request.DiscountPercentage);
            AddServiceItemsRules(request => request.ServiceIds);
        }
    }
}
