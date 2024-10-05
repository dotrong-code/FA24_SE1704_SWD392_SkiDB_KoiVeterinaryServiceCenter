using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class PetServiceCategoryErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
      => Error.Validation("PetServiceCategory.Empty", $"The '{nameField}' field is required.");

        public static Error InvalidFieldValue(string fieldName)
            => Error.Validation("PetServiceCategory.InvalidValue", $"The '{fieldName}' field has an invalid value.");

        public static Error PetServiceCategoryNotFound()
            => Error.Validation("PetServiceCategory.NotFound", "PetServiceCategory not found.");

        public static Error PetServiceCategoryNotCreated()
            => Error.Validation("PetServiceCategory.NotCreated", "PetServiceCategory could not be created.");

        public static Error PetServiceCategoryUpdateFailed()
            => Error.Validation("PetServiceCategory.UpdateFailed", "Failed to update PetServiceCategory.");

        public static Error PetServiceCategoryDeleteFailed()
           => Error.Validation("PetServiceCategory.DeleteFailed", "Failed to delete PetServiceCategory.");
        public static Error PetServiceCategoryInUse()
    => Error.Validation("PetServiceCategory.InUse", "Cannot delete PetServiceCategory because it is in use by one or more Pet Services.");
    }
}
