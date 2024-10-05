using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using Azure.Core;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Application.Common.Validator.Abstract;

namespace KVSC.Application.Common.Validator.PetService
{
    public class AddPetServiceValidator : PetServiceValidator<AddPetServiceRequest>
    {
        public AddPetServiceValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetServiceNameRules(request => request.Name);
            AddBasePriceRules(request => request.BasePrice);
            AddDurationRules(request => request.Duration);
            AddTravelCostRangeRules(request => request.TravelCost);
            AddDateRangeRules(request => request.AvailableFrom, request => request.AvailableTo);
        }
    }
}