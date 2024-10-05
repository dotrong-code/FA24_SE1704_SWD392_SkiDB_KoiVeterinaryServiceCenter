using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetServiceController : ControllerBase
    {
        private readonly IPetServiceService _petServiceService;

        public PetServiceController(IPetServiceService petServiceService)
        {
            _petServiceService = petServiceService;
        }

        // POST: api/petservice
        [HttpPost]
        public async Task<IResult> CreatePetService([FromBody] AddPetServiceRequest addPetService)
        {
            Result result = await _petServiceService.CreatePetServiceAsync(addPetService);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet]
        public async Task<IResult> GetAllPetServices()
        {
            Result result = await _petServiceService.GetAllPetServicesAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "All pet services retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/petservice/{id}
        [HttpGet("{id}")]
        public async Task<IResult> GetPetServiceById(Guid id)
        {
            Result result = await _petServiceService.GetPetServiceByIdAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/petservice/{id}
        [HttpPut("{id}")]
        public async Task<IResult> UpdatePetService(Guid id, [FromBody] AddPetServiceRequest addPetService)
        {
            Result result = await _petServiceService.UpdatePetServiceAsync(id, addPetService);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // DELETE: api/petservice/{id}
        [HttpDelete("{id}")]
        public async Task<IResult> DeletePetService(Guid id)
        {
            Result result = await _petServiceService.DeletePetServiceAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
