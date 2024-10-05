using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetServiceCategoryController : ControllerBase
    {
        private readonly IPetServiceCategoryService _petServiceCategoryService;

        public PetServiceCategoryController(IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceCategoryService = petServiceCategoryService;
        }

        // POST: api/petservicecategory
        [HttpPost]
        public async Task<IResult> CreatePetServiceCategory([FromBody] AddPetServiceCategoryRequest addPetServiceCategory)
        {
            Result result = await _petServiceCategoryService.CreatePetServiceCategoryAsync(addPetServiceCategory);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/petservicecategory
        [HttpGet]
        public async Task<IResult> GetAllPetServiceCategories()
        {
            Result result = await _petServiceCategoryService.GetAllPetServiceCategoriesAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "All pet service categories retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/petservicecategory/{id}
        [HttpGet("{id}")]
        public async Task<IResult> GetPetServiceCategoryById(Guid id)
        {
            Result result = await _petServiceCategoryService.GetPetServiceCategoryByIdAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/petservicecategory/{id}
        [HttpPut("{id}")]
        public async Task<IResult> UpdatePetServiceCategory(Guid id, [FromBody] AddPetServiceCategoryRequest addPetServiceCategory)
        {
            Result result = await _petServiceCategoryService.UpdatePetServiceCategoryAsync(id, addPetServiceCategory);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // DELETE: api/petservicecategory/{id}
        [HttpDelete("{id}")]
        public async Task<IResult> DeletePetServiceCategory(Guid id)
        {
            Result result = await _petServiceCategoryService.DeletePetServiceCategoryAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
