using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class PetServiceErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)  
            => Error.Validation("PetService.Empty", $"The '{nameField}' field is required.");

        public static Error InvalidFieldValue(string fieldName)
            => Error.Validation("PetService.InvalidValue", $"The '{fieldName}' field has an invalid value.");
        public static Error InvalidDateTimeCheck(string dateFrom, string dateTo)
            => Error.Validation("PetService.InvalidDate", $"'{dateFrom}' must be greater than '{dateTo}'.");
        public static Error PetServiceNotFound()
            => Error.Validation("PetService.NotFound", "PetService not found.");

        public static Error PetServiceNotCreated()
            => Error.Validation("PetService.NotCreated", "PetService could not be created.");

        public static Error PetServiceUpdateFailed()
            => Error.Validation("PetService.UpdateFailed", "Failed to update PetService.");

        public static Error PetServiceDeleteFailed()
           => Error.Validation("PetService.DeleteFailed", "Failed to delete PetService.");

    }
}
