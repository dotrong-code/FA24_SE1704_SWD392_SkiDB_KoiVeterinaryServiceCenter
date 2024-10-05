using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class ComboServiceErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
            => Error.Validation("ComboService.Empty", $"The '{nameField}' field is required.");

        public static Error InvalidFieldValue(string fieldName)
            => Error.Validation("ComboService.InvalidValue", $"The '{fieldName}' field has an invalid value.");

        public static Error ComboServiceNotFound()
            => Error.Validation("ComboService.NotFound", "ComboService not found.");

        public static Error ComboServiceNotCreated()
            => Error.Validation("ComboService.NotCreated", "ComboService could not be created.");

        public static Error ComboServiceUpdateFailed()
            => Error.Validation("ComboService.UpdateFailed", "Failed to update ComboService.");

        public static Error ComboServiceDeleteFailed()
            => Error.Validation("ComboService.DeleteFailed", "Failed to delete ComboService."); 
        public static Error ComboServiceInsufficientServices()
            => Error.Validation("ComboService.MinimumServices", "Combo must contain at least 2 distinct services."); 
        public static Error ComboServiceInvalidServiceIds()
            => Error.Validation("ComboService.InvalidServices", "One or more services do not exist.");
    }
}
